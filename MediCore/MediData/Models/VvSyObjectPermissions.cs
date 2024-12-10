using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvSyObjectPermissions
{
    [Column("name")]
    [StringLength(128)]
    public string Name { get; set; } = null!;

    [Column("permission_name")]
    [StringLength(128)]
    public string? PermissionName { get; set; }

    [Column("principal_name")]
    public string? PrincipalName { get; set; }
}
