using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IntfAppParmId", "IntfAppParmTransltnId")]
[Table("intf_app_parm_trnsltn_xml")]
public partial class IntfAppParmTrnsltnXml
{
    [Key]
    [Column("intf_app_parm_id")]
    [StringLength(10)]
    public string IntfAppParmId { get; set; } = null!;

    [Key]
    [Column("intf_app_parm_transltn_id")]
    [StringLength(10)]
    public string IntfAppParmTransltnId { get; set; } = null!;

    [Column("xml_dfn")]
    public string? XmlDfn { get; set; }

    [Column("xml_validator")]
    public string? XmlValidator { get; set; }

    [Column("sending_system_xpath")]
    [StringLength(1024)]
    public string? SendingSystemXpath { get; set; }

    [Column("receiving_system_xpath")]
    [StringLength(1024)]
    public string? ReceivingSystemXpath { get; set; }

    [Column("evnt_typ_xpath")]
    [StringLength(1024)]
    public string? EvntTypXpath { get; set; }

    [Column("intf_app_parm_evnt_id")]
    [StringLength(10)]
    public string? IntfAppParmEvntId { get; set; }

    [Column("xml_defn_typ")]
    [StringLength(1)]
    public string? XmlDefnTyp { get; set; }

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

    [ForeignKey("IntfAppParmId, IntfAppParmEvntId")]
    [InverseProperty("IntfAppParmTrnsltnXml")]
    public virtual IntfAppParmEvnt? IntfAppParmEvnt { get; set; }

    [ForeignKey("IntfAppParmId, IntfAppParmTransltnId")]
    [InverseProperty("IntfAppParmTrnsltnXml")]
    public virtual IntfAppParmTrnsltn IntfAppParmTrnsltn { get; set; } = null!;
}
