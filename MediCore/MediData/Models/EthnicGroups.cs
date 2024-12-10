using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("ethnic_groups")]
public partial class EthnicGroups
{
    [Key]
    [Column("ethnic_group_id")]
    public int EthnicGroupId { get; set; }

    [Column("ethnic_group_desc")]
    [StringLength(40)]
    public string EthnicGroupDesc { get; set; } = null!;

    [Column("ethnic_group_cd")]
    [StringLength(6)]
    public string? EthnicGroupCd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("active_ind")]
    [StringLength(1)]
    public string? ActiveInd { get; set; }

    [Column("default_ind")]
    [StringLength(1)]
    public string? DefaultInd { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("arra_hitech_ind")]
    [StringLength(1)]
    public string? ArraHitechInd { get; set; }

    [Column("mapped_ethnic_group_id")]
    public int? MappedEthnicGroupId { get; set; }

    [Column("single_select_ind")]
    [StringLength(1)]
    public string? SingleSelectInd { get; set; }

    [InverseProperty("MappedEthnicGroup")]
    public virtual ICollection<EthnicGroups> InverseMappedEthnicGroup { get; set; } = new List<EthnicGroups>();

    [ForeignKey("MappedEthnicGroupId")]
    [InverseProperty("InverseMappedEthnicGroup")]
    public virtual EthnicGroups? MappedEthnicGroup { get; set; }

    [InverseProperty("EthnicGroup")]
    public virtual ICollection<OptionalEthnicity> OptionalEthnicity { get; set; } = new List<OptionalEthnicity>();
}
