using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("pn_system_comp")]
public partial class PnSystemComp
{
    [Key]
    [Column("comp_id")]
    [StringLength(10)]
    public string CompId { get; set; } = null!;

    [Column("pn_sec_code")]
    [StringLength(10)]
    public string PnSecCode { get; set; } = null!;

    [Column("pn_cat_code")]
    [StringLength(10)]
    public string PnCatCode { get; set; } = null!;

    [Column("comp_code")]
    [StringLength(50)]
    public string? CompCode { get; set; }

    [Column("comp_value")]
    [StringLength(255)]
    public string? CompValue { get; set; }

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

    [Column("comp_based")]
    [StringLength(1)]
    public string? CompBased { get; set; }

    [Column("dsp_format")]
    public int? DspFormat { get; set; }

    [Column("dsp_comp")]
    public int? DspComp { get; set; }

    [Column("item_based")]
    [StringLength(1)]
    public string? ItemBased { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("toolbar_ind")]
    [StringLength(1)]
    public string? ToolbarInd { get; set; }

    [Column("pn_toolbar_fcn_typ")]
    public int? PnToolbarFcnTyp { get; set; }

    [Column("pn_comp_use_cd")]
    [StringLength(2)]
    public string? PnCompUseCd { get; set; }

    [Column("data_typ")]
    [StringLength(10)]
    public string? DataTyp { get; set; }

    [Column("dw_col_name")]
    [StringLength(80)]
    public string? DwColName { get; set; }

    [Column("dw_grp_col_names")]
    [StringLength(100)]
    public string? DwGrpColNames { get; set; }

    [Column("dw_sort_order")]
    [StringLength(100)]
    public string? DwSortOrder { get; set; }

    [Column("dw_acc_mthd")]
    [StringLength(10)]
    public string? DwAccMthd { get; set; }

    [Column("dflt_ct_id")]
    public int? DfltCtId { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("nav_ind")]
    [StringLength(1)]
    public string? NavInd { get; set; }
}
