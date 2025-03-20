using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocParty
{
    public Guid Mtmlpartyid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? Qualifier { get; set; }

    public string? PartyName { get; set; }

    public string? Identification { get; set; }

    public string? Streetaddress { get; set; }

    public string? City { get; set; }

    public string? Postcode { get; set; }

    public string? State { get; set; }

    public string? Countrycode { get; set; }

    public string? Functioncode { get; set; }

    public string? ContactName { get; set; }

    public string? Phonenumber { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? PartyLocation { get; set; }

    public string? Streetaddress2 { get; set; }

    public string? Streetaddress3 { get; set; }

    public string? EmailCc { get; set; }

    public string? EmailBcc { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
