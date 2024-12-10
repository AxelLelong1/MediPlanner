using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtLesId")]
[Table("pt_les")]
public partial class PtLes
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_les_id")]
    public int PtLesId { get; set; }

    [Column("pt_dx_id")]
    public int? PtDxId { get; set; }

    [Column("icdo_site_typ")]
    public int? IcdoSiteTyp { get; set; }

    [Column("icdo_site_cd")]
    [StringLength(3)]
    public string? IcdoSiteCd { get; set; }

    [Column("icdo_site_seq")]
    public int? IcdoSiteSeq { get; set; }

    [Column("cls_scheme_id")]
    public int? ClsSchemeId { get; set; }

    [Column("les_desc")]
    [StringLength(100)]
    public string? LesDesc { get; set; }

    [Column("les_date", TypeName = "datetime")]
    public DateTime? LesDate { get; set; }

    [Column("les_date_cd")]
    public int? LesDateCd { get; set; }

    [Column("les_order_no")]
    public int? LesOrderNo { get; set; }

    [Column("meas_ind")]
    [StringLength(1)]
    public string? MeasInd { get; set; }

    [Column("track_ind")]
    [StringLength(1)]
    public string? TrackInd { get; set; }

    [Column("meas_dim")]
    public int? MeasDim { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [ForeignKey("PtId, PtDxId")]
    [InverseProperty("PtLes")]
    public virtual PtDxCncr? PtDxCncr { get; set; }

    [InverseProperty("PtLes")]
    public virtual ICollection<PtLesAsmtMh> PtLesAsmtMh { get; set; } = new List<PtLesAsmtMh>();
}
