using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ProductId", "AgtFormularyInstId", "AgtFormularyId")]
[Table("product_formulary_agt_xref")]
public partial class ProductFormularyAgtXref
{
    [Key]
    [Column("product_id")]
    public int ProductId { get; set; }

    [Key]
    [Column("agt_formulary_inst_id")]
    [StringLength(30)]
    public string AgtFormularyInstId { get; set; } = null!;

    [Key]
    [Column("agt_formulary_id")]
    public int AgtFormularyId { get; set; }

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
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string TransLogMinstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("AgtFormularyInstId, AgtFormularyId")]
    [InverseProperty("ProductFormularyAgtXref")]
    public virtual AgtFormulary AgtFormulary { get; set; } = null!;

    [ForeignKey("ProductId")]
    [InverseProperty("ProductFormularyAgtXref")]
    public virtual Product Product { get; set; } = null!;
}
