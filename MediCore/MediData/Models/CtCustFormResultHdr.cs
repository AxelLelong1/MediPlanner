using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ct_cust_form_result_hdr")]
public partial class CtCustFormResultHdr
{
    [Key]
    [Column("cust_form_result_id")]
    public int CustFormResultId { get; set; }

    [Column("cust_form_id")]
    public int CustFormId { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string ApprInd { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("cust_form_form", TypeName = "image")]
    public byte[]? CustFormForm { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }
}
