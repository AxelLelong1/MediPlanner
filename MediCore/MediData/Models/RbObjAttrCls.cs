using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ObjTyp", "ObjAttrTyp", "RuleClsTyp", "RbUse")]
[Table("rb_obj_attr_cls")]
public partial class RbObjAttrCls
{
    [Key]
    [Column("obj_typ")]
    public int ObjTyp { get; set; }

    [Key]
    [Column("obj_attr_typ")]
    public int ObjAttrTyp { get; set; }

    [Key]
    [Column("rule_cls_typ")]
    public int RuleClsTyp { get; set; }

    [Key]
    [Column("rb_use")]
    [StringLength(1)]
    public string RbUse { get; set; } = null!;

    [Column("oper_grp")]
    public int OperGrp { get; set; }

    [Column("unit_grp")]
    [StringLength(10)]
    public string UnitGrp { get; set; } = null!;

    [Column("which_value_grp")]
    public int WhichValueGrp { get; set; }

    [Column("how_occur_grp")]
    public int HowOccurGrp { get; set; }

    [Column("ref_prd_grp")]
    public int RefPrdGrp { get; set; }

    [Column("ref_rgm_grp")]
    public int RefRgmGrp { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("ObjTyp, ObjAttrTyp")]
    [InverseProperty("RbObjAttrCls")]
    public virtual RbObjAttr RbObjAttr { get; set; } = null!;

    [ForeignKey("RuleClsTyp")]
    [InverseProperty("RbObjAttrCls")]
    public virtual RuleCls RuleClsTypNavigation { get; set; } = null!;
}
