using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimDiagnosisCodeEnm
{
    [StringLength(16)]
    public string? DiagnosisCode { get; set; }

    public int DiagnosisCodeClsSchemeId { get; set; }

    [Column("DiagnosisClinicalDescriptionENU")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionEnu { get; set; }

    [Column("DiagnosisClinicalDescriptionFRA")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionFra { get; set; }

    [Column("DiagnosisClinicalDescriptionESN")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionEsn { get; set; }

    [Column("DiagnosisClinicalDescriptionCHS")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionChs { get; set; }

    [Column("DiagnosisClinicalDescriptionDEU")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionDeu { get; set; }

    [Column("DiagnosisClinicalDescriptionITA")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionIta { get; set; }

    [Column("DiagnosisClinicalDescriptionJPN")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionJpn { get; set; }

    [Column("DiagnosisClinicalDescriptionPTB")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionPtb { get; set; }

    [Column("DiagnosisClinicalDescriptionSVE")]
    [StringLength(250)]
    public string? DiagnosisClinicalDescriptionSve { get; set; }

    [Column("DiagnosisFullTitleENU")]
    [StringLength(250)]
    public string? DiagnosisFullTitleEnu { get; set; }

    [Column("DiagnosisFullTitleFRA")]
    [StringLength(250)]
    public string? DiagnosisFullTitleFra { get; set; }

    [Column("DiagnosisFullTitleESN")]
    [StringLength(250)]
    public string? DiagnosisFullTitleEsn { get; set; }

    [Column("DiagnosisFullTitleCHS")]
    [StringLength(250)]
    public string? DiagnosisFullTitleChs { get; set; }

    [Column("DiagnosisFullTitleDEU")]
    [StringLength(250)]
    public string? DiagnosisFullTitleDeu { get; set; }

    [Column("DiagnosisFullTitleITA")]
    [StringLength(250)]
    public string? DiagnosisFullTitleIta { get; set; }

    [Column("DiagnosisFullTitleJPN")]
    [StringLength(250)]
    public string? DiagnosisFullTitleJpn { get; set; }

    [Column("DiagnosisFullTitlePTB")]
    [StringLength(250)]
    public string? DiagnosisFullTitlePtb { get; set; }

    [Column("DiagnosisFullTitleSVE")]
    [StringLength(250)]
    public string? DiagnosisFullTitleSve { get; set; }

    [Column("DiagnosisTableENU")]
    [StringLength(255)]
    public string? DiagnosisTableEnu { get; set; }

    [Column("DiagnosisTableFRA")]
    [StringLength(255)]
    public string? DiagnosisTableFra { get; set; }

    [Column("DiagnosisTableESN")]
    [StringLength(255)]
    public string? DiagnosisTableEsn { get; set; }

    [Column("DiagnosisTableCHS")]
    [StringLength(255)]
    public string? DiagnosisTableChs { get; set; }

    [Column("DiagnosisTableDEU")]
    [StringLength(255)]
    public string? DiagnosisTableDeu { get; set; }

    [Column("DiagnosisTableITA")]
    [StringLength(255)]
    public string? DiagnosisTableIta { get; set; }

    [Column("DiagnosisTableJPN")]
    [StringLength(255)]
    public string? DiagnosisTableJpn { get; set; }

    [Column("DiagnosisTablePTB")]
    [StringLength(255)]
    public string? DiagnosisTablePtb { get; set; }

    [Column("DiagnosisTableSVE")]
    [StringLength(255)]
    public string? DiagnosisTableSve { get; set; }
}
