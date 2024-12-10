using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("imp_hx_mast")]
public partial class ImpHxMast
{
    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Column("imp_date", TypeName = "datetime")]
    public DateTime ImpDate { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("imp_file_name")]
    [StringLength(60)]
    public string ImpFileName { get; set; } = null!;

    [Column("file_create_date", TypeName = "datetime")]
    public DateTime FileCreateDate { get; set; }

    [Column("file_create_by")]
    [StringLength(50)]
    public string FileCreateBy { get; set; } = null!;

    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("ImpHxMast")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [InverseProperty("SeqNoNavigation")]
    public virtual ICollection<ImpHxPt> ImpHxPt { get; set; } = new List<ImpHxPt>();

    [InverseProperty("SeqNoNavigation")]
    public virtual ICollection<ImpHxTp> ImpHxTp { get; set; } = new List<ImpHxTp>();
}
