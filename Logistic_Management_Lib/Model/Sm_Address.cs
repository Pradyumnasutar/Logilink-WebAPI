using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class SM_ADDRESS
    {
        #region Instance Properties
        [Key]
        public int addressid { get; set; }

        public string? addr_code { get; set; }

        public string? addr_name { get; set; }

        public string? contact_person { get; set; }

        public string? address1 { get; set; }

        public string? address2 { get; set; }

        public string? address3 { get; set; }

        public string? address4 { get; set; }

        public string? addr_city { get; set; }

        public string? addr_country { get; set; }

        public string? addr_zipcode { get; set; }

        public string? addr_phone1 { get; set; }

        public string? addr_phone2 { get; set; }

        public string? addr_fax { get; set; }

        public string? addr_telex { get; set; }

        public string? addr_email { get; set; }

        public string? addr_mobilephone { get; set; }

        public string? addr_type { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? update_date { get; set; }

        public int? addr_currencyid { get; set; }

        public string? ebizconnectorid { get; set; }

        public string? ebizcode { get; set; }

        public Int16? active { get; set; }

        public string? addr_mts_code { get; set; }

        public string? addr_mtml_code { get; set; }

        public string? addr_inbox { get; set; }

        public string? addr_outbox { get; set; }

        public Int16? esupplier { get; set; }

        public Int16? einvoice { get; set; }

        public Int16? epurchase { get; set; }

        public int? xml_addr_no { get; set; }

        public string? buyer_link { get; set; }

        public int? group_id { get; set; }

        public string? web_link { get; set; }

        public string? addr_country_code2 { get; set; }

        public int? islesconnect { get; set; }

        public int? company_group_id { get; set; }

        public int? sub_buyer_addressid { get; set; }

        #endregion Instance Properties
    }
}
