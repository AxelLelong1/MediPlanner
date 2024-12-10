using MediData.Models;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediPlanner.Class;
using MediPlanner.Queries;
using MediCore.Services;
using MediPlanner.Queries.Request;
using MediPlanner.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MediCore.Controllers
{
    /// <summary>
    /// Controller For the ADMIN part
    /// Needed to add centers, add machines and configures everything
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class AdminController : ControllerBase
    {
        // Logger
        private Logger.Logger logger = Logger.Logger.Instance;

        // Database Context
        private readonly IDbContextFactory<VarianContext> dbContextFactory;

        // Center Manager
        private CenterService centerService;

        public AdminController(IDbContextFactory<VarianContext> db, CenterService centerService)
        {
            dbContextFactory = db ?? throw new ArgumentNullException(nameof(dbContextFactory));
            this.centerService = centerService;

            // Preset StCloud : TODO REMOVE PRESET AND LEAVE EMPTY
            if(centerService.Centers.Count == 0)
                centerService.AddCenter(new Center());
        }


        /// <summary>
        /// Add a blank center
        /// </summary>
        /// <param name="centerName"> The name of the new center</param>
        /// <returns>IAction Ok or BadRequest</returns>
        [HttpPost("createCentre")]
        public IActionResult CreateCentre([FromQuery] string centerName)
        {

            // create blank center
            var center = new Center(centerName);
            
            logger.Log($"Creating center: {center.Name}", MediCore.Logger.LogLevel.Info);

            // If center is somewhat null or contains invalid name, BadRequest
            if (center == null || string.IsNullOrWhiteSpace(center.Name))
            {
                return BadRequest("Invalid center data.");
            }

            // Ensure unique center ID
            center.Id = centerService.Centers.Count > 0 ? centerService.Centers.Max(c => c.Id) + 1 : 1;
            centerService.AddCenter(center);

            logger.Log($"Added center: {center.Name}", MediCore.Logger.LogLevel.Info);
            return Ok(center);
        }

        /// <summary>
        /// Return all centers known
        /// </summary>
        /// <returns></returns>
        [HttpGet("centres")]
        public IActionResult GetCentres()
        {
            logger.Log($"Getting all centers", MediCore.Logger.LogLevel.Info);

            return Ok(centerService.Centers);
        }

        /// <summary>
        /// Delete a center by it's ID
        /// </summary>
        /// <param name="id">ID of the center we want to erase</param>
        /// <returns></returns>
        [HttpDelete("deleteCentre/{id}")]
        public IActionResult DeleteCentre(int id)
        {
            logger.Log($"Trying to delete a center !", MediCore.Logger.LogLevel.Info);

            // search the center
            var center = centerService.Centers.FirstOrDefault(c => c.Id == id);

            // try to delete it
            var deleted = centerService.DeleteCenter(center);

            if (!deleted)
            {
                logger.Log($"Center with ID {id} not found.", MediCore.Logger.LogLevel.Warning);
                return NotFound();
            }

            logger.Log($"Center with ID {id} removed.", MediCore.Logger.LogLevel.Info);
            return Ok();
        }

        /// <summary>
        /// Edit the HUMAN ressources of a center
        /// </summary>
        /// <param name="id">Edit the HUMAN ressources of a center</param>
        /// <param name="resources">Ressources to add to the center</param>
        /// <returns></returns>
        [HttpPost("editCentreResources/{id}")]
        public IActionResult EditCentre(int id, [FromBody] List<string> resources)
        {
            logger.Log($"Editing Centre {id} with new resources :{string.Join(",", resources)}", MediCore.Logger.LogLevel.Info);

            var center = centerService.GetCenter(id);
            if (center == null)
            {
                logger.Log($"Center number {id} not found...", Logger.LogLevel.Warning);
                return NotFound();
            }

            // Using the database, fetch ressources asked and include them (db is here to unsure existence of said ressources)
            using (VarianContext context = dbContextFactory.CreateDbContext())
            {
                var r = AdminQueries.GetRessourcesById(context, resources);
                if (centerService.EditCenterRessources(center, r))
                    return Ok();
                return NotFound();
            }
        }

        /// <summary>
        /// Edit the MACHINE ressources of a center
        /// </summary>
        /// <param name="id">Edit the HUMAN ressources of a center</param>
        /// <param name="resources">Machines to add to the center</param>
        /// <returns></returns>
        [HttpPost("editCentreMachines/{id}")]
        public IActionResult EditCentreMachines(int id, [FromBody] List<string> resources)
        {
            logger.Log($"Editing Centre {id} with new machines :{string.Join(",", resources)}", MediCore.Logger.LogLevel.Info);

            var center = centerService.GetCenter(id);
            if (center == null)
            {
                logger.Log($"Center number {id} not found...", Logger.LogLevel.Warning);
                return NotFound();
            }

            // Using the database, fetch machines asked and include them (db is here to unsure existence of said machines)
            using (VarianContext context = dbContextFactory.CreateDbContext())
            {
                var r = AdminQueries.GetMachinesById(context, resources);
                if (centerService.EditCenterMachines(center, r))
                    return Ok();
                return NotFound();
            }
        }


        /// <summary>
        /// Edit the affinity of machines
        /// </summary>
        /// <param name="id">ID of the center impacted</param>
        /// <param name="machine_name">name of the machine where the change are applied</param>
        /// <param name="request">Request which contains the new levels of affinity and priorities</param>
        /// <returns></returns>
        [HttpPost("editMachinePref/{id}/{machine_name}")]
        public IActionResult EditMachinepref(
            int id,
            string machine_name,
            [FromBody] EditMachinePrefRequest request)
        {
            var center = centerService.GetCenter(id);
            if (center != null)
            {
                var machine = center.GetMachineByName(machine_name);
                
                // update maximum size fo treatement
                machine.Champs = new(request.champsX, request.champsY);

                // get all localizations and update affinities
                var convertedLoca = new Dictionary<LocalizationType, Tuple<Preferences, bool>>();
                foreach (var loc in request.localisations)
                {
                    Enum.TryParse<LocalizationType>(loc.Key, true, out var type); // convertir la string en enum
                    var locaType = type;

                    var preferences = (Preferences)(loc.Value.Item1);
                    convertedLoca[locaType] = new Tuple<Preferences, bool>(preferences, loc.Value.Item2);
                }

                machine.Localizations = convertedLoca;

                return Ok();
            }

            return NotFound($"Error, centre {id} not found");
        }

        /// <summary>
        /// get information about a specific center
        /// </summary>
        /// <param name="id">ID of the center we want information about</param>
        /// <returns></returns>
        [HttpGet("centres/{id}")]
        public IActionResult GetCenter(int id)
        {
            logger.Log("Attemting to get CenterInfo !", MediCore.Logger.LogLevel.Info);

            var center = centerService.GetCenter(id);
            if (center == null)
            {
                logger.Log($"Center number {id} not found...", Logger.LogLevel.Warning);
                return NotFound();
            }

            logger.Log($"Getting info of center {center.Name}", MediCore.Logger.LogLevel.Info);
            return Ok(center);
        }

        /// <summary>
        /// Get the machine of a center
        /// </summary>
        /// <param name="id">ID of the said center</param>
        /// <param name="name">Name of the said machine</param>
        /// <returns></returns>
        [HttpGet("getMachineCenter/{id}/{name}")]
        public IActionResult GetMachineCenter(int id, string name)
        {
            var Center = centerService.GetCenter(id);

            if (Center != null)
                if (Center.Machines.Select(x => x.Name).Contains(name))
                    return Ok(Center.Machines.Where(x => x.Name == name).ToList()[0]);

            return NotFound("Center Or Machine not Found");
        }
        
        /// <summary>
        /// Get all machines known in database
        /// </summary>
        /// <returns></returns>
        [HttpGet("getMachines")]
        public IActionResult GetMachines()
        {
            using (VarianContext varianContext = dbContextFactory.CreateDbContext())
            {
                var machines = AdminQueries.GetMachines(varianContext);

                return Ok(machines);
            }
        }

        /// <summary>
        /// Get all humans ressources known in database
        /// </summary>
        /// <returns></returns>
        [HttpGet("getRessources")]
        public IActionResult GetRessources()
        {
            using (VarianContext varianContext = dbContextFactory.CreateDbContext())
            {
                var ressources = AdminQueries.GetRessources(varianContext);

                return Ok(ressources);
            }
        }

        /// <summary>
        /// Will setup the center Manager through an imported configuration
        /// </summary>
        /// <param name="centres">List of the centers imported</param>
        /// <returns></returns>
        [HttpPost("importCenters")]
        public IActionResult ImportCentres([FromBody] List<Center> centres)
        {
            centerService.Centers.Clear();
            foreach (var c in centres)
                centerService.AddCenter(c);
            

            return Ok();
        }
    }
}
