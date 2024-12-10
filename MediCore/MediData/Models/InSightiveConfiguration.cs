using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("InSightiveConfiguration", Schema = "DWH")]
public partial class InSightiveConfiguration
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(64)]
    public string? Key { get; set; }

    [StringLength(1024)]
    public string? KeyValue { get; set; }
}
