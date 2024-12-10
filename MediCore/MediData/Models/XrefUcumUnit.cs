using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("UcumId", "Uom")]
[Table("xref_ucum_unit")]
public partial class XrefUcumUnit
{
    [Key]
    [Column("ucum_id")]
    public int UcumId { get; set; }

    [Key]
    [Column("uom")]
    public int Uom { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("UcumId")]
    [InverseProperty("XrefUcumUnit")]
    public virtual Ucum Ucum { get; set; } = null!;

    [ForeignKey("Uom")]
    [InverseProperty("XrefUcumUnit")]
    public virtual UnitOfMeas UomNavigation { get; set; } = null!;
}
