using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "DoseDataId", "CompName")]
[Table("pt_dose_data")]
public partial class PtDoseData
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("dose_data_id")]
    public int DoseDataId { get; set; }

    [Key]
    [Column("comp_name")]
    [StringLength(30)]
    public string CompName { get; set; } = null!;

    [Column("date_obtained", TypeName = "datetime")]
    public DateTime? DateObtained { get; set; }

    [Column("comp_value", TypeName = "decimal(11, 4)")]
    public decimal? CompValue { get; set; }

    [Column("comp_value_alt", TypeName = "decimal(11, 4)")]
    public decimal? CompValueAlt { get; set; }

    [Column("comp_unit")]
    public int? CompUnit { get; set; }

    [Column("comp_value_typ")]
    public int? CompValueTyp { get; set; }

    [Column("alt_value_typ")]
    public int? AltValueTyp { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("used_ind")]
    [StringLength(1)]
    public string? UsedInd { get; set; }

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

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [ForeignKey("AltValueTyp")]
    [InverseProperty("PtDoseDataAltValueTypNavigation")]
    public virtual ValueTyp? AltValueTypNavigation { get; set; }

    [ForeignKey("CompValueTyp")]
    [InverseProperty("PtDoseDataCompValueTypNavigation")]
    public virtual ValueTyp? CompValueTypNavigation { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtDoseData")]
    public virtual Pt Pt { get; set; } = null!;

    [InverseProperty("PtDoseData")]
    public virtual ICollection<XrefOptPtDose> XrefOptPtDose { get; set; } = new List<XrefOptPtDose>();

    [InverseProperty("PtDoseData")]
    public virtual ICollection<XrefRxPtDose> XrefRxPtDose { get; set; } = new List<XrefRxPtDose>();
}
