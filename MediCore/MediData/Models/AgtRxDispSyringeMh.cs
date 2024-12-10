using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SyringeId", "SyringeSeqNo", "RevisionNo")]
[Table("agt_rx_disp_syringe_mh")]
public partial class AgtRxDispSyringeMh
{
    [Key]
    [Column("syringe_id")]
    public int SyringeId { get; set; }

    [Key]
    [Column("syringe_seq_no")]
    public int SyringeSeqNo { get; set; }

    [Column("syringe_vol", TypeName = "numeric(11, 4)")]
    public decimal SyringeVol { get; set; }

    [Column("syringe_vol_uom")]
    public int SyringeVolUom { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

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
    [StringLength(10)]
    public string? PlacerOrderNo { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }
}
