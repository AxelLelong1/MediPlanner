using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactActivityBillingErrorData_MO", Schema = "DWH")]
public partial class StgFactActivityBillingErrorDataMo
{
    [Column("bill_event_id")]
    public int? BillEventId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_visit_id")]
    public int? PtVisitId { get; set; }
}
