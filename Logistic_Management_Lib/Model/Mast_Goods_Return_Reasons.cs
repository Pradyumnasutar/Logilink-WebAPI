using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Mast_Goods_Return_Reasons
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("GRN_REASON_ID")]
        public int GrnReasonId { get; set; }

        [Column("GRN_REASON_CODE")]
        [MaxLength(50)]
        public string? GrnReasonCode { get; set; }

        [Column("GRN_REASON_DESCRIPTION")]
        [MaxLength(500)]
        public string? GrnReasonDescription { get; set; }

        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }

    }

    public class Update_Goods_Return_Reasons
    {
        public int GrnReasonId { get; set; }

        public string? GrnReasonCode { get; set; }

        public string? GrnReasonDescription { get; set; }

        public DateTime? updated_date { get; set; }
        
        public int? updated_by { get; set; }

    }


}
