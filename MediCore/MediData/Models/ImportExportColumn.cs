using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("TableName", "ColumnName")]
[Index("TableName", Name = "XIE1ImportExportColumn")]
public partial class ImportExportColumn
{
    [Key]
    [StringLength(64)]
    public string TableName { get; set; } = null!;

    [Key]
    [StringLength(64)]
    public string ColumnName { get; set; } = null!;

    public int CopyOnExport { get; set; }

    public int IncludeInDuplicateCheck { get; set; }

    public int IncludeInConflictCheck { get; set; }

    [StringLength(32)]
    public string? UseInRowMatching { get; set; }

    public int RenameOnConflict { get; set; }

    [StringLength(32)]
    public string? LookupTableListSelector { get; set; }

    [StringLength(64)]
    public string? ValueOnImport { get; set; }

    [StringLength(32)]
    public string? SpecialValue { get; set; }

    [StringLength(64)]
    public string? InsertionParameterName { get; set; }

    [InverseProperty("ImportExportColumn")]
    public virtual ICollection<ImportExportReference> ImportExportReferenceImportExportColumn { get; set; } = new List<ImportExportReference>();

    [InverseProperty("ImportExportColumnNavigation")]
    public virtual ICollection<ImportExportReference> ImportExportReferenceImportExportColumnNavigation { get; set; } = new List<ImportExportReference>();

    [ForeignKey("TableName")]
    [InverseProperty("ImportExportColumn")]
    public virtual ImportExportTable TableNameNavigation { get; set; } = null!;
}
