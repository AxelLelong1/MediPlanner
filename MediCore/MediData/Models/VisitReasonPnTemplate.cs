using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("VisitReasonId", "VisitReasonInstId", "Userid", "UserInstId")]
[Table("visit_reason_pn_template")]
public partial class VisitReasonPnTemplate
{
    [Key]
    [Column("visit_reason_id")]
    public int VisitReasonId { get; set; }

    [Key]
    [Column("visit_reason_inst_id")]
    [StringLength(30)]
    public string VisitReasonInstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Column("template_id")]
    public int TemplateId { get; set; }

    [Column("template_inst_id")]
    [StringLength(30)]
    public string TemplateInstId { get; set; } = null!;

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("VisitReasonInstId, VisitReasonId")]
    [InverseProperty("VisitReasonPnTemplate")]
    public virtual InstVisitReasonTyp InstVisitReasonTyp { get; set; } = null!;

    [ForeignKey("TemplateInstId, TemplateId")]
    [InverseProperty("VisitReasonPnTemplate")]
    public virtual PnTemplate PnTemplate { get; set; } = null!;

    [ForeignKey("UserInstId, Userid")]
    [InverseProperty("VisitReasonPnTemplate")]
    public virtual Userid UseridNavigation { get; set; } = null!;
}
