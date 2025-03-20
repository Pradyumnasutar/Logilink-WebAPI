using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MxmlAddress
{
    public Guid Mxmladdressid { get; set; }

    public Guid? Mxmldocid { get; set; }

    public string? AddrType { get; set; }

    public string? AddrName { get; set; }

    public string? ContactPerson { get; set; }

    public string? AddrStreet11 { get; set; }

    public string? AddrStreet2 { get; set; }

    public string? AddrCity { get; set; }

    public string? AddrPostcode { get; set; }

    public string? AddrCountry { get; set; }

    public string? AddrEmail { get; set; }

    public string? AddrPhoneCountry { get; set; }

    public string? AddrPhoneAreacode { get; set; }

    public string? AddrPhoneNumber { get; set; }

    public string? AddrFaxCountry { get; set; }

    public string? AddrFaxAreacode { get; set; }

    public string? AddrFaxNumber { get; set; }

    public string? AddrComments { get; set; }

    public virtual MxmlTransactionHeader? Mxmldoc { get; set; }
}
