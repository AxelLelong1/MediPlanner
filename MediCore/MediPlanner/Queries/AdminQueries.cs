using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

using MediData.Models;

using MediPlanner.Class;

namespace MediPlanner.Queries
{
    /// <summary>
    /// Queries request for the admin controller
    /// </summary>
    public class AdminQueries
    {
        static public List<Class.Machine> GetMachines(VarianContext context)
        {
            List<Class.Machine> machines = context.Machine
                .Where(m => m.MachineName != null && m.OperationStatus != "Disabled" && m.OperationStatus != "Virtual")
                .OrderBy(m => m.MachineName)
                .Select(m => new Class.Machine
                {
                    Id = m.MachineId,
                    Name = m.MachineName,
                })
                .ToList();
            return machines;
        }

        static public List<Ressources> GetRessources(VarianContext context)
        {
            var resources = context.Staff
                .Select(x => new Ressources{ Id = x.StaffId,
                                   FirstName = x.FirstName,
                                   LastName = x.LastName })
                .OrderBy(x => x.FirstName)
                .ToList();
            return resources;
        }

        static public List<Ressources> GetRessourcesById(VarianContext context, List<string> Ids)
        { 
            var resources = context.Staff
                .Select(x => new Ressources
                {
                    Id = x.StaffId,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                })
                .OrderBy(x => x.FirstName)
                .ToList();

            resources = resources.Where(x => Ids.Contains(x.Id)).ToList();

            return resources;
        }

        static public List<Class.Machine> GetMachinesById(VarianContext context, List<string> Ids)
        {
            var machines = context.Machine
                .Select(x => new Class.Machine
                {
                    Id = x.MachineId,
                    Name = x.MachineName
                })
                .OrderBy(x => x.Name)
                .ToList();

            machines = machines.Where(x => Ids.Contains(x.Id)).ToList();

            return machines;
        }
    }
}
