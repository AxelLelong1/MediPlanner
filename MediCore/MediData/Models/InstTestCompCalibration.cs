using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TypOfTest", "CompName")]
[Table("inst_test_comp_calibration")]
public partial class InstTestCompCalibration
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

    [Column("comp_typ")]
    public int? CompTyp { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("inst_comp_order_no")]
    public int? InstCompOrderNo { get; set; }

    [Column("min_norm", TypeName = "decimal(16, 4)")]
    public decimal? MinNorm { get; set; }

    [Column("max_norm", TypeName = "decimal(16, 4)")]
    public decimal? MaxNorm { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }

    [Column("custom_ind")]
    [StringLength(1)]
    public string? CustomInd { get; set; }

    [Column("favorite_ind")]
    [StringLength(1)]
    public string? FavoriteInd { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
