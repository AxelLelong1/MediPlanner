using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("optional_demgr")]
public partial class OptionalDemgr
{
    [Key]
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("race")]
    [StringLength(64)]
    public string? Race { get; set; }

    [Column("ethnic_group")]
    [StringLength(64)]
    public string? EthnicGroup { get; set; }

    [Column("marital_status")]
    [StringLength(1)]
    public string? MaritalStatus { get; set; }

    [Column("occupation")]
    [StringLength(30)]
    public string? Occupation { get; set; }

    [Column("educational_level")]
    [StringLength(30)]
    public string? EducationalLevel { get; set; }

    [Column("present_empr_name")]
    [StringLength(30)]
    public string? PresentEmprName { get; set; }

    [Column("mom_full_name")]
    [StringLength(30)]
    public string? MomFullName { get; set; }

    [Column("fathers_full_name")]
    [StringLength(30)]
    public string? FathersFullName { get; set; }

    [Column("ethnic_group_id")]
    public int? EthnicGroupId { get; set; }

    [Column("religion_id")]
    public int? ReligionId { get; set; }

    [Column("language")]
    [StringLength(64)]
    public string? Language { get; set; }

    [Column("mom_maiden_name")]
    [StringLength(30)]
    public string? MomMaidenName { get; set; }

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

    [Column("hlth_care_dpoa")]
    [StringLength(1)]
    public string? HlthCareDpoa { get; set; }

    [Column("dnr_status")]
    [StringLength(1)]
    public string? DnrStatus { get; set; }

    [Column("dnh_status")]
    [StringLength(1)]
    public string? DnhStatus { get; set; }

    [Column("living_will")]
    [StringLength(1)]
    public string? LivingWill { get; set; }

    [Column("autopsy_rqst")]
    [StringLength(1)]
    public string? AutopsyRqst { get; set; }

    [Column("feeding_rstr")]
    [StringLength(1)]
    public string? FeedingRstr { get; set; }

    [Column("organ_donor")]
    [StringLength(1)]
    public string? OrganDonor { get; set; }

    [Column("birth_place")]
    [StringLength(30)]
    public string? BirthPlace { get; set; }

    [Column("med_rstr")]
    [StringLength(1)]
    public string? MedRstr { get; set; }

    [Column("tx_rstr")]
    [StringLength(1)]
    public string? TxRstr { get; set; }

    [Column("language_cd")]
    [StringLength(3)]
    public string? LanguageCd { get; set; }

    [Column("race_typ")]
    public int? RaceTyp { get; set; }

    [Column("gender_identity")]
    [StringLength(64)]
    public string? GenderIdentity { get; set; }

    [Column("sexual_orientation")]
    [StringLength(64)]
    public string? SexualOrientation { get; set; }
}
