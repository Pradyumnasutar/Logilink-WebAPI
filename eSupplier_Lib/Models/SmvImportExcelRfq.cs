using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvImportExcelRfq
{
    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerCode { get; set; }

    public string? BuyerName { get; set; }

    public string? BuyerMtsCode { get; set; }

    public string? BuyerMtmlCode { get; set; }

    public string? SupplierCode { get; set; }

    public string? SupplierName { get; set; }

    public string? SupplierMtsCode { get; set; }

    public string? SupplierMtmlCode { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public byte? ImportRfq { get; set; }

    public byte? ExportRfq { get; set; }

    public byte? ExportRfqAck { get; set; }

    public byte? ImportQuote { get; set; }

    public byte? ExportQuote { get; set; }

    public byte? ImportPo { get; set; }

    public byte? ExportPoAck { get; set; }

    public byte? ExportPoc { get; set; }

    public string? ImportPath { get; set; }

    public string? ExportPath { get; set; }
}
