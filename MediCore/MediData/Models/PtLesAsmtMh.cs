using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "LesAsmtId", "RevisionNo")]
[Table("pt_les_asmt_mh")]
public partial class PtLesAsmtMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("les_asmt_id")]
    public int LesAsmtId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_les_id")]
    public int PtLesId { get; set; }

    [Column("asmt_date", TypeName = "datetime")]
    public DateTime? AsmtDate { get; set; }

    [Column("size_x", TypeName = "decimal(4, 1)")]
    public decimal? SizeX { get; set; }

    [Column("size_y", TypeName = "decimal(4, 1)")]
    public decimal? SizeY { get; set; }

    [Column("size_z", TypeName = "decimal(4, 1)")]
    public decimal? SizeZ { get; set; }

    [Column("size_asmt")]
    [StringLength(14)]
    public string? SizeAsmt { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("asmt_source")]
    public int? AsmtSource { get; set; }

    [Column("cncr_status_id")]
    public int? CncrStatusId { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [ForeignKey("PtId, CncrStatusId")]
    [InverseProperty("PtLesAsmtMh")]
    public virtual PtCncrStatus? PtCncrStatus { get; set; }

    [ForeignKey("PtId, PtLesId")]
    [InverseProperty("PtLesAsmtMh")]
    public virtual PtLes PtLes { get; set; } = null!;
}
