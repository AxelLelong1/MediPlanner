using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("ErrorCode", "LanguageId")]
[Index("ErrorLabel", Name = "XIE1ErrorMsg")]
[Index("LanguageId", Name = "XIF682ErrorMsg")]
public partial class ErrorMsg
{
    [Key]
    public int ErrorCode { get; set; }

    [Key]
    [StringLength(16)]
    public string LanguageId { get; set; } = null!;

    [StringLength(32)]
    public string ErrorLabel { get; set; } = null!;

    [StringLength(254)]
    public string ErrorMessage { get; set; } = null!;

    [StringLength(254)]
    public string? ErrorDescription { get; set; }

    [ForeignKey("LanguageId")]
    [InverseProperty("ErrorMsg")]
    public virtual LanguageLookup Language { get; set; } = null!;
}
