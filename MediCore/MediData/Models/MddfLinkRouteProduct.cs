using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[PrimaryKey("IProductId", "IRoutePrescribedId", "IRouteStatusId", "IRouteMessageSetId")]
[Table("MDDF_linkRouteProduct")]
public partial class MddfLinkRouteProduct
{
    [Key]
    [Column("iProductID")]
    public int IProductId { get; set; }

    [Column("iChangeTypeID")]
    public int? IChangeTypeId { get; set; }

    [Column("dDateOfChange", TypeName = "datetime")]
    public DateTime? DDateOfChange { get; set; }

    [Key]
    [Column("iRoutePrescribedID")]
    public int IRoutePrescribedId { get; set; }

    [Key]
    [Column("iRouteStatusID")]
    public int IRouteStatusId { get; set; }

    [Key]
    [Column("iRouteMessageSetID")]
    public int IRouteMessageSetId { get; set; }
}
