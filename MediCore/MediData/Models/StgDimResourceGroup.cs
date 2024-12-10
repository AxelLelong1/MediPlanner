﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Keyless]
[Table("stgDimResourceGroup", Schema = "DWH")]
public partial class StgDimResourceGroup
{
    public long ResourceGroupSer { get; set; }
}