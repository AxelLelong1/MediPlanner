using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_email")]
public partial class IntfEmail
{
    [Key]
    [Column("intf_email_id")]
    public int IntfEmailId { get; set; }

    [Column("email_incident_id")]
    public int EmailIncidentId { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string? IntfAppParmId { get; set; }

    [Column("intf_engine_id")]
    [StringLength(10)]
    public string? IntfEngineId { get; set; }

    [Column("intf_comm_id")]
    [StringLength(10)]
    public string? IntfCommId { get; set; }

    [Column("sch_seq_no")]
    public int? SchSeqNo { get; set; }

    [Column("svrty")]
    public int? Svrty { get; set; }

    [Column("intf_app_parm_seg_id")]
    [StringLength(10)]
    public string? IntfAppParmSegId { get; set; }

    [Column("intf_app_parm_evnt_id")]
    [StringLength(10)]
    public string? IntfAppParmEvntId { get; set; }

    [Column("intf_email_desc")]
    [StringLength(255)]
    public string? IntfEmailDesc { get; set; }

    [Column("header_line")]
    [StringLength(100)]
    public string? HeaderLine { get; set; }

    [Column("subject_line")]
    [StringLength(100)]
    public string? SubjectLine { get; set; }

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

    [ForeignKey("EmailIncidentId")]
    [InverseProperty("IntfEmail")]
    public virtual EmailIncidentTyp EmailIncident { get; set; } = null!;

    [InverseProperty("IntfEmail")]
    public virtual ICollection<IntfEmailMsg> IntfEmailMsg { get; set; } = new List<IntfEmailMsg>();
}
