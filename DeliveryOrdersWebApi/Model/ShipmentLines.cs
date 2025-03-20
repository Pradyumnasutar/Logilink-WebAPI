using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class ShipmentLines
    {
        [Key]
        public int ShipmentLineId { get; set; }
        public int? SalesPartId { get; set; }
        public int? ShipmentId { get; set; }
        public int? OrderId { get; set; }
        public int? Line_No { get; set; }

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

        public int? Is_Delete { get; set; }

        public int? End_CustomerId { get; set; }

        //added by Kalpita on 04/07/2023
        public int? CustomerId { get; set; }

        //added on 03/08/2023
        public int? Vehicle_TonnageId { get; set; }

        public int? Trailer_TypeId { get; set; }
    }

    public partial class V_SHIPMENT_LINES
    {

        [Key]
        public int ShipmentLineId { get; set; }
        public int? SalesPartId { get; set; }
        public int? ShipmentId { get; set; }
        public int? OrderId { get; set; }
        public int? Line_No { get; set; }

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

        public string? status_text { get; set; }

        public double? part_price { get; set; }

        public string? custline_productcode { get; set; }
        public string? custline_productname { get; set; }

        public string? shipment_type { get; set; }

        public string? order_no { get; set; }

        public int? item_status { get; set; }

        //added on 04/07/23
        public int? End_CustomerId { get; set; }

        public int? CustomerId { get; set; }

        public string? EndCustomer_Code { get; set; }

        public string? EndCustomer_Name { get; set; }

        public string? Customer_Code { get; set; }

        public string? Customer_Name { get; set; }
        //added on 03/08/2023
        public int? Vehicle_TonnageId { get; set; }

        public int? Trailer_TypeId { get; set; }
    }

}
