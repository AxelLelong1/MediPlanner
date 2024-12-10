using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AgtRxPharmId")]
[Table("agt_rx_pharm")]
public partial class AgtRxPharm
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("agt_rx_pharm_id")]
    public int AgtRxPharmId { get; set; }

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("rx_id")]
    public int RxId { get; set; }

    [Column("item_no")]
    public int ItemNo { get; set; }

    [Column("admn_start_date", TypeName = "datetime")]
    public DateTime? AdmnStartDate { get; set; }

    [Column("admn_dur")]
    public int? AdmnDur { get; set; }

    [Column("admn_dur_unit")]
    public int? AdmnDurUnit { get; set; }

    [Column("disp_loc_id")]
    public int? DispLocId { get; set; }

    [Column("dose_level_ind")]
    [StringLength(1)]
    public string? DoseLevelInd { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("cancel_date", TypeName = "datetime")]
    public DateTime? CancelDate { get; set; }

    [Column("cancel_cmt")]
    [StringLength(255)]
    public string? CancelCmt { get; set; }

    [Column("agt_formulary_inst_id")]
    [StringLength(30)]
    public string? AgtFormularyInstId { get; set; }

    [Column("agt_formulary_id")]
    public int? AgtFormularyId { get; set; }

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

    [Column("placer_order_no")]
    [StringLength(20)]
    public string? PlacerOrderNo { get; set; }

    [Column("parent_agt_rx_pharm_id")]
    public int? ParentAgtRxPharmId { get; set; }

    [Column("intf_status")]
    [StringLength(1)]
    public string? IntfStatus { get; set; }

    [InverseProperty("AgtRxPharm")]
    public virtual ICollection<AgtRxPharmXref> AgtRxPharmXref { get; set; } = new List<AgtRxPharmXref>();

    [ForeignKey("DispLocId")]
    [InverseProperty("AgtRxPharm")]
    public virtual DispLoc? DispLoc { get; set; }
}
