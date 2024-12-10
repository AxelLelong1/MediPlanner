using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ReferencedTable", "ReferencedColumn", "ReferencingTable", "ReferencingColumn")]
[Index("ReferencedTable", "ReferencedColumn", Name = "XIE1ImportExportReference")]
[Index("ReferencingTable", "ReferencingColumn", Name = "XIE2ImportExportReference")]
public partial class ImportExportReference
{
    [Key]
    [StringLength(64)]
    public string ReferencedTable { get; set; } = null!;

    [Key]
    [StringLength(64)]
    public string ReferencedColumn { get; set; } = null!;

    [Key]
    [StringLength(64)]
    public string ReferencingTable { get; set; } = null!;

    [Key]
    [StringLength(64)]
    public string ReferencingColumn { get; set; } = null!;

    public int Forward { get; set; }

    public int Reverse { get; set; }

    [ForeignKey("ReferencedTable, ReferencedColumn")]
    [InverseProperty("ImportExportReferenceImportExportColumn")]
    public virtual ImportExportColumn ImportExportColumn { get; set; } = null!;

    [ForeignKey("ReferencingTable, ReferencingColumn")]
    [InverseProperty("ImportExportReferenceImportExportColumnNavigation")]
    public virtual ImportExportColumn ImportExportColumnNavigation { get; set; } = null!;
}
