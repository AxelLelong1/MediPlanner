using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stg_stkh_role_typ", Schema = "DWH")]
public partial class StgStkhRoleTyp
{
    [Column("table_name")]
    [StringLength(60)]
    public string? TableName { get; set; }

    [Column("role_typ")]
    public int? RoleTyp { get; set; }
}
