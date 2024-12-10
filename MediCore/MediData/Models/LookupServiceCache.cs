using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

public partial class LookupServiceCache
{
    [Key]
    public long LookupServiceCacheSer { get; set; }

    [StringLength(256)]
    public string LookupName { get; set; } = null!;

    [StringLength(30)]
    public string LookupType { get; set; } = null!;

    public int CacheInClient { get; set; }

    public int CacheInServer { get; set; }

    public int ClientCacheExpiryMinutes { get; set; }

    public int ServerCacheExpiryMinutes { get; set; }

    [StringLength(1024)]
    public string? LookupQuery { get; set; }
}
