using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimClinic
{
    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctrclinic_id")]
    public int CtrclinicId { get; set; }

    [StringLength(50)]
    public string ClinicName { get; set; } = null!;

    [StringLength(1)]
    public string? ActiveEntryInd { get; set; }
}
