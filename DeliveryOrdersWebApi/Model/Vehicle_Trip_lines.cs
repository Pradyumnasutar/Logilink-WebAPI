using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class Vehicle_Trip_lines
    {
        [Key]
        public int triplineid { get; set; }
        public int? tripid { get; set; }
        public int? lineno { get; set; }
        public int? shipmentlineid { get; set; }
        public double? qty { get; set; }
        public string uom { get; set; }
        public int? salespartid { get; set; }
        public int? statusid { get; set; }
        public DateTime? created_Date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? Is_Delete { get; set; }
        public int? custorderlineid { get; set; }
        public int? Is_Billed { get; set; }

    }
    public partial class V_Vehicle_Trip_lines
    {
        [Key]
        public int triplineid { get; set; }
        public int? tripid { get; set; }
        public int? lineno { get; set; }
        public string source_ref1 { get; set; }
        public string source_ref2 { get; set; }
        public int? source_ref3 { get; set; }
        public string joborderno { get; set; }
        public string source_partno { get; set; }
        public string source_partdescr { get; set; }
        public int? shipmentlineid { get; set; }
        public double? qty { get; set; }
        public string uom { get; set; }
        public int? salespartid { get; set; }
        public int? statusid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? delivery_date { get; set; }
        public string activity_type { get; set; }
        public double? m3 { get; set; }
        public string buyerpono { get; set; }


        //added on 04/07/2023
        public int? End_CustomerId { get; set; }

        public int? CustomerId { get; set; }

        public string EndCustomer_Name { get; set; }

        public string Customer_Name { get; set; }
        public int? custorderlineid { get; set; }
    }
    public partial class V_Vehicle_Trip_lines_CO
    {
        [Key]
        public int triplineid { get; set; }
        public int? tripid { get; set; }
        public int? lineno { get; set; }
        public string source_ref1 { get; set; }
        public string source_ref2 { get; set; }
        public int? source_ref3 { get; set; }
        public string joborderno { get; set; }
        public string source_partno { get; set; }
        public string source_partdescr { get; set; }
        public int? shipmentlineid { get; set; }
        public double? qty { get; set; }
        public string uom { get; set; }
        public int? salespartid { get; set; }
        public int? statusid { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public DateTime? delivery_date { get; set; }
        public string activity_type { get; set; }
        public double? m3 { get; set; }
        public string buyerpono { get; set; }


        //added on 04/07/2023
        public int? End_CustomerId { get; set; }

        public int? CustomerId { get; set; }

        public string EndCustomer_Name { get; set; }

        public string Customer_Name { get; set; }
        public int? custorderlineid { get; set; }
    }
}
