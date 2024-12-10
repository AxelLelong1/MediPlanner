using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("fac_comp_map")]
[Index("InstId", "FacId", "MappingTyp", "MappingCd", "EffDate", "TermDate", Name = "nc97_fac_comp_map")]
public partial class FacCompMap
{
    [Key]
    [Column("fac_comp_seq")]
    public int FacCompSeq { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("fac_id")]
    public int FacId { get; set; }

    [Column("fac_comp_id")]
    public int FacCompId { get; set; }

    [Column("typ_of_test")]
    [StringLength(20)]
    public string? TypOfTest { get; set; }

    [Column("comp_name")]
    [StringLength(30)]
    public string? CompName { get; set; }

    [Column("mapping_typ")]
    [StringLength(2)]
    public string? MappingTyp { get; set; }

    [Column("mapping_cd")]
    [StringLength(30)]
    public string? MappingCd { get; set; }

    [Column("eff_date", TypeName = "datetime")]
    public DateTime? EffDate { get; set; }

    [Column("term_date", TypeName = "datetime")]
    public DateTime? TermDate { get; set; }

    [Column("spec_typ")]
    public int? SpecTyp { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("InstId, FacId, FacCompId")]
    [InverseProperty("FacCompMap")]
    public virtual FacComp FacComp { get; set; } = null!;
}
