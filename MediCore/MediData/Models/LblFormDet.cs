using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("LblFormId", "SeqNo")]
[Table("lbl_form_det")]
public partial class LblFormDet
{
    [Key]
    [Column("lbl_form_id")]
    [StringLength(20)]
    public string LblFormId { get; set; } = null!;

    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Column("line_no")]
    public int LineNo { get; set; }

    [Column("line_point_size")]
    [StringLength(2)]
    public string LinePointSize { get; set; } = null!;

    [Column("font_typ")]
    [StringLength(40)]
    public string? FontTyp { get; set; }

    [Column("barcode_line_ind")]
    [StringLength(1)]
    public string? BarcodeLineInd { get; set; }

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

    [Column("multi_line_ind")]
    [StringLength(1)]
    public string? MultiLineInd { get; set; }

    [Column("line_remove_ind")]
    [StringLength(1)]
    public string? LineRemoveInd { get; set; }

    [Column("align_no")]
    public int? AlignNo { get; set; }

    [ForeignKey("LblFormId")]
    [InverseProperty("LblFormDet")]
    public virtual LblForm LblForm { get; set; } = null!;

    [InverseProperty("LblFormDet")]
    public virtual ICollection<LblFormDetComp> LblFormDetComp { get; set; } = new List<LblFormDetComp>();
}
