using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Index("FileName", Name = "XAKFileLocation", IsUnique = true)]
public partial class FileLocation
{
    [Key]
    public long FileLocationSer { get; set; }

    [StringLength(254)]
    public string FileName { get; set; } = null!;

    [StringLength(254)]
    public string ServerName { get; set; } = null!;

    [StringLength(254)]
    public string DriveName { get; set; } = null!;

    [StringLength(254)]
    public string? FolderName1 { get; set; }

    [StringLength(254)]
    public string? FolderName2 { get; set; }

    [StringLength(254)]
    public string? FolderName3 { get; set; }

    [StringLength(254)]
    public string? FolderName4 { get; set; }

    [StringLength(16)]
    public string? FileExtension { get; set; }

    [StringLength(255)]
    public string HstryUserName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime HstryDateTime { get; set; }

    public byte[]? HstryTimeStamp { get; set; }

    [StringLength(32)]
    public string? HstryTaskName { get; set; }
}
