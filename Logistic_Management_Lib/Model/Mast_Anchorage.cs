using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Mast_Anchorage
    {
        [Key]
        [Column("ANCHORAGE_ID")]
        public int AnchorageId { get; set; }

        [Column("ANCHORAGE_CODE")]
        [MaxLength(50)]
        public string? AnchorageCode { get; set; }

        [Column("ANCHORAGE_DESCRIPTION")]
        [MaxLength(250)]
        public string? AnchorageDescription { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("UPDATED_BY")]
        public int? UpdatedBy { get; set; }
    }

    public class Update_Anchorage
    {
        public int AnchorageId { get; set; }

        public string? AnchorageCode { get; set; }

        public string? AnchorageDescription { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
    }
}
