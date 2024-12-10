using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class AavLinkRttempFldAddon
{
    [Column("SPID")]
    public long Spid { get; set; }

    public long? AddOnSer { get; set; }

    public long? SlotSer { get; set; }

    public long? CacheKey { get; set; }
}
