using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtDxId", "PtDxInvasiveTypId")]
[Table("pt_dx_invasive_typ")]
public partial class PtDxInvasiveTyp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_dx_id")]
    public int PtDxId { get; set; }

    [Key]
    [Column("pt_dx_invasive_typ_id")]
    public int PtDxInvasiveTypId { get; set; }

    [Column("invasive_typ")]
    public int? InvasiveTyp { get; set; }

    [Column("invasive_typ_desc")]
    [StringLength(40)]
    public string? InvasiveTypDesc { get; set; }

    [Column("invasive_present_typ")]
    public int? InvasivePresentTyp { get; set; }

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

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [ForeignKey("PtId, PtDxId")]
    [InverseProperty("PtDxInvasiveTyp")]
    public virtual PtDx PtDx { get; set; } = null!;
}
