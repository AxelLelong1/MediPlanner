using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "RuleId", "RuleIdDesc", "CompTyp", "CompSeqNo")]
[Table("rule_comp")]
public partial class RuleComp
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("rule_id")]
    public int RuleId { get; set; }

    [Key]
    [Column("rule_id_desc")]
    [StringLength(40)]
    public string RuleIdDesc { get; set; } = null!;

    [Key]
    [Column("comp_typ")]
    [StringLength(1)]
    public string CompTyp { get; set; } = null!;

    [Key]
    [Column("comp_seq_no")]
    public int CompSeqNo { get; set; }

    [Column("comp_proc_order")]
    public int? CompProcOrder { get; set; }

    [Column("conj")]
    [StringLength(3)]
    public string? Conj { get; set; }

    [Column("and_or_order")]
    public int? AndOrOrder { get; set; }

    [Column("cf", TypeName = "numeric(5, 2)")]
    public decimal? Cf { get; set; }

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

    [ForeignKey("InstId, RuleId, RuleIdDesc")]
    [InverseProperty("RuleComp")]
    public virtual RuleBody RuleBody { get; set; } = null!;
}
