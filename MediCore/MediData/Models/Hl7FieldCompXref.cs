using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_field_comp_xref")]
public partial class Hl7FieldCompXref
{
    [Key]
    [Column("field_comp_xref_id")]
    [StringLength(10)]
    public string FieldCompXrefId { get; set; } = null!;

    [Column("field_comp_name")]
    [StringLength(30)]
    public string FieldCompName { get; set; } = null!;

    [Column("field_id")]
    [StringLength(10)]
    public string FieldId { get; set; } = null!;

    [Column("comp_id")]
    [StringLength(10)]
    public string CompId { get; set; } = null!;

    [Column("data_typ_no")]
    public int DataTypNo { get; set; }

    [Column("data_typ")]
    [StringLength(3)]
    public string DataTyp { get; set; } = null!;

    [Column("inbnd_prcs_cd")]
    [StringLength(1)]
    public string InbndPrcsCd { get; set; } = null!;

    [Column("outbnd_prcs_cd")]
    [StringLength(1)]
    public string OutbndPrcsCd { get; set; } = null!;

    [Column("inbnd_dflt_severity")]
    public int InbndDfltSeverity { get; set; }

    [Column("outbnd_dflt_severity")]
    public int OutbndDfltSeverity { get; set; }

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

    [Column("field_sub_comp_name")]
    [StringLength(30)]
    public string? FieldSubCompName { get; set; }

    [ForeignKey("CompId")]
    [InverseProperty("Hl7FieldCompXref")]
    public virtual Hl7Comp Comp { get; set; } = null!;

    [ForeignKey("FieldId")]
    [InverseProperty("Hl7FieldCompXref")]
    public virtual Hl7Field Field { get; set; } = null!;

    [InverseProperty("CmprFieldCompXref")]
    public virtual ICollection<Hl7CondDetail> Hl7CondDetailCmprFieldCompXref { get; set; } = new List<Hl7CondDetail>();

    [InverseProperty("CondFieldCompXref")]
    public virtual ICollection<Hl7CondDetail> Hl7CondDetailCondFieldCompXref { get; set; } = new List<Hl7CondDetail>();

    [InverseProperty("FieldCompXrefId1Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgFieldCompXrefId1Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("FieldCompXrefId2Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgFieldCompXrefId2Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("FieldCompXrefId3Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgFieldCompXrefId3Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("FieldCompXrefId4Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgFieldCompXrefId4Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("FieldCompXrefId5Navigation")]
    public virtual ICollection<Hl7CondHeaderAppMsg> Hl7CondHeaderAppMsgFieldCompXrefId5Navigation { get; set; } = new List<Hl7CondHeaderAppMsg>();

    [InverseProperty("FalseFieldCompXref")]
    public virtual ICollection<Hl7CondHeader> Hl7CondHeaderFalseFieldCompXref { get; set; } = new List<Hl7CondHeader>();

    [InverseProperty("TrueFieldCompXref")]
    public virtual ICollection<Hl7CondHeader> Hl7CondHeaderTrueFieldCompXref { get; set; } = new List<Hl7CondHeader>();

    [InverseProperty("CmprFieldCompXref")]
    public virtual ICollection<IntfAppParmCondDetail> IntfAppParmCondDetailCmprFieldCompXref { get; set; } = new List<IntfAppParmCondDetail>();

    [InverseProperty("CondFieldCompXref")]
    public virtual ICollection<IntfAppParmCondDetail> IntfAppParmCondDetailCondFieldCompXref { get; set; } = new List<IntfAppParmCondDetail>();
}
