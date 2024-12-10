using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("email_address")]
public partial class EmailAddress
{
    [Key]
    [Column("email_address_id")]
    public int EmailAddressId { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("email_key")]
    [StringLength(30)]
    public string? EmailKey { get; set; }

    [Column("email_address")]
    [StringLength(60)]
    public string? EmailAddress1 { get; set; }

    [Column("address_desc")]
    [StringLength(255)]
    public string? AddressDesc { get; set; }

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [Column("cc_ind")]
    [StringLength(1)]
    public string? CcInd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

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

    [ForeignKey("AppCd")]
    [InverseProperty("EmailAddress")]
    public virtual App? AppCdNavigation { get; set; }

    [ForeignKey("StkhId")]
    [InverseProperty("EmailAddress")]
    public virtual Stkh? Stkh { get; set; }
}
