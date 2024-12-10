using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pt_merge")]
[Index("PtIdMaster", "PtIdDuplicate", Name = "nc1_pt_merge")]
[Index("PtIdDuplicate", "PtIdMaster", Name = "nc2_pt_merge")]
public partial class PtMerge
{
    [Key]
    [Column("pt_id_merged")]
    [StringLength(20)]
    public string PtIdMerged { get; set; } = null!;

    [Column("pt_id_master")]
    [StringLength(20)]
    public string PtIdMaster { get; set; } = null!;

    [Column("pt_id_duplicate")]
    [StringLength(20)]
    public string PtIdDuplicate { get; set; } = null!;

    [Column("date_merged", TypeName = "datetime")]
    public DateTime? DateMerged { get; set; }

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
