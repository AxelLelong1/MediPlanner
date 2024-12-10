using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class PatEdHstryRelevance
{
    [Key]
    public long PatEdHstryRelevanceSer { get; set; }

    [StringLength(30)]
    public string TableName { get; set; } = null!;

    [StringLength(64)]
    public string AttribName { get; set; } = null!;

    [StringLength(1)]
    public string? AfterTreatInd { get; set; }

    [StringLength(1)]
    public string? AfterApproveInd { get; set; }

    public int AttribRelevanceInd { get; set; }

    public int RowRelevanceInd { get; set; }

    public int OnInsInd { get; set; }

    public int OnUpdInd { get; set; }

    public int OnDelInd { get; set; }
}
