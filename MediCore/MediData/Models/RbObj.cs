using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("rb_obj")]
public partial class RbObj
{
    [Key]
    [Column("obj_typ")]
    public int ObjTyp { get; set; }

    [Column("obj_desc")]
    [StringLength(40)]
    public string ObjDesc { get; set; } = null!;

    [Column("obj_subcls_typ")]
    [StringLength(1)]
    public string ObjSubclsTyp { get; set; } = null!;

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

    [InverseProperty("ObjTypNavigation")]
    public virtual ICollection<RbObjAttr> RbObjAttr { get; set; } = new List<RbObjAttr>();
}
