using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimUserDepartment", Schema = "DWH")]
public partial class StgDimUserDepartment
{
    [Column("ctrAppUserSer")]
    public long? CtrAppUserSer { get; set; }
}
