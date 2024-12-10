using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CountryId", "FmtFieldName")]
[Table("country_field")]
public partial class CountryField
{
    [Key]
    [Column("country_id")]
    public int CountryId { get; set; }

    [Key]
    [Column("fmt_field_name")]
    [StringLength(40)]
    public string FmtFieldName { get; set; } = null!;

    [Column("fmt_field_lbl")]
    [StringLength(40)]
    public string? FmtFieldLbl { get; set; }

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

    [InverseProperty("CountryField")]
    public virtual ICollection<FmtField> FmtField { get; set; } = new List<FmtField>();
}
