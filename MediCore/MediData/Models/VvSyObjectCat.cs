using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyObjectCat
{
    public int ObjectCat { get; set; }

    [StringLength(39)]
    [Unicode(false)]
    public string Label { get; set; } = null!;
}
