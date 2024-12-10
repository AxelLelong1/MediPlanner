using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
public partial class VvDimUserMo
{
    [Column("UserCUID")]
    [StringLength(64)]
    public string? UserCuid { get; set; }

    [StringLength(255)]
    public string UserId { get; set; } = null!;

    [Column("ctrstkh_id")]
    [StringLength(20)]
    public string? CtrstkhId { get; set; }

    [Column("app_user_userid")]
    [StringLength(255)]
    public string? AppUserUserid { get; set; }

    [Column("user_first_name")]
    [StringLength(20)]
    public string? UserFirstName { get; set; }

    [Column("user_last_name")]
    [StringLength(30)]
    public string? UserLastName { get; set; }

    [Column("dsp_name")]
    [StringLength(80)]
    public string? DspName { get; set; }

    [Column("inst_id")]
    [StringLength(30)]
    public string InstId { get; set; } = null!;

    public int? ProfType { get; set; }

    [StringLength(40)]
    public string? ProfDescription { get; set; }
}
