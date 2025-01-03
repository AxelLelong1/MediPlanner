using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediData.Models;

using MediPlanner.Enums;
using MediPlanner.Helper;
using MediPlanner.Queries;

namespace MediPlanner.Class
{
    /// <summary>
    /// Concerne les sites
    /// </summary>
    public class Center
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Machine> Machines { get; set; }
        public List<Ressources> Ressources { get; set; }
        public Localisations Localisations { get; set; }

        public Center(string name)
        {
            Id = 0;
            Name = name;
            Machines = new();
            Ressources = new();
            Localisations = new();
        }

        /// <summary>
        /// Class par défaut (StCloud 2024)
        /// </summary>
        public Center()
        {
            Machines = new List<Machine>();
            Name = "StCloud";
            Id = 0;
            Ressources = new();
            Localisations = new Localisations();
            // Ajout des machines avec les préférences pour chaque localisation
            
            Machine trueBeam1 = new Machine("TRUEBEAM", MachineType.TRUEBEAM, new Tuple<int,int>(40, 40)); // machine setup
            trueBeam1.Champs = new Tuple<int, int>(40, 40);
            trueBeam1.AddLocalization(LocalizationType.SeinLocal, Preferences.PRIORITE, true); // affinity setup
            trueBeam1.AddLocalization(LocalizationType.SeinRegional, Preferences.AEVITER, false);
            trueBeam1.AddLocalization(LocalizationType.SeinDIBH, Preferences.PRIORITE, true);
            trueBeam1.AddLocalization(LocalizationType.Hematologie, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Urologie, Preferences.AEVITER, false);
            trueBeam1.AddLocalization(LocalizationType.Gynecologie, Preferences.AEVITER, false);
            trueBeam1.AddLocalization(LocalizationType.Digestif, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Thorax, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Sarcome, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.ORL, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Dermatologie, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.SpiroPoumon, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Medulloblastomes, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Membres, Preferences.POSSIBLE, false);
            trueBeam1.AddLocalization(LocalizationType.Palliatif, Preferences.POSSIBLE, false);

            Machine trueBeam2 = new Machine("TRUEBEAM2", MachineType.TRUEBEAM2, new Tuple<int, int>(40, 40));
            trueBeam2.Champs = new Tuple<int, int>(40, 40);
            trueBeam2.AddLocalization(LocalizationType.SeinLocal, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.SeinRegional, Preferences.AEVITER, false);
            trueBeam2.AddLocalization(LocalizationType.SeinDIBH, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Hematologie, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Urologie, Preferences.PRIORITE, true);
            trueBeam2.AddLocalization(LocalizationType.Gynecologie, Preferences.AEVITER, false);
            trueBeam2.AddLocalization(LocalizationType.Digestif, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Thorax, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Crane, Preferences.PRIORITE, true);
            trueBeam2.AddLocalization(LocalizationType.Sarcome, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.ORL, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Dermatologie, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.SpiroPoumon, Preferences.AEVITER, false);
            trueBeam2.AddLocalization(LocalizationType.Medulloblastomes, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Membres, Preferences.POSSIBLE, false);
            trueBeam2.AddLocalization(LocalizationType.Palliatif, Preferences.POSSIBLE, false);

            Machine novalisTx = new Machine("NOVALISTX", MachineType.NOVALISTX, new Tuple<int, int>(22, 40));
            novalisTx.Champs = new Tuple<int, int>(22, 40);
            novalisTx.AddLocalization(LocalizationType.Hematologie, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.Urologie, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.Gynecologie, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.Digestif, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.Thorax, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.Crane, Preferences.POSSIBLE, true);
            novalisTx.AddLocalization(LocalizationType.ORL, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.SpiroPoumon, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.Palliatif, Preferences.AEVITER, false);
            novalisTx.AddLocalization(LocalizationType.StereoIntraExtra, Preferences.PRIORITE, true);

            Machine halcyon = new Machine("HALCYON SC", MachineType.HALCYONSC, new Tuple<int, int>(28, 28));
            halcyon.Champs = new Tuple<int, int>(28, 28);
            halcyon.AddLocalization(LocalizationType.SeinLocal, Preferences.AEVITER, false);
            halcyon.AddLocalization(LocalizationType.SeinRegional, Preferences.PRIORITE, true);
            halcyon.AddLocalization(LocalizationType.Hematologie, Preferences.AEVITER, false);
            halcyon.AddLocalization(LocalizationType.Urologie, Preferences.POSSIBLE, false);
            halcyon.AddLocalization(LocalizationType.Gynecologie, Preferences.PRIORITE, true);
            halcyon.AddLocalization(LocalizationType.Digestif, Preferences.AEVITER, false);
            halcyon.AddLocalization(LocalizationType.Sarcome, Preferences.POSSIBLE, true);
            halcyon.AddLocalization(LocalizationType.Crane, Preferences.AEVITER, false);
            halcyon.AddLocalization(LocalizationType.ORL, Preferences.PRIORITE, true);
            halcyon.AddLocalization(LocalizationType.Dermatologie, Preferences.AEVITER, false);
            halcyon.AddLocalization(LocalizationType.Medulloblastomes, Preferences.AEVITER, false);
            halcyon.AddLocalization(LocalizationType.Palliatif, Preferences.AEVITER, false);

            // Ajout des machines au centre
            this.AddMachine(trueBeam1);
            this.AddMachine(trueBeam2);
            this.AddMachine(novalisTx);
            this.AddMachine(halcyon);
        }

        /// <summary>
        /// Ajoute une machine
        /// </summary>
        /// <param name="machine"></param>
        public void AddMachine(Machine machine)
        {
            Machines.Add(machine);
        }

        /// <summary>
        /// Return the machine class associated by its name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Machine GetMachineByName(string name)
        {
            return Machines.Find(m => m.GetMachineName().ToUpper() == name.ToUpper());
        }
        /// <summary>
        /// Return the localization Type by its name
        /// </summary>
        /// <param name="loca"></param>
        /// <returns></returns>
        public LocalizationType? GetLocaByName(string loca)
        {
            foreach (var loc in Localisations.localisations)
            {
                if (loc.Name == loca)
                    return loc.Type;
            }

            return null;
        }

        /// <summary>
        /// Retourne une liste de machine par ordre de préférence pour un traitement donné
        /// </summary>
        /// <param name="localization"></param>
        /// <returns></returns>
        public List<Machine> GetMachinesByPreference(LocalizationType localization)
        {
            return Machines
                .Where(m => m.Localizations.ContainsKey(localization) && m.Localizations[localization].Item1 != Preferences.NON)
                .OrderBy(m => m.Localizations[localization])
                .ToList();
        }

        /// <summary>
        /// Get the most preferred (or most interesting if equality) machine for a given loc
        /// </summary>
        /// <param name="context"></param>
        /// <param name="machines"></param>
        /// <param name="localization"></param>
        /// <param name="Champs"></param>
        /// <param name="date"></param>
        /// <param name="weeks"></param>
        /// <returns></returns>
        public Machine GetMostOptimalMachine(VarianContext context, LocalizationType localization, Tuple<int, int> Champs, DateTime date, int weeks)
        {
            double min = -1;
            Machine final = null;
            foreach (var machine in Machines.Where(m => m.GetLocalizationPref(localization) <= Preferences.POSSIBLE
                                                        && m.Champs.Item1 >= Champs.Item1 && m.Champs.Item2 >= Champs.Item2))
            {
                var temp = MachineScheduleQuery.GetMachineUsedTime(context, machine.GetMachineName(), date, weeks);
                Console.WriteLine("{0} has been occupied for {1} minutes during the potential patient placement", machine.GetMachineName(), temp);

                if (min == -1 || min > temp)
                {
                    min = temp;
                    final = machine;
                }
            }

            return final;
        }
        /*
        public Machine ChooseMachine(VarianContext context, LocalizationType localization, DateTime Monday, int semaines)
        {
            List<Class.Machine> machines = GetMachinesByPreference(localization);

            // TODO add CHAMPS

            Class.Machine machine = GetMostOptimalMachine(context, localization, new Tuple<int, int>(10,10) ,Monday, semaines);

            Console.WriteLine("recommandée basée sur le temps : {0}", machine.GetMachineName());

            Machine official = machines.Where(m => m.GetLocalizationOffcial(localization) == true).FirstOrDefault();
            if (official != null)
                Console.WriteLine("recommandée : {0}", official.GetMachineName());

            Console.Write("Sur quelle machine positionner le patient ?");
            return GetMachineByName(Console.ReadLine()); // TODO BABY PROOF THAT READLINE
        }
         */


        /* ------------------------------------- DISPLAY ------------------------------------- */

        public string DisplayPreference(Preferences pref)
        {
            switch (pref)
            {
                case Preferences.PRIORITE: return "Priorité";
                case Preferences.POSSIBLE: return "Possible";
                case Preferences.AEVITER: return "à éviter";
                default: return "Non Traité";
            };
        }

        public ConsoleColor ColorPrefence(Preferences pref)
        {
            switch (pref)
            {
                case Preferences.PRIORITE: return ConsoleColor.Green;
                case Preferences.POSSIBLE: return ConsoleColor.DarkGreen;
                case Preferences.AEVITER: return ConsoleColor.Yellow;
                default: return ConsoleColor.Red;
            };
        }

        public void DisplayTreatmentTable()
        {
            // Liste des localisations à afficher
            var localizations = Enum.GetValues(typeof(LocalizationType)).Cast<LocalizationType>().ToList();

            // Afficher l'en-tête avec les machines
            Console.Write("Localisation".PadRight(20));
            foreach (var machine in Machines)
            {
                Console.Write(machine.GetMachineName);
            }
            Console.WriteLine();

            // Afficher chaque localisation et les préférences par machine
            foreach (var localization in localizations)
            {
                Console.Write(localization.ToString().PadRight(20));

                foreach (var machine in Machines)
                {
                    var preference = machine.GetLocalizationPref(localization);
                    Console.ForegroundColor = ColorPrefence(preference);
                    Console.Write(DisplayPreference(preference).PadRight(15));
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine();
            }
        }
    }
}
