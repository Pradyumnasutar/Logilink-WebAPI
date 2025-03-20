using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class V_DELIVERY_ORDER_LINES
    {
        #region Instance Properties
        [Key]
        public int delivery_order_lines_id { get; set; }

        public int? item_no { get; set; }

        public string? item_ref_no { get; set; }

        public string? item_description { get; set; }

        public double? quantity { get; set; }

        public string? uom { get; set; }

        public string? awb_bl { get; set; }

        public double? quantity_invoiced { get; set; }

        public int? statusid { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        public int? grn_reason_id { get; set; }

        public int delivery_order_id { get; set; }

        public string? delivery_order_no { get; set; }

        public string? location_code { get; set; }

        public string? internal_dept { get; set; }

        public string? jobno { get; set; }

        public string? vessel_code { get; set; }

        public string? vessel_name { get; set; }

        public string? sales_person_code { get; set; }

        public string? dept_code { get; set; }

        public double? packaging_unit_no { get; set; }

        public string? epod_line_remarks { get; set; }
        public string? grn_reason_code { get;set; }
        public string? grn_reason_description { get; set; }
        public string? broker_code { get; set; }
        public string? broker_name { get; set; }
        public string? pono { get; set; }

        #endregion Instance Properties
    }
}
