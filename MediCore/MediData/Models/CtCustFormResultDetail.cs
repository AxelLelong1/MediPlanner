using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CustFormResultId", "CustFormFieldName")]
[Table("ct_cust_form_result_detail")]
public partial class CtCustFormResultDetail
{
    [Key]
    [Column("cust_form_result_id")]
    public int CustFormResultId { get; set; }

    [Key]
    [Column("cust_form_field_name")]
    [StringLength(55)]
    public string CustFormFieldName { get; set; } = null!;

    [Column("cust_form_field_value")]
    [StringLength(125)]
    public string? CustFormFieldValue { get; set; }

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
}
