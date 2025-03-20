using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportStamcoExcelQuote
{
    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public string? DocType { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public string? Company { get; set; }

    public byte? ImportRfq { get; set; }

    public byte? ExportRfq { get; set; }

    public byte? ExportRfqAck { get; set; }

    public byte? ImportQuote { get; set; }

    public byte? ExportQuote { get; set; }

    public byte? ImportPo { get; set; }

    public byte? ExportPoAck { get; set; }

    public byte? ExportPoc { get; set; }

    public string? Docid { get; set; }

    public string? Messagereferencenumber { get; set; }

    public string? Messagenumber { get; set; }
}
