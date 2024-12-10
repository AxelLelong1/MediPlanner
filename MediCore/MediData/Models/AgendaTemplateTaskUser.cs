using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Userid", "UserInstId", "InstId", "AgendaTemplateId", "AgendaTemplateTaskId")]
[Table("agenda_template_task_user")]
public partial class AgendaTemplateTaskUser
{
    [Key]
    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Key]
    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agenda_template_id")]
    public int AgendaTemplateId { get; set; }

    [Key]
    [Column("agenda_template_task_id")]
    public int AgendaTemplateTaskId { get; set; }

    [Column("seq_no")]
    public int SeqNo { get; set; }

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

    [ForeignKey("InstId, AgendaTemplateId, AgendaTemplateTaskId")]
    [InverseProperty("AgendaTemplateTaskUser")]
    public virtual AgendaTemplateTask AgendaTemplateTask { get; set; } = null!;

    [ForeignKey("UserInstId, Userid")]
    [InverseProperty("AgendaTemplateTaskUser")]
    public virtual Userid UseridNavigation { get; set; } = null!;
}
