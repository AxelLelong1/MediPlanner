using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtTxCtId", "RevisionNo")]
[Table("pt_tx_ct_mh")]
public partial class PtTxCtMh
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_tx_ct_id")]
    public int PtTxCtId { get; set; }

    [Key]
    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("study_no")]
    [StringLength(30)]
    public string? StudyNo { get; set; }

    [Column("ord_by_stkh_id")]
    [StringLength(20)]
    public string? OrdByStkhId { get; set; }

    [Column("internal_ind")]
    [StringLength(1)]
    public string? InternalInd { get; set; }

    [Column("prov_name")]
    [StringLength(80)]
    public string? ProvName { get; set; }

    [Column("inst_name")]
    [StringLength(50)]
    public string? InstName { get; set; }

    [Column("pt_tx_id")]
    public int? PtTxId { get; set; }

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
}
