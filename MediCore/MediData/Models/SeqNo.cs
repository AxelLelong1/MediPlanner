using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("seq_no")]
public partial class SeqNo
{
    [Key]
    [Column("no_typ")]
    [StringLength(40)]
    public string NoTyp { get; set; } = null!;

    [Column("next_no")]
    public int NextNo { get; set; }
}
