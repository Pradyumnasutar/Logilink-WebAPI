using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class LesClientSystemInfo
{
    public int SysInfoId { get; set; }

    public string? Client { get; set; }

    public string? Serverip { get; set; }

    public string? Serverpath { get; set; }

    public string? ExeName { get; set; }

    public string? ExeVersion { get; set; }

    public string? ExeDate { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? Pcname { get; set; }

    public DateTime? SysUpdateDate { get; set; }
}
