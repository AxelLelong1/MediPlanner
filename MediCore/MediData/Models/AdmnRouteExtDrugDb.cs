using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("AdmnRoute", "ExtDrugDbId")]
[Table("admn_route_ext_drug_db")]
public partial class AdmnRouteExtDrugDb
{
    [Key]
    [Column("admn_route")]
    public int AdmnRoute { get; set; }

    [Key]
    [Column("ext_drug_db_id")]
    public int ExtDrugDbId { get; set; }

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

    [ForeignKey("AdmnRoute")]
    [InverseProperty("AdmnRouteExtDrugDb")]
    public virtual AdmnRoute AdmnRouteNavigation { get; set; } = null!;

    [ForeignKey("ExtDrugDbId")]
    [InverseProperty("AdmnRouteExtDrugDb")]
    public virtual ExtDrugDb ExtDrugDb { get; set; } = null!;
}
