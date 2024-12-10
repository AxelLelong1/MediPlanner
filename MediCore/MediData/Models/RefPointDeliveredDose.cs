using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class RefPointDeliveredDose
{
    public long RefPointSer { get; set; }

    public double? TotDeliveredDose { get; set; }
}
