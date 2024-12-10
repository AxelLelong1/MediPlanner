using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmCondHeaderId")]
[Table("intf_app_parm_cond_header")]
public partial class IntfAppParmCondHeader
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string IntfAppParmCondHeaderId { get; set; } = null!;

    [Column("hl7_cond_header_id")]
    [StringLength(10)]
    public string? Hl7CondHeaderId { get; set; }

    [Column("intf_app_parm_comp_id")]
    [StringLength(10)]
    public string IntfAppParmCompId { get; set; } = null!;

    [Column("global_ind")]
    [StringLength(1)]
    public string GlobalInd { get; set; } = null!;

    [Column("cond_process_order")]
    public int CondProcessOrder { get; set; }

    [Column("true_val_cd")]
    [StringLength(1)]
    public string? TrueValCd { get; set; }

    [Column("true_val")]
    [StringLength(255)]
    public string? TrueVal { get; set; }

    [Column("true_seg_field_xref_id")]
    [StringLength(10)]
    public string? TrueSegFieldXrefId { get; set; }

    [Column("true_field_comp_xref_id")]
    [StringLength(10)]
    public string? TrueFieldCompXrefId { get; set; }

    [Column("true_mapped_ind")]
    [StringLength(1)]
    public string? TrueMappedInd { get; set; }

    [Column("false_val_cd")]
    [StringLength(1)]
    public string? FalseValCd { get; set; }

    [Column("false_val")]
    [StringLength(255)]
    public string? FalseVal { get; set; }

    [Column("false_seg_field_xref_id")]
    [StringLength(10)]
    public string? FalseSegFieldXrefId { get; set; }

    [Column("false_field_comp_xref_id")]
    [StringLength(10)]
    public string? FalseFieldCompXrefId { get; set; }

    [Column("false_mapped_ind")]
    [StringLength(1)]
    public string? FalseMappedInd { get; set; }

    [Column("ovride_val_cd")]
    [StringLength(1)]
    public string? OvrideValCd { get; set; }

    [Column("ovride_val")]
    [StringLength(255)]
    public string? OvrideVal { get; set; }

    [Column("ovride_seg_field_xref_id")]
    [StringLength(10)]
    public string? OvrideSegFieldXrefId { get; set; }

    [Column("ovride_field_comp_xref_id")]
    [StringLength(10)]
    public string? OvrideFieldCompXrefId { get; set; }

    [Column("ovride_mapped_ind")]
    [StringLength(1)]
    public string? OvrideMappedInd { get; set; }

    [Column("cond_ind")]
    [StringLength(1)]
    public string CondInd { get; set; } = null!;

    [Column("prcs_ind")]
    [StringLength(1)]
    public string PrcsInd { get; set; } = null!;

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime? BaseTstamp { get; set; }

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

    [InverseProperty("IntfAppParmCondHeader")]
    public virtual ICollection<IntfAppParmCondDetail> IntfAppParmCondDetail { get; set; } = new List<IntfAppParmCondDetail>();
}
