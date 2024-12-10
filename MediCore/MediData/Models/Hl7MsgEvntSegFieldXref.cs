using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_msg_evnt_seg_field_xref")]
[Index("SegFieldXrefId", Name = "nc1hl7_msg_evnt_seg_field_xref")]
public partial class Hl7MsgEvntSegFieldXref
{
    [Key]
    [Column("msg_evnt_seg_field_xref_id")]
    [StringLength(10)]
    public string MsgEvntSegFieldXrefId { get; set; } = null!;

    [Column("msg_evnt_seg_xref_id")]
    [StringLength(10)]
    public string MsgEvntSegXrefId { get; set; } = null!;

    [Column("seg_field_xref_id")]
    [StringLength(10)]
    public string SegFieldXrefId { get; set; } = null!;

    [Column("inbnd_prcs_cd")]
    [StringLength(1)]
    public string InbndPrcsCd { get; set; } = null!;

    [Column("outbnd_prcs_cd")]
    [StringLength(1)]
    public string OutbndPrcsCd { get; set; } = null!;

    [Column("ovride_ind")]
    [StringLength(1)]
    public string OvrideInd { get; set; } = null!;

    [Column("validation_ind")]
    [StringLength(1)]
    public string ValidationInd { get; set; } = null!;

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

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

    [Column("business_rule_ind")]
    [StringLength(1)]
    public string? BusinessRuleInd { get; set; }

    [InverseProperty("MsgEvntSegFieldXref")]
    public virtual ICollection<Hl7CondHeader> Hl7CondHeader { get; set; } = new List<Hl7CondHeader>();

    [ForeignKey("MsgEvntSegXrefId")]
    [InverseProperty("Hl7MsgEvntSegFieldXref")]
    public virtual Hl7MsgEvntSegXref MsgEvntSegXref { get; set; } = null!;

    [ForeignKey("SegFieldXrefId")]
    [InverseProperty("Hl7MsgEvntSegFieldXref")]
    public virtual Hl7SegFieldXref SegFieldXref { get; set; } = null!;
}
