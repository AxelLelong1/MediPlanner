using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtVisitId", "RemSeqNo")]
[Table("rem")]
[Index("DateReq", Name = "nc1_rem")]
[Index("RcpntUserid", "RcpntUserInstId", "DateReq", Name = "nc2_rem")]
[Index("RemStatus", "CompletedInd", "RemTyp", "RemSeqNo", "PtId", "PtVisitId", "RcpntUserid", "DateReq", Name = "nc3_rem")]
[Index("RcpntUserid", "RemStatus", "CompletedInd", "DateReq", "PtId", "PtVisitId", "RemSeqNo", "RcpntUserInstId", "RemPrcsInd", Name = "nc4_rem")]
[Index("RemStatus", "RcpntUserid", "RcpntUserInstId", "DateReq", "PtId", "PtVisitId", "RemSeqNo", "RemPrcsInd", "CompletedInd", Name = "nc5_rem")]
public partial class Rem
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_visit_id")]
    public int PtVisitId { get; set; }

    [Key]
    [Column("rem_seq_no")]
    public int RemSeqNo { get; set; }

    [Column("rem_name")]
    [StringLength(30)]
    public string RemName { get; set; } = null!;

    [Column("rem_cls")]
    public int RemCls { get; set; }

    [Column("rem_typ")]
    [StringLength(1)]
    public string RemTyp { get; set; } = null!;

    [Column("rem_status")]
    [StringLength(1)]
    public string RemStatus { get; set; } = null!;

    [Column("rem_desc")]
    public string? RemDesc { get; set; }

    [Column("date_req", TypeName = "datetime")]
    public DateTime? DateReq { get; set; }

    [Column("date_completed", TypeName = "datetime")]
    public DateTime? DateCompleted { get; set; }

    [Column("req")]
    [StringLength(1)]
    public string? Req { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

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

    [Column("date_init", TypeName = "datetime")]
    public DateTime? DateInit { get; set; }

    [Column("rcpnt_userid")]
    [StringLength(255)]
    public string? RcpntUserid { get; set; }

    [Column("rcpnt_user_inst_id")]
    [StringLength(30)]
    public string? RcpntUserInstId { get; set; }

    [Column("rcpnt_discipline_typ")]
    public int? RcpntDisciplineTyp { get; set; }

    [Column("completed_ind")]
    [StringLength(1)]
    public string? CompletedInd { get; set; }

    [Column("rcpnt_inst_id")]
    [StringLength(30)]
    public string? RcpntInstId { get; set; }

    [Column("send_appr_ind")]
    [StringLength(1)]
    public string? SendApprInd { get; set; }

    [Column("rem_attach_ind")]
    [StringLength(1)]
    public string? RemAttachInd { get; set; }

    [Column("rem_prcs_ind")]
    [StringLength(1)]
    public string? RemPrcsInd { get; set; }

    [Column("pln_generated_ind")]
    [StringLength(1)]
    public string? PlnGeneratedInd { get; set; }

    [InverseProperty("Rem")]
    public virtual ICollection<RemAttach> RemAttach { get; set; } = new List<RemAttach>();

    [InverseProperty("Rem")]
    public virtual ICollection<RemRcpnt> RemRcpnt { get; set; } = new List<RemRcpnt>();
}
