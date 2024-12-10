using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("intf_sch_map")]
public partial class IntfSchMap
{
    [Key]
    [Column("intf_sch_map_id")]
    public int IntfSchMapId { get; set; }

    [Column("intf_app_parm_id")]
    [StringLength(15)]
    public string IntfAppParmId { get; set; } = null!;

    [Column("mapping_typ_cd")]
    [StringLength(1)]
    public string MappingTypCd { get; set; } = null!;

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [Column("department_ser")]
    public long? DepartmentSer { get; set; }

    [Column("loc_id")]
    public int? LocId { get; set; }

    [Column("machine_resource_ser")]
    public long? MachineResourceSer { get; set; }

    [Column("mapping_cd")]
    [StringLength(30)]
    public string MappingCd { get; set; } = null!;

    [Column("event_typ")]
    [StringLength(1)]
    public string? EventTyp { get; set; }

    [Column("activity_ser")]
    public long? ActivitySer { get; set; }

    [Column("send_ind")]
    [StringLength(1)]
    public string? SendInd { get; set; }

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
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }
}
