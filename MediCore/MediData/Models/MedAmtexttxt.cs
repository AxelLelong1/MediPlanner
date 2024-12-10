using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ExternalSource", "ExternalSourceCode", "TextLineSequence")]
[Table("med_amtexttxt")]
public partial class MedAmtexttxt
{
    [Key]
    [Column("external_source")]
    [StringLength(10)]
    [Unicode(false)]
    public string ExternalSource { get; set; } = null!;

    [Key]
    [Column("external_source_code")]
    [StringLength(30)]
    [Unicode(false)]
    public string ExternalSourceCode { get; set; } = null!;

    [Key]
    [Column("text_line_sequence")]
    public int TextLineSequence { get; set; }

    [Column("transaction_code")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransactionCode { get; set; }

    [Column("representative_text_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RepresentativeTextDesc { get; set; }

    [Column("reserve")]
    [StringLength(49)]
    [Unicode(false)]
    public string? Reserve { get; set; }
}
