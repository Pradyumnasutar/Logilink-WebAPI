using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Delivery_Order_Documents
    {
        [Key]
        
        [Column("Delivery_Document_ID")]
        public int DeliveryDocumentId { get; set; }

        [Column("Document_No")]
        public int? DocumentNo { get; set; }

        [Column("Document_Type")]
        [MaxLength(20)]
        public string? DocumentType { get; set; }

        [Column("Document_Name")]
        [MaxLength(200)]
        public string? DocumentName { get; set; }

        [Column("Document_Title")]
        [MaxLength(20)]
        public string? DocumentTitle { get; set; }

        [Column("Document_Path")]
        [MaxLength(500)]
        public string? DocumentPath { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("DELIVERY_ORDER_ID")]
        public int? DeliveryOrderId { get; set; }

        [Column("Is_Delete")]
        public int? IsDelete { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
    }

    public class Remove_Delivery_Order_Documents
    {
        public int DeliveryDocumentId { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? DeliveryOrderId { get; set; }

        public int? updated_by { get; set; }
    }
}
