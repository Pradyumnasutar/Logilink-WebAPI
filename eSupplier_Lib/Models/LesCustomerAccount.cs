using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesCustomerAccount
{
    public int Custaccountid { get; set; }

    public int? Customerid { get; set; }

    public int? Paytermsid { get; set; }

    public string? PaymentTerms { get; set; }

    public double? CreditLimit { get; set; }

    public int? CreditlimitUsage { get; set; }

    public string? CurrCode { get; set; }

    public int? Companyid { get; set; }

    public virtual LesCustomer? Customer { get; set; }
}
