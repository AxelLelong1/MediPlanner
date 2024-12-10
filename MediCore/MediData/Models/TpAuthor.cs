using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "AuthorId")]
[Table("tp_author")]
public partial class TpAuthor
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("author_id")]
    public int AuthorId { get; set; }

    [Column("author_typ")]
    public int AuthorTyp { get; set; }

    [Column("author_name")]
    [StringLength(100)]
    public string? AuthorName { get; set; }

    [Column("author_seq_no")]
    public int? AuthorSeqNo { get; set; }

    [Column("author_email")]
    [StringLength(100)]
    public string? AuthorEmail { get; set; }

    [Column("author_userid")]
    [StringLength(255)]
    public string? AuthorUserid { get; set; }

    [Column("author_inst_id")]
    [StringLength(30)]
    public string? AuthorInstId { get; set; }

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

    [Column("author_cd")]
    [StringLength(1)]
    public string? AuthorCd { get; set; }

    [Column("stkh_id")]
    [StringLength(20)]
    public string? StkhId { get; set; }

    [ForeignKey("AuthorTyp")]
    [InverseProperty("TpAuthor")]
    public virtual AuthorTyp AuthorTypNavigation { get; set; } = null!;
}
