using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FcnAreaTyp", "VrtnTyp1")]
[Table("vrtn_typ")]
public partial class VrtnTyp
{
    [Key]
    [Column("fcn_area_typ")]
    public int FcnAreaTyp { get; set; }

    [Key]
    [Column("vrtn_typ")]
    public int VrtnTyp1 { get; set; }

    [Column("vrtn_typ_desc")]
    [StringLength(40)]
    public string VrtnTypDesc { get; set; } = null!;

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

    [ForeignKey("FcnAreaTyp")]
    [InverseProperty("VrtnTyp")]
    public virtual FcnAreaTyp FcnAreaTypNavigation { get; set; } = null!;

    [InverseProperty("VrtnTypNavigation")]
    public virtual ICollection<VrtnRsnTyp> VrtnRsnTyp { get; set; } = new List<VrtnRsnTyp>();
}
