using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("vrtn_source_cls")]
public partial class VrtnSourceCls
{
    [Key]
    [Column("vrtn_source_cls")]
    public int VrtnSourceCls1 { get; set; }

    [Column("cls_desc")]
    [StringLength(40)]
    public string ClsDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("VrtnSourceClsNavigation")]
    public virtual ICollection<VrtnSourceTyp> VrtnSourceTyp { get; set; } = new List<VrtnSourceTyp>();
}
