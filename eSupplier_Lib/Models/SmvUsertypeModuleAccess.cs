using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmvUsertypeModuleAccess
{
    public int? ExUserid { get; set; }

    public string? ExUsername { get; set; }

    public string? Usertypedescr { get; set; }

    public int? UsertypeLevel { get; set; }

    public int? AccessLevel { get; set; }

    public int? Moduleid { get; set; }

    public int Moduleaccessid { get; set; }

    public string? ActionName { get; set; }

    public int Usertypeid { get; set; }
}
