using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesParttype
{
    public int Parttypeid { get; set; }

    public string? ParttypeCode { get; set; }

    public string? Description { get; set; }

    public int? Categoryid { get; set; }
}
