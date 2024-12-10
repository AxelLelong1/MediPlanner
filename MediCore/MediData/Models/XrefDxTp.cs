using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtDxId", "DateTpInit")]
[Table("xref_dx_tp")]
public partial class XrefDxTp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_dx_id")]
    public int PtDxId { get; set; }

    [Key]
    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime DateTpInit { get; set; }

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

    [ForeignKey("PtId, PtDxId")]
    [InverseProperty("XrefDxTp")]
    public virtual PtDx PtDx { get; set; } = null!;

    [ForeignKey("PtId, DateTpInit")]
    [InverseProperty("XrefDxTp")]
    public virtual PtTp PtTp { get; set; } = null!;
}
