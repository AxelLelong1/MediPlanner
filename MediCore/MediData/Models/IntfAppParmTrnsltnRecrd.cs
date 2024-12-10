using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmTransltnId", "IntfAppParmTransltnRcrdId")]
[Table("intf_app_parm_trnsltn_recrd")]
public partial class IntfAppParmTrnsltnRecrd
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_rcrd_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnRcrdId { get; set; } = null!;

    [Column("intf_app_parm_seg_id")]
    [StringLength(10)]
    public string IntfAppParmSegId { get; set; } = null!;

    [Column("repeating_ind")]
    [StringLength(1)]
    public string RepeatingInd { get; set; } = null!;

    [Column("xml_path")]
    [StringLength(1024)]
    public string? XmlPath { get; set; }

    [Column("seg_occurence")]
    public int? SegOccurence { get; set; }

    [Column("intf_app_parm_evnt_id")]
    [StringLength(10)]
    public string? IntfAppParmEvntId { get; set; }

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

    [ForeignKey("IntfAppParmId, IntfAppParmSegId")]
    [InverseProperty("IntfAppParmTrnsltnRecrd")]
    public virtual IntfAppParmSeg IntfAppParmSeg { get; set; } = null!;

    [ForeignKey("IntfAppParmId, IntfAppParmTransltnId")]
    [InverseProperty("IntfAppParmTrnsltnRecrd")]
    public virtual IntfAppParmTrnsltn IntfAppParmTrnsltn { get; set; } = null!;

    [InverseProperty("IntfAppParmTrnsltnRecrd")]
    public virtual ICollection<IntfAppParmTrnsltnFld> IntfAppParmTrnsltnFld { get; set; } = new List<IntfAppParmTrnsltnFld>();
}
