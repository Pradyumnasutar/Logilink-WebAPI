using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class V_SHIPMENT_DELIVERY_ORDERS
    {
        #region Instance Properties
        [Key]
        public int delivery_order_id { get; set; }
        public int shipmentid { get; set; }

        public string? order_no { get; set; }

        public string? jobno { get; set; }

        public string? shipment_status_desc { get; set; }

        public string? do_status_desc { get; set; }

        public string? delivery_order_no { get; set; }

        public int? tripid { get; set; }

        public int? tripdetailid { get; set; }

        public string? internal_dept { get; set; }

        public string? dept_code { get; set; }

        public string? sales_person_code { get; set; }

        public string? sales_order_no { get; set; }

        public string? quote_no { get; set; }

        public double? packaging_unit_no { get; set; }
        public string? pono { get; set; }

        public DateTime? do_verified_date { get; set; }

        #endregion Instance Properties
    }

    public class verify_shipment_delivery_orders
    {
        public int delivery_order_id { get; set; }
        public string? do_order_no { get; set; }
        public string? order_no { get; set; }
        public bool? verified { get; set; }
    }
}
