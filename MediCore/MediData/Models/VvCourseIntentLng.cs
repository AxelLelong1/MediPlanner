using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvCourseIntentLng
{
    [StringLength(64)]
    public string LookupValue { get; set; } = null!;

    [StringLength(64)]
    public string? Expression1 { get; set; }
}
