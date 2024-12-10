using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvQmQmCriteria
{
    [Column("qm_id")]
    public int QmId { get; set; }

    [Column("qmc_id")]
    public int QmcId { get; set; }

    [Column("qm_vers_no")]
    public int? QmVersNo { get; set; }

    [Column("qm_name")]
    [StringLength(150)]
    public string QmName { get; set; } = null!;

    [Column("qm_reference")]
    [StringLength(10)]
    public string? QmReference { get; set; }

    [Column("qm_guid")]
    [StringLength(100)]
    public string? QmGuid { get; set; }

    [Column("qm_vers_neutral_guid")]
    [StringLength(100)]
    public string? QmVersNeutralGuid { get; set; }

    [Column("qm_cms_no")]
    [StringLength(10)]
    public string? QmCmsNo { get; set; }

    [Column("population_guid")]
    [StringLength(100)]
    public string? PopulationGuid { get; set; }

    [Column("numerator_guid")]
    [StringLength(100)]
    public string? NumeratorGuid { get; set; }

    [Column("denomenator_guid")]
    [StringLength(100)]
    public string? DenomenatorGuid { get; set; }

    [Column("exclusions_guid")]
    [StringLength(100)]
    public string? ExclusionsGuid { get; set; }

    [Column("exceptions_guid")]
    [StringLength(100)]
    public string? ExceptionsGuid { get; set; }
}
