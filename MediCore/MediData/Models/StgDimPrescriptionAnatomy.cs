using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPrescriptionAnatomy")]
public partial class StgDimPrescriptionAnatomy
{
    public long PrescriptionAnatomySer { get; set; }
}
