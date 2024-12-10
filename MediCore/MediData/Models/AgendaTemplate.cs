using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "AgendaTemplateId")]
[Table("agenda_template")]
public partial class AgendaTemplate
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("agenda_template_id")]
    public int AgendaTemplateId { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string Description { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [InverseProperty("AgendaTemplate")]
    public virtual ICollection<AgendaTemplateGroup> AgendaTemplateGroup { get; set; } = new List<AgendaTemplateGroup>();

    [InverseProperty("AgendaTemplate")]
    public virtual ICollection<AgendaTemplateTask> AgendaTemplateTask { get; set; } = new List<AgendaTemplateTask>();

    [InverseProperty("AgendaTemplate")]
    public virtual ICollection<PtAgendaHdr> PtAgendaHdr { get; set; } = new List<PtAgendaHdr>();
}
