using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Uom", "FcnTyp")]
[Table("xref_unit_fcn")]
public partial class XrefUnitFcn
{
    [Key]
    [Column("uom")]
    public int Uom { get; set; }

    [Key]
    [Column("fcn_typ")]
    public int FcnTyp { get; set; }

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

    [ForeignKey("Uom")]
    [InverseProperty("XrefUnitFcn")]
    public virtual UnitOfMeas UomNavigation { get; set; } = null!;
}
