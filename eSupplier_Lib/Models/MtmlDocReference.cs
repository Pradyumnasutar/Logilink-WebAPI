using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocReference
{
    public Guid Mtmlreferenceid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? Qualifier { get; set; }

    public string? Referencenumber { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
