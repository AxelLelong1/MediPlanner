using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("exp_hx_mast")]
public partial class ExpHxMast
{
    [Key]
    [Column("seq_no")]
    public int SeqNo { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string AppCd { get; set; } = null!;

    [Column("exp_dest")]
    [StringLength(50)]
    public string ExpDest { get; set; } = null!;

    [Column("create_date", TypeName = "datetime")]
    public DateTime CreateDate { get; set; }

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("exp_file_name")]
    [StringLength(60)]
    public string ExpFileName { get; set; } = null!;

    [Column("decryption_pw")]
    [StringLength(16)]
    public string DecryptionPw { get; set; } = null!;

    [Column("nonaffiliate_pw")]
    [StringLength(16)]
    public string NonaffiliatePw { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("dest_inst_ind")]
    [StringLength(1)]
    public string? DestInstInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [ForeignKey("AppCd")]
    [InverseProperty("ExpHxMast")]
    public virtual App AppCdNavigation { get; set; } = null!;

    [InverseProperty("SeqNoNavigation")]
    public virtual ICollection<ExpHxPt> ExpHxPt { get; set; } = new List<ExpHxPt>();

    [InverseProperty("SeqNoNavigation")]
    public virtual ICollection<ExpHxTp> ExpHxTp { get; set; } = new List<ExpHxTp>();
}
