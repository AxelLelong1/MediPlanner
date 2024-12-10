using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimLocationMo
{
    [StringLength(44)]
    public string? Country { get; set; }

    [StringLength(30)]
    public string? State { get; set; }

    [StringLength(30)]
    public string? City { get; set; }

    [StringLength(30)]
    public string? County { get; set; }

    [StringLength(10)]
    public string? PostalCode { get; set; }
}
