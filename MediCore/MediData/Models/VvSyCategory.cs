using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyCategory
{
    public int EventCat { get; set; }

    [StringLength(21)]
    [Unicode(false)]
    public string Label { get; set; } = null!;
}
