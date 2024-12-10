using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_data_typ")]
public partial class Hl7DataTyp
{
    [Key]
    [Column("data_typ")]
    [StringLength(3)]
    public string DataTyp { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("data_typ_name")]
    [StringLength(30)]
    public string DataTypName { get; set; } = null!;

    [Column("data_typ_desc")]
    [StringLength(255)]
    public string? DataTypDesc { get; set; }

    [Column("multi_comp_ind")]
    [StringLength(1)]
    public string MultiCompInd { get; set; } = null!;

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
    [InverseProperty("Hl7DataTyp")]
    public virtual Hl7DefTyp DefTypNavigation { get; set; } = null!;

    [InverseProperty("CompDataTypNavigation")]
    public virtual ICollection<Hl7Comp> Hl7CompCompDataTypNavigation { get; set; } = new List<Hl7Comp>();

    [InverseProperty("DataTypNavigation")]
    public virtual ICollection<Hl7Comp> Hl7CompDataTypNavigation { get; set; } = new List<Hl7Comp>();

    [InverseProperty("SubCompDataTypNavigation")]
    public virtual ICollection<Hl7Comp> Hl7CompSubCompDataTypNavigation { get; set; } = new List<Hl7Comp>();

    [InverseProperty("FieldDataTypNavigation")]
    public virtual ICollection<Hl7Field> Hl7Field { get; set; } = new List<Hl7Field>();
}
