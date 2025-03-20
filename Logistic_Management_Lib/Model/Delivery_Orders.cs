using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Delivery_Orders
    {
        [Key]
        [Column("DELIVERY_ORDER_ID")]
        public int DeliveryOrderId { get; set; }

        [Column("DELIVERY_ORDER_NO")]
        [MaxLength(50)]
        public string? DeliveryOrderNo { get; set; }

        [Column("SHIPMENTID")]
        public int? ShipmentId { get; set; }

        [Column("SITEID")]
        public int? SiteId { get; set; }

        [Column("TRIPDETAILID")]
        public int? TripDetailId { get; set; }

        [Column("TRIPID")]
        public int? TripId { get; set; }

        [Column("REMARKS")]
        [MaxLength(500)]
        public string? Remarks { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATE_DATE")]
        public DateTime? UpdateDate { get; set; }

        [Column("DELIVERY_DATE")]
        public DateTime? DeliveryDate { get; set; }

        [Column("STATUSID")]
        public int? StatusId { get; set; }

        [Column("Is_Delete")]
        public int? IsDelete { get; set; }

        [Column("CUSTOMERID")]
        public int? CustomerId { get; set; }

        [Column("END_CUSTOMERID")]
        public int? EndCustomerId { get; set; }

        [Column("Dispatched_Advise_Sent")]
        public int? DispatchedAdviseSent { get; set; }

        [Column("EPOD_STATUS")]
        public int? EpodStatus { get; set; }

        [Column("PLANNED_FROM")]
        public DateTime? PlannedFrom { get; set; }

        [Column("PLANNED_TO")]
        public DateTime? PlannedTo { get; set; }

        [Column("ACTUAL_START")]
        public DateTime? ActualStart { get; set; }

        [Column("ACTUAL_END")]
        public DateTime? ActualEnd { get; set; }

        [Column("ORDERID")]
        public int? OrderId { get; set; }

        [Column("ISAUTO")]
        public int? IsAuto { get; set; }

        [Column("SMS_INDICATOR")]
        public int? SmsIndicator { get; set; }

        [Column("WHATSAPP_INDICATOR")]
        public int? WhatsappIndicator { get; set; }

        [Column("INSTRUCTIONS")]
        [MaxLength(250)]
        public string? Instructions { get; set; }

        [Column("DO_Complete_Date")]
        public DateTime? DoCompleteDate { get; set; }

        [Column("BILLTYPE")]
        public int? BillType { get; set; }

        [Column("EXPORTED")]
        public int? Exported { get; set; }

        [Column("COMPANYID")]
        public int? CompanyId { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
        public int? InternalOrderId { get; set; }
    }
}
