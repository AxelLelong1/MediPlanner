using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "GyneHxId", "RevisionNo")]
[Table("pt_gyne_hx_mh")]
public partial class PtGyneHxMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("gyne_hx_id")]
    public int GyneHxId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("gravida")]
    public int? Gravida { get; set; }

    [Column("para")]
    public int? Para { get; set; }

    [Column("no_abortions")]
    public int? NoAbortions { get; set; }

    [Column("first_birth_age")]
    public int? FirstBirthAge { get; set; }

    [Column("menses_start_age")]
    public int? MensesStartAge { get; set; }

    [Column("mpause_cd")]
    [StringLength(1)]
    public string? MpauseCd { get; set; }

    [Column("mpause_age")]
    public int? MpauseAge { get; set; }

    [Column("mpause_reason_typ")]
    public int? MpauseReasonTyp { get; set; }

    [Column("mpause_reason_desc")]
    [StringLength(255)]
    public string? MpauseReasonDesc { get; set; }

    [Column("hormone_use_ind")]
    [StringLength(1)]
    public string? HormoneUseInd { get; set; }

    [Column("ocp_use_ind")]
    [StringLength(1)]
    public string? OcpUseInd { get; set; }

    [Column("ocp_use_dur")]
    public int? OcpUseDur { get; set; }

    [Column("mpause_hormone_ind")]
    [StringLength(1)]
    public string? MpauseHormoneInd { get; set; }

    [Column("mpause_hormone_dur")]
    public int? MpauseHormoneDur { get; set; }

    [Column("other_hormone_use_ind")]
    [StringLength(1)]
    public string? OtherHormoneUseInd { get; set; }

    [Column("other_hormone_dur")]
    public int? OtherHormoneDur { get; set; }

    [Column("mr_pap_date", TypeName = "datetime")]
    public DateTime? MrPapDate { get; set; }

    [Column("mr_mammogram_date", TypeName = "datetime")]
    public DateTime? MrMammogramDate { get; set; }

    [Column("gyne_detail_desc")]
    [StringLength(255)]
    public string? GyneDetailDesc { get; set; }

    [Column("hormone_desc")]
    [StringLength(255)]
    public string? HormoneDesc { get; set; }

    [Column("gyne_hx_desc")]
    public string? GyneHxDesc { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

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

    [Column("mpause_cycle")]
    public int? MpauseCycle { get; set; }

    [Column("lmp_date", TypeName = "datetime")]
    public DateTime? LmpDate { get; set; }

    [Column("mpause_desc")]
    [StringLength(255)]
    public string? MpauseDesc { get; set; }

    [Column("mr_mammogram_cmt")]
    [StringLength(255)]
    public string? MrMammogramCmt { get; set; }

    [Column("mr_pap_cmt")]
    [StringLength(255)]
    public string? MrPapCmt { get; set; }

    [Column("mr_pap_date_cd")]
    public int? MrPapDateCd { get; set; }

    [Column("mr_mammogram_date_cd")]
    public int? MrMammogramDateCd { get; set; }

    [Column("menses_desc")]
    [StringLength(255)]
    public string? MensesDesc { get; set; }

    [Column("last_tests_desc")]
    [StringLength(255)]
    public string? LastTestsDesc { get; set; }
}
