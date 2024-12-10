using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvImageRadiation
{
    public long ImageSer { get; set; }

    public long? RadiationSer { get; set; }

    public int ReferenceImage { get; set; }

    [StringLength(254)]
    public string? SliceCharacteristics { get; set; }
}
