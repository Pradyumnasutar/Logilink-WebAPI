using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesCustomer
{
    public int Customerid { get; set; }

    public string? CustCode { get; set; }

    public string? CustName { get; set; }

    public string? CustType { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? AddrCity { get; set; }

    public string? AddrState { get; set; }

    public string? AddrCountry { get; set; }

    public string? Phone { get; set; }

    public string? Emailid { get; set; }

    public string? Fax { get; set; }

    public int? Companyid { get; set; }

    public string? CompanyName { get; set; }

    public string? Homepage { get; set; }

    public string? ContactPersonName { get; set; }

    public int? ContactPersonid { get; set; }

    public string? Address4 { get; set; }

    public string? Zipcode { get; set; }

    public int? Parentid { get; set; }

    public int? Paytermsid { get; set; }

    public string? PaymentTerms { get; set; }

    public double? CreditLimit { get; set; }

    public int? CreditlimitUsage { get; set; }

    public string? CurrCode { get; set; }

    public int? Brokerid { get; set; }

    public int? Currencyid { get; set; }

    public int? Addressid { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public double? BalanceLcy { get; set; }

    public virtual ICollection<LesCustomerAccount> LesCustomerAccounts { get; set; } = new List<LesCustomerAccount>();
}
