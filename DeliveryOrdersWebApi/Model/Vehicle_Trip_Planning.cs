using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class Vehicle_Trip_Planning
    {
        [Key]
        public int tripid { get; set; }
        public int? shipmentid { get; set; }
        public int? statusid { get; set; }
        public int? point_typeid { get; set; }
        public int? customerid { get; set; }
        public int? siteid { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? created_date { get; set; }

        public int? Is_Delete { get; set; }
        public int? orderid { get; set; }
        public DateTime? planned_delivery_date { get; set; }

        public string? source_reftype { get; set; }//added by Kalpita on 31/07/2023

        public int? exported { get; set; }


    }

    public partial class V_TRIP_PLAN
    {
        [Key]
        public int tripid { get; set; }
        public int? shipmentid { get; set; }
        public int? statusid { get; set; }
        public int? point_typeid { get; set; }
        public int? customerid { get; set; }
        public int? siteid { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? planned_ship_date { get; set; }
        public DateTime? planned_delivery_date { get; set; }
        public string? order_no { get; set; }
        public string? status_desc { get; set; }
        public string? point_code { get; set; }
        public string? customer_code { get; set; }
        public string? customer_name { get; set; }
        public string? site_code { get; set; }
        //added by Kalpita on 04/07/2023
        public string? customer_type { get; set; }
        public int? orderid { get; set; }

        public string? source_reftype { get; set; }//added by Kalpita on 31/07/2023



    }


}
