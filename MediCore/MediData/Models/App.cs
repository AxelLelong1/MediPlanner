using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("app")]
public partial class App
{
    [Key]
    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("app_name")]
    [StringLength(20)]
    public string AppName { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("app_vers_no")]
    [StringLength(10)]
    public string? AppVersNo { get; set; }

    [Column("app_build_no")]
    [StringLength(10)]
    public string? AppBuildNo { get; set; }

    [Column("dsp_app_vers_no")]
    [StringLength(10)]
    public string? DspAppVersNo { get; set; }

    [Column("dsp_app_build_no")]
    [StringLength(10)]
    public string? DspAppBuildNo { get; set; }

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<AppLevelXref> AppLevelXref { get; set; } = new List<AppLevelXref>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<AppTyp> AppTyp { get; set; } = new List<AppTyp>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<DfltCtrl> DfltCtrl { get; set; } = new List<DfltCtrl>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<DfltMenu> DfltMenu { get; set; } = new List<DfltMenu>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<DfltXrefCtrl> DfltXrefCtrl { get; set; } = new List<DfltXrefCtrl>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<DfltXrefMenu> DfltXrefMenu { get; set; } = new List<DfltXrefMenu>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<EmailAddress> EmailAddress { get; set; } = new List<EmailAddress>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<ExpHxMast> ExpHxMast { get; set; } = new List<ExpHxMast>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<HelpKwrd> HelpKwrd { get; set; } = new List<HelpKwrd>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<Hl7AppTyp> Hl7AppTyp { get; set; } = new List<Hl7AppTyp>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<ImpHxMast> ImpHxMast { get; set; } = new List<ImpHxMast>();

    [InverseProperty("AppNameNavigation")]
    public virtual ICollection<OnlineLog> OnlineLog { get; set; } = new List<OnlineLog>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<PtInfoRequest> PtInfoRequest { get; set; } = new List<PtInfoRequest>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<UserGroupCtrl> UserGroupCtrl { get; set; } = new List<UserGroupCtrl>();

    [InverseProperty("AppCdNavigation")]
    public virtual ICollection<UserGroupMenu> UserGroupMenu { get; set; } = new List<UserGroupMenu>();
}
