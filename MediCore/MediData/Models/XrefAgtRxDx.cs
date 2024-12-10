using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "ItemNo", "DxId")]
[Table("xref_agt_rx_dx")]
public partial class XrefAgtRxDx
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
    [Column("dx_id")]
    public int DxId { get; set; }

    [Column("agt_rx_dx_seq_no")]
    public int AgtRxDxSeqNo { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("send_appr_ind")]
    [StringLength(1)]
    public string SendApprInd { get; set; } = null!;

    [ForeignKey("PtId, DxId")]
    [InverseProperty("XrefAgtRxDx")]
    public virtual PtDx PtDx { get; set; } = null!;
}
