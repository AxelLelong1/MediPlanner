using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_def_typ")]
public partial class Hl7DefTyp
{
    [Key]
    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("def_typ_name")]
    [StringLength(30)]
    public string? DefTypName { get; set; }

    [Column("def_typ_desc")]
    [StringLength(255)]
    public string? DefTypDesc { get; set; }

    [Column("del_ind")]
    [StringLength(1)]
    public string DelInd { get; set; } = null!;

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime BaseTstamp { get; set; }

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

    [InverseProperty("DefTypNavigation")]
    public virtual ICollection<Hl7Comp> Hl7Comp { get; set; } = new List<Hl7Comp>();

    [InverseProperty("DefTypNavigation")]
    public virtual ICollection<Hl7DataTyp> Hl7DataTyp { get; set; } = new List<Hl7DataTyp>();

    [InverseProperty("DefTypNavigation")]
    public virtual ICollection<Hl7Vers> Hl7Vers { get; set; } = new List<Hl7Vers>();
}
