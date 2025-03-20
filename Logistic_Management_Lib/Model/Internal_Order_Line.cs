using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Internal_Order_Line
    {
        [Key]
        public int Internallineid { get; set; }
        public int? orderId { get; set; }
        public int? lineNo { get; set; }
        public int? releaseNo { get; set; }
        public string? partNo { get; set; } = "";
        public string? partName { get; set; } = "";
        public string? serialNo { get; set; } = "";
        public string? refNo { get; set; } = "";
        public string? uom { get; set; } = "";
        public DateTime? receiptDate { get; set; }
        public DateTime? arrivalDate { get; set; }
        public DateTime? deliveryDate { get; set; }
        public double? qty { get; set; }
        public double? volume { get; set; }
        public string? remarks { get; set; } = "";
        public string? productTypes { get; set; } = "";
        public DateTime? created_Date { get; set; }
        public DateTime? updated_Date { get; set; }
        public double? part_Price { get; set; }
        public double? part_Price_Incl_Tax { get; set; }
        public int? item_Status { get; set; }
        public int? salesPartId { get; set; }
        public int? statusId { get; set; }
        public double? qty_Rec { get; set; }
        public int? is_Delete { get; set; }
        public int? is_Billed { get; set; }
        public int? locked_UserId { get; set; }
        public DateTime? locked_Time { get; set; }
        public string? specialInstructions { get; set; } = "";
    }
}
