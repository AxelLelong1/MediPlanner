using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("contact_typ")]
public partial class ContactTyp
{
    [Key]
    [Column("contact_typ")]
    public int ContactTyp1 { get; set; }

    [Column("contact_desc")]
    [StringLength(30)]
    public string ContactDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("ContactTypNavigation")]
    public virtual ICollection<PtContact> PtContact { get; set; } = new List<PtContact>();
}
