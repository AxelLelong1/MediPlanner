using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActTransResourceSer", Schema = "DWH")]
public partial class StgDimActTransResourceSer
{
    [Column("DimActivityTransactionID")]
    public long? DimActivityTransactionId { get; set; }

    [Column("ctrScheduledActivitySer")]
    public long? CtrScheduledActivitySer { get; set; }

    [Column("ctrActivityInstanceSer")]
    public long? CtrActivityInstanceSer { get; set; }

    [Column("ctrResourceSer")]
    public long? CtrResourceSer { get; set; }
}
