using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ext_drug_db")]
public partial class ExtDrugDb
{
    [Key]
    [Column("ext_drug_db_id")]
    public int ExtDrugDbId { get; set; }

    [Column("ext_drug_db_desc")]
    [StringLength(30)]
    public string ExtDrugDbDesc { get; set; } = null!;

    [Column("ext_drug_db_abbr")]
    [StringLength(10)]
    public string ExtDrugDbAbbr { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("ExtDrugDb")]
    public virtual ICollection<AdmnRouteExtDrugDb> AdmnRouteExtDrugDb { get; set; } = new List<AdmnRouteExtDrugDb>();

    [InverseProperty("ExtDrugDb")]
    public virtual ICollection<DosageFormExtDrugDb> DosageFormExtDrugDb { get; set; } = new List<DosageFormExtDrugDb>();

    [InverseProperty("ExtDrugDb")]
    public virtual ICollection<ExtDrugDbLog> ExtDrugDbLog { get; set; } = new List<ExtDrugDbLog>();

    [InverseProperty("ExtDrugDb")]
    public virtual ICollection<InstExtDrugDb> InstExtDrugDb { get; set; } = new List<InstExtDrugDb>();
}
