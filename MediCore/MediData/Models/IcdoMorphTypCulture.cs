using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class IcdoMorphTypCulture
{
    [Column("icdo_morph_typ")]
    public int IcdoMorphTyp { get; set; }

    [Column("icdo_morph_desc")]
    [StringLength(200)]
    public string? IcdoMorphDesc { get; set; }

    [Column("culture_cd")]
    [StringLength(10)]
    public string CultureCd { get; set; } = null!;
}
