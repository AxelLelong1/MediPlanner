using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("dictation_typ")]
public partial class DictationTyp
{
    [Key]
    [Column("dictation_typ")]
    public int DictationTyp1 { get; set; }

    [Column("dictation_typ_desc")]
    [StringLength(40)]
    public string DictationTypDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string TransLogUserid { get; set; } = null!;

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string TransLogInstId { get; set; } = null!;

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("DictationTypNavigation")]
    public virtual ICollection<DictationQueue> DictationQueue { get; set; } = new List<DictationQueue>();
}
