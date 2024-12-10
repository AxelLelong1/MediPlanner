using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("enm_db_mod")]
public partial class EnmDbMod
{
    [Key]
    [Column("enm_db_mod_id")]
    public int EnmDbModId { get; set; }

    [Column("enm_db_mod_desc")]
    [StringLength(255)]
    public string EnmDbModDesc { get; set; } = null!;

    [Column("sort_order")]
    public int SortOrder { get; set; }

    [Column("completed_ind")]
    [StringLength(1)]
    public string CompletedInd { get; set; } = null!;

    [Column("date_completed", TypeName = "datetime")]
    public DateTime? DateCompleted { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
