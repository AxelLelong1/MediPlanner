using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IRoutePrescribedId", "RegionCode", "LanguageId")]
[Table("MDDF_reg_routes")]
public partial class MddfRegRoutes
{
    [Key]
    [Column("iRoutePrescribedId")]
    public int IRoutePrescribedId { get; set; }

    [Key]
    [Column("region_code")]
    public int RegionCode { get; set; }

    [Key]
    [Column("language_id")]
    public int LanguageId { get; set; }

    [Column("route_text")]
    [StringLength(255)]
    public string? RouteText { get; set; }
}
