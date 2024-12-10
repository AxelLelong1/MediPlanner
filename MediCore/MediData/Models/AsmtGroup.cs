using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("asmt_group")]
public partial class AsmtGroup
{
    [Key]
    [Column("asmt_group_name")]
    [StringLength(30)]
    public string AsmtGroupName { get; set; } = null!;

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("actual_time_req")]
    [StringLength(1)]
    public string? ActualTimeReq { get; set; }

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

    [Column("discipline_typ")]
    public int? DisciplineTyp { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("AsmtGroupNameNavigation")]
    public virtual ICollection<AsmtGroupBill> AsmtGroupBill { get; set; } = new List<AsmtGroupBill>();

    [InverseProperty("AsmtGroupNameNavigation")]
    public virtual ICollection<AsmtGroupComp> AsmtGroupComp { get; set; } = new List<AsmtGroupComp>();
}
