using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimActInstTemplateLink", Schema = "DWH")]
public partial class StgDimActInstTemplateLink
{
    public long? ActivityInstanceLinkSer { get; set; }

    [StringLength(20)]
    public string? ActivityInstanceSer { get; set; }
}
