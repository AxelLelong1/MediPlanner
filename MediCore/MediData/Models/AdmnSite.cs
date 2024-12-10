using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("admn_site")]
public partial class AdmnSite
{
    [Key]
    [Column("admn_site_id")]
    public int AdmnSiteId { get; set; }

    [Column("base_typ")]
    public int BaseTyp { get; set; }

    [Column("admn_site_desc")]
    [StringLength(40)]
    public string? AdmnSiteDesc { get; set; }

    [Column("hl7_admn_site")]
    [StringLength(4)]
    public string? Hl7AdmnSite { get; set; }

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

    [ForeignKey("BaseTyp")]
    [InverseProperty("AdmnSite")]
    public virtual BaseTyp BaseTypNavigation { get; set; } = null!;
}
