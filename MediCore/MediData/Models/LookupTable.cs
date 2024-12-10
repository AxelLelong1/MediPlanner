using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("ListSelector", "LanguageId", "SubSelector", "LookupValue", Name = "XAKLookupTable", IsUnique = true)]
[Index("LanguageId", Name = "XIF681LookupTable")]
public partial class LookupTable
{
    [Key]
    public long LookupTableSer { get; set; }

    [StringLength(32)]
    public string ListSelector { get; set; } = null!;

    public long? SubSelector { get; set; }

    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [StringLength(64)]
    public string LookupValue { get; set; } = null!;

    [StringLength(64)]
    public string? Expression1 { get; set; }

    [StringLength(64)]
    public string? Expression2 { get; set; }

    [StringLength(64)]
    public string? Expression3 { get; set; }

    public int EditFlag { get; set; }

    public int DefaultFlag { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [InverseProperty("CtrStatusLookupTableSerNavigation")]
    public virtual ICollection<InSightiveSimplifiedActivitiesConfigurationTb> InSightiveSimplifiedActivitiesConfigurationTb { get; set; } = new List<InSightiveSimplifiedActivitiesConfigurationTb>();

    [ForeignKey("LanguageId")]
    [InverseProperty("LookupTable")]
    public virtual LanguageLookup Language { get; set; } = null!;
}
