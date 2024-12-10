using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("db_text_select")]
public partial class DbTextSelect
{
    [Column("db_text_select")]
    public string? DbTextSelect1 { get; set; }
}
