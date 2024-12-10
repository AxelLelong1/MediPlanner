using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmTransltnId")]
[Table("intf_app_parm_trnsltn")]
public partial class IntfAppParmTrnsltn
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnId { get; set; } = null!;

    [Column("transltn_typ")]
    [StringLength(15)]
    public string? TransltnTyp { get; set; }

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

    [ForeignKey("IntfAppParmId")]
    [InverseProperty("IntfAppParmTrnsltn")]
    public virtual IntfAppParm IntfAppParm { get; set; } = null!;

    [InverseProperty("IntfAppParmTrnsltn")]
    public virtual ICollection<IntfAppParmTrnsltnRecrd> IntfAppParmTrnsltnRecrd { get; set; } = new List<IntfAppParmTrnsltnRecrd>();

    [InverseProperty("IntfAppParmTrnsltn")]
    public virtual IntfAppParmTrnsltnXml? IntfAppParmTrnsltnXml { get; set; }
}
