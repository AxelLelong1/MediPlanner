using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPrescriptionAnatomy", Schema = "DWH")]
public partial class StgDimPrescriptionAnatomy1
{
    public long PrescriptionAnatomySer { get; set; }
}
