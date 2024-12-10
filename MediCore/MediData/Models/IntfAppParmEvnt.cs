using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmEvntId")]
[Table("intf_app_parm_evnt")]
public partial class IntfAppParmEvnt
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_evnt_id")]
    [StringLength(10)]
    public string IntfAppParmEvntId { get; set; } = null!;

    [Column("msg_evnt_xref_id")]
    [StringLength(10)]
    public string? MsgEvntXrefId { get; set; }

    [Column("flip_evnt_typ_id")]
    [StringLength(10)]
    public string? FlipEvntTypId { get; set; }

    [Column("flip_cond_cd")]
    [StringLength(1)]
    public string? FlipCondCd { get; set; }

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

    [Column("log_invalid_pt_id_prcs_ind")]
    [StringLength(1)]
    public string? LogInvalidPtIdPrcsInd { get; set; }

    [Column("log_missing_pt_id_prcs_ind")]
    [StringLength(1)]
    public string? LogMissingPtIdPrcsInd { get; set; }

    [Column("prcs_typ")]
    [StringLength(1)]
    public string PrcsTyp { get; set; } = null!;

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime BaseTstamp { get; set; }

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

    [Column("evnt_typ")]
    [StringLength(3)]
    public string? EvntTyp { get; set; }

    [Column("evnt_typ_name")]
    [StringLength(30)]
    public string? EvntTypName { get; set; }

    [Column("evnt_typ_desc")]
    [StringLength(255)]
    public string? EvntTypDesc { get; set; }

    [Column("flip_ind")]
    [StringLength(1)]
    public string? FlipInd { get; set; }

    [Column("flip_intf_app_parm_evnt_id")]
    [StringLength(10)]
    public string? FlipIntfAppParmEvntId { get; set; }

    [Column("custom_ind")]
    [StringLength(1)]
    public string? CustomInd { get; set; }

    [Column("ignore_addl_pt_key_match_ind")]
    [StringLength(1)]
    public string? IgnoreAddlPtKeyMatchInd { get; set; }

    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string? IntfAppParmCondHeaderId { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmEvnt")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [InverseProperty("IntfAppParmEvnt")]
    public virtual ICollection<IntfAppParmSeg> IntfAppParmSeg { get; set; } = new List<IntfAppParmSeg>();

    [InverseProperty("IntfAppParmEvnt")]
    public virtual ICollection<IntfAppParmTrnsltnXml> IntfAppParmTrnsltnXml { get; set; } = new List<IntfAppParmTrnsltnXml>();
}
