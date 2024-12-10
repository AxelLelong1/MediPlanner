using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "FacId", "FacCompId")]
[Table("fac_comp")]
[Index("TypOfTest", "CompName", Name = "nc1_fac_comp")]
[Index("FacId", "AppendResultInd", Name = "nc2_fac_comp")]
public partial class FacComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("fac_id")]
    public int FacId { get; set; }

    [Key]
    [Column("fac_comp_id")]
    public int FacCompId { get; set; }

    [Column("typ_of_test")]
    [StringLength(20)]
    public string? TypOfTest { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Column("fac_typ_of_test")]
    [StringLength(30)]
    public string? FacTypOfTest { get; set; }

    [Column("fac_comp_name")]
    [StringLength(30)]
    public string? FacCompName { get; set; }

    [Column("fac_comp_order_no")]
    public int? FacCompOrderNo { get; set; }

    [Column("intf_ord_ind")]
    [StringLength(1)]
    public string? IntfOrdInd { get; set; }

    [Column("intf_result_prcs_ind")]
    [StringLength(1)]
    public string? IntfResultPrcsInd { get; set; }

    [Column("intf_label_test")]
    [StringLength(30)]
    public string? IntfLabelTest { get; set; }

    [Column("prnt_lbl_txt")]
    [StringLength(7)]
    public string? PrntLblTxt { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }

    [Column("multi_result_ind")]
    [StringLength(1)]
    public string? MultiResultInd { get; set; }

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

    [Column("append_result_ind")]
    [StringLength(1)]
    public string? AppendResultInd { get; set; }

    [Column("configured_ind")]
    [StringLength(1)]
    public string? ConfiguredInd { get; set; }

    [Column("intf_merge_cmt_ind")]
    [StringLength(1)]
    public string? IntfMergeCmtInd { get; set; }

    [Column("image_ind")]
    [StringLength(1)]
    public string? ImageInd { get; set; }

    [InverseProperty("FacComp")]
    public virtual ICollection<FacCalibration> FacCalibration { get; set; } = new List<FacCalibration>();

    [InverseProperty("FacComp")]
    public virtual ICollection<FacCompMap> FacCompMap { get; set; } = new List<FacCompMap>();

    [InverseProperty("FacComp")]
    public virtual ICollection<FacCompVal> FacCompVal { get; set; } = new List<FacCompVal>();

    [InverseProperty("FacComp")]
    public virtual ICollection<XrefFacGroup> XrefFacGroup { get; set; } = new List<XrefFacGroup>();
}
