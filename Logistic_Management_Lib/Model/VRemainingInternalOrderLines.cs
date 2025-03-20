using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class VRemainingInternalOrderLines
    {
        [Key]
        public int InternalLineId { get; set; }
        public int? OrderId { get; set; }
        public int? LineNo { get; set; }
        public string? PartNo { get; set; }
        public string? PartName { get; set; }
        public double? OrderedQuantity { get; set; }
        public double? DeliveredQuantity { get; set; }
        public double? RemainingQuantity { get; set; }
        public double? UnitPrice { get; set; }
        public double? UnitPriceInclTax { get; set; }
        public string? Uom { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public int? InternalOrderStatus { get; set; }
        public int? DeliveryOrderStatus { get; set; }
    }
}
