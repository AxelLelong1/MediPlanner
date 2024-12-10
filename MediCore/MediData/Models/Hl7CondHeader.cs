using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("FieldCompXrefId", "Hl7CondHeaderId")]
[Table("hl7_cond_header")]
public partial class Hl7CondHeader
{
    [Key]
    [Column("field_comp_xref_id")]
    [StringLength(10)]
    public string FieldCompXrefId { get; set; } = null!;

    [Key]
    [Column("hl7_cond_header_id")]
    [StringLength(10)]
    public string Hl7CondHeaderId { get; set; } = null!;

    [Column("msg_evnt_seg_field_xref_id")]
    [StringLength(10)]
    public string MsgEvntSegFieldXrefId { get; set; } = null!;

    [Column("global_ind")]
    [StringLength(1)]
    public string GlobalInd { get; set; } = null!;

    [Column("cond_process_order")]
    public int CondProcessOrder { get; set; }

    [Column("cond_type")]
    [StringLength(1)]
    public string CondType { get; set; } = null!;

    [Column("validation_ref_id")]
    [StringLength(15)]
    public string? ValidationRefId { get; set; }

    [Column("validation_inst_id")]
    [StringLength(30)]
    public string? ValidationInstId { get; set; }

    [Column("true_val_cd")]
    [StringLength(1)]
    public string? TrueValCd { get; set; }

    [Column("true_val")]
    [StringLength(255)]
    public string? TrueVal { get; set; }

    [Column("true_field_comp_xref_id")]
    [StringLength(10)]
    public string? TrueFieldCompXrefId { get; set; }

    [Column("true_seg_field_xref_id")]
    [StringLength(10)]
    public string? TrueSegFieldXrefId { get; set; }

    [Column("true_mapped_ind")]
    [StringLength(1)]
    public string? TrueMappedInd { get; set; }

    [Column("false_val_cd")]
    [StringLength(1)]
    public string? FalseValCd { get; set; }

    [Column("false_val")]
    [StringLength(255)]
    public string? FalseVal { get; set; }

    [Column("false_field_comp_xref_id")]
    [StringLength(10)]
    public string? FalseFieldCompXrefId { get; set; }

    [Column("false_seg_field_xref_id")]
    [StringLength(10)]
    public string? FalseSegFieldXrefId { get; set; }

    [Column("false_mapped_ind")]
    [StringLength(1)]
    public string? FalseMappedInd { get; set; }

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

    [Column("del_ind")]
    [StringLength(1)]
    public string DelInd { get; set; } = null!;

    [Column("inbnd_ind")]
    [StringLength(1)]
    public string InbndInd { get; set; } = null!;

    [Column("outbnd_ind")]
    [StringLength(1)]
    public string OutbndInd { get; set; } = null!;

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

    [Column("pre_cond_ind")]
    [StringLength(1)]
    public string? PreCondInd { get; set; }

    [ForeignKey("FalseFieldCompXrefId")]
    [InverseProperty("Hl7CondHeaderFalseFieldCompXref")]
    public virtual Hl7FieldCompXref? FalseFieldCompXref { get; set; }

    [ForeignKey("FalseSegFieldXrefId")]
    [InverseProperty("Hl7CondHeaderFalseSegFieldXref")]
    public virtual Hl7SegFieldXref? FalseSegFieldXref { get; set; }

    [InverseProperty("Hl7CondHeader")]
    public virtual ICollection<Hl7CondDetail> Hl7CondDetail { get; set; } = new List<Hl7CondDetail>();

    [InverseProperty("Hl7CondHeader")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsg { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [ForeignKey("MsgEvntSegFieldXrefId")]
    [InverseProperty("Hl7CondHeader")]
    public virtual Hl7MsgEvntSegFieldXref MsgEvntSegFieldXref { get; set; } = null!;

    [ForeignKey("TrueFieldCompXrefId")]
    [InverseProperty("Hl7CondHeaderTrueFieldCompXref")]
    public virtual Hl7FieldCompXref? TrueFieldCompXref { get; set; }

    [ForeignKey("TrueSegFieldXrefId")]
    [InverseProperty("Hl7CondHeaderTrueSegFieldXref")]
    public virtual Hl7SegFieldXref? TrueSegFieldXref { get; set; }
}
