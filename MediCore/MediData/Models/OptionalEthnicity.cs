using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("optional_ethnicity")]
public partial class OptionalEthnicity
{
    [Key]
    [Column("optional_ethnicity_id")]
    public int OptionalEthnicityId { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("ethnic_group_id")]
    public int? EthnicGroupId { get; set; }

    [Column("defined_demgr_id")]
    public int? DefinedDemgrId { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string TransLogMuserid { get; set; } = null!;

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [ForeignKey("DefinedDemgrId")]
    [InverseProperty("OptionalEthnicity")]
    public virtual UserDefinedDemgr? DefinedDemgr { get; set; }

    [ForeignKey("EthnicGroupId")]
    [InverseProperty("OptionalEthnicity")]
    public virtual EthnicGroups? EthnicGroup { get; set; }
}
