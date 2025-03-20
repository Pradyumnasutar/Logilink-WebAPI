using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class V_DRIVER_COMMISSION_LINK_LINES
    {
        [Key]
        public int? LINEID { get; set; }
        public string? Driver_Name { get; set; }
        public string? Driver_Role { get; set; }
        public string? Vehicle_No { get; set; }
        public int? COMMISSIONAGREEID { get; set; }
        public int? minvalue { get; set; }
        public double? comm_percentage { get; set; }
        public double? comm_amt_curr { get; set; }
        public double? overtime_amt_curr { get; set; }
        public int? maxhoures { get; set; }
        public DateTime? VALIDFROM { get; set; }
        public DateTime? VALIDTO { get; set; }
        public string? COMMSSIONAGREECODE { get; set; }
        public string? COMMISSIONDESC { get; set; }
        public int? CURRENCYID { get; set; }
        public int? DriverProfileid { get; set; }
        public int? LINENO { get; set; }
        public int? STATUSID { get; set; }
        public string? STATUS_DESC { get; set; }

    }
}
