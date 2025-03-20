using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlTransactionHeader
{
    public Guid Mtmldocid { get; set; }

    public string? Controlreference { get; set; }

    public string? Identifier { get; set; }

    public string? Preparationdate { get; set; }

    public string? Preparationtime { get; set; }

    public string? Recipeint { get; set; }

    public string? Recipientcodequalifier { get; set; }

    public string? Sender { get; set; }

    public string? Sendercodequalifier { get; set; }

    public string? Versionnumber { get; set; }

    public string? ReferenceNumber { get; set; }

    public string? Doctype { get; set; }

    public int Autoid { get; set; }

    public DateTime? UpdateDate { get; set; }
}
