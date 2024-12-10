using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimUserProfType", Schema = "DWH")]
public partial class StgDimUserProfType
{
    [Column("prof_typ")]
    public int? ProfTyp { get; set; }
}
