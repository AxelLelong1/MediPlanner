using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "PtIvTherapyId", "PtIvAbsorbId")]
[Table("pt_iv_absorption")]
public partial class PtIvAbsorption
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("pt_iv_therapy_id")]
    public int PtIvTherapyId { get; set; }

    [Key]
    [Column("pt_iv_absorb_id")]
    public int PtIvAbsorbId { get; set; }

    [Column("establish_tstamp", TypeName = "datetime")]
    public DateTime EstablishTstamp { get; set; }

    [Column("establish_seq")]
    public int EstablishSeq { get; set; }

    [Column("establish_amount")]
    public int EstablishAmount { get; set; }

    [Column("absorb_tstamp", TypeName = "datetime")]
    public DateTime? AbsorbTstamp { get; set; }

    [Column("absorb_amount")]
    public int? AbsorbAmount { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string ApprInd { get; set; } = null!;

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

    [ForeignKey("PtId, PtVisitId, PtIvTherapyId")]
    [InverseProperty("PtIvAbsorption")]
    public virtual PtIvTherapy PtIvTherapy { get; set; } = null!;
}
