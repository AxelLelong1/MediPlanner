using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("title_typ")]
public partial class TitleTyp
{
    [Key]
    [Column("title_id")]
    public int TitleId { get; set; }

    [Column("title_desc")]
    [StringLength(10)]
    public string TitleDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("TitleTypNavigation")]
    public virtual ICollection<Pt> Pt { get; set; } = new List<Pt>();

    [InverseProperty("UserTitle")]
    public virtual ICollection<Userid> Userid { get; set; } = new List<Userid>();
}
