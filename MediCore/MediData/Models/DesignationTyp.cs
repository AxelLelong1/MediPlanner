using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("designation_typ")]
public partial class DesignationTyp
{
    [Key]
    [Column("designation_typ")]
    public int DesignationTyp1 { get; set; }

    [Column("designation_desc")]
    [StringLength(40)]
    public string DesignationDesc { get; set; } = null!;

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

    [InverseProperty("DesignationTypNavigation")]
    public virtual ICollection<Userid> Userid { get; set; } = new List<Userid>();
}
