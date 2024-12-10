using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgFactPatientSocialHistory", Schema = "DWH")]
public partial class StgFactPatientSocialHistory
{
    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("pt_soc_hx_id")]
    public int? PtSocHxId { get; set; }
}
