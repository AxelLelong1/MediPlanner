using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("Ekey", "Area")]
[Table("AIC_Patient")]
public partial class AicPatient
{
    [Key]
    [Column("EKey")]
    [StringLength(25)]
    [Unicode(false)]
    public string Ekey { get; set; } = null!;

    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string Area { get; set; } = null!;

    public string Datas { get; set; } = null!;
}
