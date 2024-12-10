using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("EventTyp", "IntvName")]
[Table("intv_library")]
public partial class IntvLibrary
{
    [Key]
    [Column("event_typ")]
    [StringLength(1)]
    public string EventTyp { get; set; } = null!;

    [Key]
    [Column("intv_name")]
    [StringLength(100)]
    public string IntvName { get; set; } = null!;

    [Column("notification_req")]
    [StringLength(1)]
    public string NotificationReq { get; set; } = null!;

    [Column("notification_days")]
    public int? NotificationDays { get; set; }

    [Column("rqstn_req")]
    [StringLength(1)]
    public string RqstnReq { get; set; } = null!;

    [Column("prof_typ")]
    public int? ProfTyp { get; set; }

    [Column("actual_time_req")]
    [StringLength(1)]
    public string ActualTimeReq { get; set; } = null!;

    [Column("intv_detail_txt")]
    public string? IntvDetailTxt { get; set; }

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

    [ForeignKey("EventTyp")]
    [InverseProperty("IntvLibrary")]
    public virtual EventTyp EventTypNavigation { get; set; } = null!;

    [InverseProperty("IntvLibrary")]
    public virtual ICollection<IntvLibraryBill> IntvLibraryBill { get; set; } = new List<IntvLibraryBill>();
}
