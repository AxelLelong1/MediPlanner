using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("race_typ")]
public partial class RaceTyp
{
    [Key]
    [Column("race_typ")]
    public int RaceTyp1 { get; set; }

    [Column("race_desc")]
    [StringLength(64)]
    public string RaceDesc { get; set; } = null!;

    [Column("race_group_cd")]
    [StringLength(6)]
    public string? RaceGroupCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("default_ind")]
    [StringLength(1)]
    public string? DefaultInd { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("single_select_ind")]
    [StringLength(1)]
    public string? SingleSelectInd { get; set; }

    [Column("arra_hitech_ind")]
    [StringLength(1)]
    public string? ArraHitechInd { get; set; }

    [Column("mapped_race_typ")]
    public int? MappedRaceTyp { get; set; }

    [InverseProperty("MappedRaceTypNavigation")]
    public virtual ICollection<RaceTyp> InverseMappedRaceTypNavigation { get; set; } = new List<RaceTyp>();

    [ForeignKey("MappedRaceTyp")]
    [InverseProperty("InverseMappedRaceTypNavigation")]
    public virtual RaceTyp? MappedRaceTypNavigation { get; set; }
}
