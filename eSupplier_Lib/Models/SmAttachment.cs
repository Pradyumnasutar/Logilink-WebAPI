using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmAttachment
{
    public int Attachmentid { get; set; }

    public int? Quotationid { get; set; }

    public string? Attachmenttype { get; set; }

    public string? FileName { get; set; }

    public short? Exported { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? FileLocation { get; set; }
}
