using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Vehicle_Trip_Planning
    {
        #region Instance Properties
        [Key]
        public int tripid { get; set; }

        public int? shipmentid { get; set; }

        public int? statusid { get; set; }

        public int? point_typeid { get; set; }

        public int? customerid { get; set; }

        public int? siteid { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        public int? is_delete { get; set; }

        public int? orderid { get; set; }

        public DateTime? planned_delivery_date { get; set; }

        public string? source_reftype { get; set; }

        public int? is_billed { get; set; }

        public int? exported { get; set; }

        #endregion Instance Properties
    }
}
