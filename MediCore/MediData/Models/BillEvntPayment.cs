using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BillEvntPmtId", "InstId")]
[Table("bill_evnt_payment")]
public partial class BillEvntPayment
{
    [Key]
    [Column("bill_evnt_pmt_id")]
    public int BillEvntPmtId { get; set; }

    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }

    [Column("bill_evnt_id")]
    public int? BillEvntId { get; set; }

    [Column("trans_id")]
    [StringLength(12)]
    public string? TransId { get; set; }

    [Column("extrnl_trans_id")]
    [StringLength(12)]
    public string? ExtrnlTransId { get; set; }

    [Column("trans_typ")]
    [StringLength(8)]
    public string? TransTyp { get; set; }

    [Column("bill_cd_typ")]
    public int? BillCdTyp { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string? BillCd { get; set; }

    [Column("bill_units")]
    public int? BillUnits { get; set; }

    [Column("unit_trans_amt", TypeName = "decimal(8, 2)")]
    public decimal? UnitTransAmt { get; set; }

    [Column("total_trans_amt", TypeName = "decimal(8, 2)")]
    public decimal? TotalTransAmt { get; set; }

    [Column("trans_desc")]
    [StringLength(40)]
    public string? TransDesc { get; set; }

    [Column("ins_plan_id")]
    [StringLength(60)]
    public string? InsPlanId { get; set; }

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
