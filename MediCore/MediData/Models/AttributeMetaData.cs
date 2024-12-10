using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("AttributeMetaData", Schema = "DWH")]
public partial class AttributeMetaData
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(64)]
    public string? DatasetName { get; set; }

    [StringLength(64)]
    public string? DatasetAttributeName { get; set; }

    [StringLength(64)]
    public string? TableAttributeName { get; set; }

    [StringLength(64)]
    public string? TableName { get; set; }

    public bool? IsRealTime { get; set; }
}
