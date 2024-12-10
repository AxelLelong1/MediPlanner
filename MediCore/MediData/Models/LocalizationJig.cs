using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class LocalizationJig
{
    [Key]
    public long ResourceSer { get; set; }

    [StringLength(32)]
    public string? ImagingGeometry { get; set; }

    [StringLength(64)]
    public string? Beam1Label { get; set; }

    public double? Beam1FocusToFilmDist { get; set; }

    public double? Beam1IsocenterToFilmDist { get; set; }

    public double? Beam1Angle { get; set; }

    public double? Beam1FilmToJigDist { get; set; }

    public double? Beam1JigSize { get; set; }

    public double? Beam1JigCrossSize { get; set; }

    public double? Beam1JigCrossAngle { get; set; }

    public double? Beam1JigCrossShift { get; set; }

    [StringLength(64)]
    public string? Beam2Label { get; set; }

    public double? Beam2FocusToFilmDist { get; set; }

    public double? Beam2IsocenterToFilmDist { get; set; }

    public double? Beam2Angle { get; set; }

    public double? Beam2FilmToJigDist { get; set; }

    public double? Beam2JigSize { get; set; }

    public double? Beam2JigCrossSize { get; set; }

    public double? Beam2JigCrossAngle { get; set; }

    public double? Beam2JigCrossShift { get; set; }

    [MaxLength(96)]
    public byte[]? Plane { get; set; }

    public int Beam1FocusToFilmDistFlag { get; set; }

    public int Beam2FocusToFilmDistFlag { get; set; }

    [ForeignKey("ResourceSer")]
    [InverseProperty("LocalizationJig")]
    public virtual ImagingDevice ResourceSerNavigation { get; set; } = null!;
}
