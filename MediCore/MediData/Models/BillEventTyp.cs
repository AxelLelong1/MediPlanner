using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("bill_event_typ")]
public partial class BillEventTyp
{
    [Key]
    [Column("event_cd_typ_id")]
    public int EventCdTypId { get; set; }

    [Column("event_cd_typ_desc")]
    [StringLength(10)]
    public string EventCdTypDesc { get; set; } = null!;

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

    [InverseProperty("BillEventTyp")]
    public virtual ICollection<BillEvent> BillEvent { get; set; } = new List<BillEvent>();

    [InverseProperty("BillEventTyp")]
    public virtual ICollection<BillFormItem> BillFormItem { get; set; } = new List<BillFormItem>();
}
