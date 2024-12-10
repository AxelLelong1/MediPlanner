using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtFbmCaseSchId")]
[Table("pt_fbm_case_sch")]
public partial class PtFbmCaseSch
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_fbm_case_sch_id")]
    public int PtFbmCaseSchId { get; set; }

    [Column("pt_fbm_case_id")]
    public int PtFbmCaseId { get; set; }

    [Column("fbm_pgm_sch_month")]
    public int? FbmPgmSchMonth { get; set; }

    [Column("send_tstamp", TypeName = "datetime")]
    public DateTime? SendTstamp { get; set; }

    [Column("fbm_ltr_id")]
    public int FbmLtrId { get; set; }

    [Column("pt_notification_ind")]
    [StringLength(1)]
    public string? PtNotificationInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("visit_note_id")]
    public int? VisitNoteId { get; set; }

    [Column("sent_tstamp", TypeName = "datetime")]
    public DateTime? SentTstamp { get; set; }

    [Column("sent_name")]
    [StringLength(255)]
    public string? SentName { get; set; }

    [Column("sent_name_2")]
    [StringLength(255)]
    public string? SentName2 { get; set; }

    [Column("sent_address_1")]
    [StringLength(255)]
    public string? SentAddress1 { get; set; }

    [Column("sent_address_2")]
    [StringLength(255)]
    public string? SentAddress2 { get; set; }

    [Column("sent_address_3")]
    [StringLength(255)]
    public string? SentAddress3 { get; set; }

    [Column("sent_city")]
    [StringLength(255)]
    public string? SentCity { get; set; }

    [Column("sent_county")]
    [StringLength(255)]
    public string? SentCounty { get; set; }

    [Column("sent_prv_state")]
    [StringLength(255)]
    public string? SentPrvState { get; set; }

    [Column("sent_pc_zip")]
    [StringLength(255)]
    public string? SentPcZip { get; set; }

    [Column("sent_country")]
    [StringLength(255)]
    public string? SentCountry { get; set; }

    [Column("pt_fbm_case_sch_cmt")]
    public string? PtFbmCaseSchCmt { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
