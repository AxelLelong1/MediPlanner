using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class AavLinkRttempMlcsegment
{
    [Column("SPID")]
    public long Spid { get; set; }

    public long? LeafNumber { get; set; }

    public short? LeftLeaf { get; set; }

    public short? RightLeaf { get; set; }
}
