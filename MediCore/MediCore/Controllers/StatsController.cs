using MediData.Models;

using MediPlanner.Class;
using MediPlanner.Queries;
using MediPlanner.Queries.QueryResultClass;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace MediCore.Controllers
{
    /// <summary>
    /// Here for stats and other things because i was bored
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class StatsController : ControllerBase
    {

        private Center center = new();
        private readonly IDbContextFactory<VarianContext> dbContextFactory;

        public StatsController(IDbContextFactory<VarianContext> db)
        {
            dbContextFactory = db ?? throw new ArgumentNullException(nameof(dbContextFactory));
        }

        [HttpGet()]
        public IActionResult HelloPage()
        {
            return Ok("hello");
        }

        /// <summary>
        /// Get the number of RDV today !
        /// </summary>
        /// <returns></returns>
        [HttpGet("numberPatient")]
        public IActionResult GetNumberPatient()
        {
            double result = 0;
            using (var context = dbContextFactory.CreateDbContext())
            {
                foreach (var machine in center.Machines)
                    result += MachineScheduleQuery.GetMachineNumberPatient(context, machine.GetMachineName(), DateTime.Today);
            }
            return Ok(result);
        }

        /// <summary>
        /// Get all the current and upcomming maintenances of the day
        /// </summary>
        /// <returns></returns>
        [HttpGet("machinesMaintenance")]
        public IActionResult GetMachinesMaintenance()
        {
            List<MaintenanceMachineResult> result = [];
            using (var context = dbContextFactory.CreateDbContext())
            {
                foreach (var machine in center.Machines)
                {
                    var m = MachineScheduleQuery.GetMaintenance(context, machine.GetMachineName(), DateTime.Today);
                    if (m != null)
                        result.Add(m);
                }
            }
            return Ok(result);
        }
    }
}
