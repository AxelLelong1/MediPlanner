using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("user_defined_demgr")]
[Index("DemgrTyp", "DemgrDesc", Name = "nc1_user_defined_demgr", IsUnique = true)]
public partial class UserDefinedDemgr
{
    [Key]
    [Column("defined_demgr_id")]
    public int DefinedDemgrId { get; set; }

    [Column("demgr_typ")]
    public int DemgrTyp { get; set; }

    [Column("demgr_desc")]
    [StringLength(64)]
    public string DemgrDesc { get; set; } = null!;

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("base_table_name")]
    [StringLength(64)]
    public string? BaseTableName { get; set; }

    [Column("base_table_id")]
    public int? BaseTableId { get; set; }

    [Column("default_ind")]
    [StringLength(1)]
    public string? DefaultInd { get; set; }

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

    [Column("revision_no")]
    public int RevisionNo { get; set; }

    [Column("intf_map_cd")]
    [StringLength(10)]
    public string? IntfMapCd { get; set; }

    [InverseProperty("DefinedDemgr")]
    public virtual ICollection<OptionalEthnicity> OptionalEthnicity { get; set; } = new List<OptionalEthnicity>();
}
