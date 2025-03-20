using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eSupplier_Lib.Models;

public partial class SmQuotationsVendorAddress
{
    [Key]
    public int addressid { get; set; } // ADDRESSID
    public int? quotationid { get; set; } // QUOTATIONID
    public string? addr_type { get; set; } // ADDR_TYPE
    public string? addr_code { get; set; } // ADDR_CODE
    public string? addr_name { get; set; } // ADDR_NAME
    public string? contact_person { get; set; } // CONTACT_PERSON
    public string? address1 { get; set; } // ADDRESS1
    public string? address2 { get; set; } // ADDRESS2
    public string? address3 { get; set; } // ADDRESS3
    public string? address4 { get; set; } // ADDRESS4
    public string? addr_city { get; set; } // ADDR_CITY
    public string? addr_country { get; set; } // ADDR_COUNTRY
    public string? addr_zipcode { get; set; } // ADDR_ZIPCODE
    public string? addr_phone1 { get; set; } // ADDR_PHONE1
    public string? addr_phone2 { get; set; } // ADDR_PHONE2
    public string? addr_fax { get; set; } // ADDR_FAX
    public string? addr_telex { get; set; } // ADDR_TELEX
    public string? addr_email { get; set; } // ADDR_EMAIL
    public string? addr_mobilephone { get; set; } // ADDR_MOBILEPHONE
    public DateTime? update_date { get; set; } // UPDATE_DATE
    public string? addr_remarks { get; set; } // ADDR_REMARKS
    public string? email_cc { get; set; } // EMAIL_CC
    public string? email_bcc { get; set; } // EMAIL_BCC
}
