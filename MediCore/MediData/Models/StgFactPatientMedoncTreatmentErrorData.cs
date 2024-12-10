using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientMedoncTreatmentErrorData", Schema = "DWH")]
public partial class StgFactPatientMedoncTreatmentErrorData
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_tx_id")]
    public int? PtTxId { get; set; }
}
