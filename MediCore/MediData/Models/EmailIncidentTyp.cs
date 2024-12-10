using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("email_incident_typ")]
public partial class EmailIncidentTyp
{
    [Key]
    [Column("email_incident_id")]
    public int EmailIncidentId { get; set; }

    [Column("fnctnl_area_cd")]
    [StringLength(3)]
    public string FnctnlAreaCd { get; set; } = null!;

    [Column("incident")]
    [StringLength(30)]
    public string Incident { get; set; } = null!;

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

    [ForeignKey("FnctnlAreaCd")]
    [InverseProperty("EmailIncidentTyp")]
    public virtual EmailFnctnlAreaCd FnctnlAreaCdNavigation { get; set; } = null!;

    [InverseProperty("EmailIncident")]
    public virtual ICollection<IntfEmail> IntfEmail { get; set; } = new List<IntfEmail>();
}
