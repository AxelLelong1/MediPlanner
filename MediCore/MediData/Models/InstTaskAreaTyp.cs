using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "TaskAreaTyp")]
[Table("inst_task_area_typ")]
public partial class InstTaskAreaTyp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("task_area_typ")]
    public int TaskAreaTyp { get; set; }

    [Column("inst_task_area_desc")]
    [StringLength(50)]
    public string? InstTaskAreaDesc { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

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

    [InverseProperty("InstTaskAreaTypNavigation")]
    public virtual ICollection<InstAgendaCatTyp> InstAgendaCatTyp { get; set; } = new List<InstAgendaCatTyp>();

    [ForeignKey("TaskAreaTyp")]
    [InverseProperty("InstTaskAreaTyp")]
    public virtual TaskAreaTyp TaskAreaTypNavigation { get; set; } = null!;
}
