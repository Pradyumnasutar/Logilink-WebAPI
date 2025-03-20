using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Delivery_Order_Lines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("DELIVERY_ORDER_LINES_ID")]
        public int DeliveryOrderLinesId { get; set; }

        [Column("ITEM_NO")]
        public int? ItemNo { get; set; }

        [Column("ITEM_REF_NO")]
        [MaxLength(50)]
        public string? ItemRefNo { get; set; }

        [Column("ITEM_DESCRIPTION")]
        [MaxLength(250)]
        public string? ItemDescription { get; set; }

        [Column("QUANTITY")]
        public double? Quantity { get; set; }

        [Column("UOM")]
        [MaxLength(50)]
        public string? Uom { get; set; }

        [Column("AWB_BL")]
        [MaxLength(100)]
        public string? AwbBl { get; set; }

        [Column("QUANTITY_INVOICED")]
        public double? QuantityInvoiced { get; set; }

        [Column("STATUSID")]
        public int? StatusId { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("UPDATED_BY")]
        public int? UpdatedBy { get; set; }

        [Column("GRN_REASON_ID")]
        public int? GrnReasonId { get; set; }

        [Column("DELIVERY_ORDER_ID")]
        public int DeliveryOrderId { get; set; }

        [Column("BROKER_CODE")]
        [MaxLength(100)]
        public string? BrokerCode { get; set; }

        [Column("EPOD_LINE_REMARKS")]
        [MaxLength(500)]
        public string? EPOD_LINE_REMARKS { get; set; }
        public int? InternalOrderLineId { get; set; }

    }
}
