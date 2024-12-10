using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Rxaui1", "Rxaui2", "Rui")]
[Table("RXNREL")]
[Index("Rxcui1", Name = "nc1_RXNREL")]
[Index("Rxcui2", Name = "nc2_RXNREL")]
[Index("Rela", Name = "nc3_RXNREL")]
public partial class Rxnrel
{
    [Column("RXCUI1")]
    [StringLength(8)]
    public string? Rxcui1 { get; set; }

    [Key]
    [Column("RXAUI1")]
    [StringLength(8)]
    public string Rxaui1 { get; set; } = null!;

    [Column("STYPE1")]
    [StringLength(50)]
    public string? Stype1 { get; set; }

    [Column("REL")]
    [StringLength(4)]
    public string? Rel { get; set; }

    [Column("RXCUI2")]
    [StringLength(8)]
    public string? Rxcui2 { get; set; }

    [Key]
    [Column("RXAUI2")]
    [StringLength(8)]
    public string Rxaui2 { get; set; } = null!;

    [Column("STYPE2")]
    [StringLength(50)]
    public string? Stype2 { get; set; }

    [Column("RELA")]
    [StringLength(100)]
    public string? Rela { get; set; }

    [Key]
    [Column("RUI")]
    [StringLength(10)]
    public string Rui { get; set; } = null!;

    [Column("SRUI")]
    [StringLength(50)]
    public string? Srui { get; set; }

    [Column("SAB")]
    [StringLength(20)]
    public string Sab { get; set; } = null!;

    [Column("SL")]
    [StringLength(1000)]
    public string? Sl { get; set; }

    [Column("DIR")]
    [StringLength(1)]
    public string? Dir { get; set; }

    [Column("RG")]
    [StringLength(10)]
    public string? Rg { get; set; }

    [Column("SUPPRESS")]
    [StringLength(1)]
    public string? Suppress { get; set; }

    [Column("CVF")]
    [StringLength(50)]
    public string? Cvf { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
