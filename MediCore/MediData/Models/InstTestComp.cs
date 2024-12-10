using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TypOfTest", "CompName")]
[Table("inst_test_comp")]
[Index("TypOfTest", "CompName", Name = "nc1_inst_test_comp")]
public partial class InstTestComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("typ_of_test")]
    [StringLength(20)]
    public string TypOfTest { get; set; } = null!;

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("inst_comp_name")]
    [StringLength(30)]
    public string? InstCompName { get; set; }

    [Column("rqstn_ind")]
    [StringLength(1)]
    public string? RqstnInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("inst_comp_order_no")]
    public int? InstCompOrderNo { get; set; }

    [Column("favorite_ind")]
    [StringLength(1)]
    public string? FavoriteInd { get; set; }

    [Column("inst_typ_of_test")]
    [StringLength(20)]
    public string? InstTypOfTest { get; set; }

    [Column("fs_active_ind")]
    [StringLength(1)]
    public string? FsActiveInd { get; set; }

    [Column("inst_comp_abbr")]
    [StringLength(10)]
    public string? InstCompAbbr { get; set; }

    [Column("threshold_unit")]
    public int? ThresholdUnit { get; set; }

    [Column("threshold_typ")]
    public int? ThresholdTyp { get; set; }

    [Column("threshold_value", TypeName = "numeric(11, 4)")]
    public decimal? ThresholdValue { get; set; }

    [ForeignKey("TypOfTest, CompName")]
    [InverseProperty("InstTestComp")]
    public virtual TestComp TestComp { get; set; } = null!;
}
