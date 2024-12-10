using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtCmtId")]
[Table("pt_cmt")]
public partial class PtCmt
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_cmt_id")]
    public int PtCmtId { get; set; }

    [Column("pt_cmt")]
    [StringLength(255)]
    public string PtCmt1 { get; set; } = null!;

    [Column("pt_cmt_tstamp", TypeName = "datetime")]
    public DateTime PtCmtTstamp { get; set; }

    [Column("pt_cmt_prty")]
    public int PtCmtPrty { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string ActiveEntryInd { get; set; } = null!;

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

    [Column("pt_cmt_typ")]
    public int? PtCmtTyp { get; set; }

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [ForeignKey("PtId")]
    [InverseProperty("PtCmt")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("PtCmtTyp")]
    [InverseProperty("PtCmt")]
    public virtual PtCmtTyp? PtCmtTypNavigation { get; set; }
}
