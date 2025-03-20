using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvErrorLog
{
    public int Logid { get; set; }

    public string? Modulename { get; set; }

    public string? Filename { get; set; }

    public string? Auditvalue { get; set; }

    public string? KeyRef1 { get; set; }

    public string? Keyref2 { get; set; }

    public int? BuyerId { get; set; }

    public string? BuyerCode { get; set; }

    public int? SupplierId { get; set; }

    public string? VendorCode { get; set; }

    public int? ErrorLogid { get; set; }

    public string? ErrorProblem { get; set; }

    public string? ErrorSolution { get; set; }

    public int ErrorStatus { get; set; }

    public string? ServerName { get; set; }

    public string? SupplierCode { get; set; }

    public string? BuyerCode1 { get; set; }

    public string? DocType { get; set; }

    public string? ProcessorName { get; set; }

    public DateTime? Updatedate { get; set; }

    public int? PriorityFlag { get; set; }
}
