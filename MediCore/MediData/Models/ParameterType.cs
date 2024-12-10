using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ParameterType
{
    [Key]
    public long ParameterTypeSer { get; set; }

    [StringLength(64)]
    public string ParameterTypeDataType { get; set; } = null!;

    [InverseProperty("ParameterTypeSerNavigation")]
    public virtual ICollection<ReportParameter> ReportParameter { get; set; } = new List<ReportParameter>();
}
