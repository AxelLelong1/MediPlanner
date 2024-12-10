using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("DicomLocationSer", Name = "XIF1ObjectPointer")]
[Index("DcobjectPointerSeriesSer", Name = "XIF2ObjectPointer")]
[Index("SopclassSer", Name = "XIF3ObjectPointer")]
public partial class ObjectPointer
{
    [Key]
    public long ObjectPointerSer { get; set; }

    [StringLength(32)]
    public string ObjectType { get; set; } = null!;

    public long? ObjectSer { get; set; }

    public long? DicomLocationSer { get; set; }

    [Column("DCObjectPointerSeriesSer")]
    public long? DcobjectPointerSeriesSer { get; set; }

    [Column("SOPClassSer")]
    public long? SopclassSer { get; set; }

    [Column("SOPInstanceUID")]
    [StringLength(64)]
    public string? SopinstanceUid { get; set; }

    [ForeignKey("DcobjectPointerSeriesSer")]
    [InverseProperty("ObjectPointer")]
    public virtual DcobjectPointerSeries? DcobjectPointerSeriesSerNavigation { get; set; }

    [InverseProperty("ObjectPointerSerNavigation")]
    public virtual ICollection<DcobjectTrackingInfo> DcobjectTrackingInfo { get; set; } = new List<DcobjectTrackingInfo>();

    [ForeignKey("DicomLocationSer")]
    [InverseProperty("ObjectPointer")]
    public virtual DicomLocation? DicomLocationSerNavigation { get; set; }

    [InverseProperty("ObjectPointerSerNavigation")]
    public virtual ICollection<ScheduledObjectPointer> ScheduledObjectPointer { get; set; } = new List<ScheduledObjectPointer>();

    [ForeignKey("SopclassSer")]
    [InverseProperty("ObjectPointer")]
    public virtual Sopclass? SopclassSerNavigation { get; set; }

    [ForeignKey("ObjectPointerSer")]
    [InverseProperty("ObjectPointerSer")]
    public virtual ICollection<PerformedProcedure> PerformedProcedureSer { get; set; } = new List<PerformedProcedure>();
}
