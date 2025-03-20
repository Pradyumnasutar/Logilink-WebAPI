using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportRmsExcelDocsSupp
{
    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public short? ImportRfq { get; set; }

    public short? ExportRfq { get; set; }

    public short? ExportRfqAck { get; set; }

    public short? ImportQuote { get; set; }

    public short? ExportQuote { get; set; }

    public short? ImportPo { get; set; }

    public short? ExportPoAck { get; set; }

    public short? ExportPoc { get; set; }

    public string? ImportPath { get; set; }

    public string? ExportPath { get; set; }

    public short? NotifyBuyer { get; set; }

    public short? NotifySupplr { get; set; }

    public double? DefaultPrice { get; set; }

    public int Linkid { get; set; }

    public string? BuyerLinkCode { get; set; }

    public string? VendorLinkCode { get; set; }

    public short? IsActive { get; set; }

    public string? ReplyEmail { get; set; }

    public string? BuyerEmail { get; set; }

    public string? SupplierEmail { get; set; }

    public string? CcEmail { get; set; }

    public string? BccEmail { get; set; }

    public string? MailSubject { get; set; }

    public int? GroupId { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupDesc { get; set; }

    public string? AddrInbox { get; set; }
}
