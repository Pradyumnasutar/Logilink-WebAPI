using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class CustomerOrderLine
    {
        [Key]
        public int CustOrderLineId { get; set; }
        public int? OrderId { get; set; }
        public int? LineNo { get; set; }
        public int? DelNo { get; set; }
        public string? ProductCode { get; set; }
        public string? ProductName { get; set; }
        public string? SerialNo { get; set; }
        public string? RefNo { get; set; }
        public double? NetWeight { get; set; }
        public double? GrossWeight { get; set; }
        public double? Tareweight { get; set; }
        public string? WeightedUom { get; set; }
        public string? Marking { get; set; }
        public string? VolumeUom { get; set; }
        public string? StockCode { get; set; }
        public string? BaseUom { get; set; }
        public string? Color { get; set; }
        public double? Qty { get; set; }
        public double? Volume { get; set; }
        public double? QtyCancelled { get; set; }
        public double? QtyProcessed { get; set; }
        public double? QtyReceived { get; set; }
        public double? QtyBalance { get; set; }
        //public string? Remarks { get; set; }
        public string? TransUom { get; set; }
        public string? TransStatus { get; set; }
        public double? Cvrate { get; set; }
        public string? ProductTypes { get; set; }
        public string? PutAwayLocation { get; set; }
        public string? Spec { get; set; }
        public string? Species { get; set; }
        public string? Sizes { get; set; }
        public DateTime? MfgDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? ProjectEngineer { get; set; }
        public string? CustomerDept { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public double? Part_Price { get; set; }
        public double? Part_Price_Incl_Tax { get; set; }
        public int? Item_Status { get; set; }
        public int? SalesPartId { get; set; }
        public double? Tax { get; set; }
        public double? discount { get; set; }
        public string? Price_Source { get; set; }

        public int? Is_Delete { get; set; }

        //added on 31/07/2023
        public int? Vehicle_TonnageId { get; set; }

        public int? Trailer_TypeId { get; set; }
        public int? activitytypeid { get; set; }   // Add by Rushikesh 04/10/23

        public int? created_by { get; set; }  // Add by Rushikesh 04/10/23

        public int? updated_by { get; set; } // Add by Rushikesh 04/10/23

        public string? UDF1 { get; set; }
        public string? UDF2 { get; set; }
        public string? UDF3 { get; set; }
        public double? co_picked_qty { get; set; }
    }
}
