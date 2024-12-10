using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class PtSocialHx
{
    [Column("patient_ser")]
    public long? PatientSer { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_soc_hx_id")]
    public int PtSocHxId { get; set; }

    [Column("smoking_use_cd")]
    [StringLength(1)]
    public string? SmokingUseCd { get; set; }

    [Column("smoking_yrs")]
    public int? SmokingYrs { get; set; }

    [Column("smoking_packs_per_day", TypeName = "numeric(3, 1)")]
    public decimal? SmokingPacksPerDay { get; set; }

    [Column("smoking_yrs_quit")]
    public int? SmokingYrsQuit { get; set; }

    [Column("alcohol_use_cd")]
    [StringLength(1)]
    public string? AlcoholUseCd { get; set; }

    [Column("alcohol_days_per_week")]
    public int? AlcoholDaysPerWeek { get; set; }

    [Column("alcohol_use_per_day")]
    public int? AlcoholUsePerDay { get; set; }

    [Column("alcohol_yrs_quit")]
    public int? AlcoholYrsQuit { get; set; }

    [Column("hazard_mat_contact_ind")]
    [StringLength(1)]
    public string? HazardMatContactInd { get; set; }

    [Column("pt_soc_hx_cmt")]
    [StringLength(255)]
    public string? PtSocHxCmt { get; set; }

    [Column("haz_material_desc")]
    [StringLength(255)]
    public string? HazMaterialDesc { get; set; }

    [Column("prod_use_desc")]
    [StringLength(255)]
    public string? ProdUseDesc { get; set; }

    [Column("support_desc")]
    [StringLength(255)]
    public string? SupportDesc { get; set; }

    [Column("diet_desc")]
    [StringLength(255)]
    public string? DietDesc { get; set; }

    [Column("activity_desc")]
    [StringLength(255)]
    public string? ActivityDesc { get; set; }

    [Column("smoking_desc")]
    [StringLength(255)]
    public string? SmokingDesc { get; set; }

    [Column("alcohol_desc")]
    [StringLength(100)]
    public string? AlcoholDesc { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
