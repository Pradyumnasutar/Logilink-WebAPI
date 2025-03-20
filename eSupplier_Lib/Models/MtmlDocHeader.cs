using System;
using System.Collections.Generic;

namespace eSupplier_Lib.Models;

public partial class MtmlDocHeader
{
    public Guid Mtmldocheaderid { get; set; }

    public Guid? Mtmldocid { get; set; }

    public string? Doctype { get; set; }

    public string? Versionnumber { get; set; }

    public string? Taxstatus { get; set; }

    public string? Releasenumber { get; set; }

    public string? Priority { get; set; }

    public string? Messagereferencenumber { get; set; }

    public string? Messagenumber { get; set; }

    public int? Linecount { get; set; }

    public string? Functioncode { get; set; }

    public string? Deliverytermscode { get; set; }

    public string? Currencycode { get; set; }

    public string? Controllingagency { get; set; }

    public string? Associationassignedcode { get; set; }

    public string? TransportModeCode { get; set; }

    public string? EquipName { get; set; }

    public string? Manufacturer { get; set; }

    public string? ModelNumber { get; set; }

    public string? PortCode { get; set; }

    public string? PortName { get; set; }

    public string? DepartmentCode { get; set; }

    public string? ControlReference { get; set; }

    public double? TotalAmount { get; set; }

    public string? Originatingsystemref { get; set; }

    public int? LeadTimeDays { get; set; }

    public string? EquipType { get; set; }

    public string? EquipDtls { get; set; }

    public string? BuyerRefno { get; set; }

    public double? AdditionalDisc { get; set; }

    public int Autoid { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? RevisionNumber { get; set; }

    public string? OrderHandling { get; set; }

    public string? OrderType { get; set; }

    public string? OriginatingRequestNo { get; set; }

    public string? ShipComplete { get; set; }

    public string? SupplierOrgref { get; set; }

    public string? UpdType { get; set; }

    public string? ContractType { get; set; }

    public DateTime? UpdateDate { get; set; }
}
