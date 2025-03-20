using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocDatetime
{
    public Guid Mtmldocdatetimeid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? DateValue { get; set; }

    public string? Qualifier { get; set; }

    public string? Formatqualifier { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
