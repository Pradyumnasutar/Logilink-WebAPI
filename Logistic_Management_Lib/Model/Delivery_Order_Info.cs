using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{

    public class Delivery_Order_Info
    {
        #region Instance Properties
        [Key]
        public int delivery_order_info_id { get; set; }

        public int? delivery_order_id { get; set; }

        public string? sales_order_no { get; set; }

        public string? quote_no { get; set; }

        public string? contact { get; set; }

        public int? vessel_id { get; set; }

        public DateTime? vessel_eta { get; set; }

        public string? dept_code { get; set; }

        public string? sales_person_code { get; set; }

        public DateTime? posting_date { get; set; }

        public DateTime? requested_delivery_date { get; set; }

        public string? internal_dept { get; set; }

        public string? mark_reference_no { get; set; }

        public string? pono { get; set; }

        public string? customer_no { get; set; }

        public string? customer_name { get; set; }

        public string? parent_customer { get; set; }

        public DateTime? promised_delivery_date { get; set; }

        public string? location_code { get; set; }

        public string? agent_service { get; set; }

        public double? packaging_unit_no { get; set; }

        public int? customerid { get; set; }

        public string? currency_code { get; set; }

        public string? do_job_no { get; set; }

        public string? good_return_remarks { get; set; }


        public DateTime? shipmentdate { get; set; }
        public DateTime? planneddeliverydate { get; set; }
        public DateTime? plannedshipmentdate { get; set; }

        public DateTime? do_verified_date { get; set; }
        #endregion Instance Properties
    }

    public class V_Delivery_Orders_Info
    {
        #region Instance Properties
        [Key]
        public int delivery_order_id { get; set; }

        public string? delivery_order_no { get; set; }

        public int? shipmentid { get; set; }

        public int? tripdetailid { get; set; }

        public int? tripid { get; set; }

        public string? sales_order_no { get; set; }

        public string? quote_no { get; set; }

        public string? contact { get; set; }

        public int? vessel_id { get; set; }

        public DateTime? vessel_eta { get; set; }

        public string? dept_code { get; set; }

        public string? sales_person_code { get; set; }

        public DateTime? posting_date { get; set; }

        public DateTime? requested_delivery_date { get; set; }

        public string? internal_dept { get; set; }

        public string? mark_reference_no { get; set; }

        public string? pono { get; set; }

        public string? customer_no { get; set; }

        public string? customer_name { get; set; }

        public DateTime? planned_ship_date { get; set; }

        public string? vessel_code { get; set; }

        public string? vessel_name { get; set; }

        public string? imo_no { get; set; }

        public string? jobno { get; set; }

        public string? status_desc { get; set; }

        public int? statusid { get; set; }

        public string? order_no { get; set; }

        public string? parent_customer { get; set; }

        public DateTime? promised_delivery_date { get; set; }

        public double? packaging_unit_no { get; set; }

        public string? agent_service { get; set; }

        public string? location_code { get; set; }

        public int? companyid { get; set; }

        public int? customerid { get; set; }

        public string? currency_code { get; set; }

        public string? do_job_no { get; set; }

        public string? good_return_remarks { get; set; }

        public int? end_customerid { get; set; }

        public DateTime? shipmentdate { get; set; }
        public DateTime? planneddeliverydate { get; set; }
        public DateTime? plannedshipmentdate { get; set; }
        public DateTime? do_verified_date { get; set; }
        [NotMapped] //added by ravi 28-11-2024
        public string? CompanyName { get; set; }
        [NotMapped] //added by ravi 28-11-2024
        public string? CompanyCode { get; set; }

        public int? internalOrderId { get; set; }

        #endregion Instance Properties
    }

    public class Delivery_Orders_DropDown
    {
        public int? delivery_order_id { get; set; }

        public string? delivery_order_no { get; set; }
    }
}
