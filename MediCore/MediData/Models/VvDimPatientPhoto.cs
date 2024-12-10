using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimPatientPhoto
{
    public long PhotoSer { get; set; }

    public long PatientSer { get; set; }

    public byte[]? Picture { get; set; }
}
