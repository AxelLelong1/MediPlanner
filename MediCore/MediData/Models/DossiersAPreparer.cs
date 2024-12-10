using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("Dossiers_a_preparer")]
public partial class DossiersAPreparer
{
    public long PatientSer { get; set; }

    [StringLength(25)]
    public string PatientId { get; set; } = null!;

    [StringLength(64)]
    public string? FirstName { get; set; }

    [StringLength(64)]
    public string LastName { get; set; } = null!;

    [Column("début_TTT", TypeName = "datetime")]
    public DateTime? DébutTtt { get; set; }

    [Column("TemplateID")]
    [StringLength(64)]
    public string? TemplateId { get; set; }

    [StringLength(16)]
    public string MachineId { get; set; } = null!;

    [StringLength(254)]
    public string? ActivityNote { get; set; }

    public long ActivityInstanceSer { get; set; }

    [Column("statut_icon")]
    public string? StatutIcon { get; set; }

    [Column("done")]
    public int Done { get; set; }
}
