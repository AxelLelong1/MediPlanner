using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvGetEnumNlslookupStrings
{
    [StringLength(15)]
    public string TableName { get; set; } = null!;

    [Column("LookupDescriptionENU")]
    [StringLength(11)]
    public string LookupDescriptionEnu { get; set; } = null!;

    [StringLength(15)]
    public string EnumLookupDesc { get; set; } = null!;
}
