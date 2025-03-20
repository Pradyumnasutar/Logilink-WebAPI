using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class SmByrSuppMailConfig
{
    public int ConfigId { get; set; }

    public int? ByrSupLinkid { get; set; }

    public int? BuyerId { get; set; }

    public int? SupplierId { get; set; }

    public string? SmtpHost { get; set; }

    public int? SmtpPort { get; set; }

    public string? FromEmail { get; set; }

    public string? FromUser { get; set; }

    public string? FromPwd { get; set; }

    public string? DisplayName { get; set; }

    public string? ReplyEmail { get; set; }

    public int? IsSsl { get; set; }

    public int? IsAuthorised { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public int? IsHtml { get; set; }

    public int? IsTls { get; set; }

    public string? TenantId { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? ProtocolType { get; set; }

    public DateTime? UpdateDate { get; set; }
}
