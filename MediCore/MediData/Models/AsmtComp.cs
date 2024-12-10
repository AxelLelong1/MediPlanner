using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("asmt_comp")]
public partial class AsmtComp
{
    [Key]
    [Column("asmt_comp_name")]
    [StringLength(30)]
    public string AsmtCompName { get; set; } = null!;

    [Column("result_meas_typ")]
    public int ResultMeasTyp { get; set; }

    [Column("status_typ")]
    public int? StatusTyp { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("min_norm", TypeName = "decimal(11, 4)")]
    public decimal? MinNorm { get; set; }

    [Column("max_norm", TypeName = "decimal(11, 4)")]
    public decimal? MaxNorm { get; set; }

    [Column("min_reason", TypeName = "decimal(11, 4)")]
    public decimal? MinReason { get; set; }

    [Column("max_reason", TypeName = "decimal(11, 4)")]
    public decimal? MaxReason { get; set; }

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("actual_time_req")]
    [StringLength(1)]
    public string? ActualTimeReq { get; set; }

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

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("grade_type")]
    public int? GradeType { get; set; }

    [Column("med_mntr_asmt_ind")]
    [StringLength(1)]
    public string? MedMntrAsmtInd { get; set; }

    [InverseProperty("AsmtCompNameNavigation")]
    public virtual ICollection<AsmtCompBill> AsmtCompBill { get; set; } = new List<AsmtCompBill>();

    [InverseProperty("AsmtCompNameNavigation")]
    public virtual ICollection<AsmtCompGrade> AsmtCompGrade { get; set; } = new List<AsmtCompGrade>();

    [InverseProperty("AsmtCompNameNavigation")]
    public virtual ICollection<AsmtGroupComp> AsmtGroupComp { get; set; } = new List<AsmtGroupComp>();

    [ForeignKey("StatusTyp")]
    [InverseProperty("AsmtComp")]
    public virtual StatusTyp? StatusTypNavigation { get; set; }

    [InverseProperty("AsmtCompNameNavigation")]
    public virtual ICollection<TpAsmt> TpAsmt { get; set; } = new List<TpAsmt>();
}
