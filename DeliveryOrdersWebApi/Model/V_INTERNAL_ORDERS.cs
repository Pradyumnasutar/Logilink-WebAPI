using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class INTERNAL_ORDERS
    {
        [Key]
        public int INTERNALORDERID { get; set; }

        public string? INTERNAL_ORDER_NO { get; set; }

        public string? INTERNAL_ORDER_DESC { get; set; }

        public int? CUSTOMERID { get; set; }

        public int? BUYERID { get; set; }

        public int? SITEID { get; set; }

        public int? STATUSID { get; set; }

        public string? joborderno { get; set; }

        public int? ORDER_CODE_ID { get; set; }

        public DateTime? receiptdate { get; set; }

        public int? currencyid { get; set; }

        //public int? coordinatorid { get; set; }

        public string? projectid { get; set; }

        public string? remarks { get; set; }

        public string? consignee { get; set; }

        public string? fromservicepoint { get; set; }

        public string? toservicepoint { get; set; }

        public string? containernumber { get; set; }

        public string? containertype { get; set; }

        public string? containersize { get; set; }

        public string? sealno { get; set; }
        public string? bondedlotno { get; set; }

        //public string? billoflading { get; set; }

        //public string? vesselno { get; set; }

        //public string? vesselname { get; set; }

        public string? inwardpermitno { get; set; }

        public DateTime? orderdate { get; set; }

        public int? paytermsid { get; set; }

        public int? forwarderid { get; set; }

        public DateTime? delivery_date { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        public int? Is_Delete { get; set; }

        public int? IsAuto { get; set; }//09/08/2023
        public int? inboundshipmentid { get; set; }
        public string? external_reference_no { get; set; }

    }

    public class V_INTERNAL_ORDERS
    {

        [Key]
        public int internalorderid { get; set; }

        public string? internal_order_no { get; set; }

        public string? internal_order_desc { get; set; }

        public int? order_code_id { get; set; }
        public string? order_code { get; set; }
        public string? customer_name { get; set; }

        public string? site_name { get; set; }
        public string? status_text { get; set; }

        public string? projectid { get; set; }

        public int? customerid { get; set; }

        public string? joborderno { get; set; }

        public string? curr_code { get; set; }


        public DateTime? receiptdate { get; set; }
        public int? statusid { get; set; }
        public string? consignee { get; set; }
        public string? fromservicepoint { get; set; }
        public string? toservicepoint { get; set; }
        public string? containernumber { get; set; }
        public string? containertype { get; set; }
        public string? containersize { get; set; }
        public string? sealno { get; set; }
        public string? bondedlotno { get; set; }
        public string? inwardpermitno { get; set; }

        public int? IsAuto { get; set; }
        public int? CompanyId { get; set; }
        public int? siteid { get; set; }


    }

   

}
