using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvExportGoodwoodPoc
{
    public int Quotationid { get; set; }

    public string? Vrno { get; set; }

    public string? PocReference { get; set; }

    public DateTime? Deliverytime { get; set; }

    public string? QuoteRemarks { get; set; }

    public string? Messagereferencenumber { get; set; }

    public int Linkid { get; set; }

    public int? Supplierid { get; set; }

    public int? Buyerid { get; set; }

    public string? BuyerMapping { get; set; }
}
