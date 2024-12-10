using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class Workspace
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(32)]
    public string WorkspaceId { get; set; } = null!;

    public int VarianWorkspaceFlag { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("Workspace")]
    public virtual Resource ResourceSerNavigation { get; set; } = null!;
}
