using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("OptxLblTblId", "ColumnName")]
[Table("lbl_form_col_det")]
public partial class LblFormColDet
{
    [Key]
    [Column("optx_lbl_tbl_id")]
    [StringLength(30)]
    public string OptxLblTblId { get; set; } = null!;

    [Key]
    [Column("column_name")]
    [StringLength(40)]
    public string ColumnName { get; set; } = null!;

    [Column("column_desc")]
    [StringLength(50)]
    public string ColumnDesc { get; set; } = null!;

    [Column("column_typ")]
    [StringLength(20)]
    public string ColumnTyp { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
