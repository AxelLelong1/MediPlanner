using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("refusal_reason")]
public partial class RefusalReason
{
    [Key]
    [Column("refusal_reason_id")]
    public int RefusalReasonId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("refusal_reason_desc")]
    [StringLength(40)]
    public string? RefusalReasonDesc { get; set; }

    [Column("hl7_refusal_reason")]
    [StringLength(3)]
    public string? Hl7RefusalReason { get; set; }

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

    [ForeignKey("BaseTyp")]
    [InverseProperty("RefusalReason")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;
}
