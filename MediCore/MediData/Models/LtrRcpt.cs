using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("LtrId", "LtrRcptStkhId")]
[Table("ltr_rcpt")]
public partial class LtrRcpt
{
    [Key]
    [Column("ltr_id")]
    public int LtrId { get; set; }

    [Key]
    [Column("ltr_rcpt_stkh_id")]
    [StringLength(20)]
    public string LtrRcptStkhId { get; set; } = null!;

    [Column("cc_ind")]
    [StringLength(1)]
    public string? CcInd { get; set; }

    [Column("print_ind")]
    [StringLength(1)]
    public string? PrintInd { get; set; }

    [Column("email_ind")]
    [StringLength(1)]
    public string? EmailInd { get; set; }

    [Column("fax_ind")]
    [StringLength(1)]
    public string? FaxInd { get; set; }

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

    [Column("sent_date", TypeName = "datetime")]
    public DateTime? SentDate { get; set; }
}
