using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvInstituteDepartmentEnm
{
    [StringLength(50)]
    public string HospitalName { get; set; } = null!;

    public int? HospitalLocation { get; set; }

    [StringLength(4000)]
    public string? HospitalCompleteAddress { get; set; }

    [StringLength(50)]
    public string DepartmentName { get; set; } = null!;

    [Column("ctrHospitalSer")]
    public long? CtrHospitalSer { get; set; }

    [Column("ctrDepartmentSer")]
    public long? CtrDepartmentSer { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string? InstId { get; set; }

    [StringLength(10)]
    public string? HospitalTelephoneExtension { get; set; }
}
