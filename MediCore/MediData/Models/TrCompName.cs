using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TrTyp", "TrCompName1")]
[Table("tr_comp_name")]
public partial class TrCompName
{
    [Key]
    [Column("tr_typ")]
    [StringLength(30)]
    public string TrTyp { get; set; } = null!;

    [Key]
    [Column("tr_comp_name")]
    [StringLength(30)]
    public string TrCompName1 { get; set; } = null!;

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

    [Column("tr_comp_desc")]
    [StringLength(255)]
    public string? TrCompDesc { get; set; }

    [InverseProperty("TrCompNameNavigation")]
    public virtual ICollection<AgtTr> AgtTr { get; set; } = new List<AgtTr>();

    [InverseProperty("TrCompName")]
    public virtual ICollection<AspectDesc> AspectDesc { get; set; } = new List<AspectDesc>();

    [InverseProperty("TrCompNameNavigation")]
    public virtual ICollection<TrComp> TrComp { get; set; } = new List<TrComp>();

    [InverseProperty("TrCompNameNavigation")]
    public virtual ICollection<TrTypComp> TrTypComp { get; set; } = new List<TrTypComp>();
}
