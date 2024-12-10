using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InstPoDetailId", "InstPoId")]
[Table("inst_po_detail")]
public partial class InstPoDetail
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("inst_po_detail_id")]
    public int InstPoDetailId { get; set; }

    [Key]
    [Column("inst_po_id")]
    public int InstPoId { get; set; }

    [Column("po_detail_desc")]
    [StringLength(40)]
    public string? PoDetailDesc { get; set; }

    [Column("po_detail_seq_no")]
    public int? PoDetailSeqNo { get; set; }

    [Column("fav_po_detail_ind")]
    [StringLength(1)]
    public string? FavPoDetailInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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

    [ForeignKey("InstId, InstPoId")]
    [InverseProperty("InstPoDetail")]
    public virtual InstPo InstPo { get; set; } = null!;
}
