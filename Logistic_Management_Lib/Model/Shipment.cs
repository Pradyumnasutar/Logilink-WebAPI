using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Shipment
    {
        [Key]
        [Column("SHIPMENTID")]
        public int ShipmentId { get; set; }

        [Column("ORDER_NO")]
        [MaxLength(50)]
        public string? OrderNo { get; set; }

        [Column("ORDER_ID")]
        public int? OrderId { get; set; }

        [Column("SENDERID")]
        public int? SenderId { get; set; }

        [Column("RECEIVERID")]
        public int? ReceiverId { get; set; }

        [Column("SITEID")]
        public int? SiteId { get; set; }

        [Column("PLANNED_SHIP_DATE")]
        public DateTime? PlannedShipDate { get; set; }

        [Column("PLANNED_DELIVERY_DATE")]
        public DateTime? PlannedDeliveryDate { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("SHIPMENT_NOTES")]
        public string? ShipmentNotes { get; set; }

        [Column("REFERENCE_TYPE")]
        [MaxLength(50)]
        public string? ReferenceType { get; set; }

        [Column("SHIPMENT_TYPE")]
        [MaxLength(50)]
        public string? ShipmentType { get; set; }

        [Column("NEXT_STEP_SHIPMENT")]
        [MaxLength(100)]
        public string? NextStepShipment { get; set; }

        [Column("AUTOCONNECTION_BLOCKED")]
        public int? AutoConnectionBlocked { get; set; }

        [Column("SHIPMENT_STATUSID")]
        public int? ShipmentStatusId { get; set; }

        [Column("SHIPMENTTYPE_ID")]
        public int? ShipmentTypeId { get; set; }

        [Column("Is_Delete")]
        public int? IsDelete { get; set; }

        [Column("ISAUTO")]
        public int? IsAuto { get; set; }

        [Column("JOBNO")]
        [MaxLength(50)]
        public string? JobNo { get; set; }

        [Column("COMPANYID")]
        public int? CompanyId { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("UPDATED_BY")]
        public int? UpdatedBy { get; set; }
    }

    public class Shipment_DropDown
    {
        public int ShipmentId { get; set; }

        public string? OrderNo { get; set; }
    }
}
