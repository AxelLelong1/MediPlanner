using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FamHxId", "RevisionNo")]
[Table("pt_fam_hx_mh")]
public partial class PtFamHxMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("fam_hx_id")]
    public int FamHxId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("fam_reltn_typ")]
    public int FamReltnTyp { get; set; }

    [Column("seq_no")]
    public int? SeqNo { get; set; }

    [Column("fam_mbr_name")]
    [StringLength(50)]
    public string? FamMbrName { get; set; }

    [Column("alive_ind")]
    [StringLength(1)]
    public string? AliveInd { get; set; }

    [Column("age_at_death")]
    public int? AgeAtDeath { get; set; }

    [Column("fam_mbr_dob", TypeName = "datetime")]
    public DateTime? FamMbrDob { get; set; }

    [Column("fam_mbr_cmt")]
    [StringLength(255)]
    public string? FamMbrCmt { get; set; }

    [Column("fam_mbr_prob_desc")]
    public string? FamMbrProbDesc { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

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
}
