using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("VrtnSourceCls", "VrtnSourceTyp1")]
[Table("vrtn_source_typ")]
public partial class VrtnSourceTyp
{
    [Key]
    [Column("vrtn_source_cls")]
    public int VrtnSourceCls { get; set; }

    [Key]
    [Column("vrtn_source_typ")]
    public int VrtnSourceTyp1 { get; set; }

    [Column("typ_desc")]
    [StringLength(40)]
    public string TypDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(40)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("VrtnSourceTypNavigation")]
    public virtual ICollection<PtTpVrtnSource> PtTpVrtnSource { get; set; } = new List<PtTpVrtnSource>();

    [ForeignKey("VrtnSourceCls")]
    [InverseProperty("VrtnSourceTyp")]
    public virtual VrtnSourceCls VrtnSourceClsNavigation { get; set; } = null!;
}
