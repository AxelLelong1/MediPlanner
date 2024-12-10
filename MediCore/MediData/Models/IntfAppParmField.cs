using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmFieldId")]
[Table("intf_app_parm_field")]
[Index("MsgEvntSegFieldXrefId", Name = "nc1_intf_app_parm_field")]
[Index("IntfAppParmId", "SegFieldXrefId", Name = "nc2_intf_app_parm_field")]
[Index("IntfAppParmSegId", "IntfAppParmId", "IntfAppParmFieldId", Name = "nc3_intf_app_parm_field")]
public partial class IntfAppParmField
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_field_id")]
    [StringLength(10)]
    public string IntfAppParmFieldId { get; set; } = null!;

    [Column("intf_app_parm_seg_id")]
    [StringLength(10)]
    public string IntfAppParmSegId { get; set; } = null!;

    [Column("msg_evnt_seg_field_xref_id")]
    [StringLength(10)]
    public string? MsgEvntSegFieldXrefId { get; set; }

    [Column("prcs_cd")]
    [StringLength(1)]
    public string PrcsCd { get; set; } = null!;

    [Column("intf_stkh_key_map_ind")]
    [StringLength(1)]
    public string? IntfStkhKeyMapInd { get; set; }

    [Column("intf_pt_key_map_ind")]
    [StringLength(1)]
    public string? IntfPtKeyMapInd { get; set; }

    [Column("hl7_mapped_ind")]
    [StringLength(1)]
    public string Hl7MappedInd { get; set; } = null!;

    [Column("stkh_map_severity")]
    public int? StkhMapSeverity { get; set; }

    [Column("ovride_ind")]
    [StringLength(1)]
    public string OvrideInd { get; set; } = null!;

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

    [Column("stkh_bitmap_ind")]
    [StringLength(1)]
    public string? StkhBitmapInd { get; set; }

    [Column("dflt_stkh_id")]
    [StringLength(20)]
    public string? DfltStkhId { get; set; }

    [Column("stkh_add_ind")]
    [StringLength(1)]
    public string? StkhAddInd { get; set; }

    [Column("seg_field_xref_id")]
    [StringLength(10)]
    public string? SegFieldXrefId { get; set; }

    [Column("field_starting_posn")]
    public int? FieldStartingPosn { get; set; }

    [Column("field_length")]
    public int? FieldLength { get; set; }

    [Column("field_pos")]
    public int? FieldPos { get; set; }

    [Column("def_typ")]
    [StringLength(1)]
    public string? DefTyp { get; set; }

    [Column("item_no")]
    [StringLength(5)]
    public string? ItemNo { get; set; }

    [Column("field_name")]
    [StringLength(30)]
    public string? FieldName { get; set; }

    [Column("field_desc")]
    [StringLength(255)]
    public string? FieldDesc { get; set; }

    [Column("field_data_typ")]
    [StringLength(3)]
    public string? FieldDataTyp { get; set; }

    [Column("map_mthd_cd")]
    [StringLength(1)]
    public string? MapMthdCd { get; set; }

    [Column("stkh_prcs_cd")]
    [StringLength(1)]
    public string? StkhPrcsCd { get; set; }

    [Column("add_ind")]
    [StringLength(1)]
    public string? AddInd { get; set; }

    [Column("pt_prcs_cd")]
    [StringLength(1)]
    public string? PtPrcsCd { get; set; }

    [Column("stkh_cd")]
    [StringLength(1)]
    public string? StkhCd { get; set; }

    [Column("prof_reltn_ind")]
    [StringLength(1)]
    public string? ProfReltnInd { get; set; }

    [Column("repeatable_ind")]
    [StringLength(1)]
    public string? RepeatableInd { get; set; }

    [Column("field_no")]
    public int? FieldNo { get; set; }

    [Column("null_ind")]
    [StringLength(1)]
    public string? NullInd { get; set; }

    [Column("outbnd_prcs_cd")]
    [StringLength(1)]
    public string? OutbndPrcsCd { get; set; }

    [Column("inbnd_prcs_cd")]
    [StringLength(1)]
    public string? InbndPrcsCd { get; set; }

    [Column("custom_ind")]
    [StringLength(1)]
    public string? CustomInd { get; set; }

    [Column("seg_field_xref_desc")]
    [StringLength(255)]
    public string? SegFieldXrefDesc { get; set; }

    [Column("intf_field_cd_map_send_cd")]
    [StringLength(1)]
    public string? IntfFieldCdMapSendCd { get; set; }

    [Column("req_role_typ")]
    public int? ReqRoleTyp { get; set; }

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmField")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [InverseProperty("IntfAppParmField")]
    public virtual ICollection<IntfAppParmComp> IntfAppParmComp { get; set; } = new List<IntfAppParmComp>();

    [ForeignKey("IntfAppParmId, IntfAppParmSegId")]
    [InverseProperty("IntfAppParmField")]
    public virtual IntfAppParmSeg IntfAppParmSeg { get; set; } = null!;

    [InverseProperty("IntfAppParmField")]
    public virtual ICollection<IntfAppParmTrnsltnFld> IntfAppParmTrnsltnFld { get; set; } = new List<IntfAppParmTrnsltnFld>();
}
