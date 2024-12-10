using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Hl7CondHeaderId", "AppMsgNo")]
[Table("hl7_cond_header_app_msg")]
public partial class Hl7CondHeaderAppMsg
{
    [Column("field_comp_xref_id")]
    [StringLength(10)]
    public string FieldCompXrefId { get; set; } = null!;

    [Key]
    [Column("hl7_cond_header_id")]
    [StringLength(10)]
    public string Hl7CondHeaderId { get; set; } = null!;

    [Key]
    [Column("app_msg_no")]
    [StringLength(10)]
    public string AppMsgNo { get; set; } = null!;

    [Column("msg_parameter_1")]
    [StringLength(60)]
    public string? MsgParameter1 { get; set; }

    [Column("val_cd_1")]
    [StringLength(1)]
    public string? ValCd1 { get; set; }

    [Column("seg_field_xref_id_1")]
    [StringLength(10)]
    public string? SegFieldXrefId1 { get; set; }

    [Column("field_comp_xref_id_1")]
    [StringLength(10)]
    public string? FieldCompXrefId1 { get; set; }

    [Column("msg_parameter_2")]
    [StringLength(60)]
    public string? MsgParameter2 { get; set; }

    [Column("val_cd_2")]
    [StringLength(1)]
    public string? ValCd2 { get; set; }

    [Column("seg_field_xref_id_2")]
    [StringLength(10)]
    public string? SegFieldXrefId2 { get; set; }

    [Column("field_comp_xref_id_2")]
    [StringLength(10)]
    public string? FieldCompXrefId2 { get; set; }

    [Column("msg_parameter_3")]
    [StringLength(60)]
    public string? MsgParameter3 { get; set; }

    [Column("val_cd_3")]
    [StringLength(1)]
    public string? ValCd3 { get; set; }

    [Column("seg_field_xref_id_3")]
    [StringLength(10)]
    public string? SegFieldXrefId3 { get; set; }

    [Column("field_comp_xref_id_3")]
    [StringLength(10)]
    public string? FieldCompXrefId3 { get; set; }

    [Column("msg_parameter_4")]
    [StringLength(60)]
    public string? MsgParameter4 { get; set; }

    [Column("val_cd_4")]
    [StringLength(1)]
    public string? ValCd4 { get; set; }

    [Column("seg_field_xref_id_4")]
    [StringLength(10)]
    public string? SegFieldXrefId4 { get; set; }

    [Column("field_comp_xref_id_4")]
    [StringLength(10)]
    public string? FieldCompXrefId4 { get; set; }

    [Column("msg_parameter_5")]
    [StringLength(60)]
    public string? MsgParameter5 { get; set; }

    [Column("val_cd_5")]
    [StringLength(1)]
    public string? ValCd5 { get; set; }

    [Column("seg_field_xref_id_5")]
    [StringLength(10)]
    public string? SegFieldXrefId5 { get; set; }

    [Column("field_comp_xref_id_5")]
    [StringLength(10)]
    public string? FieldCompXrefId5 { get; set; }

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

    [ForeignKey("FieldCompXrefId1")]
    [InverseProperty("Hl7CondHeaderAppMsgFieldCompXrefId1Navigation")]
    public virtual Hl7FieldCompXref? FieldCompXrefId1Navigation { get; set; }

    [ForeignKey("FieldCompXrefId2")]
    [InverseProperty("Hl7CondHeaderAppMsgFieldCompXrefId2Navigation")]
    public virtual Hl7FieldCompXref? FieldCompXrefId2Navigation { get; set; }

    [ForeignKey("FieldCompXrefId3")]
    [InverseProperty("Hl7CondHeaderAppMsgFieldCompXrefId3Navigation")]
    public virtual Hl7FieldCompXref? FieldCompXrefId3Navigation { get; set; }

    [ForeignKey("FieldCompXrefId4")]
    [InverseProperty("Hl7CondHeaderAppMsgFieldCompXrefId4Navigation")]
    public virtual Hl7FieldCompXref? FieldCompXrefId4Navigation { get; set; }

    [ForeignKey("FieldCompXrefId5")]
    [InverseProperty("Hl7CondHeaderAppMsgFieldCompXrefId5Navigation")]
    public virtual Hl7FieldCompXref? FieldCompXrefId5Navigation { get; set; }

    [ForeignKey("FieldCompXrefId, Hl7CondHeaderId")]
    [InverseProperty("Hl7CondHeaderAppMsg")]
    public virtual Hl7CondHeader Hl7CondHeader { get; set; } = null!;

    [ForeignKey("SegFieldXrefId1")]
    [InverseProperty("Hl7CondHeaderAppMsgSegFieldXrefId1Navigation")]
    public virtual Hl7SegFieldXref? SegFieldXrefId1Navigation { get; set; }

    [ForeignKey("SegFieldXrefId2")]
    [InverseProperty("Hl7CondHeaderAppMsgSegFieldXrefId2Navigation")]
    public virtual Hl7SegFieldXref? SegFieldXrefId2Navigation { get; set; }

    [ForeignKey("SegFieldXrefId3")]
    [InverseProperty("Hl7CondHeaderAppMsgSegFieldXrefId3Navigation")]
    public virtual Hl7SegFieldXref? SegFieldXrefId3Navigation { get; set; }

    [ForeignKey("SegFieldXrefId4")]
    [InverseProperty("Hl7CondHeaderAppMsgSegFieldXrefId4Navigation")]
    public virtual Hl7SegFieldXref? SegFieldXrefId4Navigation { get; set; }

    [ForeignKey("SegFieldXrefId5")]
    [InverseProperty("Hl7CondHeaderAppMsgSegFieldXrefId5Navigation")]
    public virtual Hl7SegFieldXref? SegFieldXrefId5Navigation { get; set; }
}
