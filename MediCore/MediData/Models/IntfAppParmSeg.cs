using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmSegId")]
[Table("intf_app_parm_seg")]
[Index("IntfAppParmId", "IntfAppParmEvntId", "IntfAppParmSegId", Name = "nc1_intf_app_parm_seg")]
public partial class IntfAppParmSeg
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_seg_id")]
    [StringLength(10)]
    public string IntfAppParmSegId { get; set; } = null!;

    [Column("intf_app_parm_evnt_id")]
    [StringLength(10)]
    public string IntfAppParmEvntId { get; set; } = null!;

    [Column("msg_evnt_seg_xref_id")]
    [StringLength(10)]
    public string? MsgEvntSegXrefId { get; set; }

    [Column("prcs_nte_ind")]
    [StringLength(1)]
    public string PrcsNteInd { get; set; } = null!;

    [Column("reject_seg_ind")]
    [StringLength(1)]
    public string RejectSegInd { get; set; } = null!;

    [Column("reject_msg_ind")]
    [StringLength(1)]
    public string RejectMsgInd { get; set; } = null!;

    [Column("prcs_ind")]
    [StringLength(1)]
    public string PrcsInd { get; set; } = null!;

    [Column("doc_desc")]
    [StringLength(255)]
    public string? DocDesc { get; set; }

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

    [Column("auto_gen_ind")]
    [StringLength(1)]
    public string? AutoGenInd { get; set; }

    [Column("write_seg_ind")]
    [StringLength(1)]
    public string? WriteSegInd { get; set; }

    [Column("prcs_mthd_typ")]
    [StringLength(1)]
    public string? PrcsMthdTyp { get; set; }

    [Column("generate_ind")]
    [StringLength(1)]
    public string? GenerateInd { get; set; }

    [Column("header_ind")]
    [StringLength(1)]
    public string? HeaderInd { get; set; }

    [Column("def_typ")]
    [StringLength(1)]
    public string? DefTyp { get; set; }

    [Column("seg_typ")]
    [StringLength(3)]
    public string? SegTyp { get; set; }

    [Column("seg_typ_name")]
    [StringLength(30)]
    public string? SegTypName { get; set; }

    [Column("seg_typ_desc")]
    [StringLength(255)]
    public string? SegTypDesc { get; set; }

    [Column("snapshot_ind")]
    [StringLength(1)]
    public string? SnapshotInd { get; set; }

    [Column("grp_ind")]
    [StringLength(1)]
    public string? GrpInd { get; set; }

    [Column("req_ind")]
    [StringLength(1)]
    public string? ReqInd { get; set; }

    [Column("sort_order_no")]
    public int? SortOrderNo { get; set; }

    [Column("nte_assoc_ind")]
    [StringLength(1)]
    public string? NteAssocInd { get; set; }

    [Column("grp_child_ind")]
    [StringLength(1)]
    public string? GrpChildInd { get; set; }

    [Column("repeatable_ind")]
    [StringLength(1)]
    public string? RepeatableInd { get; set; }

    [Column("parent_intf_app_parm_seg_id")]
    [StringLength(10)]
    public string? ParentIntfAppParmSegId { get; set; }

    [Column("seg_typ_id")]
    [StringLength(10)]
    public string? SegTypId { get; set; }

    [Column("predefined_ind")]
    [StringLength(1)]
    public string? PredefinedInd { get; set; }

    [Column("intf_app_parm_cond_header_id")]
    [StringLength(10)]
    public string? IntfAppParmCondHeaderId { get; set; }

    [Column("inbound_prcs_ind")]
    [StringLength(1)]
    public string? InboundPrcsInd { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmSeg")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [ForeignKey("IntfAppParmId, IntfAppParmEvntId")]
    [InverseProperty("IntfAppParmSeg")]
    public virtual IntfAppParmEvnt IntfAppParmEvnt { get; set; } = null!;

    [InverseProperty("IntfAppParmSeg")]
    public virtual ICollection<IntfAppParmField> IntfAppParmField { get; set; } = new List<IntfAppParmField>();

    [InverseProperty("IntfAppParmSeg")]
    public virtual ICollection<IntfAppParmTrnsltnRecrd> IntfAppParmTrnsltnRecrd { get; set; } = new List<IntfAppParmTrnsltnRecrd>();
}
