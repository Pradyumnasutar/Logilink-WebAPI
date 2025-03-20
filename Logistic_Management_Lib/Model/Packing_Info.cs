using Logistic_Management_Lib.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Packing_Info
    {
        [Key]
        public int packing_info_id { get; set; }
        public int? delivery_order_id{ get; set; }
        public string? packing_info{ get; set; }
    }
}
