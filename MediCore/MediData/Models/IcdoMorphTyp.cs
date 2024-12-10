using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("icdo_morph_typ")]
public partial class IcdoMorphTyp
{
    [Key]
    [Column("icdo_morph_typ")]
    public int IcdoMorphTyp1 { get; set; }

    [Column("icdo_morph_desc")]
    [StringLength(100)]
    public string IcdoMorphDesc { get; set; } = null!;

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

    [InverseProperty("IcdoMorphTypNavigation")]
    public virtual ICollection<IcdoMorphCd> IcdoMorphCd { get; set; } = new List<IcdoMorphCd>();
}
