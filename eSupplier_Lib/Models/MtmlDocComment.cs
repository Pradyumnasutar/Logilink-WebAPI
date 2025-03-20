using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocComment
{
    public Guid Mtmldoccommentid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? Comments { get; set; }

    public string? Qualifier { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
