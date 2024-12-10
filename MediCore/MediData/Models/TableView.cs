using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("table_view")]
public partial class TableView
{
    [Column("pbt_tnam")]
    [StringLength(129)]
    public string PbtTnam { get; set; } = null!;
}
