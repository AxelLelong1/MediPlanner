using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacGroupId")]
[Table("fac_group")]
public partial class FacGroup
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_group_id")]
    public int FacGroupId { get; set; }

    [Column("fac_group_name")]
    [StringLength(30)]
    public string FacGroupName { get; set; } = null!;

    [Column("billable_ind")]
    [StringLength(1)]
    public string? BillableInd { get; set; }

    [Column("group_ind")]
    [StringLength(1)]
    public string? GroupInd { get; set; }

    [Column("intf_result_prcs_ind")]
    [StringLength(1)]
    public string? IntfResultPrcsInd { get; set; }

    [Column("intf_ord_ind")]
    [StringLength(1)]
    public string? IntfOrdInd { get; set; }

    [Column("intf_label_test")]
    [StringLength(30)]
    public string? IntfLabelTest { get; set; }

    [Column("prnt_lbl_txt")]
    [StringLength(7)]
    public string? PrntLblTxt { get; set; }

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

    [Column("configured_ind")]
    [StringLength(1)]
    public string? ConfiguredInd { get; set; }

    [Column("order_reason_req_ind")]
    [StringLength(1)]
    public string? OrderReasonReqInd { get; set; }

    [Column("report_grp_ind")]
    [StringLength(1)]
    public string? ReportGrpInd { get; set; }

    [InverseProperty("FacGroup")]
    public virtual ICollection<FacGroupBill> FacGroupBill { get; set; } = new List<FacGroupBill>();

    [InverseProperty("FacGroup")]
    public virtual ICollection<FacGroupMap> FacGroupMap { get; set; } = new List<FacGroupMap>();

    [InverseProperty("FacGroup")]
    public virtual ICollection<XrefCatGroup> XrefCatGroup { get; set; } = new List<XrefCatGroup>();

    [InverseProperty("FacGroup")]
    public virtual ICollection<XrefFacGroup> XrefFacGroup { get; set; } = new List<XrefFacGroup>();
}
