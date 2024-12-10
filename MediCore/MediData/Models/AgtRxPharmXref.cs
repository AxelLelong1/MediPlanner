using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "AgtRxPharmId", "AdmnId")]
[Table("agt_rx_pharm_xref")]
public partial class AgtRxPharmXref
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("agt_rx_pharm_id")]
    public int AgtRxPharmId { get; set; }

    [Key]
    [Column("admn_id")]
    public int AdmnId { get; set; }

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

    [Column("admn_seq_no")]
    public int? AdmnSeqNo { get; set; }

    [Column("expected_date_time", TypeName = "datetime")]
    public DateTime? ExpectedDateTime { get; set; }

    [Column("total_doses")]
    public int? TotalDoses { get; set; }

    [ForeignKey("PtId, AgtRxPharmId")]
    [InverseProperty("AgtRxPharmXref")]
    public virtual AgtRxPharm AgtRxPharm { get; set; } = null!;
}
