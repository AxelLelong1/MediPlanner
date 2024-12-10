using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StatusCatId", "StatusValueId")]
[Table("status_cat_value")]
public partial class StatusCatValue
{
    [Key]
    [Column("status_cat_id")]
    public int StatusCatId { get; set; }

    [Key]
    [Column("status_value_id")]
    public int StatusValueId { get; set; }

    [Column("status_value_desc")]
    [StringLength(40)]
    public string StatusValueDesc { get; set; } = null!;

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

    [InverseProperty("StatusCatValue")]
    public virtual ICollection<PtTpIntvStatus> PtTpIntvStatus { get; set; } = new List<PtTpIntvStatus>();

    [ForeignKey("StatusCatId")]
    [InverseProperty("StatusCatValue")]
    public virtual StatusCat StatusCat { get; set; } = null!;
}
