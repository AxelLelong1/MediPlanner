using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("agt_contra_ind_typ")]
public partial class AgtContraIndTyp
{
    [Key]
    [Column("contra_ind_typ")]
    public int ContraIndTyp { get; set; }

    [Column("contra_ind_desc")]
    [StringLength(40)]
    public string ContraIndDesc { get; set; } = null!;

    [Column("trans_log_userid")]
    [StringLength(255)]
    public string? TransLogUserid { get; set; }

    [Column("trans_log_tstamp", TypeName = "datetime")]
    public DateTime? TransLogTstamp { get; set; }

    [Column("trans_log_inst_id")]
    [StringLength(30)]
    public string? TransLogInstId { get; set; }

    [Column("trans_trf_tstamp", TypeName = "datetime")]
    public DateTime? TransTrfTstamp { get; set; }

    [InverseProperty("AgtContraIndTypNavigation")]
    public virtual ICollection<AgtContraInd> AgtContraInd { get; set; } = new List<AgtContraInd>();
}
