using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AgendaTemplateId", "AgendaTemplateGroupId")]
[Table("agenda_template_group")]
public partial class AgendaTemplateGroup
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agenda_template_id")]
    public int AgendaTemplateId { get; set; }

    [Key]
    [Column("agenda_template_group_id")]
    public int AgendaTemplateGroupId { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string Description { get; set; } = null!;

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

    [ForeignKey("InstId, AgendaTemplateId")]
    [InverseProperty("AgendaTemplateGroup")]
    public virtual AgendaTemplate AgendaTemplate { get; set; } = null!;

    [InverseProperty("AgendaTemplateGroup")]
    public virtual ICollection<AgendaTemplateTask> AgendaTemplateTask { get; set; } = new List<AgendaTemplateTask>();
}
