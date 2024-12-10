using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MDDF_dictQualifier")]
public partial class MddfDictQualifier
{
    [Key]
    [Column("iQualifierId")]
    public int IQualifierId { get; set; }

    [Column("iChangeTypeId")]
    public int? IChangeTypeId { get; set; }

    [Column("dDateOfChange", TypeName = "datetime")]
    public DateTime? DDateOfChange { get; set; }

    [Column("sQualifierText")]
    [StringLength(75)]
    public string? SQualifierText { get; set; }

    [Column("sQualifierAbbrev")]
    [StringLength(20)]
    public string? SQualifierAbbrev { get; set; }
}
