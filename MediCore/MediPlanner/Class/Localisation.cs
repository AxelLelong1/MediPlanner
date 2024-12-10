using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediPlanner.Enums;

namespace MediPlanner.Class
{
    public class Localisation
    {
        public LocalizationType Type { get; set; }
        public string Name { get; set; }

        public Localisation(LocalizationType type, string name)
        {
            Type = type;
            Name = name;
        }
    }

    public class Localisations
    {
        public List<Localisation> localisations { get; set; }
        public Localisations()
        {
            localisations = new List<Localisation>();
            localisations.Add(new Localisation(LocalizationType.SeinLocal, "SeinLocal"));
            localisations.Add(new Localisation(LocalizationType.SeinRegional, "SeinRegional"));
            localisations.Add(new Localisation(LocalizationType.SeinDIBH, "SeinDIBH"));
            localisations.Add(new Localisation(LocalizationType.Hematologie, "Hematologie"));
            localisations.Add(new Localisation(LocalizationType.Urologie, "Urologie"));
            localisations.Add(new Localisation(LocalizationType.Gynecologie, "Gynecologie"));
            localisations.Add(new Localisation(LocalizationType.Digestif, "Digestif"));
            localisations.Add(new Localisation(LocalizationType.Thorax, "Thorax"));
            localisations.Add(new Localisation(LocalizationType.Crane, "Crane"));
            localisations.Add(new Localisation(LocalizationType.Sarcome, "Sarcome"));
            localisations.Add(new Localisation(LocalizationType.ORL, "ORL"));
            localisations.Add(new Localisation(LocalizationType.Dermatologie, "Dermatologie"));
            localisations.Add(new Localisation(LocalizationType.SpiroPoumon, "SpiroPoumon"));
            localisations.Add(new Localisation(LocalizationType.Medulloblastomes, "Medulloblastomes"));
            localisations.Add(new Localisation(LocalizationType.Membres, "Membres"));
            localisations.Add(new Localisation(LocalizationType.Palliatif, "Palliatif"));
            localisations.Add(new Localisation(LocalizationType.StereoIntraExtra, "StereoIntraExtra"));
        }
    }
}
