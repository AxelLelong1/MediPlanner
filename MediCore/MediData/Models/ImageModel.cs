using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("ImageModel", Schema = "DWH")]
public partial class ImageModel
{
    public long? PatientSer { get; set; }

    [StringLength(25)]
    public string? PatientId { get; set; }

    [StringLength(16)]
    public string? MachineId { get; set; }

    [StringLength(16)]
    public string? FieldId { get; set; }

    [StringLength(64)]
    public string? FieldName { get; set; }

    [StringLength(16)]
    public string? ImageId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AcquisitionDate { get; set; }

    [StringLength(30)]
    public string? ImageType { get; set; }

    [StringLength(64)]
    public string? ImageStatus { get; set; }

    [StringLength(255)]
    public string? ApprovedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovalDate { get; set; }

    public string? ImageNote { get; set; }

    [StringLength(254)]
    public string? Comment { get; set; }

    public long? Oncologist { get; set; }

    public double? IsocenterX { get; set; }

    public double? IsocenterY { get; set; }

    public double? IsocenterZ { get; set; }

    [Column("DicomUID")]
    [StringLength(64)]
    public string? DicomUid { get; set; }

    public int? Energy { get; set; }

    public double? MetersetExposure { get; set; }

    public int? ExposureTime { get; set; }

    [Column("XRayTubeCurrent")]
    public int? XrayTubeCurrent { get; set; }

    [StringLength(16)]
    public string? PrimaryDosimeterUnit { get; set; }

    public int? ImageNotesLen { get; set; }

    [StringLength(255)]
    public string? CreationUserName { get; set; }

    public long? CourseSer { get; set; }

    public long? StudySer { get; set; }

    public long? SeriesSer { get; set; }

    public long? ImageSer { get; set; }

    public long? SliceSer { get; set; }

    public long? ResourceSer { get; set; }

    public long? RadiationSer { get; set; }
}
