using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtOptionId")]
[Table("pt_option")]
public partial class PtOption
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_option_id")]
    public int PtOptionId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("tp_name")]
    [StringLength(20)]
    public string? TpName { get; set; }

    [Column("tp_vers_no")]
    [StringLength(10)]
    public string? TpVersNo { get; set; }

    [Column("phase_seq_no")]
    public int? PhaseSeqNo { get; set; }

    [Column("date_tp_init", TypeName = "datetime")]
    public DateTime? DateTpInit { get; set; }

    [Column("rule_cls")]
    public int RuleCls { get; set; }

    [Column("option_author")]
    public int? OptionAuthor { get; set; }

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

    [Column("option_status")]
    public int? OptionStatus { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("PtOption")]
    public virtual ICollection<PtOptionComp> PtOptionComp { get; set; } = new List<PtOptionComp>();

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("PtOption")]
    public virtual PtVisit? PtVisit { get; set; }

    [InverseProperty("PtOption")]
    public virtual ICollection<XrefOptPtDose> XrefOptPtDose { get; set; } = new List<XrefOptPtDose>();
}
