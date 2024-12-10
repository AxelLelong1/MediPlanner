using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("FlatPatientDiagnosisSite", Schema = "DWH")]
public partial class FlatPatientDiagnosisSite
{
    [Column("ID")]
    public long Id { get; set; }

    [Column("pt_id")]
    [StringLength(20)]
    public string? PtId { get; set; }

    [Column("patient_ser")]
    public long? PatientSer { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DxSiteActiveStartDateTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DxSiteActiveEndDateTime { get; set; }

    [Column("DxSiteENU")]
    [StringLength(100)]
    public string? DxSiteEnu { get; set; }
}
