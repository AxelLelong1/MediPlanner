using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ext_drug_db_log")]
public partial class ExtDrugDbLog
{
    [Key]
    [Column("ext_drug_db_log_id")]
    public int ExtDrugDbLogId { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("userid")]
    [StringLength(255)]
    public string Userid { get; set; } = null!;

    [Column("user_inst_id")]
    [StringLength(30)]
    public string UserInstId { get; set; } = null!;

    [Column("prescriber_userid")]
    [StringLength(255)]
    public string? PrescriberUserid { get; set; }

    [Column("prescriber_user_inst_id")]
    [StringLength(30)]
    public string? PrescriberUserInstId { get; set; }

    [Column("init_ind")]
    [StringLength(1)]
    public string InitInd { get; set; } = null!;

    [Column("init_tstamp", TypeName = "datetime")]
    public DateTime InitTstamp { get; set; }

    [Column("expiry_ind")]
    [StringLength(1)]
    public string? ExpiryInd { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

    [Column("init_msg")]
    [StringLength(500)]
    public string? InitMsg { get; set; }

    [Column("app_cd")]
    [StringLength(10)]
    public string? AppCd { get; set; }

    [Column("ext_drug_db_id")]
    public int? ExtDrugDbId { get; set; }

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

    [ForeignKey("ExtDrugDbId")]
    [InverseProperty("ExtDrugDbLog")]
    public virtual ExtDrugDb? ExtDrugDb { get; set; }

    [ForeignKey("InstId")]
    [InverseProperty("ExtDrugDbLog")]
    public virtual Inst Inst { get; set; } = null!;

    [ForeignKey("UserInstId, Userid")]
    [InverseProperty("ExtDrugDbLogUserid1")]
    public virtual Userid Userid1 { get; set; } = null!;

    [ForeignKey("PrescriberUserInstId, PrescriberUserid")]
    [InverseProperty("ExtDrugDbLogUseridNavigation")]
    public virtual Userid? UseridNavigation { get; set; }
}
