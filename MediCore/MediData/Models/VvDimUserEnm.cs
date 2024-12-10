using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimUserEnm
{
    [Column("UserCUID")]
    [StringLength(64)]
    public string? UserCuid { get; set; }

    [StringLength(255)]
    public string? UserId { get; set; }

    [StringLength(16)]
    public string? LanguageId { get; set; }

    [Column("ctrAppUserSer")]
    public int CtrAppUserSer { get; set; }

    [Column("ctrstkh_id")]
    [StringLength(20)]
    public string? CtrstkhId { get; set; }

    [StringLength(20)]
    public string? UserFirstName { get; set; }

    [StringLength(30)]
    public string? UserLastName { get; set; }

    [Column("ctrinst_id")]
    [StringLength(30)]
    public string? CtrinstId { get; set; }

    [Column("ctruserid")]
    [StringLength(255)]
    public string? Ctruserid { get; set; }

    [StringLength(80)]
    public string? DisplayName { get; set; }

    public int? ProfType { get; set; }

    [StringLength(40)]
    public string? ProfDescription { get; set; }
}
