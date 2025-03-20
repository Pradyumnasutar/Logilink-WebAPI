using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesUsertypeModuleAccess
{
    public int Moduleaccessid { get; set; }

    public int? Usertypeid { get; set; }

    public int? Moduleid { get; set; }

    public int? AccessLevel { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual LesUsertype? Usertype { get; set; }
}
