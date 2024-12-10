using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtAgendaHdrId", "PtAgendaTaskId")]
[Table("pt_agenda")]
public partial class PtAgenda
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_agenda_hdr_id")]
    public int PtAgendaHdrId { get; set; }

    [Key]
    [Column("pt_agenda_task_id")]
    public int PtAgendaTaskId { get; set; }

    [Column("agenda_task_id")]
    public int AgendaTaskId { get; set; }

    [Column("agenda_template_task_id")]
    public int AgendaTemplateTaskId { get; set; }

    [Column("task_description")]
    [StringLength(50)]
    public string TaskDescription { get; set; } = null!;

    [Column("task_seq_no")]
    public int TaskSeqNo { get; set; }

    [Column("group_id")]
    public int GroupId { get; set; }

    [Column("group_description")]
    [StringLength(50)]
    public string GroupDescription { get; set; } = null!;

    [Column("group_seq_no")]
    public int GroupSeqNo { get; set; }

    [Column("customization_xml")]
    [StringLength(1024)]
    public string CustomizationXml { get; set; } = null!;

    [Column("status")]
    [StringLength(16)]
    public string Status { get; set; } = null!;

    [Column("req_ind")]
    [StringLength(1)]
    public string ReqInd { get; set; } = null!;

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

    [ForeignKey("AgendaTaskId")]
    [InverseProperty("PtAgenda")]
    public virtual AgendaTask AgendaTask { get; set; } = null!;

    [ForeignKey("PtId, PtAgendaHdrId")]
    [InverseProperty("PtAgenda")]
    public virtual PtAgendaHdr PtAgendaHdr { get; set; } = null!;
}
