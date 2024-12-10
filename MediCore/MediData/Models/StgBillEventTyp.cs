using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_bill_event_typ", Schema = "DWH")]
public partial class StgBillEventTyp
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("event_cd_typ_id")]
    public int? EventCdTypId { get; set; }
}
