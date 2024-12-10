using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class ImportExportTable
{
    [Key]
    [StringLength(64)]
    public string TableName { get; set; } = null!;

    [StringLength(64)]
    public string? PreprocessingMethodName { get; set; }

    [StringLength(64)]
    public string? PostprocessingMethodName { get; set; }

    public int CheckObjectStatusOnExport { get; set; }

    [StringLength(64)]
    public string? InsertionStoredProcedure { get; set; }

    public int ContinueIfInsertFails { get; set; }

    [InverseProperty("TableNameNavigation")]
    public virtual ICollection<ImportExportColumn> ImportExportColumn { get; set; } = new List<ImportExportColumn>();
}
