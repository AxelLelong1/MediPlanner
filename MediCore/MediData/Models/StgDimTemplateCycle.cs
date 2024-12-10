using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimTemplateCycle", Schema = "DWH")]
public partial class StgDimTemplateCycle
{
    public long? TemplateCycleSer { get; set; }

    public long? TemplateSer { get; set; }
}
