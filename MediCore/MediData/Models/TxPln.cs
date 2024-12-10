using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo")]
[Table("tx_pln")]
[Index("TpTyp", "ActiveInd", "PlnTyp", Name = "nc97_tx_pln")]
public partial class TxPln
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Column("tp_typ")]
    [StringLength(1)]
    public string? TpTyp { get; set; }

    [Column("pln_typ")]
    public int? PlnTyp { get; set; }

    [Column("summary")]
    public string? Summary { get; set; }

    [Column("brief_desc")]
    [StringLength(200)]
    public string? BriefDesc { get; set; }

    [Column("mod_conflict_typ")]
    public int? ModConflictTyp { get; set; }

    [Column("mod_typ")]
    public int? ModTyp { get; set; }

    [Column("tp_cls")]
    public int? TpCls { get; set; }

    [Column("spsr")]
    public int? Spsr { get; set; }

    [Column("original_inst_id")]
    [StringLength(30)]
    public string OriginalInstId { get; set; } = null!;

    [Column("original_userid")]
    [StringLength(255)]
    public string? OriginalUserid { get; set; }

    [Column("original_spsr")]
    public int? OriginalSpsr { get; set; }

    [Column("original_tp_name")]
    [StringLength(20)]
    public string? OriginalTpName { get; set; }

    [Column("gs_author")]
    public int? GsAuthor { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime? EffDate { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("authors")]
    public string? Authors { get; set; }

    [Column("original_authors")]
    public string? OriginalAuthors { get; set; }

    [Column("tp_source")]
    [StringLength(1)]
    public string? TpSource { get; set; }

    [Column("source_tp_name")]
    [StringLength(20)]
    public string? SourceTpName { get; set; }

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

    [Column("phys_order_ind")]
    [StringLength(1)]
    public string? PhysOrderInd { get; set; }

    [Column("billable_ind")]
    [StringLength(1)]
    public string? BillableInd { get; set; }

    [Column("clin_trial_ind")]
    [StringLength(1)]
    public string? ClinTrialInd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("sex_cd")]
    [StringLength(1)]
    public string? SexCd { get; set; }

    [Column("age_start")]
    public int? AgeStart { get; set; }

    [Column("age_start_unit")]
    public int? AgeStartUnit { get; set; }

    [Column("age_end")]
    public int? AgeEnd { get; set; }

    [Column("age_end_unit")]
    public int? AgeEndUnit { get; set; }

    [Column("ct_phase")]
    public int? CtPhase { get; set; }

    [Column("dsp_tp_name")]
    [StringLength(80)]
    public string? DspTpName { get; set; }

    [Column("mndtry_amend_ind")]
    [StringLength(1)]
    public string? MndtryAmendInd { get; set; }

    [Column("reg_group")]
    [StringLength(80)]
    public string? RegGroup { get; set; }

    [ForeignKey("OriginalSpsr")]
    [InverseProperty("TxPlnOriginalSpsrNavigation")]
    public virtual Spsr? OriginalSpsrNavigation { get; set; }

    [InverseProperty("TxPln")]
    public virtual ICollection<Phase> Phase { get; set; } = new List<Phase>();

    [ForeignKey("PlnTyp")]
    [InverseProperty("TxPln")]
    public virtual PlnTyp? PlnTypNavigation { get; set; }

    [InverseProperty("TxPln")]
    public virtual ICollection<RgmSiteSeq> RgmSiteSeq { get; set; } = new List<RgmSiteSeq>();

    [ForeignKey("Spsr")]
    [InverseProperty("TxPlnSpsrNavigation")]
    public virtual Spsr? SpsrNavigation { get; set; }

    [InverseProperty("TxPln")]
    public virtual ICollection<TpClsGroup> TpClsGroup { get; set; } = new List<TpClsGroup>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpCoauthor> TpCoauthor { get; set; } = new List<TpCoauthor>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpDoseMgmt> TpDoseMgmt { get; set; } = new List<TpDoseMgmt>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpFocus> TpFocus { get; set; } = new List<TpFocus>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpIntv> TpIntv { get; set; } = new List<TpIntv>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpScheme> TpScheme { get; set; } = new List<TpScheme>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpSeq> TpSeq { get; set; } = new List<TpSeq>();

    [InverseProperty("TxPln")]
    public virtual ICollection<TpSum> TpSum { get; set; } = new List<TpSum>();
}
