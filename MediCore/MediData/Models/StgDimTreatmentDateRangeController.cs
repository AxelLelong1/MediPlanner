﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimTreatmentDateRangeController")]
public partial class StgDimTreatmentDateRangeController
{
    public long? TreatmentRecordSer { get; set; }
}