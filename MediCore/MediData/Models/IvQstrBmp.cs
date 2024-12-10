using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IvQstrId", "IvQstrCatId")]
[Table("iv_qstr_bmp")]
public partial class IvQstrBmp
{
    [Key]
    [Column("iv_qstr_id")]
    public int IvQstrId { get; set; }

    [Key]
    [Column("iv_qstr_cat_id")]
    public int IvQstrCatId { get; set; }

    [Column("bmp_name")]
    [StringLength(50)]
    public string BmpName { get; set; } = null!;

    [Column("bmp_height", TypeName = "numeric(11, 4)")]
    public decimal BmpHeight { get; set; }

    [Column("bmp_width", TypeName = "numeric(11, 4)")]
    public decimal BmpWidth { get; set; }

    [Column("bmp_margin", TypeName = "numeric(11, 4)")]
    public decimal BmpMargin { get; set; }

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

    [ForeignKey("IvQstrId, IvQstrCatId")]
    [InverseProperty("IvQstrBmp")]
    public virtual IvQstrCat IvQstrCat { get; set; } = null!;
}
