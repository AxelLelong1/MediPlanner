using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DepartmentSer", Name = "XIF462DepartmentPttrnDetails")]
public partial class DepartmentPttrnDetails
{
    [Key]
    public long DeptPttrnDetailSer { get; set; }

    public long? DepartmentSer { get; set; }

    public int? PatternDayOfWeek { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternStartTime { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PatternEndTime { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    public byte[]? HstryTimeStamp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }

    [ForeignKey("DepartmentSer")]
    [InverseProperty("DepartmentPttrnDetails")]
    public virtual Department? DepartmentSerNavigation { get; set; }
}
