using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("prov_queue_subscription")]
[Index("Userid", "InstId", Name = "nc1_prov_queue_subscription")]
[Index("ProvUserid", "ProvInstId", Name = "nc2_prov_queue_subscription")]
[Index("ExpiryDate", Name = "nc3_prov_queue_subscription")]
public partial class ProvQueueSubscription
{
    [Key]
    [Column("prov_queue_subscription_id")]
    public int ProvQueueSubscriptionId { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("prov_userid")]
    [StringLength(255)]
    public string ProvUserid { get; set; } = null!;

    [Column("prov_inst_id")]
    [StringLength(30)]
    public string ProvInstId { get; set; } = null!;

    [Column("effective_date", TypeName = "datetime")]
    public DateTime EffectiveDate { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

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
}
