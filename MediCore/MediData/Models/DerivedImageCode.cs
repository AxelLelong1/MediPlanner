using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("SliceSer", Name = "XIF935DeviceImageCode")]
[Index("DicomcodeValueSer", Name = "XIF940DeviceImageCode")]
public partial class DerivedImageCode
{
    [Key]
    public long DerivedImageCodeSer { get; set; }

    public long SliceSer { get; set; }

    [Column("DICOMCodeValueSer")]
    public long DicomcodeValueSer { get; set; }

    [ForeignKey("DicomcodeValueSer")]
    [InverseProperty("DerivedImageCode")]
    public virtual DicomcodeValue DicomcodeValueSerNavigation { get; set; } = null!;

    [ForeignKey("SliceSer")]
    [InverseProperty("DerivedImageCode")]
    public virtual Slice SliceSerNavigation { get; set; } = null!;
}
