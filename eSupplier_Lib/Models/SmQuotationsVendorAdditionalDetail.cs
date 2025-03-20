using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eSupplier_Lib.Models;

public partial class SmQuotationsVendorAdditionalDetail
{
    [Key]
    public int QuotationAddId { get; set; } // QUOTATION_ADD_ID
    public int? QuotationId { get; set; } // QUOTATIONID
    public string? DepartmentCode { get; set; } // DEPARTMENT_CODE
    public string? DepartmentDesc { get; set; } // DEPARTMENT_DESC
    public DateTime? UpdateDate { get; set; } // UPDATE_DATE
    public DateTime? CreatedDate { get; set; } // CREATED_DATE
    public string? SqNumber { get; set; } // SQNumber
    public string? JobNumber { get; set; } // JOBNumber
    public string? DeliveryTermLocation { get; set; } // DeliveryTermLocation
    public string? PackagingInstructions { get; set; } // PackagingInstructions
    public string? DeliveryTerms { get; set; } // DeliveryTerms
}
