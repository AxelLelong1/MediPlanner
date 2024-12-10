using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("InitialCTDetails", Schema = "DWH")]
public partial class InitialCtdetails1
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("dbName")]
    [StringLength(32)]
    public string? DbName { get; set; }

    [Column("CurrentCTVersion")]
    public long? CurrentCtversion { get; set; }
}
