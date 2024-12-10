using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimHospitalDepartment
{
    [StringLength(64)]
    public string HospitalName { get; set; } = null!;

    [StringLength(64)]
    public string HospitalLocation { get; set; } = null!;

    [StringLength(4000)]
    public string? HospitalCompleteAddress { get; set; }

    [StringLength(64)]
    public string? HospitalWebAddress { get; set; }

    [StringLength(16)]
    public string? DepartmentId { get; set; }

    [StringLength(64)]
    public string? DepartmentName { get; set; }

    [StringLength(254)]
    public string? DepartmentComment { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepartmentHstryDateTime { get; set; }

    [StringLength(255)]
    public string? DepartmentHstryUserName { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HospitalHstryDateTime { get; set; }

    [StringLength(255)]
    public string HospitalHstryUserName { get; set; } = null!;

    [Column("ctrHospitalSer")]
    public long CtrHospitalSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    public int? HospitalTelephoneExtension { get; set; }
}
