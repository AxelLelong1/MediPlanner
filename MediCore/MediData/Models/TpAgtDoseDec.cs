using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "IntvId", "DoseDecId")]
[Table("tp_agt_dose_dec")]
public partial class TpAgtDoseDec
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Key]
    [Column("dose_dec_id")]
    public int DoseDecId { get; set; }

    [Column("dose_dec_min", TypeName = "decimal(11, 4)")]
    public decimal? DoseDecMin { get; set; }

    [Column("dose_dec_max", TypeName = "decimal(11, 4)")]
    public decimal? DoseDecMax { get; set; }

    [Column("order_dose", TypeName = "decimal(11, 4)")]
    public decimal? OrderDose { get; set; }

    [Column("dec_cd")]
    [StringLength(3)]
    public string DecCd { get; set; } = null!;

    [Column("dec_uom")]
    public int DecUom { get; set; }

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
}
