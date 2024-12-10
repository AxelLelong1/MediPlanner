using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyObjectType
{
    public int ObjectType { get; set; }

    [StringLength(19)]
    [Unicode(false)]
    public string Label { get; set; } = null!;
}
