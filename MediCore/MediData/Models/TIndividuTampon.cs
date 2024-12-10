using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("T_Individu_Tampon")]
public partial class TIndividuTampon
{
    [StringLength(1)]
    [Unicode(false)]
    public string IppIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DateTimeEnr { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NomNaissanceIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string PrenomNaissanceIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DateNaissanceIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string SexeIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string LieuNaissanceIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ListPrenomIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string InsIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string NomUsuelIndividu { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string PrenomUsuelIndividu { get; set; } = null!;
}
