using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("admn_route_bill")]
public partial class AdmnRouteBill
{
    [Key]
    [Column("admn_route_bill_id")]
    public int AdmnRouteBillId { get; set; }

    [Column("admn_route")]
    public int AdmnRoute { get; set; }

    [Column("infusion_typ")]
    public int? InfusionTyp { get; set; }

    [Column("bill_cd")]
    [StringLength(30)]
    public string BillCd { get; set; } = null!;

    [Column("bill_cd_typ_id")]
    public int BillCdTypId { get; set; }

    [Column("agt_cls_bill_typ")]
    public int? AgtClsBillTyp { get; set; }

    [Column("init_cd_prty")]
    public int? InitCdPrty { get; set; }

    [Column("start_dur")]
    public int? StartDur { get; set; }

    [Column("end_dur")]
    public int? EndDur { get; set; }

    [Column("unit_dur")]
    public int? UnitDur { get; set; }

    [Column("min_dur")]
    public int? MinDur { get; set; }

    [Column("max_units_per_day")]
    public int? MaxUnitsPerDay { get; set; }

    [Column("time_based_bill_ind")]
    [StringLength(1)]
    public string? TimeBasedBillInd { get; set; }

    [Column("concur_cd")]
    [StringLength(1)]
    public string? ConcurCd { get; set; }

    [Column("partly_non_concur_ind")]
    [StringLength(1)]
    public string? PartlyNonConcurInd { get; set; }

    [Column("bill_route_grp")]
    [StringLength(15)]
    public string? BillRouteGrp { get; set; }

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
}
