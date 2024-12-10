using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TableName", "LookupTyp", "CultureCd")]
[Table("lookup_typ_culture")]
public partial class LookupTypCulture
{
    [Key]
    [Column("table_name")]
    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [Key]
    [Column("lookup_typ")]
    public int LookupTyp { get; set; }

    [Key]
    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;

    [Column("lookup_desc")]
    [StringLength(255)]
    public string LookupDesc { get; set; } = null!;

    [Column("lookup_desc_en")]
    [StringLength(255)]
    public string LookupDescEn { get; set; } = null!;

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

    [Column("seq_no")]
    public int? SeqNo { get; set; }
}
