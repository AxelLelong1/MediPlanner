using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("val_xref")]
[Index("ARefId", Name = "nc1_val_xref")]
[Index("BRefId", Name = "nc2_val_xref")]
public partial class ValXref
{
    [Key]
    [Column("val_xref_id")]
    public int ValXrefId { get; set; }

    [Column("a_inst_id")]
    [StringLength(30)]
    public string AInstId { get; set; } = null!;

    [Column("a_ref_id")]
    [StringLength(15)]
    public string ARefId { get; set; } = null!;

    [Column("a_val_1")]
    [StringLength(60)]
    public string AVal1 { get; set; } = null!;

    [Column("a_val_2")]
    [StringLength(60)]
    public string? AVal2 { get; set; }

    [Column("a_val_3")]
    [StringLength(60)]
    public string? AVal3 { get; set; }

    [Column("a_val_4")]
    [StringLength(60)]
    public string? AVal4 { get; set; }

    [Column("a_val_5")]
    [StringLength(60)]
    public string? AVal5 { get; set; }

    [Column("b_inst_id")]
    [StringLength(30)]
    public string BInstId { get; set; } = null!;

    [Column("b_ref_id")]
    [StringLength(15)]
    public string BRefId { get; set; } = null!;

    [Column("b_val_1")]
    [StringLength(60)]
    public string BVal1 { get; set; } = null!;

    [Column("b_val_2")]
    [StringLength(60)]
    public string? BVal2 { get; set; }

    [Column("b_val_3")]
    [StringLength(60)]
    public string? BVal3 { get; set; }

    [Column("b_val_4")]
    [StringLength(60)]
    public string? BVal4 { get; set; }

    [Column("b_val_5")]
    [StringLength(60)]
    public string? BVal5 { get; set; }

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

    [ForeignKey("AInstId, ARefId, BInstId, BRefId")]
    [InverseProperty("ValXref")]
    public virtual RefXref RefXref { get; set; } = null!;
}
