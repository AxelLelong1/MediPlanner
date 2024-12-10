using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("qrda_cat")]
public partial class QrdaCat
{
    [Key]
    [Column("qrda_cat_id")]
    public int QrdaCatId { get; set; }

    [Column("qrda_cat_cd")]
    [StringLength(10)]
    public string QrdaCatCd { get; set; } = null!;

    [Column("qrda_cat_desc")]
    [StringLength(100)]
    public string QrdaCatDesc { get; set; } = null!;

    [Column("qrda_cat_oid")]
    [StringLength(255)]
    public string QrdaCatOid { get; set; } = null!;

    [Column("parent_cat_oid")]
    [StringLength(255)]
    public string? ParentCatOid { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

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

    [InverseProperty("QrdaCat")]
    public virtual ICollection<PtQmDetail> PtQmDetail { get; set; } = new List<PtQmDetail>();
}
