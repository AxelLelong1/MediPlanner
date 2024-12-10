using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtInfectionCtrlId")]
[Table("pt_infection_ctrl")]
public partial class PtInfectionCtrl
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_infection_ctrl_id")]
    public int PtInfectionCtrlId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("infection_ctrl_typ_id")]
    public int? InfectionCtrlTypId { get; set; }

    [Column("infection_desc")]
    public string? InfectionDesc { get; set; }

    [Column("isolation_date_to", TypeName = "datetime")]
    public DateTime? IsolationDateTo { get; set; }

    [Column("isolation_date_from", TypeName = "datetime")]
    public DateTime? IsolationDateFrom { get; set; }

    [Column("active_date", TypeName = "datetime")]
    public DateTime? ActiveDate { get; set; }

    [Column("inactive_date", TypeName = "datetime")]
    public DateTime? InactiveDate { get; set; }

    [Column("isolation_ind")]
    [StringLength(1)]
    public string? IsolationInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

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

    [Column("revision_no")]
    public int? RevisionNo { get; set; }
}
