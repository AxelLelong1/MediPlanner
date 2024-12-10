using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyLastTreatedImagedSession
{
    public long CourseSer { get; set; }

    public long SessionSer { get; set; }

    public int SessionNum { get; set; }
}
