using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Hl7SeqInstId", "Hl7SeqTyp")]
[Table("hl7_seq")]
public partial class Hl7Seq
{
    [Key]
    [Column("hl7_seq_inst_id")]
    [StringLength(30)]
    public string Hl7SeqInstId { get; set; } = null!;

    [Key]
    [Column("hl7_seq_typ")]
    [StringLength(10)]
    public string Hl7SeqTyp { get; set; } = null!;

    [Column("hl7_seq_no", TypeName = "decimal(20, 0)")]
    public decimal Hl7SeqNo { get; set; }

    [Column("hl7_seq_digits")]
    public int Hl7SeqDigits { get; set; }
}
