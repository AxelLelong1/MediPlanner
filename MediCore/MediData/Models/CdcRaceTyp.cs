using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class CdcRaceTyp
{
    [Column("intf_map_cd")]
    [StringLength(10)]
    public string? IntfMapCd { get; set; }

    [Column("race_desc")]
    [StringLength(64)]
    public string RaceDesc { get; set; } = null!;

    [Column("cdc_cd")]
    [StringLength(6)]
    public string? CdcCd { get; set; }

    [Column("race_typ")]
    [StringLength(3)]
    [Unicode(false)]
    public string? RaceTyp { get; set; }

    [Column("user_defined_ind")]
    [StringLength(1)]
    [Unicode(false)]
    public string UserDefinedInd { get; set; } = null!;
}
