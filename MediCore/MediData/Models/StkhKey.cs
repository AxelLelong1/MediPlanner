using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("StkhId", "StkhKeyId")]
[Table("stkh_key")]
[Index("UpperKeyValue", Name = "nc1_stkh_key")]
public partial class StkhKey
{
    [Key]
    [Column("stkh_id")]
    [StringLength(20)]
    public string StkhId { get; set; } = null!;

    [Key]
    [Column("stkh_key_id")]
    public int StkhKeyId { get; set; }

    [Column("stkh_key_cd")]
    public int StkhKeyCd { get; set; }

    [Column("role_typ")]
    public int RoleTyp { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    [Column("key_value")]
    [StringLength(30)]
    public string KeyValue { get; set; } = null!;

    [Column("key_value_unformat")]
    [StringLength(30)]
    public string KeyValueUnformat { get; set; } = null!;

    [Column("upper_key_value")]
    [StringLength(30)]
    public string UpperKeyValue { get; set; } = null!;

    [Column("cur_value_ind")]
    [StringLength(1)]
    public string CurValueInd { get; set; } = null!;

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string ValidEntryInd { get; set; } = null!;

    [Column("eff_date", TypeName = "datetime")]
    public DateTime EffDate { get; set; }

    [Column("expiry_date", TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

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

    [ForeignKey("StkhId")]
    [InverseProperty("StkhKey")]
    public virtual Stkh Stkh { get; set; } = null!;

    [ForeignKey("StkhKeyCd")]
    [InverseProperty("StkhKey")]
    public virtual StkhKeyCd StkhKeyCdNavigation { get; set; } = null!;
}
