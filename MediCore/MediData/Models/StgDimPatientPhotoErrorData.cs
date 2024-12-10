using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimPatientPhotoErrorData", Schema = "DWH")]
public partial class StgDimPatientPhotoErrorData
{
    public long? PhotoSer { get; set; }

    public long? PatientSer { get; set; }
}
