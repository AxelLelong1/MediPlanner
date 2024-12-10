using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("status_cat")]
public partial class StatusCat
{
    [Key]
    [Column("status_cat_id")]
    public int StatusCatId { get; set; }

    [Column("status_cat_desc")]
    [StringLength(40)]
    public string StatusCatDesc { get; set; } = null!;

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

    [InverseProperty("StatusCat")]
    public virtual ICollection<StatusCatValue> StatusCatValue { get; set; } = new List<StatusCatValue>();
}
