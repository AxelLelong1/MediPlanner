using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("icdo_site_typ")]
public partial class IcdoSiteTyp
{
    [Key]
    [Column("icdo_site_typ")]
    [StringLength(2)]
    public string IcdoSiteTyp1 { get; set; } = null!;

    [Column("icdo_site_desc")]
    [StringLength(100)]
    public string IcdoSiteDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("diag_file")]
    [StringLength(12)]
    public string? DiagFile { get; set; }

    [InverseProperty("IcdoSiteTypNavigation")]
    public virtual ICollection<IcdoSiteCd> IcdoSiteCd { get; set; } = new List<IcdoSiteCd>();
}
