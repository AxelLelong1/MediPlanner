using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfStkhKeyMapId", "StkhRoleTyp")]
[Table("intf_stkh_key_map_role")]
public partial class IntfStkhKeyMapRole
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_stkh_key_map_id")]
    [StringLength(10)]
    public string IntfStkhKeyMapId { get; set; } = null!;

    [Key]
    [Column("stkh_role_typ")]
    public int StkhRoleTyp { get; set; }

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

    [ForeignKey("IntfAppParmId, IntfStkhKeyMapId")]
    [InverseProperty("IntfStkhKeyMapRole")]
    public virtual IntfStkhKeyMap IntfStkhKeyMap { get; set; } = null!;

    [ForeignKey("StkhRoleTyp")]
    [InverseProperty("IntfStkhKeyMapRole")]
    public virtual StkhRoleTyp StkhRoleTypNavigation { get; set; } = null!;
}
