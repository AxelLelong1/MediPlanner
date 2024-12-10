using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class GetPtPrimaryDateRankedDxSite
{
    [Column("rownumber")]
    public long? Rownumber { get; set; }

    [Column("ctrPatientSer")]
    public long? CtrPatientSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DxSiteDateTime { get; set; }

    [StringLength(40)]
    public string DxSite { get; set; } = null!;
}
