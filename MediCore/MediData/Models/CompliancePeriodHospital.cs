using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CompliancePeriodId", "HospitalSer")]
public partial class CompliancePeriodHospital
{
    [Key]
    public int CompliancePeriodId { get; set; }

    [Key]
    public long HospitalSer { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [ForeignKey("HospitalSer")]
    [InverseProperty("CompliancePeriodHospital")]
    public virtual Hospital HospitalSerNavigation { get; set; } = null!;
}
