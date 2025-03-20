using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesUsertype
{
    public int Usertypeid { get; set; }

    public string? Usertypedescr { get; set; }

    public int? UsertypeLevel { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual ICollection<LesUsertypeModuleAccess> LesUsertypeModuleAccesses { get; set; } = new List<LesUsertypeModuleAccess>();
}
