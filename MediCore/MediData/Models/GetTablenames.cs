using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class GetTablenames
{
    [Column("ID")]
    public int Id { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ViewName { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? TableName { get; set; }

    public long? TableObjId { get; set; }
}
