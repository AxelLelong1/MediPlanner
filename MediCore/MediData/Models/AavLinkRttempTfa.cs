using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class AavLinkRttempTfa
{
    [Column("SPID")]
    public long Spid { get; set; }

    public long? AddOnSer { get; set; }

    [StringLength(16)]
    public string? AddOnId { get; set; }

    public long? SlotSer { get; set; }

    public long? SlotNo { get; set; }
}
