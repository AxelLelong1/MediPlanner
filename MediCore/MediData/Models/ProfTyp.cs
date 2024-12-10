using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("prof_typ")]
public partial class ProfTyp
{
    [Key]
    [Column("prof_typ")]
    public int ProfTyp1 { get; set; }

    [Column("prof_desc")]
    [StringLength(40)]
    public string ProfDesc { get; set; } = null!;

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

    [Column("med_prof_ind")]
    [StringLength(1)]
    public string? MedProfInd { get; set; }

    [InverseProperty("ProfTypNavigation")]
    public virtual ICollection<Stkh> Stkh { get; set; } = new List<Stkh>();

    [InverseProperty("ProfTypNavigation")]
    public virtual ICollection<Userid> Userid { get; set; } = new List<Userid>();
}
