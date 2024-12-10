using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TpName", "TpVersNo", "SpsrStkhId")]
[Table("tp_spsr")]
public partial class TpSpsr
{
    [Key]
    [Column("tp_name")]
    [StringLength(20)]
    public string TpName { get; set; } = null!;

    [Key]
    [Column("tp_vers_no")]
    [StringLength(10)]
    public string TpVersNo { get; set; } = null!;

    [Key]
    [Column("spsr_stkh_id")]
    [StringLength(20)]
    public string SpsrStkhId { get; set; } = null!;

    [Column("ct_spsr_typ")]
    public int? CtSpsrTyp { get; set; }

    [Column("ct_id")]
    [StringLength(25)]
    public string? CtId { get; set; }

    [Column("ct_spsr_cd")]
    [StringLength(1)]
    public string? CtSpsrCd { get; set; }

    [Column("funding_status_cd")]
    [StringLength(1)]
    public string? FundingStatusCd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("spsr_cmt")]
    [StringLength(255)]
    public string? SpsrCmt { get; set; }

    [Column("active_entry_ind")]
    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }

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

    [Column("primary_spsr_ind")]
    [StringLength(1)]
    public string? PrimarySpsrInd { get; set; }
}
