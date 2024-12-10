using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvPtQmresults
{
    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column("qmci_id")]
    public int QmciId { get; set; }

    [Column("qmc_id")]
    public int QmcId { get; set; }

    [Column("qmi_id")]
    public int QmiId { get; set; }

    [Column("qm_id")]
    public int QmId { get; set; }

    [Column("compliance_prd_id")]
    public int CompliancePrdId { get; set; }

    [Column("population_ind")]
    [StringLength(1)]
    public string? PopulationInd { get; set; }

    [Column("exclusion_ind")]
    [StringLength(1)]
    public string? ExclusionInd { get; set; }

    [Column("exception_ind")]
    [StringLength(1)]
    public string? ExceptionInd { get; set; }

    [Column("denominator_ind")]
    [StringLength(1)]
    public string? DenominatorInd { get; set; }

    [Column("numerator_ind")]
    [StringLength(1)]
    public string? NumeratorInd { get; set; }

    [Column("episode_of_care_ind")]
    [StringLength(1)]
    public string? EpisodeOfCareInd { get; set; }

    [Column("population_episode_count")]
    public int? PopulationEpisodeCount { get; set; }

    [Column("exclusion_episode_count")]
    public int? ExclusionEpisodeCount { get; set; }

    [Column("exception_episode_count")]
    public int? ExceptionEpisodeCount { get; set; }

    [Column("denominator_episode_count")]
    public int? DenominatorEpisodeCount { get; set; }

    [Column("numerator_episode_count")]
    public int? NumeratorEpisodeCount { get; set; }

    [Column("population_override_tstamp", TypeName = "datetime")]
    public DateTime? PopulationOverrideTstamp { get; set; }

    [Column("exclusion_override_tstamp", TypeName = "datetime")]
    public DateTime? ExclusionOverrideTstamp { get; set; }

    [Column("exception_override_tstamp", TypeName = "datetime")]
    public DateTime? ExceptionOverrideTstamp { get; set; }

    [Column("denominator_override_tstamp", TypeName = "datetime")]
    public DateTime? DenominatorOverrideTstamp { get; set; }

    [Column("numerator_override_tstamp", TypeName = "datetime")]
    public DateTime? NumeratorOverrideTstamp { get; set; }

    [Column("include_manual")]
    [StringLength(1)]
    public string IncludeManual { get; set; } = null!;

    [Column("include_population")]
    [StringLength(1)]
    public string IncludePopulation { get; set; } = null!;

    [Column("include_denominator")]
    [StringLength(1)]
    public string IncludeDenominator { get; set; } = null!;

    [Column("include_qualify")]
    [StringLength(1)]
    public string IncludeQualify { get; set; } = null!;

    [Column("include_numerator")]
    [StringLength(1)]
    public string IncludeNumerator { get; set; } = null!;

    [Column("include_exclusion")]
    [StringLength(1)]
    public string IncludeExclusion { get; set; } = null!;

    [Column("include_exception")]
    [StringLength(1)]
    public string IncludeException { get; set; } = null!;
}
