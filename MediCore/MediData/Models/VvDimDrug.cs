using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimDrug
{
    [StringLength(50)]
    public string? AgentName { get; set; }

    [StringLength(30)]
    public string? MedispanDrugName { get; set; }

    [StringLength(50)]
    public string? PreferredAgentName { get; set; }

    [StringLength(20)]
    public string? AgentClassDescription { get; set; }

    [StringLength(2)]
    public string? Route { get; set; }

    [StringLength(4)]
    public string? Form { get; set; }

    [StringLength(15)]
    public string? Strength { get; set; }

    [StringLength(10)]
    public string? UnitOfMeasure { get; set; }

    [Column("ctrdrug_desc_id")]
    [StringLength(6)]
    public string? CtrdrugDescId { get; set; }
}
