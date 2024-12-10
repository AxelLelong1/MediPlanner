using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("task_area_typ")]
public partial class TaskAreaTyp
{
    [Key]
    [Column("task_area_typ")]
    public int TaskAreaTyp1 { get; set; }

    [Column("task_area_desc")]
    [StringLength(50)]
    public string TaskAreaDesc { get; set; } = null!;

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

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [InverseProperty("TaskAreaTypNavigation")]
    public virtual ICollection<InstTaskAreaTyp> InstTaskAreaTyp { get; set; } = new List<InstTaskAreaTyp>();
}
