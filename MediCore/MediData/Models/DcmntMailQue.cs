using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dcmnt_mail_que")]
[Index("PtId", "VisitNoteId", Name = "nc1_dcmnt_mail_que")]
[Index("PtId", "PtVisitId", "VisitNoteId", "PrcsIndCd", Name = "nc2_dcmnt_mail_que")]
[Index("AuthStkhId", Name = "nc3_dcmnt_mail_que")]
[Index("TransLogMtstamp", Name = "nc4_dcmnt_mail_que")]
[Index("InstId", "TransLogTstamp", Name = "nc5_dcmnt_mail_que")]
[Index("QueueTstamp", Name = "nc6_dcmnt_mail_que")]
[Index("InstId", "DcmntMailQueId", "AuthStkhId", "PtId", "PtVisitId", "VisitNoteId", Name = "nc7_dcmnt_mail_que")]
public partial class DcmntMailQue
{
    [Key]
    [Column("dcmnt_mail_que_id")]
    [StringLength(14)]
    public string DcmntMailQueId { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Column("visit_note_id")]
    public int VisitNoteId { get; set; }

    [Column("auth_stkh_id")]
    [StringLength(20)]
    public string AuthStkhId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("visit_note_txt")]
    public string? VisitNoteTxt { get; set; }

    [Column("prcs_ind_cd")]
    [StringLength(1)]
    public string? PrcsIndCd { get; set; }

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

    [Column("visit_note_begin_txt")]
    [StringLength(255)]
    public string? VisitNoteBeginTxt { get; set; }

    [Column("dcmnt_prty")]
    [StringLength(1)]
    public string? DcmntPrty { get; set; }

    [Column("send_on_appr")]
    [StringLength(1)]
    public string? SendOnAppr { get; set; }

    [Column("error_msg_ind")]
    [StringLength(1)]
    public string? ErrorMsgInd { get; set; }

    [Column("queue_tstamp", TypeName = "datetime")]
    public DateTime? QueueTstamp { get; set; }

    [InverseProperty("DcmntMailQue")]
    public virtual ICollection<DcmntMailRcpts> DcmntMailRcpts { get; set; } = new List<DcmntMailRcpts>();
}
