using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtInfoRequestId")]
[Table("pt_info_request")]
public partial class PtInfoRequest
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_info_request_id")]
    public int PtInfoRequestId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("request_typ")]
    public int RequestTyp { get; set; }

    [Column("request_date", TypeName = "datetime")]
    public DateTime RequestDate { get; set; }

    [Column("delivery_method_requested_typ")]
    public int DeliveryMethodRequestedTyp { get; set; }

    [Column("delivery_method_actual_typ")]
    public int? DeliveryMethodActualTyp { get; set; }

    [Column("date_completed", TypeName = "datetime")]
    public DateTime? DateCompleted { get; set; }

    [Column("info_request_start_date", TypeName = "datetime")]
    public DateTime? InfoRequestStartDate { get; set; }

    [Column("info_request_end_date", TypeName = "datetime")]
    public DateTime? InfoRequestEndDate { get; set; }

    [Column("prov_userid")]
    [StringLength(255)]
    public string? ProvUserid { get; set; }

    [Column("prov_inst_id")]
    [StringLength(30)]
    public string? ProvInstId { get; set; }

    [Column("request_cmt")]
    [StringLength(255)]
    public string? RequestCmt { get; set; }

    [Column("status_cd")]
    [StringLength(1)]
    public string StatusCd { get; set; } = null!;

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("authorized_ind")]
    [StringLength(1)]
    public string AuthorizedInd { get; set; } = null!;

    [Column("authorized_inst_id")]
    [StringLength(30)]
    public string? AuthorizedInstId { get; set; }

    [Column("authorized_userid")]
    [StringLength(255)]
    public string? AuthorizedUserid { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("PtInfoRequest")]
    public virtual App? AppCdNavigation { get; set; }

    [ForeignKey("DeliveryMethodActualTyp")]
    [InverseProperty("PtInfoRequestDeliveryMethodActualTypNavigation")]
    public virtual BaseTyp? DeliveryMethodActualTypNavigation { get; set; }

    [ForeignKey("DeliveryMethodRequestedTyp")]
    [InverseProperty("PtInfoRequestDeliveryMethodRequestedTypNavigation")]
    public virtual BaseTyp DeliveryMethodRequestedTypNavigation { get; set; } = null!;

    [ForeignKey("InstId")]
    [InverseProperty("PtInfoRequest")]
    public virtual Inst Inst { get; set; } = null!;

    [ForeignKey("PtId")]
    [InverseProperty("PtInfoRequest")]
    public virtual Pt Pt { get; set; } = null!;

    [ForeignKey("PtId, PtVisitId")]
    [InverseProperty("PtInfoRequest")]
    public virtual PtVisit? PtVisit { get; set; }

    [ForeignKey("RequestTyp")]
    [InverseProperty("PtInfoRequest")]
    public virtual BaseClsTyp RequestTypNavigation { get; set; } = null!;

    [ForeignKey("AuthorizedInstId, AuthorizedUserid")]
    [InverseProperty("PtInfoRequestUserid")]
    public virtual Userid? Userid { get; set; }

    [ForeignKey("ProvInstId, ProvUserid")]
    [InverseProperty("PtInfoRequestUseridNavigation")]
    public virtual Userid? UseridNavigation { get; set; }
}
