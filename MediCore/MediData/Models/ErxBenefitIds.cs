using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_benefit_ids")]
public partial class ErxBenefitIds
{
    [Key]
    [Column("erx_benefit_id_id")]
    public int ErxBenefitIdId { get; set; }

    [Column("erx_benefit_id")]
    public int ErxBenefitId { get; set; }

    [Column("id_value")]
    [StringLength(80)]
    public string? IdValue { get; set; }

    [Column("id_value_cd")]
    [StringLength(30)]
    public string? IdValueCd { get; set; }
}
