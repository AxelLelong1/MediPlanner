using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("implantable_device")]
public partial class ImplantableDevice
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("udi")]
    [StringLength(255)]
    public string Udi { get; set; } = null!;

    [Column("device_id")]
    [StringLength(64)]
    public string? DeviceId { get; set; }

    [Column("lot_number")]
    [StringLength(64)]
    public string? LotNumber { get; set; }

    [Column("serial_number")]
    [StringLength(64)]
    public string? SerialNumber { get; set; }

    [Column("exp_date")]
    public DateOnly? ExpDate { get; set; }

    [Column("mfg_date")]
    public DateOnly? MfgDate { get; set; }

    [Column("donation_id")]
    [StringLength(64)]
    public string? DonationId { get; set; }

    [Column("gmdnpt_name")]
    [StringLength(255)]
    public string? GmdnptName { get; set; }

    [Column("gmdnpt_def")]
    public string? GmdnptDef { get; set; }

    [Column("brand_name")]
    [StringLength(64)]
    public string? BrandName { get; set; }

    [Column("vers_model_no")]
    [StringLength(64)]
    public string? VersModelNo { get; set; }

    [Column("company_name")]
    [StringLength(64)]
    public string? CompanyName { get; set; }

    [Column("mri_safety_status")]
    [StringLength(64)]
    public string? MriSafetyStatus { get; set; }

    [Column("labeled_contains_nrl")]
    [StringLength(64)]
    public string? LabeledContainsNrl { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string? Status { get; set; }

    [Column("valid_entry")]
    [StringLength(1)]
    public string? ValidEntry { get; set; }

    [Column("revision_no")]
    public int? RevisionNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("location_cmnt")]
    public string? LocationCmnt { get; set; }

    [Column("inactive_reason")]
    public string? InactiveReason { get; set; }

    [Column("implant_date", TypeName = "datetime")]
    public DateTime? ImplantDate { get; set; }

    [Column("implant_date_cd")]
    public int? ImplantDateCd { get; set; }
}
