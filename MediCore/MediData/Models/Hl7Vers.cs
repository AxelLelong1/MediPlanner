using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DefTyp", "VersNo")]
[Table("hl7_vers")]
public partial class Hl7Vers
{
    [Key]
    [Column("vers_no")]
    [StringLength(10)]
    public string VersNo { get; set; } = null!;

    [Key]
    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("vers_desc")]
    [StringLength(255)]
    public string? VersDesc { get; set; }

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

    [ForeignKey("DefTyp")]
    [InverseProperty("Hl7Vers")]
    public virtual Hl7DefTyp DefTypNavigation { get; set; } = null!;

    [InverseProperty("Hl7Vers")]
    public virtual ICollection<Hl7EvntTyp> Hl7EvntTyp { get; set; } = new List<Hl7EvntTyp>();

    [InverseProperty("Hl7Vers")]
    public virtual ICollection<Hl7Field> Hl7Field { get; set; } = new List<Hl7Field>();

    [InverseProperty("Hl7Vers")]
    public virtual ICollection<Hl7MsgTyp> Hl7MsgTyp { get; set; } = new List<Hl7MsgTyp>();

    [InverseProperty("Hl7Vers")]
    public virtual ICollection<Hl7SegTyp> Hl7SegTyp { get; set; } = new List<Hl7SegTyp>();
}
