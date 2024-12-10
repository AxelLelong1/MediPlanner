using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("BatchSetupId", "BatchGroupId")]
[Table("bill_sys_batch_group")]
public partial class BillSysBatchGroup
{
    [Key]
    [Column("batch_setup_id")]
    public int BatchSetupId { get; set; }

    [Key]
    [Column("batch_group_id")]
    public int BatchGroupId { get; set; }

    [Column("batch_no")]
    [StringLength(20)]
    public string? BatchNo { get; set; }

    [Column("batch_desc")]
    [StringLength(80)]
    public string BatchDesc { get; set; } = null!;

    [Column("batch_group_order_no")]
    public int BatchGroupOrderNo { get; set; }

    [Column("bill_sys_key_1")]
    [StringLength(30)]
    public string? BillSysKey1 { get; set; }

    [Column("bill_sys_key_id_1")]
    public int? BillSysKeyId1 { get; set; }

    [Column("bill_sys_key_2")]
    [StringLength(30)]
    public string? BillSysKey2 { get; set; }

    [Column("bill_sys_key_id_2")]
    public int? BillSysKeyId2 { get; set; }

    [Column("bill_sys_key_3")]
    [StringLength(30)]
    public string? BillSysKey3 { get; set; }

    [Column("bill_sys_key_id_3")]
    public int? BillSysKeyId3 { get; set; }

    [Column("bill_sys_key_4")]
    [StringLength(30)]
    public string? BillSysKey4 { get; set; }

    [Column("bill_sys_key_id_4")]
    public int? BillSysKeyId4 { get; set; }

    [Column("bill_sys_key_5")]
    [StringLength(30)]
    public string? BillSysKey5 { get; set; }

    [Column("bill_sys_key_id_5")]
    public int? BillSysKeyId5 { get; set; }

    [Column("default_ind")]
    [StringLength(1)]
    public string? DefaultInd { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

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

    [ForeignKey("BatchSetupId")]
    [InverseProperty("BillSysBatchGroup")]
    public virtual BillSysBatchSetup BatchSetup { get; set; } = null!;

    [InverseProperty("BillSysBatchGroup")]
    public virtual ICollection<BillEvntChrgWrk> BillEvntChrgWrk { get; set; } = new List<BillEvntChrgWrk>();

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("BillSysBatchGroup")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;
}
