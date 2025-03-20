using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class InboundShipment
    {
        [Key]
        public int inboundShipmentId { get; set; }
        public string? shipmentno { get; set; } = "";    
        public string? jobOrderNo { get; set; } = "";
        public DateTime? transactionDate { get; set; }
        public int? customerId { get; set; }
        public int? contractId { get; set; }
        public int? siteId { get; set; }
        public int? department { get; set; }
        public string? specialInstruction { get; set; } = "";
        public string? consignee { get; set; } = "";
        public string? remarks { get; set; } = "";
        public int? statusId { get; set; }
        public string? billOfLading { get; set; } = "";
        public int? countryId { get; set; }
        public int? shipViaId { get; set; }
        public int? terms { get; set; }
        public int? vesselid { get; set; }
        public int? companyid { get; set; }
        public string? voyage { get; set; } = "";
        public string? bookingRef { get; set; } = "";
        public string? shippingLine { get; set; } = "";
        public string? forwarder { get; set; } = "";
        public DateTime? eta { get; set; }
        public DateTime? etd { get; set; }
        public string? instRemarks { get; set; } = "";
        public DateTime? updatedDate { get; set; }
        public int? updatedBy { get; set; }
        public int? createdBy { get; set; }
        public DateTime? createdDate { get; set; }
        public int? projectId { get; set; }
        public int? coordinatorId { get; set; }
        public int? pod { get; set; }
        public int? pol { get; set; }
        public int? contactPersonId { get; set; }
        public string? email { get; set; } = "";
        public string? contactNumber { get; set; } = "";
        public int? shipping_Line_Id { get; set; }
    }

}
