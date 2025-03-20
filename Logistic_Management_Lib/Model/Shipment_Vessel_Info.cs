using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Logistic_Management_Lib.Model
{
    public class Shipment_Vessel_Info
    {
        [Key]
        [Column("SHIPMENT_VESSEL_INFO_ID")]
        public int ShipmentVesselInfoId { get; set; }

        [Column("SHIPMENTID")]
        public int? ShipmentId { get; set; }

        [Column("VESSEL_ID")]
        public int? VesselId { get; set; }

        [Column("VESSEL_ETA")]
        public DateTime? VesselEta { get; set; }

        [Column("VESSEL_ATA")]
        public DateTime? VesselAta { get; set; }

        [Column("DELIVERY_DATE")]
        public DateTime? DeliveryDate { get; set; }

        [Column("ANCHORAGE_ID")]
        public int? AnchorageId { get; set; }

        [Column("AGENT")]
        [MaxLength(100)]
        public string? Agent { get; set; }

        [Column("AGENT_CONTACT_PERSON")]
        [MaxLength(100)]
        public string? AgentContactPerson { get; set; }

        [Column("AGENT_CONTACT_NO")]
        [MaxLength(50)]
        public string? AgentContactNo { get; set; }

        [Column("SUPPLY_BOAT")]
        [MaxLength(100)]
        public string? SupplyBoat { get; set; }

        [Column("SUPPLY_BOAT_CONTACT_PERSON")]
        [MaxLength(100)]
        public string? SupplyBoatContactPerson { get; set; }

        [Column("SUPPLY_BOAT_CONTACT_NO")]
        [MaxLength(50)]
        public string? SupplyBoatContactNo { get; set; }

        [Column("LOADING_POINT")]
        [MaxLength(200)]
        public string? LoadingPoint { get; set; }

        [Column("LOADING_TIME")]
        public DateTime? LoadingTime { get; set; }

        [Column("CO_PARTY")]
        [MaxLength(100)]
        public string? CoParty { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("UPDATED_BY")]
        public int? UpdatedBy { get; set; }
        public string? Epod_Shipment_Notes { get; set; }
        public DateTime? shipped_date { get; set; }
        public DateTime? confirm_date { get; set; }

		public int? InitialReceiptExported { get; set; }
		public int? FinalReceiptExported { get; set; }

		public DateTime? verified_date { get; set; }
	}

}
