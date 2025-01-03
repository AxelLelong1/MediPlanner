using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using MediPlanner.Queries;
using MediPlanner.Class;
using MediPlanner.Enums;
using MediPlanner.Calculus;
using MediPlanner.Queries.QueryResultClass;
using MediPlanner.Queries.Request;

using MediData.Models;

using MediCore.Services;
using Azure.Core;

namespace MediCore.Controllers
{
    /// <summary>
    /// Planning controller, used for the... well... Planning :D
    /// We will add, remove, intereact with the front end here !
    /// Call to the logic functions and such are made here
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class PlanningController : ControllerBase
    {
        private Center StCloud = new();
        private Logger.Logger logger = Logger.Logger.Instance;
        private readonly IDbContextFactory<VarianContext> dbContextFactory;
        private AdminController adminController;
        private readonly CenterService centerService;
        private readonly PatientListService patientListService;

        public PlanningController(IDbContextFactory<VarianContext> db, CenterService centerService, PatientListService patientListService, AdminController adminController)
        {
            dbContextFactory = db ?? throw new ArgumentNullException(nameof(dbContextFactory));
            this.centerService = centerService;
            this.patientListService = patientListService;
            this.adminController = adminController ?? throw new ArgumentNullException(nameof(adminController));
        }

        /// <summary>
        /// HELLO PAGE (if you want some setup or remove data, apply the code here and go to http://localhost:port)
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public IActionResult HelloPage()
        {
            logger.Log("Hello !", MediCore.Logger.LogLevel.Info);
            return Ok("hello");
        }

        /// <summary>
        /// Get the full schedule for a machine from a specific starter date
        /// </summary>
        /// <param name="machine">Machine name we want the schedule of</param>
        /// <param name="startTime">Start date</param>
        /// <returns></returns>
        [HttpGet("schedule")]
        public IActionResult GetSchedule([FromQuery] string machine, [FromQuery] DateTime startTime)
        {
            logger.Log(("Attempt to get schedule for ") + (machine) + " at " + (startTime), MediCore.Logger.LogLevel.Info);

            using (VarianContext context = dbContextFactory.CreateDbContext())
            {
                if (!string.IsNullOrEmpty(machine))
                {
                    var response = MachineScheduleQuery.GetScheduleActivity(context, machine, startTime, 4, patientListService.patients);

                    logger.Log("Successfully got the schedule", MediCore.Logger.LogLevel.Info);
                    return Ok(response);
                }
            }

            logger.Log("Coundl't get the schedule... Maybe the request is wrong ...", MediCore.Logger.LogLevel.Warning);
            return NotFound("Machine " + machine + " Not Found");
        }

        /// <summary>
        /// Get the machines for the center with the best priority that localization with the specific size.
        /// Get the machine with highest priority and most free time as well
        /// </summary>
        /// <param name="centerID">ID of the center where to treat</param>
        /// <param name="localization">Localization to treat</param>
        /// <param name="sizeX">X size</param>
        /// <param name="sizeY">Y size</param>
        /// <param name="start_date">Date from which the treatment begins</param>
        /// <returns></returns>
        [HttpGet("preferredMachine")]
        public IActionResult GetPreferredMachine(
        [FromQuery] int centerID,
        [FromQuery] string localization,
        [FromQuery] int sizeX,
        [FromQuery] int sizeY,
        [FromQuery] DateTime start_date,
        [FromQuery] int weeks)
        {
            logger.Log($"Getting preferred machine for {localization} with tumor size ({sizeX}, {sizeY}) and date {start_date}",
                        MediCore.Logger.LogLevel.Info);

            // Créer le tuple (sizeX, sizeY) pour la taille de la tumeur
            Tuple<int, int> tumorSize = new(sizeX, sizeY);

            // Get the center
            Center c = null;
            var result_center = adminController.GetCenter(centerID);
            if (result_center is OkObjectResult center)
            {
                c = (Center)center.Value;
            }

            // get the Localization
            LocalizationType loca = c.GetLocaByName(localization).Value;

            using (VarianContext context = dbContextFactory.CreateDbContext())
            {
                // Appeler la méthode GetMostOptimalMachine avec les paramètres corrects
                var mostOptimal = c.GetMostOptimalMachine(
                context,
                loca,
                tumorSize,
                start_date,
                weeks); // TODO: replace by weeks

                // Récupérer la machine préférée
                var preferredMachine = c.Machines
                    .Where(m => m.GetLocalizationOffcial(loca) == true)
                    .FirstOrDefault();

                // Créer l'objet de résultat
                var preferred = new PreferredMachineResult();

                if (preferredMachine != null)
                    preferred.Preferred = preferredMachine;

                if (mostOptimal != null)
                    preferred.Optimum = mostOptimal;

                return Ok(preferred);
            }
        }

        /// <summary>
        /// Get machines ABLE to treat localization with the specific size.
        /// </summary>
        /// <param name="centerID">ID of the center where to treat</param>
        /// <param name="localization">Localization to treat</param>
        /// <param name="sizeX">X size</param>
        /// <param name="sizeY">Y size</param>
        /// <param name="start_date">Date from which the treatment begins</param>
        /// <returns></returns>
        [HttpGet("CompatibleMachines")]
        public IActionResult GetCompatibleMachines(
            [FromQuery] int centerID,
            [FromQuery] string localization,
            [FromQuery] int sizeX,
            [FromQuery] int sizeY,
            [FromQuery] DateTime start_date)
        {

            var result_center = adminController.GetCenter(centerID);
            if (result_center is OkObjectResult center)
            {
                Center c = (Center)center.Value;

                LocalizationType loca = c.GetLocaByName(localization).Value;
                return Ok(c.Machines.Where(m => m.GetLocalizationPref(loca) <= Preferences.POSSIBLE
                                                            && m.Champs.Item1 >= sizeX && m.Champs.Item2 >= sizeY));
            }
            return NotFound("Something went wrong");
        }

        /// <summary>
        /// Get all added patients
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAddedPatients")]
        public IActionResult GetAddedpatients()
        {
            return Ok(patientListService.patients);
        }

        /// <summary>
        /// get the schedules added for an added patients
        /// </summary>
        /// <param name="patientName">name of the targeted patient</param>
        /// <returns></returns>
        [HttpGet("GetSchedulePatient/")]
        public IActionResult GetSchedulePatient([FromQuery] string patientName)
        {
            Console.WriteLine($"Trying ti get schedule of {patientName}");
            return Ok(patientListService.patients.Where(x => patientName.ToUpper() == x.FirstName.ToUpper() + " " + x.LastName.ToUpper()).Select(x => x.Schedules));
        }

        /// <summary>
        /// Add a patient and try to put the schedules automatically (possibility to add manually more schedules and modify existing ones)
        /// </summary>
        /// <param name="name">Name of the patient</param>
        /// <param name="surname">Surname of the patient</param>
        /// <param name="machineName">name of the machine the patient is chosen to be treated on</param>
        /// <param name="centerId">Center where the patient is treated</param>
        /// <param name="localization">Localization treated</param>
        /// <param name="sizeX">Size X</param>
        /// <param name="sizeY">Size Y</param>
        /// <param name="start_date">Start date of the treatment</param>
        /// <param name="start_hour">Preferred hour of treamtment (00:00) if none</param>
        /// <returns></returns>
        [HttpGet("AddPatient")]
        public IActionResult AddPatientAPI(
            [FromQuery] string name,
            [FromQuery] string surname,
            [FromQuery] string machineName,
            [FromQuery] int centerId,
            [FromQuery] string localization,
            [FromQuery] int sizeX,
            [FromQuery] int sizeY,
            [FromQuery] DateTime start_date,
            [FromQuery] int frac,
            [FromQuery] int week,
            [FromQuery] TimeSpan? start_hour = null) // rendre le paramètre nullable avec une valeur par défaut
        {
            // Logger l'heure ou mentionner que l'heure est null
            logger.Log($"Adding patient with machine {machineName} for {localization} with tumor size ({sizeX}, {sizeY}) starting {start_date} at {(start_hour.HasValue ? start_hour.ToString() : "no specific hour")}",
            MediCore.Logger.LogLevel.Info);

            using var context = new VarianContext();

            var activities = MachineScheduleQuery.GetScheduleActivity(context, machineName, start_date, week, patientListService.patients);

            // Si une heure est fournie, l'utiliser ; sinon, utiliser une valeur par défaut ou ignorer
            if (!start_hour.HasValue)
                start_hour = new TimeSpan(0, 0, 0); // début de journée par défaut

            AddPatient.AddPatientStabilized(name, surname, activities, frac, week, new TimeSpan(0, 15, 0), start_hour.Value); // TIMESPAN (15) == TEMPS DE TRAIEMETMENT DE 15 MINUTES PAR DEFAUT CAR PAS HANDLE YET (TODO)

            // Get the booked activities and add need informations
            var pat_schedule = activities.SelectMany(x => x).Where(y => y.Name == name + " " + surname && y.Note.Equals("BOOKED")).ToList();
            foreach (var sc in pat_schedule)
            {
                sc.Machine = machineName;
                sc.centerId = centerId;
            }

            // update added patients 
            var new_pat = new MediPlanner.Class.Patient(name, surname, pat_schedule);
            if (!patientListService.patients.Contains(new_pat))
                patientListService.patients.Add(new_pat);

            return Ok(activities);
        }

        /// <summary>
        /// Delete a patient from the added patient list
        /// </summary>
        /// <param name="request">Request containing patient Name (request because we might need something else later for more specific purposes)</param>
        /// <returns></returns>
        [HttpDelete("DeletePatient")]
        public IActionResult DeletePatient(
            [FromBody] RemovePatientRequest request)
        {
            var splittedNaMe = request.PatientName.Split(" ");
            var Fname = splittedNaMe[0];
            var Lname = splittedNaMe[1];

            // Trouver le patient qui contient le ScheduleId dans ses horaires
            var patient = patientListService.patients
                .FirstOrDefault(p => p.FirstName == Fname && p.LastName == Lname);

            if (patient == null)
            {
                Console.WriteLine("Aucun patient trouvé pour cet ID de schedule.");
                return NotFound("Patient ou Schedule introuvable.");
            }

            patientListService.patients.Remove(patient);
            return Ok();
        }

        /// <summary>
        /// Update schedules... Some has made manual modifications that need to be saved
        /// </summary>
        /// <param name="events">List of events modified</param>
        /// <returns></returns>
        [HttpPost("UpdateEvent")]
        public IActionResult updateEvent(
            [FromBody] List<Event> events)
        {

            foreach (var e in events)
            {
                try
                {
                    // get the paitents and the correspondings events
                    var pat = patientListService.patients[patientListService.patients.IndexOf(patientListService.patients.First(x => x.FirstName.ToUpper() == e.Title.Split(" ")[0].ToUpper()))];
                    Console.WriteLine($"Modifying event {e.Id} of {e.Title} to {e.Start} - {e.End}");

                    // Modify the event accordingly
                    pat.Schedules[pat.Schedules.IndexOf(pat.Schedules.First(x => x.Id == e.Id))].StartTime = e.Start;
                    pat.Schedules[pat.Schedules.IndexOf(pat.Schedules.First(x => x.Id == e.Id))].EndTime = e.End;
                }
                catch (Exception error)
                {
                    return NotFound(error.Message);
                }
            }
            return Ok();
        }

        /// <summary>
        /// Add manually a schedule to a patient
        /// </summary>
        /// <param name="request">Contains the name, start date, end date and machine of treatment</param>
        /// <returns></returns>
        [HttpPost("AddSchedule")]
        public IActionResult AddSchedule(
           [FromBody] AddScheduleRequest request)
        {
            var splittedNaMe = request.Name.Split(" ");
            var Fname = splittedNaMe[0];
            var Lname = splittedNaMe[1];

            // Trouver le patient qui contient le ScheduleId dans ses horaires
            var patient = patientListService.patients
                .FirstOrDefault(p => p.FirstName == Fname && p.LastName == Lname);

            if (patient == null)
            {
                Console.WriteLine("Aucun patient trouvé pour cet ID de schedule.");
                return NotFound("Patient ou Schedule introuvable.");
            }

            // création d'un nouveau schedule
            patient.Schedules.Add(new MediPlanner.QueryResultClass.ScheduleQueryResult
            {
                Id = Guid.NewGuid().ToString(),
                StartTime = request.Start,
                EndTime = request.End,
                Machine = request.Machine,
                Status = "BOOKED",
                Note = "BOOKED",
                Name = request.Name
            });

            return Ok("Schedule mis à jour avec succès.");
        }

        /// <summary>
        /// Remove manually a schedule
        /// </summary>
        /// <param name="request">Contains the schedule id to remove</param>
        /// <returns></returns>
        [HttpDelete("RemoveSchedule")]
        public IActionResult RemoveSchedule(
            [FromBody] RemoveScheduleRequest request)
        {

            // Trouver le patient qui contient le ScheduleId dans ses horaires
            var patient = patientListService.patients
                .FirstOrDefault(p => p.Schedules.Any(s => s.Id == request.ScheduleId));

            if (patient == null)
            {
                return NotFound("Patient ou Schedule introuvable.");
            }

            // Trouver le schedule spécifique à modifier
            var schedule = patient.Schedules.FirstOrDefault(s => s.Id == request.ScheduleId);

            if (schedule != null)
            {
                patient.Schedules.Remove(schedule);
                return Ok("Schedule deleted avec succès.");
            }

            return NotFound("Patient ou Schedule introuvable.");
        }

        /// <summary>
        /// Manual change to a single event
        /// (more specific than modifying events, here, we can cahnge center and machine of the event)
        /// </summary>
        /// <param name="request">Contains the name, start date, end date and machine of treatment</param>
        /// <returns></returns>
        [HttpPost("UpdateSchedule")]
        public IActionResult UpdateSchedule(
            [FromBody] UpdateScheduleRequest request)
        {

            // Trouver le patient qui contient le ScheduleId dans ses horaires
            var patient = patientListService.patients
                .FirstOrDefault(p => p.Schedules.Any(s => s.Id == request.ScheduleId));

            if (patient == null)
            {
                Console.WriteLine("Aucun patient trouvé pour cet ID de schedule.");
                return NotFound("Patient ou Schedule introuvable.");
            }

            // Trouver le schedule spécifique à modifier
            var schedule = patient.Schedules.FirstOrDefault(s => s.Id == request.ScheduleId);

            if (schedule != null)
            {
                // Mettre à jour les informations de l'horaire
                patient.Schedules.First(s => s.Id == request.ScheduleId).StartTime = request.NewStart;
                patient.Schedules.First(s => s.Id == request.ScheduleId).EndTime = request.NewEnd;
                patient.Schedules.First(s => s.Id == request.ScheduleId).Machine = request.MachineName;

                Console.WriteLine($"Schedule modifié : {schedule.Id}");
            }

            return Ok("Schedule mis à jour avec succès.");
        }
    }
}
