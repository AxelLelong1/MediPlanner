using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("admit_cls")]
public partial class AdmitCls
{
    [Key]
    [Column("admit_cls")]
    public int AdmitCls1 { get; set; }

    [Column("admit_cls_desc")]
    [StringLength(40)]
    public string AdmitClsDesc { get; set; } = null!;

    [Column("admit_cls_cd")]
    [StringLength(5)]
    public string AdmitClsCd { get; set; } = null!;

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

    [Column("admit_cls_dsp")]
    [StringLength(20)]
    public string? AdmitClsDsp { get; set; }

    [Column("admit_cls_ind")]
    [StringLength(1)]
    public string? AdmitClsInd { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("inpatient_ind")]
    [StringLength(1)]
    public string? InpatientInd { get; set; }

    [InverseProperty("AdmitClsNavigation")]
    public virtual ICollection<PtAdt> PtAdt { get; set; } = new List<PtAdt>();
}
