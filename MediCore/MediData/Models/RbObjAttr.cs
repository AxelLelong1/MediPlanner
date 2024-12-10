using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ObjTyp", "ObjAttrTyp")]
[Table("rb_obj_attr")]
public partial class RbObjAttr
{
    [Key]
    [Column("obj_typ")]
    public int ObjTyp { get; set; }

    [Key]
    [Column("obj_attr_typ")]
    public int ObjAttrTyp { get; set; }

    [Column("obj_attr_desc")]
    [StringLength(40)]
    public string ObjAttrDesc { get; set; } = null!;

    [Column("attr_val_typ")]
    public int AttrValTyp { get; set; }

    [Column("rb_use")]
    [StringLength(1)]
    public string RbUse { get; set; } = null!;

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

    [Column("attr_short_desc")]
    [StringLength(30)]
    public string? AttrShortDesc { get; set; }

    [Column("pt_search_ind")]
    [StringLength(1)]
    public string? PtSearchInd { get; set; }

    [ForeignKey("ObjTyp")]
    [InverseProperty("RbObjAttr")]
    public virtual RbObj ObjTypNavigation { get; set; } = null!;

    [InverseProperty("RbObjAttr")]
    public virtual ICollection<RbObjAttrCls> RbObjAttrCls { get; set; } = new List<RbObjAttrCls>();
}
