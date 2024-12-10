using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("author_typ")]
public partial class AuthorTyp
{
    [Key]
    [Column("author_typ")]
    public int AuthorTyp1 { get; set; }

    [Column("author_desc")]
    [StringLength(30)]
    public string AuthorDesc { get; set; } = null!;

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

    [InverseProperty("AuthorTypNavigation")]
    public virtual ICollection<TpAuthor> TpAuthor { get; set; } = new List<TpAuthor>();
}
