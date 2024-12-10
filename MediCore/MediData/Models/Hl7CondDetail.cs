using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FieldCompXrefId", "Hl7CondHeaderId", "CondOrder")]
[Table("hl7_cond_detail")]
public partial class Hl7CondDetail
{
    [Key]
    [Column("field_comp_xref_id")]
    [StringLength(10)]
    public string FieldCompXrefId { get; set; } = null!;

    [Key]
    [Column("hl7_cond_header_id")]
    [StringLength(10)]
    public string Hl7CondHeaderId { get; set; } = null!;

    [Key]
    [Column("cond_order")]
    public int CondOrder { get; set; }

    [Column("open_bracket")]
    [StringLength(4)]
    public string? OpenBracket { get; set; }

    [Column("cmpr_val_cd")]
    [StringLength(1)]
    public string? CmprValCd { get; set; }

    [Column("cmpr_field_comp_xref_id")]
    [StringLength(10)]
    public string? CmprFieldCompXrefId { get; set; }

    [Column("cmpr_seg_field_xref_id")]
    [StringLength(10)]
    public string? CmprSegFieldXrefId { get; set; }

    [Column("cmpr_mapped_ind")]
    [StringLength(1)]
    public string? CmprMappedInd { get; set; }

    [Column("validation_column_name")]
    [StringLength(30)]
    public string? ValidationColumnName { get; set; }

    [Column("cmpr_operator")]
    [StringLength(10)]
    public string CmprOperator { get; set; } = null!;

    [Column("cond_val_cd")]
    [StringLength(1)]
    public string? CondValCd { get; set; }

    [Column("cond_val")]
    [StringLength(255)]
    public string? CondVal { get; set; }

    [Column("cond_field_comp_xref_id")]
    [StringLength(10)]
    public string? CondFieldCompXrefId { get; set; }

    [Column("cond_seg_field_xref_id")]
    [StringLength(10)]
    public string? CondSegFieldXrefId { get; set; }

    [Column("cond_mapped_ind")]
    [StringLength(1)]
    public string? CondMappedInd { get; set; }

    [Column("logical_operator")]
    [StringLength(3)]
    public string? LogicalOperator { get; set; }

    [Column("close_bracket")]
    [StringLength(4)]
    public string? CloseBracket { get; set; }

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

    [ForeignKey("CmprFieldCompXrefId")]
    [InverseProperty("Hl7CondDetailCmprFieldCompXref")]
    public virtual Hl7FieldCompXref? CmprFieldCompXref { get; set; }

    [ForeignKey("CmprSegFieldXrefId")]
    [InverseProperty("Hl7CondDetailCmprSegFieldXref")]
    public virtual Hl7SegFieldXref? CmprSegFieldXref { get; set; }

    [ForeignKey("CondFieldCompXrefId")]
    [InverseProperty("Hl7CondDetailCondFieldCompXref")]
    public virtual Hl7FieldCompXref? CondFieldCompXref { get; set; }

    [ForeignKey("CondSegFieldXrefId")]
    [InverseProperty("Hl7CondDetailCondSegFieldXref")]
    public virtual Hl7SegFieldXref? CondSegFieldXref { get; set; }

    [ForeignKey("FieldCompXrefId, Hl7CondHeaderId")]
    [InverseProperty("Hl7CondDetail")]
    public virtual Hl7CondHeader Hl7CondHeader { get; set; } = null!;
}
