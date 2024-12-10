using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("SeqTyp1", "SeqTableName")]
[Table("seq_typ")]
public partial class SeqTyp
{
    [Key]
    [Column("seq_typ")]
    [StringLength(20)]
    public string SeqTyp1 { get; set; } = null!;

    [Key]
    [Column("seq_table_name")]
    [StringLength(30)]
    public string SeqTableName { get; set; } = null!;

    [Column("data_table_name")]
    [StringLength(30)]
    public string DataTableName { get; set; } = null!;

    [Column("seq_table_column_name")]
    [StringLength(30)]
    public string SeqTableColumnName { get; set; } = null!;

    [Column("seq_typ_column_name")]
    [StringLength(30)]
    public string SeqTypColumnName { get; set; } = null!;

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
}
