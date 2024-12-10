using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "CncrStatusId", "RevisionNo")]
[Table("pt_cncr_status_mh")]
public partial class PtCncrStatusMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("cncr_status_id")]
    public int CncrStatusId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("pt_dx_id")]
    public int? PtDxId { get; set; }

    [Column("asmt_date", TypeName = "datetime")]
    public DateTime? AsmtDate { get; set; }

    [Column("ds_author")]
    public int? DsAuthor { get; set; }

    [Column("ds_eff_date", TypeName = "datetime")]
    public DateTime? DsEffDate { get; set; }

    [Column("dx_status")]
    public int? DxStatus { get; set; }

    [Column("appr_ind")]
    [StringLength(1)]
    public string? ApprInd { get; set; }

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

    [Column("pt_tx_id")]
    public int? PtTxId { get; set; }

    [Column("resp_label_typ")]
    public int? RespLabelTyp { get; set; }

    [Column("asmt_date_cd")]
    public int? AsmtDateCd { get; set; }

    [Column("err_rsn_txt")]
    [StringLength(255)]
    public string? ErrRsnTxt { get; set; }

    [ForeignKey("PtId, PtDxId")]
    [InverseProperty("PtCncrStatusMh")]
    public virtual PtDxCncr? PtDxCncr { get; set; }
}
