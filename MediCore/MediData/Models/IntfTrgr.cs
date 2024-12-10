using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_trgr")]
[Index("MsgEvntTyp", "MsgTyp", "AppCd", "TrgrStatusInd", Name = "nc1_intf_trgr")]
[Index("TrgrStatusInd", "TransLogTstamp", Name = "nc2_intf_trgr")]
public partial class IntfTrgr
{
    [Key]
    [Column("intf_trgr_seq_no")]
    public int IntfTrgrSeqNo { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("fac_id")]
    public int? FacId { get; set; }

    [Column("msg_typ")]
    [StringLength(3)]
    public string? MsgTyp { get; set; }

    [Column("msg_evnt_typ")]
    [StringLength(3)]
    public string? MsgEvntTyp { get; set; }

    [Column("trgr_status_ind")]
    [StringLength(1)]
    public string? TrgrStatusInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("hl7_out_seq_no")]
    public int? Hl7OutSeqNo { get; set; }

    [Column("order_typ")]
    [StringLength(3)]
    public string? OrderTyp { get; set; }

    [Column("intf_trgr_parent")]
    public int? IntfTrgrParent { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("intf_app_parm_id_no_trgr")]
    [StringLength(10)]
    public string? IntfAppParmIdNoTrgr { get; set; }

    [Column("intf_app_parm_id_trgr")]
    [StringLength(10)]
    public string? IntfAppParmIdTrgr { get; set; }

    [Column("key_name_1")]
    [StringLength(60)]
    public string? KeyName1 { get; set; }

    [Column("key_value_1")]
    [StringLength(50)]
    public string? KeyValue1 { get; set; }

    [Column("key_name_2")]
    [StringLength(60)]
    public string? KeyName2 { get; set; }

    [Column("key_value_2")]
    [StringLength(50)]
    public string? KeyValue2 { get; set; }

    [Column("key_name_3")]
    [StringLength(60)]
    public string? KeyName3 { get; set; }

    [Column("key_value_3")]
    [StringLength(50)]
    public string? KeyValue3 { get; set; }

    [Column("key_name_4")]
    [StringLength(60)]
    public string? KeyName4 { get; set; }

    [Column("key_value_4")]
    [StringLength(50)]
    public string? KeyValue4 { get; set; }

    [Column("key_name_5")]
    [StringLength(60)]
    public string? KeyName5 { get; set; }

    [Column("key_value_5")]
    [StringLength(50)]
    public string? KeyValue5 { get; set; }

    [Column("key_name_6")]
    [StringLength(60)]
    public string? KeyName6 { get; set; }

    [Column("key_value_6")]
    [StringLength(50)]
    public string? KeyValue6 { get; set; }

    [Column("key_name_7")]
    [StringLength(60)]
    public string? KeyName7 { get; set; }

    [Column("key_value_7")]
    [StringLength(50)]
    public string? KeyValue7 { get; set; }

    [Column("key_name_8")]
    [StringLength(60)]
    public string? KeyName8 { get; set; }

    [Column("key_value_8")]
    [StringLength(50)]
    public string? KeyValue8 { get; set; }

    [Column("key_name_9")]
    [StringLength(60)]
    public string? KeyName9 { get; set; }

    [Column("key_value_9")]
    [StringLength(50)]
    public string? KeyValue9 { get; set; }

    [Column("key_name_10")]
    [StringLength(60)]
    public string? KeyName10 { get; set; }

    [Column("key_value_10")]
    [StringLength(50)]
    public string? KeyValue10 { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [InverseProperty("IntfTrgrSeqNoNavigation")]
    public virtual ICollection<IntfAppParmTrgr> IntfAppParmTrgr { get; set; } = new List<IntfAppParmTrgr>();

    [InverseProperty("IntfTrgrSeqNoNavigation")]
    public virtual ICollection<IntfTrgrKeys> IntfTrgrKeys { get; set; } = new List<IntfTrgrKeys>();
}
