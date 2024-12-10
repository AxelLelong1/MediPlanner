using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("temp_agt")]
public partial class TempAgt
{
    [Key]
    [Column("drug_desc_id")]
    [StringLength(6)]
    public string DrugDescId { get; set; } = null!;

    [Column("agt_name")]
    [StringLength(40)]
    public string? AgtName { get; set; }

    [Column("gpi")]
    [StringLength(14)]
    public string? Gpi { get; set; }

    [Column("upper_agt_name")]
    [StringLength(40)]
    public string? UpperAgtName { get; set; }
}
