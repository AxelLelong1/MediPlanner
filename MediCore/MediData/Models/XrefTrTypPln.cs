using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "IntvId")]
[Table("xref_tr_typ_pln")]
public partial class XrefTrTypPln
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("intv_id")]
    public int IntvId { get; set; }

    [Column("gs_author")]
    public int GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName { get; set; } = null!;

    [Column("reason")]
    public string? Reason { get; set; }

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

    [Column("tr_sub_comp_name")]
    [StringLength(60)]
    public string? TrSubCompName { get; set; }

    [Column("dose_limit_ind")]
    [StringLength(1)]
    public string? DoseLimitInd { get; set; }

    [ForeignKey("TpName, TpVersNo, IntvId")]
    [InverseProperty("XrefTrTypPln")]
    public virtual TpIntv TpIntv { get; set; } = null!;

    [ForeignKey("GsAuthor, EffDate, TrTyp, TrCompName")]
    [InverseProperty("XrefTrTypPln")]
    public virtual TrComp TrComp { get; set; } = null!;
}
