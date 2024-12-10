using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_comp")]
public partial class Hl7Comp
{
    [Key]
    [Column("comp_id")]
    [StringLength(10)]
    public string CompId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("data_typ")]
    [StringLength(3)]
    public string DataTyp { get; set; } = null!;

    [Column("comp_no")]
    public int CompNo { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("comp_data_typ")]
    [StringLength(3)]
    public string CompDataTyp { get; set; } = null!;

    [Column("sub_comp_no")]
    public int? SubCompNo { get; set; }

    [Column("sub_comp_name")]
    [StringLength(30)]
    public string? SubCompName { get; set; }

    [Column("sub_comp_data_typ")]
    [StringLength(3)]
    public string? SubCompDataTyp { get; set; }

    [Column("comp_desc")]
    [StringLength(255)]
    public string? CompDesc { get; set; }

    [Column("sub_comp_desc")]
    [StringLength(255)]
    public string? SubCompDesc { get; set; }

    [Column("data_format")]
    [StringLength(60)]
    public string? DataFormat { get; set; }

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

    [ForeignKey("CompDataTyp")]
    [InverseProperty("Hl7CompCompDataTypNavigation")]
    public virtual Hl7DataTyp CompDataTypNavigation { get; set; } = null!;

    [ForeignKey("DataTyp")]
    [InverseProperty("Hl7CompDataTypNavigation")]
    public virtual Hl7DataTyp DataTypNavigation { get; set; } = null!;

    [ForeignKey("DefTyp")]
    [InverseProperty("Hl7Comp")]
    public virtual Hl7DefTyp DefTypNavigation { get; set; } = null!;

    [InverseProperty("Comp")]
    public virtual ICollection<Hl7FieldCompXref> Hl7FieldCompXref { get; set; } = new List<Hl7FieldCompXref>();

    [ForeignKey("SubCompDataTyp")]
    [InverseProperty("Hl7CompSubCompDataTypNavigation")]
    public virtual Hl7DataTyp? SubCompDataTypNavigation { get; set; }
}
