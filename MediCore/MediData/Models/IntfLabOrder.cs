using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_lab_order")]
public partial class IntfLabOrder
{
    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("hl7_in_seq_no_orig")]
    public int? Hl7InSeqNoOrig { get; set; }

    [Column("hl7_in_seq_no_new")]
    public int? Hl7InSeqNoNew { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("hl7_pt_intrnl_key")]
    [StringLength(20)]
    public string? Hl7PtIntrnlKey { get; set; }

    [Column("hl7_pt_extrnl_key")]
    [StringLength(16)]
    public string? Hl7PtExtrnlKey { get; set; }

    [Column("hl7_pt_last_name")]
    [StringLength(30)]
    public string? Hl7PtLastName { get; set; }

    [Column("hl7_pt_first_name")]
    [StringLength(30)]
    public string? Hl7PtFirstName { get; set; }

    [Column("hl7_msg_cntl_id")]
    [StringLength(30)]
    public string? Hl7MsgCntlId { get; set; }

    [Column("hl7_msg_datetime")]
    [StringLength(20)]
    public string? Hl7MsgDatetime { get; set; }

    [Column("test_inst_id")]
    [StringLength(30)]
    public string? TestInstId { get; set; }

    [Column("test_fac_id")]
    public int? TestFacId { get; set; }

    [Column("gen_cmt")]
    public string? GenCmt { get; set; }

    [Column("order_cmt")]
    public string? OrderCmt { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string Status { get; set; } = null!;

    [Column("asc_no")]
    [StringLength(15)]
    public string? AscNo { get; set; }

    [Column("process_ind")]
    [StringLength(1)]
    public string ProcessInd { get; set; } = null!;

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
}
