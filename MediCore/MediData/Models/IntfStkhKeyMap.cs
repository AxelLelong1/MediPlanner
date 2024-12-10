using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfStkhKeyMapId")]
[Table("intf_stkh_key_map")]
public partial class IntfStkhKeyMap
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_stkh_key_map_id")]
    [StringLength(10)]
    public string IntfStkhKeyMapId { get; set; } = null!;

    [Column("seg_field_xref_id")]
    [StringLength(10)]
    public string SegFieldXrefId { get; set; } = null!;

    [Column("stkh_id_typ_cd")]
    [StringLength(40)]
    public string? StkhIdTypCd { get; set; }

    [Column("stkh_id_typ_desc")]
    [StringLength(60)]
    public string? StkhIdTypDesc { get; set; }

    [Column("stkh_key_cd")]
    public int? StkhKeyCd { get; set; }

    [Column("stkh_key_cd_inst_id")]
    [StringLength(30)]
    public string? StkhKeyCdInstId { get; set; }

    [Column("stkh_role_typ")]
    public int? StkhRoleTyp { get; set; }

    [Column("stkh_id_match_cd")]
    [StringLength(1)]
    public string StkhIdMatchCd { get; set; } = null!;

    [Column("stkh_match_ind")]
    [StringLength(1)]
    public string StkhMatchInd { get; set; } = null!;

    [Column("add_ind")]
    [StringLength(1)]
    public string AddInd { get; set; } = null!;

    [Column("visit_inst_id")]
    [StringLength(30)]
    public string? VisitInstId { get; set; }

    [Column("req_ind")]
    [StringLength(1)]
    public string ReqInd { get; set; } = null!;

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

    [Column("stkh_cd")]
    [StringLength(1)]
    public string? StkhCd { get; set; }

    [Column("prof_reltn_typ")]
    public int? ProfReltnTyp { get; set; }

    [Column("allow_update_ind")]
    [StringLength(1)]
    public string? AllowUpdateInd { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfStkhKeyMap")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [InverseProperty("IntfStkhKeyMap")]
    public virtual ICollection<IntfStkhKeyMapRole> IntfStkhKeyMapRole { get; set; } = new List<IntfStkhKeyMapRole>();
}
