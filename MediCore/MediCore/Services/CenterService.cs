using System.Runtime.InteropServices;

using MediCore.Controllers;

using MediPlanner.Class;
using MediPlanner.Enums;

namespace MediCore.Services
{
    /// <summary>
    /// Manager of all centers ! All hail the Center Service aka CS
    /// </summary>
    public class CenterService
    {
        // basic list of centers
        public List<Center> Centers { get; private set; }

        public CenterService()
        {
            Centers = new List<Center>();
        }

        /// <summary>
        /// Adds a center
        /// </summary>
        /// <param name="center">... Self explanatory</param>
        /// <returns></returns>
        public bool AddCenter(Center center)
        {
            Centers.Add(center);
            return true;
        }

        /// <summary>
        /// Delete a center
        /// </summary>
        /// <param name="center">Do i really need to explain ?</param>
        /// <returns></returns>
        public bool DeleteCenter(Center? center)
        {
            if (center == null)
                return false;

            Centers.Remove(center);
            return true;
        }

        /// <summary>
        /// Try to get the center by it's id
        /// </summary>
        /// <param name="id">ID targeted</param>
        /// <returns></returns>
        public Center? GetCenter(int id)
        {
            return Centers.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Edit the HUMAN ressources of the center (overwrite for now)
        /// </summary>
        /// <param name="center">center targeted</param>
        /// <param name="ressources">Ressources to add</param>
        /// <returns></returns>
        public bool EditCenterRessources(Center center, List<Ressources> ressources)
        {
            center.Ressources = ressources;
            return true;
        }
        /// <summary>
        /// Edit the MACHINES ressources of the center (overwrite for now)
        /// </summary>
        /// <param name="center">center targeted</param>
        /// <param name="machines">Machines to add</param>
        /// <returns></returns>
        public bool EditCenterMachines(Center center, List<Machine> machines)
        {
            foreach (var machine in machines)
            {
                
                machine.Localizations = new Dictionary<LocalizationType, Tuple<Preferences, bool>>();

                // Ajouter toutes les localisations disponibles
                foreach (var loca in new Localisations().localisations)
                {
                    // Associer un paramètre par défaut (false dans ce cas)
                    machine.Localizations[loca.Type] = new Tuple<Preferences, bool>(0, false);
                    machine.Champs = new(99, 99);
                }
            }

            center.Machines = machines;
            return true;
        }
    }

}
