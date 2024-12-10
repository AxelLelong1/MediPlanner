using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimNationality", Schema = "DWH")]
public partial class StgDimNationality1
{
    public long? PatientSer { get; set; }
}
