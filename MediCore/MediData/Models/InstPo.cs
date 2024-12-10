using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "InstPoId")]
[Table("inst_po")]
public partial class InstPo
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("inst_po_id")]
    public int InstPoId { get; set; }

    [Column("po_typ")]
    public int? PoTyp { get; set; }

    [Column("po_desc")]
    [StringLength(255)]
    public string? PoDesc { get; set; }

    [Column("po_cat")]
    [StringLength(40)]
    public string? PoCat { get; set; }

    [Column("po_seq_no")]
    public int? PoSeqNo { get; set; }

    [Column("fav_po_ind")]
    [StringLength(1)]
    public string? FavPoInd { get; set; }

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

    [Column("po_desc_txt")]
    public string? PoDescTxt { get; set; }

    [Column("inst_po_detail_ind")]
    [StringLength(1)]
    public string? InstPoDetailInd { get; set; }

    [Column("inst_po_arra_ind")]
    [StringLength(1)]
    public string? InstPoArraInd { get; set; }

    [InverseProperty("InstPo")]
    public virtual ICollection<InstPoDetail> InstPoDetail { get; set; } = new List<InstPoDetail>();

    [InverseProperty("InstPo")]
    public virtual ICollection<InstPoSheet> InstPoSheet { get; set; } = new List<InstPoSheet>();
}
