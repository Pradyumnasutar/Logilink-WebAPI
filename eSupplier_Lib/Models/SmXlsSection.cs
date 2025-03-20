using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmXlsSection
{
    public int Sectionid { get; set; }

    public string? SectionCode { get; set; }

    public string? SectionDesc { get; set; }

    public DateTime? UpdateDate { get; set; }
}
