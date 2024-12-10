using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("epcs_vendor")]
public partial class EpcsVendor
{
    [Key]
    [Column("epcs_vendor_id")]
    public int EpcsVendorId { get; set; }

    [Column("vendor_label")]
    [StringLength(300)]
    public string VendorLabel { get; set; } = null!;

    [Column("vendor_node_label")]
    [StringLength(300)]
    public string VendorNodeLabel { get; set; } = null!;

    [Column("epcs_api_version")]
    [StringLength(10)]
    public string EpcsApiVersion { get; set; } = null!;

    [Column("encrypted_shared_secret")]
    [StringLength(255)]
    public string EncryptedSharedSecret { get; set; } = null!;

    [Column("production_api_url")]
    [StringLength(255)]
    public string? ProductionApiUrl { get; set; }

    [Column("staging_api_url")]
    [StringLength(255)]
    public string? StagingApiUrl { get; set; }

    [Column("production_ui_url")]
    [StringLength(255)]
    public string? ProductionUiUrl { get; set; }

    [Column("staging_ui_url")]
    [StringLength(255)]
    public string? StagingUiUrl { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("vendor_router_label")]
    [StringLength(300)]
    public string VendorRouterLabel { get; set; } = null!;
}
