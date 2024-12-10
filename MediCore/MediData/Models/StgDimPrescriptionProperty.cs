using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPrescriptionProperty")]
public partial class StgDimPrescriptionProperty
{
    public long PrescriptionPropertySer { get; set; }
}
