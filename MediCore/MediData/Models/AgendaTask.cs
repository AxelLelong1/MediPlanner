using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agenda_task")]
public partial class AgendaTask
{
    [Key]
    [Column("agenda_task_id")]
    public int AgendaTaskId { get; set; }

    [Column("description")]
    [StringLength(50)]
    public string Description { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("AgendaTask")]
    public virtual ICollection<AgendaTemplateTask> AgendaTemplateTask { get; set; } = new List<AgendaTemplateTask>();

    [InverseProperty("AgendaTask")]
    public virtual ICollection<PtAgenda> PtAgenda { get; set; } = new List<PtAgenda>();
}
