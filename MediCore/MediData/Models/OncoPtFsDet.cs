using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "OncoPtFsDetId")]
[Table("onco_pt_fs_det")]
public partial class OncoPtFsDet
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("onco_pt_fs_det_id")]
    [StringLength(25)]
    public string OncoPtFsDetId { get; set; } = null!;

    [Column("regimen_name")]
    [StringLength(200)]
    public string? RegimenName { get; set; }

    [Column("onco_regimen_typ_cd")]
    [StringLength(2)]
    public string? OncoRegimenTypCd { get; set; }

    [Column("regimen_desc")]
    public string? RegimenDesc { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("status")]
    [StringLength(100)]
    public string? Status { get; set; }

    [Column("clinical_trial_num")]
    [StringLength(20)]
    public string? ClinicalTrialNum { get; set; }

    [Column("create_date", TypeName = "datetime")]
    public DateTime? CreateDate { get; set; }

    [Column("current_cycle")]
    [StringLength(5)]
    public string? CurrentCycle { get; set; }

    [Column("current_day")]
    public int? CurrentDay { get; set; }

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

    [InverseProperty("OncoPtFsDet")]
    public virtual ICollection<OncoPtFsCycle> OncoPtFsCycle { get; set; } = new List<OncoPtFsCycle>();

    [InverseProperty("OncoPtFsDet")]
    public virtual ICollection<OncoPtFsDrug> OncoPtFsDrug { get; set; } = new List<OncoPtFsDrug>();

    [InverseProperty("OncoPtFsDet")]
    public virtual ICollection<OncoPtFsDx> OncoPtFsDx { get; set; } = new List<OncoPtFsDx>();

    [ForeignKey("OncoRegimenTypCd")]
    [InverseProperty("OncoPtFsDet")]
    public virtual OncoRegimenTyp? OncoRegimenTypCdNavigation { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("OncoPtFsDet")]
    public virtual Pt Pt { get; set; } = null!;
}
