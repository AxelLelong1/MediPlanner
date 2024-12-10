using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("crw_report_typ")]
public partial class CrwReportTyp
{
    [Key]
    [Column("report_typ")]
    public int ReportTyp { get; set; }

    [Column("report_typ_desc")]
    [StringLength(30)]
    public string ReportTypDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [InverseProperty("ReportTypNavigation")]
    public virtual ICollection<CrwReportList> CrwReportList { get; set; } = new List<CrwReportList>();
}
