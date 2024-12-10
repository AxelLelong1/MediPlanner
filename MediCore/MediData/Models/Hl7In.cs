using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_in")]
[Index("TransLogTstamp", Name = "nc1_hl7_in")]
[Index("ProcessInd", Name = "nc2_hl7_in")]
[Index("IntfAppParmId", Name = "nc3_hl7_in")]
[Index("DisplayPtKey1Value", Name = "nc4_hl7_in")]
[Index("TransLogMtstamp", Name = "nc5_hl7_in")]
public partial class Hl7In
{
    [Key]
    [Column("hl7_in_seq_no")]
    public int Hl7InSeqNo { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string? IntfAppParmId { get; set; }

    [Column("hl7_msg_cntl_id")]
    [StringLength(30)]
    public string? Hl7MsgCntlId { get; set; }

    [Column("sending_app")]
    [StringLength(30)]
    public string? SendingApp { get; set; }

    [Column("process_ind")]
    [StringLength(1)]
    public string? ProcessInd { get; set; }

    [Column("msg_typ")]
    [StringLength(3)]
    public string? MsgTyp { get; set; }

    [Column("msg_evnt_typ")]
    [StringLength(3)]
    public string? MsgEvntTyp { get; set; }

    [Column("file_name")]
    [StringLength(255)]
    public string? FileName { get; set; }

    [Column("msg_txt")]
    public string? MsgTxt { get; set; }

    [Column("hl7_batch_id")]
    [StringLength(20)]
    public string? Hl7BatchId { get; set; }

    [Column("hl7_out_seq_no")]
    public int? Hl7OutSeqNo { get; set; }

    [Column("wrng_msg_cnt")]
    public int? WrngMsgCnt { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("resolved_ind")]
    [StringLength(1)]
    public string? ResolvedInd { get; set; }

    [Column("resolved_desc")]
    [StringLength(255)]
    public string? ResolvedDesc { get; set; }

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

    [Column("ovride_pt_addl_match_ind")]
    [StringLength(1)]
    public string? OvridePtAddlMatchInd { get; set; }

    [Column("post_msg_seq_no")]
    public int? PostMsgSeqNo { get; set; }

    [Column("msg_stage_cd")]
    [StringLength(1)]
    public string? MsgStageCd { get; set; }

    [Column("prc_start_time", TypeName = "datetime")]
    public DateTime? PrcStartTime { get; set; }

    [Column("prc_end_time", TypeName = "datetime")]
    public DateTime? PrcEndTime { get; set; }

    [Column("patient_select_released_ind")]
    [StringLength(1)]
    public string? PatientSelectReleasedInd { get; set; }

    [Column("update_patient_ser")]
    public long? UpdatePatientSer { get; set; }

    [Column("display_pt_key_1_value")]
    [StringLength(25)]
    public string? DisplayPtKey1Value { get; set; }

    [Column("display_pt_key_2_value")]
    [StringLength(25)]
    public string? DisplayPtKey2Value { get; set; }

    [Column("upper_display_pt_last_name")]
    [StringLength(30)]
    public string? UpperDisplayPtLastName { get; set; }

    [Column("upper_display_pt_first_name")]
    [StringLength(30)]
    public string? UpperDisplayPtFirstName { get; set; }

    [Column("patient_select_userid")]
    [StringLength(255)]
    public string? PatientSelectUserid { get; set; }

    [Column("patient_select_tstamp", TypeName = "datetime")]
    public DateTime? PatientSelectTstamp { get; set; }

    [Column("update_pt_id")]
    [StringLength(20)]
    public string? UpdatePtId { get; set; }

    [Column("msh_datetime", TypeName = "datetime")]
    public DateTime? MshDatetime { get; set; }

    [Column("resubmit_datetime", TypeName = "datetime")]
    public DateTime? ResubmitDatetime { get; set; }

    [Column("hl7_report_data")]
    public string? Hl7ReportData { get; set; }
}
