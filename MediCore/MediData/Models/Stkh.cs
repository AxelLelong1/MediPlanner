using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("stkh")]
public partial class Stkh
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string StkhCd { get; set; } = null!;

    [Column("designation_txt")]
    [StringLength(255)]
    public string? DesignationTxt { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("org_typ")]
    public int? OrgTyp { get; set; }

    [Column("internal_ind")]
    [StringLength(1)]
    public string InternalInd { get; set; } = null!;

    [Column("pref_corsp_mthd_cd")]
    [StringLength(1)]
    public string PrefCorspMthdCd { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("end_reason_cd")]
    [StringLength(3)]
    public string? EndReasonCd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("internal_sys_ind")]
    [StringLength(1)]
    public string? InternalSysInd { get; set; }

    [Column("city")]
    [StringLength(30)]
    public string? City { get; set; }

    [Column("sig_pic", TypeName = "image")]
    public byte[]? SigPic { get; set; }

    [Column("allow_sig_ind")]
    [StringLength(1)]
    public string? AllowSigInd { get; set; }

    public long? ResourceSer { get; set; }

    [Column("stkh_cmt")]
    [StringLength(255)]
    public string? StkhCmt { get; set; }

    [InverseProperty("Stkh")]
    public virtual ICollection<BillAcct> BillAcct { get; set; } = new List<BillAcct>();

    [ForeignKey("DisciplineTyp")]
    [InverseProperty("Stkh")]
    public virtual DisciplineTyp? DisciplineTypNavigation { get; set; }

    [InverseProperty("Stkh")]
    public virtual ICollection<EmailAddress> EmailAddress { get; set; } = new List<EmailAddress>();

    [ForeignKey("OrgTyp")]
    [InverseProperty("Stkh")]
    public virtual OrgTyp? OrgTypNavigation { get; set; }

    [ForeignKey("ProfTyp")]
    [InverseProperty("Stkh")]
    public virtual ProfTyp? ProfTypNavigation { get; set; }

    [InverseProperty("OrgStkh")]
    public virtual ICollection<PtAdt> PtAdt { get; set; } = new List<PtAdt>();

    [InverseProperty("Stkh")]
    public virtual ICollection<PtProviderMu> PtProviderMu { get; set; } = new List<PtProviderMu>();

    [InverseProperty("OrgStkh")]
    public virtual ICollection<PtProvider> PtProviderOrgStkh { get; set; } = new List<PtProvider>();

    [InverseProperty("ProviderStkh")]
    public virtual ICollection<PtProvider> PtProviderProviderStkh { get; set; } = new List<PtProvider>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhAddress> StkhAddress { get; set; } = new List<StkhAddress>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhDesignation> StkhDesignation { get; set; } = new List<StkhDesignation>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhEmail> StkhEmail { get; set; } = new List<StkhEmail>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhKey> StkhKey { get; set; } = new List<StkhKey>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhName> StkhName { get; set; } = new List<StkhName>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhPhone> StkhPhone { get; set; } = new List<StkhPhone>();

    [InverseProperty("Stkh")]
    public virtual ICollection<StkhRole> StkhRole { get; set; } = new List<StkhRole>();

    [InverseProperty("FromStkh")]
    public virtual ICollection<StkhStkhXref> StkhStkhXrefFromStkh { get; set; } = new List<StkhStkhXref>();

    [InverseProperty("ToStkh")]
    public virtual ICollection<StkhStkhXref> StkhStkhXrefToStkh { get; set; } = new List<StkhStkhXref>();

    [InverseProperty("Stkh")]
    public virtual ICollection<Userid> Userid { get; set; } = new List<Userid>();
}
