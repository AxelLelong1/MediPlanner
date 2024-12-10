using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmTransltnId", "IntfAppParmTransltnRcrdId", "IntfAppParmTransltnFldId")]
[Table("intf_app_parm_trnsltn_fld")]
public partial class IntfAppParmTrnsltnFld
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_rcrd_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnRcrdId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_fld_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnFldId { get; set; } = null!;

    [Column("intf_app_parm_seg_id")]
    [StringLength(10)]
    public string IntfAppParmSegId { get; set; } = null!;

    [Column("process_ind")]
    [StringLength(1)]
    public string ProcessInd { get; set; } = null!;

    [Column("typ_cd")]
    [StringLength(1)]
    public string TypCd { get; set; } = null!;

    [Column("repeating_ind")]
    [StringLength(1)]
    public string RepeatingInd { get; set; } = null!;

    [Column("intf_app_parm_field_id")]
    [StringLength(10)]
    public string IntfAppParmFieldId { get; set; } = null!;

    [Column("field_occurence")]
    public int? FieldOccurence { get; set; }

    [Column("intf_app_parm_comp_id")]
    [StringLength(10)]
    public string IntfAppParmCompId { get; set; } = null!;

    [Column("xml_path")]
    [StringLength(1024)]
    public string? XmlPath { get; set; }

    [Column("xml_path_occurence")]
    public int? XmlPathOccurence { get; set; }

    [Column("constant_value")]
    [StringLength(1024)]
    public string? ConstantValue { get; set; }

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

    [ForeignKey("IntfAppParmId, IntfAppParmCompId")]
    [InverseProperty("IntfAppParmTrnsltnFld")]
    public virtual IntfAppParmComp IntfAppParmComp { get; set; } = null!;

    [ForeignKey("IntfAppParmId, IntfAppParmFieldId")]
    [InverseProperty("IntfAppParmTrnsltnFld")]
    public virtual IntfAppParmField IntfAppParmField { get; set; } = null!;

    [ForeignKey("IntfAppParmId, IntfAppParmTransltnId, IntfAppParmTransltnRcrdId")]
    [InverseProperty("IntfAppParmTrnsltnFld")]
    public virtual IntfAppParmTrnsltnRecrd IntfAppParmTrnsltnRecrd { get; set; } = null!;
}
