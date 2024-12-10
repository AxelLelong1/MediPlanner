using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("db_time_select")]
public partial class DbTimeSelect
{
    [Key]
    [Column("db_time_select")]
    [StringLength(255)]
    public string DbTimeSelect1 { get; set; } = null!;
}
