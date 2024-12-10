using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetPrimaryOncologist14days
{
    public long? RankNumber { get; set; }

    public long PatientSer { get; set; }

    [StringLength(64)]
    public string? LastName { get; set; }

    [StringLength(64)]
    public string? AliasName { get; set; }
}
