using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_seg_field_xref")]
[Index("FieldId", Name = "nc1_hl7_seg_field_xref")]
public partial class Hl7SegFieldXref
{
    [Key]
    [Column("seg_field_xref_id")]
    [StringLength(10)]
    public string SegFieldXrefId { get; set; } = null!;

    [Column("seg_typ_id")]
    [StringLength(10)]
    public string SegTypId { get; set; } = null!;

    [Column("field_id")]
    [StringLength(10)]
    public string FieldId { get; set; } = null!;

    [Column("field_no")]
    public int FieldNo { get; set; }

    [Column("inbnd_prcs_cd")]
    [StringLength(1)]
    public string InbndPrcsCd { get; set; } = null!;

    [Column("outbnd_prcs_cd")]
    [StringLength(1)]
    public string OutbndPrcsCd { get; set; } = null!;

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

    [Column("repeatable_ind")]
    [StringLength(1)]
    public string RepeatableInd { get; set; } = null!;

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

    [ForeignKey("FieldId")]
    [InverseProperty("Hl7SegFieldXref")]
    public virtual Hl7Field Field { get; set; } = null!;

    [InverseProperty("CmprSegFieldXref")]
    public virtual ICollection<Hl7CondDetail> Hl7CondDetailCmprSegFieldXref { get; set; } = new List<Hl7CondDetail>();

    [InverseProperty("CondSegFieldXref")]
    public virtual ICollection<Hl7CondDetail> Hl7CondDetailCondSegFieldXref { get; set; } = new List<Hl7CondDetail>();

    [InverseProperty("SegFieldXrefId1Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgSegFieldXrefId1Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("SegFieldXrefId2Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgSegFieldXrefId2Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("SegFieldXrefId3Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgSegFieldXrefId3Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("SegFieldXrefId4Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgSegFieldXrefId4Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("SegFieldXrefId5Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgSegFieldXrefId5Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("FalseSegFieldXref")]
    public virtual ICollection<Hl7CondHeader> Hl7CondHeaderFalseSegFieldXref { get; set; } = new List<Hl7CondHeader>();

    [InverseProperty("TrueSegFieldXref")]
    public virtual ICollection<Hl7CondHeader> Hl7CondHeaderTrueSegFieldXref { get; set; } = new List<Hl7CondHeader>();

    [InverseProperty("SegFieldXref")]
    public virtual ICollection<Hl7MsgEvntSegFieldXref> Hl7MsgEvntSegFieldXref { get; set; } = new List<Hl7MsgEvntSegFieldXref>();

    [InverseProperty("CmprSegFieldXref")]
    public virtual ICollection<IntfAppParmCondDetail> IntfAppParmCondDetailCmprSegFieldXref { get; set; } = new List<IntfAppParmCondDetail>();

    [InverseProperty("CondSegFieldXref")]
    public virtual ICollection<IntfAppParmCondDetail> IntfAppParmCondDetailCondSegFieldXref { get; set; } = new List<IntfAppParmCondDetail>();

    [InverseProperty("SegFieldXref")]
    public virtual ICollection<IntfPtKeyMap> IntfPtKeyMap { get; set; } = new List<IntfPtKeyMap>();

    [ForeignKey("SegTypId")]
    [InverseProperty("Hl7SegFieldXref")]
    public virtual Hl7SegTyp SegTyp { get; set; } = null!;
}
