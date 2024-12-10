using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("plcy_typ")]
public partial class PlcyTyp
{
    [Key]
    [Column("plcy_typ_id")]
    public int PlcyTypId { get; set; }

    [Column("plcy_typ_desc")]
    [StringLength(25)]
    public string PlcyTypDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [InverseProperty("PlcyTyp")]
    public virtual ICollection<FinancialIns> FinancialIns { get; set; } = new List<FinancialIns>();

    [InverseProperty("PlcyTyp")]
    public virtual ICollection<InstPlcyTyp> InstPlcyTyp { get; set; } = new List<InstPlcyTyp>();
}
