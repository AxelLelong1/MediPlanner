using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AdmnId", "AdmnDetailId")]
[Table("therapy_item_admn_detail")]
public partial class TherapyItemAdmnDetail
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("admn_id")]
    public int AdmnId { get; set; }

    [Key]
    [Column("admn_detail_id")]
    public int AdmnDetailId { get; set; }

    [Column("detail_tstamp", TypeName = "datetime")]
    public DateTime DetailTstamp { get; set; }

    [Column("detail_typ")]
    public int DetailTyp { get; set; }

    [Column("detail_dose_taken", TypeName = "numeric(6, 2)")]
    public decimal? DetailDoseTaken { get; set; }

    [Column("detail_dose", TypeName = "numeric(11, 4)")]
    public decimal? DetailDose { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_userinstid")]
    [StringLength(30)]
    public string? ApprUserinstid { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [ForeignKey("PtId, AdmnId")]
    [InverseProperty("TherapyItemAdmnDetail")]
    public virtual TherapyItemAdmn TherapyItemAdmn { get; set; } = null!;
}
