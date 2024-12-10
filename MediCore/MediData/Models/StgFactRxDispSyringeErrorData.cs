using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactRxDispSyringeErrorData", Schema = "DWH")]
public partial class StgFactRxDispSyringeErrorData
{
    [Column("syringe_id")]
    public int? SyringeId { get; set; }

    [Column("syringe_seq_no")]
    public int? SyringeSeqNo { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }
}
