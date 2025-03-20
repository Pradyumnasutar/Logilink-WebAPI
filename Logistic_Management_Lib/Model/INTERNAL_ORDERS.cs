using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class INTERNAL_ORDERS
    {
        [Key]
        public int InternalOrderId { get; set; }
        public string? Internal_Order_No { get; set; } = "";
        public string? Internal_Order_Desc { get; set; } = "";
        public int? CustomerId { get; set; }
        public int? BuyerId { get; set; }
        public int? SiteId { get; set; }
        public int? StatusId { get; set; }
        public string? JobOrderNo { get; set; } = "";
        public int? Order_Code_Id { get; set; }
        public DateTime? ReceiptDate { get; set; }
        public string? ProjectId { get; set; } = "";
        public string? Remarks { get; set; } = "";
        public string? Consignee { get; set; } = "";
        public string? FromServicePoint { get; set; } = "";
        public string? ToServicePoint { get; set; } = "";
        public string? ContainerNumber { get; set; } = "";
        public string? ContainerType { get; set; } = "";
        public string? ContainerSize { get; set; } = "";
        public string? SealNo { get; set; } = "";
        public string? BondedLotNo { get; set; } = "";
        public string? InwardPermitNo { get; set; } = "";
        public DateTime? OrderDate { get; set; }
        public int? PayTermsId { get; set; }
        public int? ForwarderId { get; set; }
        public DateTime? Delivery_Date { get; set; }
        public DateTime? Created_Date { get; set; }
        public DateTime? Updated_Date { get; set; }
        public int? Is_Delete { get; set; }
        public int? IsAuto { get; set; }
        public int? Is_Billed { get; set; }
        public int? Inboundshipmentid { get; set; }
        public string? External_Reference_No { get; set; } = "";
        public int? Container_Size_Id { get; set; }
        public int? Container_Type_Id { get; set; }
        public int? FromServicePointsId { get; set; }
        public int? ToServicePointsId { get; set; }
        public string? Currency { get; set; } = "";
        public double? FrieghtAmount { get; set; }
        public double? OtherCost { get; set; }
        public double? POAmount { get; set; }
        public double? ItemTotal {  get; set; }
        public int? quotationid { get; set; }
    }

}
