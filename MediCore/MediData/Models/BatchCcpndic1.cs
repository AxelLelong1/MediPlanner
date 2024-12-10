using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("batch_ccpndic1")]
public partial class BatchCcpndic1
{
    [Column("visit_note_id")]
    public int? VisitNoteId { get; set; }

    [Column("note_tstamp", TypeName = "datetime")]
    public DateTime? NoteTstamp { get; set; }

    [Column("appr_flag")]
    [StringLength(1)]
    public string? ApprFlag { get; set; }

    [Column("override_userid")]
    [StringLength(255)]
    public string? OverrideUserid { get; set; }

    [Column("override_inst_id")]
    [StringLength(30)]
    public string? OverrideInstId { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("cur_last_name")]
    [StringLength(30)]
    public string? CurLastName { get; set; }

    [Column("pt_first_name")]
    [StringLength(30)]
    public string? PtFirstName { get; set; }

    [Column("pt_initial")]
    [StringLength(2)]
    public string? PtInitial { get; set; }

    [Column("test_pt_ind")]
    [StringLength(1)]
    public string? TestPtInd { get; set; }

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("active_visit_ind")]
    [StringLength(1)]
    public string? ActiveVisitInd { get; set; }

    [Column("pt_key_value")]
    [StringLength(25)]
    public string? PtKeyValue { get; set; }

    [Column("cur_value_ind")]
    [StringLength(1)]
    public string? CurValueInd { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

    [Column("author_first_name")]
    [StringLength(30)]
    public string? AuthorFirstName { get; set; }

    [Column("author_initial")]
    [StringLength(1)]
    public string? AuthorInitial { get; set; }

    [Column("author_last_name")]
    [StringLength(30)]
    public string? AuthorLastName { get; set; }

    [Column("author_active_entry_ind")]
    [StringLength(1)]
    public string? AuthorActiveEntryInd { get; set; }

    [Column("author_pref_ind")]
    [StringLength(1)]
    public string? AuthorPrefInd { get; set; }

    [Column("stkh_first_name")]
    [StringLength(30)]
    public string? StkhFirstName { get; set; }

    [Column("stkh_initial")]
    [StringLength(1)]
    public string? StkhInitial { get; set; }

    [Column("stkh_last_name")]
    [StringLength(30)]
    public string? StkhLastName { get; set; }

    [Column("stkh_active_entry_ind")]
    [StringLength(1)]
    public string? StkhActiveEntryInd { get; set; }

    [Column("stkh_pref_ind")]
    [StringLength(1)]
    public string? StkhPrefInd { get; set; }

    [Column("inst_pt_key_desc")]
    [StringLength(40)]
    public string? InstPtKeyDesc { get; set; }

    [Column("optx_primary_ind")]
    [StringLength(1)]
    public string? OptxPrimaryInd { get; set; }

    [Column("discipline_typ1")]
    public int? DisciplineTyp1 { get; set; }

    [Column("inst_id1")]
    [StringLength(30)]
    public string? InstId1 { get; set; }

    [Column("userid1")]
    [StringLength(255)]
    public string? Userid1 { get; set; }

    [Column("inst_name")]
    [StringLength(50)]
    public string? InstName { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }
}
