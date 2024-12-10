using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("InitialCTDetails")]
public partial class InitialCtdetails
{
    [Column("ID")]
    public int Id { get; set; }

    [Column("dbName")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DbName { get; set; }

    [Column("keyvalue")]
    [StringLength(32)]
    public string? Keyvalue { get; set; }

    [Column("CurrentCTVersion")]
    public int? CurrentCtversion { get; set; }
}
