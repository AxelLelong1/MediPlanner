using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("OrderId", "GrpId")]
[Table("intf_lab_grp")]
public partial class IntfLabGrp
{
    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Key]
    [Column("grp_id")]
    public int GrpId { get; set; }

    [Column("hl7_pon")]
    [StringLength(15)]
    public string? Hl7Pon { get; set; }

    [Column("hl7_fon")]
    [StringLength(15)]
    public string? Hl7Fon { get; set; }

    [Column("hl7_obs_datetime", TypeName = "datetime")]
    public DateTime? Hl7ObsDatetime { get; set; }

    [Column("hl7_lab_sys_cd")]
    [StringLength(30)]
    public string? Hl7LabSysCd { get; set; }

    [Column("hl7_lab_sys_desc")]
    [StringLength(60)]
    public string? Hl7LabSysDesc { get; set; }

    [Column("test_inst_id")]
    [StringLength(30)]
    public string? TestInstId { get; set; }

    [Column("test_fac_id")]
    public int? TestFacId { get; set; }

    [Column("fac_group_name")]
    [StringLength(30)]
    public string? FacGroupName { get; set; }

    [Column("fac_comp_name")]
    [StringLength(30)]
    public string? FacCompName { get; set; }

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

    [Column("obr_result_status")]
    [StringLength(1)]
    public string? ObrResultStatus { get; set; }

    [Column("hl7_spec_typ")]
    [StringLength(5)]
    public string? Hl7SpecTyp { get; set; }
}
