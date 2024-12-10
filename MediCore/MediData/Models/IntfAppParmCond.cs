using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmCondHeaderId")]
[Table("intf_app_parm_cond")]
public partial class IntfAppParmCond
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string IntfAppParmCondHeaderId { get; set; } = null!;

    [Column("cond_process_order")]
    public int CondProcessOrder { get; set; }

    [Column("global_ind")]
    [StringLength(1)]
    public string GlobalInd { get; set; } = null!;

    [Column("cond_ind")]
    [StringLength(1)]
    public string CondInd { get; set; } = null!;

    [Column("prcs_ind")]
    [StringLength(1)]
    public string PrcsInd { get; set; } = null!;

    [Column("pre_cond_ind")]
    [StringLength(1)]
    public string? PreCondInd { get; set; }

    [Column("filter_ind")]
    [StringLength(1)]
    public string FilterInd { get; set; } = null!;

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

    [Column("transltn_ind")]
    [StringLength(1)]
    public string? TransltnInd { get; set; }

    [Column("seg_occurence")]
    public int? SegOccurence { get; set; }

    [Column("field_occurence")]
    public int? FieldOccurence { get; set; }

    [Column("cond_prcs_cd")]
    [StringLength(1)]
    public string? CondPrcsCd { get; set; }

    [InverseProperty("IntfAppParmCond")]
    public virtual ICollection<IntfAppParmCondExpr> IntfAppParmCondExpr { get; set; } = new List<IntfAppParmCondExpr>();
}
