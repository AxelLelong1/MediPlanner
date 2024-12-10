using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MediData.Models;

[Table("erx_in_out_xml_log")]
public partial class ErxInOutXmlLog
{
    [Key]
    [Column("erx_in_out_xml_log_id")]
    public long ErxInOutXmlLogId { get; set; }

    [Column("log_date_time", TypeName = "datetime")]
    public DateTime? LogDateTime { get; set; }

    [Column("xml_data")]
    public string? XmlData { get; set; }

    [Column("secure_hash")]
    [MaxLength(90)]
    public byte[]? SecureHash { get; set; }

    [Column("edi_out_id")]
    public int? EdiOutId { get; set; }

    [Column("msg_type")]
    [StringLength(50)]
    public string? MsgType { get; set; }

    [Column("msg_id")]
    [StringLength(35)]
    public string? MsgId { get; set; }

    [Column("prescriber_order_num")]
    [StringLength(35)]
    public string? PrescriberOrderNum { get; set; }

    [Column("relates_to_msg_id")]
    [StringLength(35)]
    public string? RelatesToMsgId { get; set; }

    [Column("rx_ref_num")]
    [StringLength(35)]
    public string? RxRefNum { get; set; }
}
