using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SliceSer", Name = "XIFImageRelatedInstance")]
public partial class ImageRelatedInstance
{
    [Key]
    public long ImageRelatedInstanceSer { get; set; }

    public long SliceSer { get; set; }

    [Column("StudyUID")]
    [StringLength(64)]
    public string? StudyUid { get; set; }

    [Column("SeriesUID")]
    [StringLength(64)]
    public string? SeriesUid { get; set; }

    [Column("SOPInstanceUID")]
    [StringLength(64)]
    public string SopinstanceUid { get; set; } = null!;

    [Column("SOPClassSer")]
    public long SopclassSer { get; set; }

    [Column("DICOMCodeValueSer")]
    public long? DicomcodeValueSer { get; set; }

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("ImageRelatedInstance")]
    public virtual DicomcodeValue? DicomcodeValueSerNavigation { get; set; }

    [ForeignKey("SliceSer")]
    [InverseProperty("ImageRelatedInstance")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;

    [ForeignKey("SopclassSer")]
    [InverseProperty("ImageRelatedInstance")]
    public virtual Sopclass SopclassSerNavigation { get; set; } = null!;
}
