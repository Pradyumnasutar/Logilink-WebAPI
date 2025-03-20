using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class V_DELIVERY_ORDER_SHIPMENTLINES
    {
        [Key]
        public int ShipmentLineId { get; set; }
        public int? SalesPartId { get; set; }
        public int? ShipmentId { get; set; }
        public int? OrderId { get; set; }
        public int? CustOrderLineId { get; set; }
        public string? Source_Ref1 { get; set; }
        public string? Source_Ref2 { get; set; }
        public string? Source_RefType { get; set; }
        public string? Source_PartNo { get; set; }
        public string? Source_PartDescr { get; set; }
        public double? Connected_SourceQty { get; set; }
        public double? Inventory_Qty { get; set; }
        public double? Reserved_Qty { get; set; }
        public double? Picked_Qty { get; set; }
        public double? Delivered_Qty { get; set; }
        public DateTime? Planned_ship_date { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? Item_Status { get; set; }
        public DateTime? Planned_Delivery_Date { get; set; }
        public int? triplineid { get; set; }
        public int? tripid { get; set; }
        public int? lineno { get; set; }
        public double? qty { get; set; }
        public string? uom { get; set; }
        public string? Customer_Name { get; set; }
        public string? End_Customer_Name { get; set; }
        public string? Customer_Code { get; set; }
        public string? End_Customer_Code { get; set; }
        public int? CUSTOMERID { get; set; }
        public int? END_CUSTOMERID { get; set; }
        public int? Vehicle_TonnageId { get; set; }
        public int? Trailer_TypeId { get; set; }
        public string? Vehicle_Tonnage { get; set; }
        public string? Trailer_Type { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public int? tripdetailid { get; set; }
        

    }


    public class V_DELIVERY_ORDER_CUSTOMER_ORDERLINES
    {
        [Key]
        public int? SalesPartId { get; set; }
        public int? OrderId { get; set; }
        public int? CustOrderLineId { get; set; }
        public string? Source_Ref1 { get; set; }
        public string? Source_Ref2 { get; set; }
        public string? Source_RefType { get; set; }
        public string? Source_PartNo { get; set; }
        public string? Source_PartDescr { get; set; }
        public double? Connected_SourceQty { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public DateTime? Planned_Delivery_Date { get; set; }
        public int? triplineid { get; set; }
        public int? tripid { get; set; }
        public int? lineno { get; set; }
        public double? qty { get; set; }
        public string? uom { get; set; }
        public string? Customer_Name { get; set; }
        public string? End_Customer_Name { get; set; }
        public string? Customer_Code { get; set; }
        public string? End_Customer_Code { get; set; }
        public int? CUSTOMERID { get; set; }
        public int? END_CUSTOMERID { get; set; }

    }

}
