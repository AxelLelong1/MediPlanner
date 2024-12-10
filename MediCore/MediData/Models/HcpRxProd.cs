using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "HcpRxId", "ItemNo")]
[Table("hcp_rx_prod")]
public partial class HcpRxProd
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

    [Key]
    [Column("item_no")]
    public int ItemNo { get; set; }

    [Column("rx_typ")]
    public int? RxTyp { get; set; }

    [Column("hcp_inst_id")]
    [StringLength(30)]
    public string? HcpInstId { get; set; }

    [Column("hcp_id")]
    public int? HcpId { get; set; }

    [Column("hcp_name")]
    [StringLength(50)]
    public string HcpName { get; set; } = null!;

    [Column("hcp_qty")]
    public int HcpQty { get; set; }

    [Column("hcp_cmt")]
    [StringLength(255)]
    public string? HcpCmt { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("upper_hcp_name")]
    [StringLength(50)]
    public string UpperHcpName { get; set; } = null!;

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

    [ForeignKey("HcpInstId, HcpId")]
    [InverseProperty("HcpRxProd")]
    public virtual HcpName? HcpNameNavigation { get; set; }

    [ForeignKey("PtId, PtVisitId, HcpRxId")]
    [InverseProperty("HcpRxProd")]
    public virtual HcpRx HcpRx { get; set; } = null!;

    [ForeignKey("RxTyp")]
    [InverseProperty("HcpRxProd")]
    public virtual RxTyp? RxTypNavigation { get; set; }
}
