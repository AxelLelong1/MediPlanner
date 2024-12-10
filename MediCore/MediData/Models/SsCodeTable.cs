using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("CodeTyp", "SsCodeVal", "InternalTyp")]
[Table("ss_code_table")]
[Index("CodeTyp", Name = "nc1_ss_code_table")]
public partial class SsCodeTable
{
    [Key]
    [Column("code_typ")]
    public int CodeTyp { get; set; }

    [Key]
    [Column("ss_code_val")]
    [StringLength(10)]
    public string SsCodeVal { get; set; } = null!;

    [Key]
    [Column("internal_typ")]
    public int InternalTyp { get; set; }

    [Column("ss_code_desc")]
    [StringLength(255)]
    public string? SsCodeDesc { get; set; }

    [Column("ss_data_tag")]
    [StringLength(40)]
    public string? SsDataTag { get; set; }

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

    [Column("radonc_internal_id")]
    public int? RadoncInternalId { get; set; }
}
