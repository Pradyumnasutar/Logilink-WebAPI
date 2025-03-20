using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmAddress
{
    public int Addressid { get; set; }

    public string? AddrCode { get; set; }

    public string? AddrName { get; set; }

    public string? ContactPerson { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? Address3 { get; set; }

    public string? Address4 { get; set; }

    public string? AddrCity { get; set; }

    public string? AddrCountry { get; set; }

    public string? AddrZipcode { get; set; }

    public string? AddrPhone1 { get; set; }

    public string? AddrPhone2 { get; set; }

    public string? AddrFax { get; set; }

    public string? AddrTelex { get; set; }

    public string? AddrEmail { get; set; }

    public string? AddrMobilephone { get; set; }

    public string? AddrType { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? AddrCurrencyid { get; set; }

    public string? EBizConnectorId { get; set; }

    public string? EBizCode { get; set; }

    public short? Active { get; set; }

    public string? AddrMtsCode { get; set; }

    public string? AddrMtmlCode { get; set; }

    public string? AddrInbox { get; set; }

    public string? AddrOutbox { get; set; }

    public short? ESupplier { get; set; }

    public short? EInvoice { get; set; }

    public short? EPurchase { get; set; }

    public int? XmlAddrNo { get; set; }

    public string? BuyerLink { get; set; }

    public int? GroupId { get; set; }

    public string? WebLink { get; set; }

    public string? AddrCountryCode2 { get; set; }

    public int? IsLeSconnect { get; set; }

    public int? CompanyGroupId { get; set; }

    public int? SubBuyerAddressid { get; set; }

    public virtual ICollection<LesBuyerSupplierFormat> LesBuyerSupplierFormats { get; set; } = new List<LesBuyerSupplierFormat>();

    public virtual ICollection<SmAddressConfig> SmAddressConfigs { get; set; } = new List<SmAddressConfig>();

    public virtual ICollection<SmBuyerSupplierLink> SmBuyerSupplierLinkBuyers { get; set; } = new List<SmBuyerSupplierLink>();

    public virtual ICollection<SmBuyerSupplierLink> SmBuyerSupplierLinkSuppliers { get; set; } = new List<SmBuyerSupplierLink>();
}
