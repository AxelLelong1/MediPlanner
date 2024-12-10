using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("hl7_field")]
[Index("MapMthdCd", Name = "nc1_hl7_field")]
public partial class Hl7Field
{
    [Key]
    [Column("field_id")]
    [StringLength(10)]
    public string FieldId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("def_typ")]
    [StringLength(1)]
    public string DefTyp { get; set; } = null!;

    [Column("item_no")]
    [StringLength(5)]
    public string ItemNo { get; set; } = null!;

    [Column("field_name")]
    [StringLength(30)]
    public string FieldName { get; set; } = null!;

    [Column("field_desc")]
    [StringLength(255)]
    public string? FieldDesc { get; set; }

    [Column("field_data_typ")]
    [StringLength(3)]
    public string FieldDataTyp { get; set; } = null!;

    [Column("vers_no")]
    [StringLength(10)]
    public string VersNo { get; set; } = null!;

    [Column("map_mthd_cd")]
    [StringLength(1)]
    public string? MapMthdCd { get; set; }

    [Column("stkh_prcs_cd")]
    [StringLength(1)]
    public string? StkhPrcsCd { get; set; }

    [Column("add_ind")]
    [StringLength(1)]
    public string AddInd { get; set; } = null!;

    [Column("pt_prcs_cd")]
    [StringLength(1)]
    public string? PtPrcsCd { get; set; }

    [Column("rule_cd")]
    [StringLength(1)]
    public string RuleCd { get; set; } = null!;

    [Column("inbnd_prcs_cd")]
    [StringLength(1)]
    public string InbndPrcsCd { get; set; } = null!;

    [Column("outbnd_prcs_cd")]
    [StringLength(1)]
    public string OutbndPrcsCd { get; set; } = null!;

    [Column("hl7_map_ind")]
    [StringLength(1)]
    public string Hl7MapInd { get; set; } = null!;

    [Column("del_ind")]
    [StringLength(1)]
    public string DelInd { get; set; } = null!;

    [Column("base_tstamp", TypeName = "datetime")]
    public DateTime BaseTstamp { get; set; }

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

    [Column("prof_reltn_ind")]
    [StringLength(1)]
    public string? ProfReltnInd { get; set; }

    [Column("stkh_cd")]
    [StringLength(1)]
    public string? StkhCd { get; set; }

    [Column("null_ind")]
    [StringLength(1)]
    public string? NullInd { get; set; }

    [ForeignKey("FieldDataTyp")]
    [InverseProperty("Hl7Field")]
    public virtual Hl7DataTyp FieldDataTypNavigation { get; set; } = null!;

    [InverseProperty("Field")]
    public virtual ICollection<Hl7FieldCompXref> Hl7FieldCompXref { get; set; } = new List<Hl7FieldCompXref>();

    [InverseProperty("Field")]
    public virtual ICollection<Hl7SegFieldXref> Hl7SegFieldXref { get; set; } = new List<Hl7SegFieldXref>();

    [ForeignKey("DefTyp, VersNo")]
    [InverseProperty("Hl7Field")]
    public virtual Hl7Vers Hl7Vers { get; set; } = null!;
}
