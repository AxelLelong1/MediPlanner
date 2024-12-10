using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("lbl_form_inst")]
public partial class LblFormInst
{
    [Key]
    [Column("lbl_form_inst_seq")]
    public int LblFormInstSeq { get; set; }

    [Column("lbl_form_id")]
    [StringLength(20)]
    public string LblFormId { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("fac_inst_id")]
    [StringLength(30)]
    public string? FacInstId { get; set; }

    [Column("fac_id")]
    public int? FacId { get; set; }

    [Column("optx_lbl_id")]
    [StringLength(20)]
    public string OptxLblId { get; set; } = null!;

    [Column("print_orient")]
    [StringLength(1)]
    public string PrintOrient { get; set; } = null!;

    [Column("lbl_copies")]
    public int LblCopies { get; set; }

    [Column("barcode_typ")]
    [StringLength(20)]
    public string? BarcodeTyp { get; set; }

    [Column("barcode_font")]
    [StringLength(40)]
    public string? BarcodeFont { get; set; }

    [Column("lbl_width", TypeName = "numeric(5, 2)")]
    public decimal LblWidth { get; set; }

    [Column("lbl_height", TypeName = "numeric(5, 2)")]
    public decimal LblHeight { get; set; }

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

    [Column("lbl_pic_ind")]
    [StringLength(1)]
    public string? LblPicInd { get; set; }

    [Column("lbl_pic_file")]
    [StringLength(255)]
    public string? LblPicFile { get; set; }

    [Column("lbl_multi_lbl")]
    [StringLength(1)]
    public string? LblMultiLbl { get; set; }

    [Column("lbl_pic_height", TypeName = "numeric(5, 2)")]
    public decimal? LblPicHeight { get; set; }

    [Column("lbl_pic_width_ind")]
    [StringLength(1)]
    public string? LblPicWidthInd { get; set; }

    [Column("num_copies_ind")]
    [StringLength(1)]
    public string? NumCopiesInd { get; set; }

    [Column("cache_ind")]
    [StringLength(1)]
    public string? CacheInd { get; set; }

    [Column("lbl_pic_width")]
    public int? LblPicWidth { get; set; }

    [Column("dw_blob")]
    public byte[]? DwBlob { get; set; }

    [ForeignKey("FacInstId, FacId")]
    [InverseProperty("LblFormInst")]
    public virtual Fac? Fac { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("LblFormInst")]
    public virtual Inst? Inst { get; set; }

    [ForeignKey("LblFormId")]
    [InverseProperty("LblFormInst")]
    public virtual LblForm LblForm { get; set; } = null!;

    [ForeignKey("OptxLblId")]
    [InverseProperty("LblFormInst")]
    public virtual LblFormOptx OptxLbl { get; set; } = null!;
}
