using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("OrderId", "GrpId", "ObsId")]
[Table("intf_lab_obs_result")]
public partial class IntfLabObsResult
{
    [Key]
    [Column("order_id")]
    public int OrderId { get; set; }

    [Key]
    [Column("grp_id")]
    public int GrpId { get; set; }

    [Key]
    [Column("obs_id")]
    public int ObsId { get; set; }

    [Column("hl7_lab_sys_cd")]
    [StringLength(30)]
    public string? Hl7LabSysCd { get; set; }

    [Column("hl7_lab_sys_desc")]
    [StringLength(60)]
    public string? Hl7LabSysDesc { get; set; }

    [Column("fac_group_name")]
    [StringLength(30)]
    public string? FacGroupName { get; set; }

    [Column("fac_comp_name")]
    [StringLength(30)]
    public string? FacCompName { get; set; }

    [Column("test_inst_id")]
    [StringLength(30)]
    public string? TestInstId { get; set; }

    [Column("test_fac_id")]
    public int? TestFacId { get; set; }

    [Column("result_typ_flag")]
    [StringLength(1)]
    public string? ResultTypFlag { get; set; }

    [Column("hl7_test_val")]
    [StringLength(255)]
    public string? Hl7TestVal { get; set; }

    [Column("test_cmt")]
    public string? TestCmt { get; set; }

    [Column("status_cmt")]
    [StringLength(1)]
    public string? StatusCmt { get; set; }

    [Column("hl7_range")]
    [StringLength(20)]
    public string? Hl7Range { get; set; }

    [Column("hl7_uom")]
    [StringLength(10)]
    public string? Hl7Uom { get; set; }

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

    [Column("hl7_result_status")]
    [StringLength(2)]
    public string? Hl7ResultStatus { get; set; }

    [Column("release_ind")]
    [StringLength(1)]
    public string? ReleaseInd { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Column("hl7_result_alt_id")]
    [StringLength(30)]
    public string? Hl7ResultAltId { get; set; }

    [Column("hl7_producer_id")]
    [StringLength(60)]
    public string? Hl7ProducerId { get; set; }
}
