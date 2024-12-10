using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvFlatPatientDiagnosisSiteIncr
{
    [Column("patient_ser")]
    public long PatientSer { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string PtId { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DxSiteActiveStartDateTime { get; set; }

    [Column("SiteDescENU")]
    [StringLength(100)]
    public string? SiteDescEnu { get; set; }

    public long? RowNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DxSiteActiveEndDateTime { get; set; }
}
