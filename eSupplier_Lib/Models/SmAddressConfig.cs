using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmAddressConfig
{
    public int Addrconfigid { get; set; }

    public int Addressid { get; set; }

    public string? PartyMapping { get; set; }

    public string? DefaultFormat { get; set; }

    public string? ExportPath { get; set; }

    public string? ImportPath { get; set; }

    public short? ImportRfq { get; set; }

    public short? ExportRfq { get; set; }

    public short? ExportRfqAck { get; set; }

    public short? ImportQuote { get; set; }

    public short? ExportQuote { get; set; }

    public short? ImportPo { get; set; }

    public short? ExportPo { get; set; }

    public short? ExportPoAck { get; set; }

    public short? ExportPoc { get; set; }

    public short? MailNotify { get; set; }

    public double? DefaultPrice { get; set; }

    public string? UploadFileType { get; set; }

    public string? MailSubject { get; set; }

    public string? SupWebServiceUrl { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? CcEmail { get; set; }

    public string? IdentificationCode { get; set; }

    public short? ImportPoc { get; set; }

    public virtual SmAddress Address { get; set; } = null!;
}
