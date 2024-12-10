using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("PtId", "PtNameId")]
[Table("pt_name")]
[Index("PtLastNameSdx", Name = "nc1_pt_name")]
[Index("UpperLastName", Name = "nc2_pt_name")]
public partial class PtName
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Key]
    [Column("pt_name_id")]
    public int PtNameId { get; set; }

    [Column("first_name")]
    [StringLength(30)]
    public string FirstName { get; set; } = null!;

    [Column("middle_name")]
    [StringLength(30)]
    public string? MiddleName { get; set; }

    [Column("last_name")]
    [StringLength(30)]
    public string LastName { get; set; } = null!;

    [Column("name_cd")]
    [StringLength(1)]
    public string NameCd { get; set; } = null!;

    [Column("stkh_cd")]
    [StringLength(1)]
    public string? StkhCd { get; set; }

    [Column("cur_entry_ind")]
    [StringLength(1)]
    public string? CurEntryInd { get; set; }

    [Column("valid_entry_ind")]
    [StringLength(1)]
    public string? ValidEntryInd { get; set; }

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_muserid")]
    [StringLength(255)]
    public string? TransLogMuserid { get; set; }

    [Column("trans_log_mtstamp", TypeName = "datetime")]
    public DateTime? TransLogMtstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_log_minst_id")]
    [StringLength(30)]
    public string? TransLogMinstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [Column("upper_last_name")]
    [StringLength(30)]
    public string? UpperLastName { get; set; }

    [Column("pt_last_name_sdx")]
    [StringLength(6)]
    public string? PtLastNameSdx { get; set; }

    [Column("pt_first_name_sdx")]
    [StringLength(6)]
    public string? PtFirstNameSdx { get; set; }

    [Column("name_suffix")]
    [StringLength(16)]
    public string? NameSuffix { get; set; }

    [ForeignKey("NameCd, StkhCd")]
    [InverseProperty("PtName")]
    public virtual NameCd? NameCdNavigation { get; set; }
}
