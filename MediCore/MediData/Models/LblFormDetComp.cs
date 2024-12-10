using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("LblFormId", "SeqNo", "CompSeqNo")]
[Table("lbl_form_det_comp")]
public partial class LblFormDetComp
{
    [Key]
    [Column("lbl_form_id")]
    [StringLength(20)]
    public string LblFormId { get; set; } = null!;

    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Key]
    [Column("comp_seq_no")]
    public int CompSeqNo { get; set; }

    [Column("sort_order")]
    public int SortOrder { get; set; }

    [Column("data_typ")]
    [StringLength(2)]
    public string DataTyp { get; set; } = null!;

    [Column("text_data")]
    [StringLength(30)]
    public string? TextData { get; set; }

    [Column("column_name")]
    [StringLength(40)]
    public string? ColumnName { get; set; }

    [Column("column_typ")]
    [StringLength(20)]
    public string? ColumnTyp { get; set; }

    [Column("column_format")]
    [StringLength(40)]
    public string? ColumnFormat { get; set; }

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

    [ForeignKey("LblFormId, SeqNo")]
    [InverseProperty("LblFormDetComp")]
    public virtual LblFormDet LblFormDet { get; set; } = null!;
}
