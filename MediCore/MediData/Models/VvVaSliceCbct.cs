using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvVaSliceCbct
{
    public long SliceSer { get; set; }

    public long SeriesSer { get; set; }

    public long? ResourceSer { get; set; }

    [Column("DCTransferSyntaxSer")]
    public long? DctransferSyntaxSer { get; set; }

    public long? EquipmentSer { get; set; }

    [Column("SliceUID")]
    [StringLength(64)]
    public string SliceUid { get; set; } = null!;
}
