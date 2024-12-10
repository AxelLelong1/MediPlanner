using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PnDspFormatId", "DspFormat", "CompId")]
[Table("pn_dsp_format")]
public partial class PnDspFormat
{
    [Key]
    [Column("pn_dsp_format_id")]
    public int PnDspFormatId { get; set; }

    [Key]
    [Column("dsp_format")]
    public int DspFormat { get; set; }

    [Key]
    [Column("comp_id")]
    [StringLength(10)]
    public string CompId { get; set; } = null!;

    [Column("pn_dsp_format_typ_id")]
    public int PnDspFormatTypId { get; set; }

    [Column("format_order_no")]
    public int FormatOrderNo { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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
