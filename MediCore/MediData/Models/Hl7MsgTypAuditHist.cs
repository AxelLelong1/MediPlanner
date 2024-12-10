using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_msg_typ_audit_hist")]
public partial class Hl7MsgTypAuditHist
{
    [Key]
    [Column("audit_hist_id")]
    [StringLength(10)]
    public string AuditHistId { get; set; } = null!;

    [Column("msg_typ_id")]
    [StringLength(10)]
    public string MsgTypId { get; set; } = null!;

    [Column("msg_typ_level")]
    public int MsgTypLevel { get; set; }

    [Column("author_name")]
    [StringLength(60)]
    public string AuthorName { get; set; } = null!;

    [Column("audit_desc")]
    public string? AuditDesc { get; set; }

    [Column("app_vers_no")]
    [StringLength(20)]
    public string? AppVersNo { get; set; }

    [Column("app_sr_no")]
    [StringLength(20)]
    public string? AppSrNo { get; set; }

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime? BaseTstamp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("MsgTypId")]
    [InverseProperty("Hl7MsgTypAuditHist")]
    public virtual Hl7MsgTyp MsgTyp { get; set; } = null!;
}
