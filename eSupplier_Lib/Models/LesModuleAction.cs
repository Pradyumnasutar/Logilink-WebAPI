using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesModuleAction
{
    public int Moduleactionid { get; set; }

    public string? ActionName { get; set; }

    public int? Moduleid { get; set; }
}
