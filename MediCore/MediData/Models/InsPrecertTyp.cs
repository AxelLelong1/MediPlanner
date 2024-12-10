using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ins_precert_typ")]
public partial class InsPrecertTyp
{
    [Key]
    [Column("ins_precert_typ")]
    public int InsPrecertTyp1 { get; set; }

    [Column("ins_precert_desc")]
    [StringLength(30)]
    public string InsPrecertDesc { get; set; } = null!;

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

    [InverseProperty("InsPrecertTypNavigation")]
    public virtual ICollection<InsPrecertAlertWindow> InsPrecertAlertWindow { get; set; } = new List<InsPrecertAlertWindow>();

    [InverseProperty("InsPrecertTypNavigation")]
    public virtual ICollection<InsPrecertBillCd> InsPrecertBillCd { get; set; } = new List<InsPrecertBillCd>();

    [InverseProperty("InsPrecertTypNavigation")]
    public virtual ICollection<PtInsPrecertDet> PtInsPrecertDet { get; set; } = new List<PtInsPrecertDet>();
}
