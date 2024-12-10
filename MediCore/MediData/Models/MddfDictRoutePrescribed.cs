using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("MDDF_dictRoutePrescribed")]
[Index("IRoutePrescribedId", Name = "pkMDDF_dictRoutePrescribed")]
public partial class MddfDictRoutePrescribed
{
    [Column("iRoutePrescribedID")]
    public int IRoutePrescribedId { get; set; }

    [Column("iChangeTypeID")]
    public int? IChangeTypeId { get; set; }

    [Column("dDateOfChange", TypeName = "datetime")]
    public DateTime? DDateOfChange { get; set; }

    [Column("sRoutePrescribedText")]
    [StringLength(70)]
    public string? SRoutePrescribedText { get; set; }

    [Column("sRoutePrescribedTextAbbrev")]
    [StringLength(30)]
    public string? SRoutePrescribedTextAbbrev { get; set; }

    [Column("sCommonTerm")]
    [StringLength(255)]
    public string? SCommonTerm { get; set; }
}
