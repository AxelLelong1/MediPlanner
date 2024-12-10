using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("task")]
public partial class Task
{
    [Key]
    [Column("task_id")]
    public int TaskId { get; set; }

    [Column("task_name")]
    [StringLength(50)]
    public string TaskName { get; set; } = null!;

    [Column("task_cat_ind")]
    [StringLength(1)]
    public string? TaskCatInd { get; set; }

    [Column("task_cat_id")]
    public int? TaskCatId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
