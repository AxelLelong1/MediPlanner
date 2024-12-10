using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtOptionId", "OptionSeqNo")]
[Table("pt_option_comp")]
public partial class PtOptionComp
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_option_id")]
    public int PtOptionId { get; set; }

    [Key]
    [Column("option_seq_no")]
    public int OptionSeqNo { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("rule_id")]
    public int RuleId { get; set; }

    [Column("rule_id_desc")]
    [StringLength(40)]
    public string RuleIdDesc { get; set; } = null!;

    [Column("comp_typ")]
    [StringLength(1)]
    public string CompTyp { get; set; } = null!;

    [Column("comp_seq_no")]
    public int CompSeqNo { get; set; }

    [Column("comp_status")]
    public int? CompStatus { get; set; }

    [Column("conflict_pref")]
    [StringLength(1)]
    public string? ConflictPref { get; set; }

    [Column("error_status")]
    public int? ErrorStatus { get; set; }

    [Column("priority", TypeName = "numeric(5, 2)")]
    public decimal? Priority { get; set; }

    [Column("obj_typ")]
    public int? ObjTyp { get; set; }

    [Column("obj_attr_typ")]
    public int? ObjAttrTyp { get; set; }

    [Column("obj_id")]
    public int? ObjId { get; set; }

    [Column("comp_obj")]
    [StringLength(50)]
    public string? CompObj { get; set; }

    [Column("comp_obj_id_1")]
    public int? CompObjId1 { get; set; }

    [Column("comp_obj_id_2")]
    public int? CompObjId2 { get; set; }

    [Column("comp_obj_desc")]
    [StringLength(100)]
    public string? CompObjDesc { get; set; }

    [Column("comp_attr")]
    [StringLength(50)]
    public string? CompAttr { get; set; }

    [Column("action")]
    [StringLength(20)]
    public string? Action { get; set; }

    [Column("comp_oper")]
    public int? CompOper { get; set; }

    [Column("comp_value")]
    [StringLength(100)]
    public string? CompValue { get; set; }

    [Column("comp_value_typ")]
    public int? CompValueTyp { get; set; }

    [Column("uom")]
    public int? Uom { get; set; }

    [Column("which_value")]
    public int? WhichValue { get; set; }

    [Column("how_occurs")]
    public int? HowOccurs { get; set; }

    [Column("cnt_inst_1")]
    public int? CntInst1 { get; set; }

    [Column("cnt_inst_2")]
    public int? CntInst2 { get; set; }

    [Column("ref_prd")]
    public int? RefPrd { get; set; }

    [Column("ref_prd_unit")]
    public int? RefPrdUnit { get; set; }

    [Column("ref_prd_1")]
    public int? RefPrd1 { get; set; }

    [Column("ref_prd_2", TypeName = "numeric(11, 4)")]
    public decimal? RefPrd2 { get; set; }

    [Column("dur_amt", TypeName = "numeric(11, 4)")]
    public decimal? DurAmt { get; set; }

    [Column("dur_unit")]
    public int? DurUnit { get; set; }

    [Column("ref_rgm")]
    [StringLength(30)]
    public string? RefRgm { get; set; }

    [Column("ref_rgm_no")]
    public int? RefRgmNo { get; set; }

    [Column("comp_desc")]
    public string? CompDesc { get; set; }

    [Column("rx_dose", TypeName = "numeric(11, 4)")]
    public decimal? RxDose { get; set; }

    [Column("short_desc")]
    public string? ShortDesc { get; set; }

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

    [Column("ref_prd_day")]
    public int? RefPrdDay { get; set; }

    [Column("dur_day")]
    public int? DurDay { get; set; }

    [Column("pln_dose", TypeName = "numeric(11, 4)")]
    public decimal? PlnDose { get; set; }

    [Column("baseline_dose", TypeName = "numeric(11, 4)")]
    public decimal? BaselineDose { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("criteria_type")]
    public int? CriteriaType { get; set; }

    [Column("criteria_value1")]
    [StringLength(255)]
    public string? CriteriaValue1 { get; set; }

    [Column("criteria_value2")]
    [StringLength(255)]
    public string? CriteriaValue2 { get; set; }

    [Column("criteria_value3")]
    [StringLength(255)]
    public string? CriteriaValue3 { get; set; }

    [Column("criteria_value4")]
    [StringLength(255)]
    public string? CriteriaValue4 { get; set; }

    [ForeignKey("PtId, PtOptionId")]
    [InverseProperty("PtOptionComp")]
    public virtual PtOption PtOption { get; set; } = null!;
}
