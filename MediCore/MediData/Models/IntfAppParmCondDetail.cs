using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmCondHeaderId", "CondOrder")]
[Table("intf_app_parm_cond_detail")]
public partial class IntfAppParmCondDetail
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string IntfAppParmCondHeaderId { get; set; } = null!;

    [Key]
    [Column("cond_order")]
    public int CondOrder { get; set; }

    [Column("open_bracket")]
    [StringLength(4)]
    public string? OpenBracket { get; set; }

    [Column("cmpr_val_cd")]
    [StringLength(1)]
    public string? CmprValCd { get; set; }

    [Column("cmpr_seg_field_xref_id")]
    [StringLength(10)]
    public string? CmprSegFieldXrefId { get; set; }

    [Column("cmpr_field_comp_xref_id")]
    [StringLength(10)]
    public string? CmprFieldCompXrefId { get; set; }

    [Column("cmpr_mapped_ind")]
    [StringLength(1)]
    public string? CmprMappedInd { get; set; }

    [Column("cmpr_operator")]
    [StringLength(30)]
    public string CmprOperator { get; set; } = null!;

    [Column("cond_val_cd")]
    [StringLength(1)]
    public string? CondValCd { get; set; }

    [Column("cond_val")]
    [StringLength(255)]
    public string? CondVal { get; set; }

    [Column("cond_seg_field_xref_id")]
    [StringLength(10)]
    public string? CondSegFieldXrefId { get; set; }

    [Column("cond_field_comp_xref_id")]
    [StringLength(10)]
    public string? CondFieldCompXrefId { get; set; }

    [Column("cond_mapped_ind")]
    [StringLength(1)]
    public string? CondMappedInd { get; set; }

    [Column("logical_operator")]
    [StringLength(3)]
    public string? LogicalOperator { get; set; }

    [Column("close_bracket")]
    [StringLength(4)]
    public string? CloseBracket { get; set; }

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

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime? BaseTstamp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("CmprFieldCompXrefId")]
    [InverseProperty("IntfAppParmCondDetailCmprFieldCompXref")]
    public virtual Hl7FieldCompXref? CmprFieldCompXref { get; set; }

    [ForeignKey("CmprSegFieldXrefId")]
    [InverseProperty("IntfAppParmCondDetailCmprSegFieldXref")]
    public virtual Hl7SegFieldXref? CmprSegFieldXref { get; set; }

    [ForeignKey("CondFieldCompXrefId")]
    [InverseProperty("IntfAppParmCondDetailCondFieldCompXref")]
    public virtual Hl7FieldCompXref? CondFieldCompXref { get; set; }

    [ForeignKey("CondSegFieldXrefId")]
    [InverseProperty("IntfAppParmCondDetailCondSegFieldXref")]
    public virtual Hl7SegFieldXref? CondSegFieldXref { get; set; }

    [ForeignKey("IntfAppParmId, IntfAppParmCondHeaderId")]
    [InverseProperty("IntfAppParmCondDetail")]
    public virtual IntfAppParmCondHeader IntfAppParmCondHeader { get; set; } = null!;
}
