using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ct_cust_form")]
public partial class CtCustForm
{
    [Key]
    [Column("cust_form_id")]
    public int CustFormId { get; set; }

    [Column("ct_cust_form_typ")]
    public int? CtCustFormTyp { get; set; }

    [Column("cust_form_trial_specific_ind")]
    [StringLength(1)]
    public string? CustFormTrialSpecificInd { get; set; }

    [Column("cust_form_name")]
    [StringLength(55)]
    public string CustFormName { get; set; } = null!;

    [Column("cust_form_vers_no")]
    [StringLength(10)]
    public string CustFormVersNo { get; set; } = null!;

    [Column("cust_form_desc")]
    [StringLength(255)]
    public string CustFormDesc { get; set; } = null!;

    [Column("cust_form_active_ind")]
    [StringLength(1)]
    public string? CustFormActiveInd { get; set; }

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

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
