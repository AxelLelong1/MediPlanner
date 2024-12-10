using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "ItemNo", "AgtLevelId")]
[Table("therapy_item_admn_agt_level")]
public partial class TherapyItemAdmnAgtLevel
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("rx_id")]
    public int RxId { get; set; }

    [Key]
    [Column("item_no")]
    public int ItemNo { get; set; }

    [Key]
    [Column("agt_level_id")]
    public int AgtLevelId { get; set; }

    [Column("agt_level_seq_no")]
    public int? AgtLevelSeqNo { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("no_doses_taken")]
    public int? NoDosesTaken { get; set; }

    [Column("dose", TypeName = "numeric(11, 4)")]
    public decimal? Dose { get; set; }

    [Column("dose_uom")]
    public int? DoseUom { get; set; }

    [Column("dose_rec_cmt")]
    public string? DoseRecCmt { get; set; }

    [Column("how_recorded")]
    public int? HowRecorded { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("appr_userid")]
    [StringLength(255)]
    public string? ApprUserid { get; set; }

    [Column("appr_inst_id")]
    [StringLength(30)]
    public string? ApprInstId { get; set; }

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

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [ForeignKey("PtId, PtVisitId, RxId, ItemNo")]
    [InverseProperty("TherapyItemAdmnAgtLevel")]
    public virtual AgtRx AgtRx { get; set; } = null!;
}
