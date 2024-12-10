using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

using MediPlanner.Enums;

namespace MediPlanner.Class
{
    public class Machine
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public MachineType MachineType { get; set; }
        public Dictionary<LocalizationType, Tuple<Preferences, bool>> Localizations { get; set; }
        public Tuple<int, int> Champs { get; set; }

        public Machine()
        {

        }
        public Machine(string name, MachineType MachineType, Tuple<int, int> champs)
        {
            Id = name;
            Name = name;
            this.MachineType = MachineType;
            Localizations = new Dictionary<LocalizationType, Tuple<Preferences, bool>>();
            Champs = champs;
        }

        /// <summary>
        /// Ajoute une localisation traitable avec une spécificité (si besoin)
        /// </summary>
        public void AddLocalization(LocalizationType localization, Preferences pref, bool Officiel)
        {
            Localizations[localization] = new Tuple<Preferences, bool>(pref, Officiel);
        }

        public string GetMachineName()
        {
            return this.Name;
        }

        /// <summary>
        /// Retourne la préférence d'une localzation sur la machine
        /// </summary>
        /// <param name="localization"></param>
        /// <returns></returns>
        public Preferences GetLocalizationPref(LocalizationType localization)
        {
            if (Localizations.TryGetValue(localization, out Tuple<Preferences, bool> pref))
                return pref.Item1;
            return Preferences.NON; // NON TRAITE
        }

        public bool GetLocalizationOffcial(LocalizationType localization)
        {
            if (Localizations.TryGetValue(localization, out Tuple<Preferences, bool> pref))
                return pref.Item2;
            return false; // NON TRAITE
        }
    }
}
