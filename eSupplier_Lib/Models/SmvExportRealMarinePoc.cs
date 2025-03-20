﻿using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportRealMarinePoc
{
    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public string? DocType { get; set; }

    public int? Buyerid { get; set; }

    public int? Supplierid { get; set; }

    public string? BuyerFormat { get; set; }

    public string? VendorFormat { get; set; }

    public string? Company { get; set; }

    public short? ImportRfq { get; set; }

    public short? ExportRfq { get; set; }

    public short? ExportRfqAck { get; set; }

    public short? ImportQuote { get; set; }

    public short? ExportQuote { get; set; }

    public short? ImportPo { get; set; }

    public short? ExportPoAck { get; set; }

    public short? ExportPoc { get; set; }

    public string? BuyerExportFormat { get; set; }

    public string? SysDocType { get; set; }
}
