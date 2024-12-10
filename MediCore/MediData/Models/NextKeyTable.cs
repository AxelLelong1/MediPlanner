using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class NextKeyTable
{
    [Key]
    [StringLength(64)]
    public string KeyName { get; set; } = null!;

    public long KeyValue { get; set; }
}
