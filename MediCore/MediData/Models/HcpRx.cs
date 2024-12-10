using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "HcpRxId")]
[Table("hcp_rx")]
public partial class HcpRx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("hcp_rx_id")]
    public int HcpRxId { get; set; }

    [Column("status")]
    [StringLength(1)]
    public string Status { get; set; } = null!;

    [Column("hcp_rx_cmt")]
    public string? HcpRxCmt { get; set; }

    [Column("copies_printed")]
    public int? CopiesPrinted { get; set; }

    [Column("vrbl_id")]
    public int? VrblId { get; set; }

    [Column("ord_by_userid")]
    [StringLength(255)]
    public string? OrdByUserid { get; set; }

    [Column("ord_by_inst_id")]
    [StringLength(30)]
    public string? OrdByInstId { get; set; }

    [Column("refill_ind")]
    [StringLength(1)]
    public string? RefillInd { get; set; }

    [Column("refill_qty")]
    public int? RefillQty { get; set; }

    [Column("refill_hcp_rx_id")]
    public int? RefillHcpRxId { get; set; }

    [Column("pp_int_prints")]
    public int? PpIntPrints { get; set; }

    [Column("pp_ext_prints")]
    public int? PpExtPrints { get; set; }

    [Column("appr_tstamp", TypeName = "datetime")]
    public DateTime? ApprTstamp { get; set; }

    [Column("disp_by_inst_id")]
    [StringLength(30)]
    public string? DispByInstId { get; set; }

    [Column("disp_by_userid")]
    [StringLength(255)]
    public string? DispByUserid { get; set; }

    [Column("disp_tstamp", TypeName = "datetime")]
    public DateTime? DispTstamp { get; set; }

    [Column("date_time_ord", TypeName = "datetime")]
    public DateTime? DateTimeOrd { get; set; }

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

    [Column("int_prints")]
    public int? IntPrints { get; set; }

    [InverseProperty("HcpRx")]
    public virtual ICollection<HcpRxProd> HcpRxProd { get; set; } = new List<HcpRxProd>();

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("HcpRx")]
    public virtual PtVisit PtVisit { get; set; } = null!;
}
