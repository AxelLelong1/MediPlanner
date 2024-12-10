using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("MDDF_dictBaseFormulation")]
public partial class MddfDictBaseFormulation
{
    [Key]
    [Column("iBaseFormulationID")]
    public int IBaseFormulationId { get; set; }

    [Column("iChangeTypId")]
    public int? IChangeTypId { get; set; }

    [Column("dDateOfChange", TypeName = "datetime")]
    public DateTime? DDateOfChange { get; set; }

    [Column("sBaseFormulationText")]
    [StringLength(50)]
    public string? SBaseFormulationText { get; set; }

    [Column("sBaseFormulationAbbrev")]
    [StringLength(20)]
    public string? SBaseFormulationAbbrev { get; set; }
}
