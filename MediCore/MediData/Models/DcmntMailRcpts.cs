using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("DcmntMailQueId", "DcmntMailRcptsId")]
[Table("dcmnt_mail_rcpts")]
[Index("DcmntMailRcptsId", Name = "nc1_dcmnt_mail_rcpts")]
[Index("CorspMthd", "ExternalPrcsCd", Name = "nc2_dcmnt_mail_rcpts")]
[Index("OrgStkhId", "PrcsCd", "CorspMthd", Name = "nc3_dcmnt_mail_rcpts")]
[Index("ProviderStkhId", "PrcsCd", "CorspMthd", "ExternalPrcsCd", Name = "nc4_dcmnt_mail_rcpts")]
[Index("CorspMthd", "ExternalPrcsCd", Name = "nc5_dcmnt_mail_rcpts")]
[Index("TransLogMtstamp", "CorspMthd", "ExternalPrcsCd", "PrcsCd", "DcmntMailQueId", "DcmntMailRcptsId", "OrgStkhId", "ProviderStkhId", Name = "nc7_dcmnt_mail_rcpts")]
public partial class DcmntMailRcpts
{
    [Key]
    [Column("dcmnt_mail_que_id")]
    [StringLength(14)]
    public string DcmntMailQueId { get; set; } = null!;

    [Key]
    [Column("dcmnt_mail_rcpts_id")]
    public int DcmntMailRcptsId { get; set; }

    [Column("corsp_mthd")]
    [StringLength(1)]
    public string? CorspMthd { get; set; }

    [Column("provider_stkh_id")]
    [StringLength(20)]
    public string? ProviderStkhId { get; set; }

    [Column("org_stkh_id")]
    [StringLength(20)]
    public string? OrgStkhId { get; set; }

    [Column("prcs_cd")]
    [StringLength(1)]
    public string? PrcsCd { get; set; }

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

    [Column("prcs_tstamp", TypeName = "datetime")]
    public DateTime? PrcsTstamp { get; set; }

    [Column("external_prcs_cd")]
    [StringLength(1)]
    public string? ExternalPrcsCd { get; set; }

    [Column("external_prcs_tstamp", TypeName = "datetime")]
    public DateTime? ExternalPrcsTstamp { get; set; }

    [Column("dcmnt_err_cd")]
    public int? DcmntErrCd { get; set; }

    [ForeignKey("DcmntMailQueId")]
    [InverseProperty("DcmntMailRcpts")]
    public virtual DcmntMailQue DcmntMailQue { get; set; } = null!;
}
