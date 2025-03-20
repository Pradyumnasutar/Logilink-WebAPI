using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportVshipPdf
{
    public int Linkid { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerLinkCode { get; set; }

    public string? VendorLinkCode { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public string? SuppSenderCode { get; set; }

    public string? SuppReceiverCode { get; set; }

    public string? ByrSenderCode { get; set; }

    public string? ByrReceiverCode { get; set; }

    public string? BuyerExportFormat { get; set; }

    public string? BuyerMapping { get; set; }

    public string? SupplierMapping { get; set; }

    public string? Company { get; set; }

    public short? ImportRfq { get; set; }

    public short? ExportRfq { get; set; }

    public short? ExportRfqAck { get; set; }

    public short? ImportQuote { get; set; }

    public short? ExportQuote { get; set; }

    public short? ImportPo { get; set; }

    public short? ExportPo { get; set; }

    public short? ExportPoAck { get; set; }

    public short? ExportPoc { get; set; }

    public string? ExportPath { get; set; }

    public string? ImportPath { get; set; }

    public short? NotifyBuyer { get; set; }

    public short? NotifySupplr { get; set; }

    public double? DefaultPrice { get; set; }

    public short? IsActive { get; set; }

    public string? ReplyEmail { get; set; }

    public string? BuyerContact { get; set; }

    public string? SupplierContact { get; set; }

    public string? BuyerEmail { get; set; }

    public string? SupplierEmail { get; set; }

    public string? CcEmail { get; set; }

    public string? BccEmail { get; set; }

    public string? MailSubject { get; set; }

    public string? ErrNotifyEmail { get; set; }

    public int? GroupId { get; set; }

    public string? UploadFileType { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? SupplierExportFormat { get; set; }

    public string? SuppExportPath { get; set; }

    public string? SuppImportPath { get; set; }

    public string? SupWebServiceUrl { get; set; }

    public string? AssemblyName { get; set; }

    public string? AsmbImportClass { get; set; }

    public string? ImportFunction { get; set; }

    public string? AsmbExportClass { get; set; }

    public string? ExportFunction { get; set; }

    public string? SupplierImportFormat { get; set; }

    public short? ImportPoc { get; set; }

    public string? LinkType { get; set; }

    public DateTime? CreatedDate { get; set; }
}
