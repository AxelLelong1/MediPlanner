using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RxId", "ItemNo", "CvxCd")]
[Table("agt_rx_immun")]
public partial class AgtRxImmun
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
    [Column("cvx_cd")]
    [StringLength(30)]
    public string CvxCd { get; set; } = null!;

    [Column("date_presented", TypeName = "datetime")]
    public DateTime? DatePresented { get; set; }

    [Column("date_published", TypeName = "datetime")]
    public DateTime? DatePublished { get; set; }

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

    [ForeignKey("PtId, PtVisitId, RxId, ItemNo")]
    [InverseProperty("AgtRxImmun")]
    public virtual AgtRx AgtRx { get; set; } = null!;
}
