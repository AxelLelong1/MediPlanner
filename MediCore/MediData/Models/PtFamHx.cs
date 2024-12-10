using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "FamHxId")]
[Table("pt_fam_hx")]
public partial class PtFamHx
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("fam_hx_id")]
    public int FamHxId { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
