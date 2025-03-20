using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Shipment_Documents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("SHIPMENT_DOCUMENT_ID")]
        public int ShipmentDocumentId { get; set; }

        [Column("DOCUMENT_NO")]
        public int? DocumentNo { get; set; }

        [Column("DOCUMENT_TYPE")]
        [MaxLength(20)]
        public string? DocumentType { get; set; }

        [Column("DOCUMENT_NAME")]
        [MaxLength(200)]
        public string? DocumentName { get; set; }

        [Column("DOCUMENT_TITLE")]
        [MaxLength(20)]
        public string? DocumentTitle { get; set; }

        [Column("DOCUMENT_PATH")]
        [MaxLength(500)]
        public string? DocumentPath { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("SHIPMENTID")]
        public int? ShipmentId { get; set; }

        [Column("IS_DELETE")]
        public int? IsDelete { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("UPDATED_BY")]
        public int? UpdatedBy { get; set; }
    }

    public class Remove_Shipment_Documents
    {
        public int ShipmentDocumentId { get; set; }
        public int? ShipmentId { get; set; }
        public int? IsDelete { get; set; }
        public int? UpdatedBy { get; set; }
    }


}
