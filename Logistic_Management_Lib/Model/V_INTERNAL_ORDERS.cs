using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class V_INTERNAL_ORDERS
    {
        [Key]
        public int internalorderid { get; set; }
        public string internal_order_no { get; set; } = "";
        public string internal_order_desc { get; set; } = "";
        public int? customerid { get; set; }
        public int? buyerid { get; set; }
        public int? siteid { get; set; }
        public int? statusid { get; set; }
        public string joborderno { get; set; } = "";
        public int? order_code_id { get; set; }
        public DateTime? receiptdate { get; set; }
        public string projectid { get; set; } = "";
        public string remarks { get; set; } = "";
        public string consignee { get; set; } = "";
        public string fromservicepoint { get; set; } = "";
        public string toservicepoint { get; set; } = "";
        public string containernumber { get; set; } = "";
        public string containertype { get; set; } = "";
        public string containersize { get; set; } = "";
        public string sealno { get; set; } = "";
        public string bondedlotno { get; set; } = "";
        public string inwardpermitno { get; set; } = "";
        public DateTime? orderdate { get; set; }
        public int? paytermsid { get; set; }
        public int? forwarderid { get; set; }
        public DateTime? delivery_date { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? is_delete { get; set; }
        public int? isauto { get; set; }
        public int? is_billed { get; set; }
        public int? inboundshipmentid { get; set; }
        public string external_reference_no { get; set; } = "";
        public int? container_size_id { get; set; }
        public int? container_type_id { get; set; }
        public int? fromservicepointsid { get; set; }
        public int? toservicepointsid { get; set; }
        public string cust_code { get; set; } = "";
        public string cust_name { get; set; } = "";
        public string status_desc { get; set; }= "";
        public string shipmentno { get; set; } = "";
        public string? Currency { get; set; } = "";
        public int? FrieghtAmount { get; set; }
        public int? OtherCost { get; set; }
        public int? POAmount { get; set; }
        public int? ItemTotal { get; set; }
        public int? quotationid { get; set; }
    }
}
