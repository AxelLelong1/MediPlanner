using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("InstId", "SeqTyp")]
[Table("inst_seq")]
public partial class InstSeq
{
    [Key]
    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Key]
    [Column("seq_typ")]
    [StringLength(20)]
    public string SeqTyp { get; set; } = null!;

    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Column("filler_1")]
    [StringLength(255)]
    public string Filler1 { get; set; } = null!;

    [Column("filler_2")]
    [StringLength(255)]
    public string Filler2 { get; set; } = null!;

    [Column("filler_3")]
    [StringLength(255)]
    public string Filler3 { get; set; } = null!;

    [Column("filler_4")]
    [StringLength(255)]
    public string Filler4 { get; set; } = null!;

    [Column("filler_5")]
    [StringLength(255)]
    public string Filler5 { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
