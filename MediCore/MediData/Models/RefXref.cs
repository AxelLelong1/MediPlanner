using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AInstId", "ARefId", "BInstId", "BRefId")]
[Table("ref_xref")]
public partial class RefXref
{
    [Key]
    [Column("a_inst_id")]
    [StringLength(30)]
    public string AInstId { get; set; } = null!;

    [Key]
    [Column("a_ref_id")]
    [StringLength(15)]
    public string ARefId { get; set; } = null!;

    [Key]
    [Column("b_inst_id")]
    [StringLength(30)]
    public string BInstId { get; set; } = null!;

    [Key]
    [Column("b_ref_id")]
    [StringLength(15)]
    public string BRefId { get; set; } = null!;

    [Column("single_multi")]
    [StringLength(1)]
    public string? SingleMulti { get; set; }

    [Column("reltn_typ")]
    [StringLength(1)]
    public string? ReltnTyp { get; set; }

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

    [Column("xref_purpose")]
    [StringLength(255)]
    public string? XrefPurpose { get; set; }

    [ForeignKey("AInstId, ARefId")]
    [InverseProperty("RefXrefRefDef")]
    public virtual RefDef RefDef { get; set; } = null!;

    [ForeignKey("BInstId, BRefId")]
    [InverseProperty("RefXrefRefDefNavigation")]
    public virtual RefDef RefDefNavigation { get; set; } = null!;

    [InverseProperty("RefXref")]
    public virtual ICollection<ValXref> ValXref { get; set; } = new List<ValXref>();
}
