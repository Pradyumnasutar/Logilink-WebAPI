using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class les_Customers
    {
        #region Instance Properties
        [Key]
        public int customerid { get; set; }

        public string? cust_code { get; set; }

        public string? cust_name { get; set; }

        public string? cust_type { get; set; }

        public string? address1 { get; set; }

        public string? address2 { get; set; }

        public string? address3 { get; set; }

        public string? addr_city { get; set; }

        public string? addr_state { get; set; }

        public string? addr_country { get; set; }

        public string? phone { get; set; }

        public string? emailid { get; set; }

        public string? fax { get; set; }

        public int? companyid { get; set; }

        public string? company_name { get; set; }

        public string? homepage { get; set; }

        public string? contact_person_name { get; set; }

        public int? contact_personid { get; set; }

        public string? address4 { get; set; }

        public string? zipcode { get; set; }

        public int? parentid { get; set; }

        public int? paytermsid { get; set; }

        public string? payment_terms { get; set; }

        public double? credit_limit { get; set; }

        public int? creditlimit_usage { get; set; }

        public string? curr_code { get; set; }

        public int? brokerid { get; set; }

        public int? currencyid { get; set; }

        public int? addressid { get; set; }

        public double? balance_lcy { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? updated_date { get; set; }

        #endregion Instance Properties
    }

    public class lesv_Customers
    {
        #region Instance Properties
        [Key]
        public int customerid { get; set; }

        public string? cust_code { get; set; }

        public string? cust_name { get; set; }

        public int? parentid { get; set; }

        public string? parent_code { get; set; }

        public string? parent_name { get; set; }

        public int? brokerid { get; set; }

        public string? broker_code { get; set; }

        public string? broker_name { get; set; }

        public string? cust_type { get; set; }

        public string? address1 { get; set; }

        public string? address2 { get; set; }

        public string? address3 { get; set; }

        public string? addr_city { get; set; }

        public string? addr_state { get; set; }

        public string? addr_country { get; set; }

        public string? phone { get; set; }

        public string? emailid { get; set; }

        public string? fax { get; set; }

        public int? companyid { get; set; }

        public string? company_name { get; set; }

        public string? homepage { get; set; }

        public string? contact_person_name { get; set; }

        public double? balance_lcy { get; set; }

        public int? contact_personid { get; set; }

        public string? address4 { get; set; }

        public int? addressid { get; set; }

        public int? currencyid { get; set; }

        public string? curr_code { get; set; }

        public int? creditlimit_usage { get; set; }

        public double? credit_limit { get; set; }

        public string? payment_terms { get; set; }

        public int? paytermsid { get; set; }

        public string? zipcode { get; set; }

        public string? addr_type { get; set; }

        #endregion Instance Properties
    }

    public class Customers_Grid
    {
        #region Instance Properties
        
        public int customerid { get; set; }

        public string? cust_code { get; set; }

        public string? cust_name { get; set; }

        public string? broker_code { get; set; }

        public string? broker_name { get; set; }

        public string? cust_type { get; set; }

        public string? addr_state { get; set; }

        public string? addr_country { get; set; }

        public string? phone { get; set; }

        public string? emailid { get; set; }

        public string? fax { get; set; }

        public int? companyid { get; set; }

        public string? company_name { get; set; }

        public string? curr_code { get; set; }

        public string? addr_type { get; set; }

        #endregion Instance Properties
    }

}
