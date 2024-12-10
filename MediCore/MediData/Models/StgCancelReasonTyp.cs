using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_cancel_reason_typ", Schema = "DWH")]
public partial class StgCancelReasonTyp
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("cancel_reason_typ")]
    public int? CancelReasonTyp { get; set; }
}
