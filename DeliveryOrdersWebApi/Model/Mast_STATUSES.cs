using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class Mast_STATUSES
    {
        [Key]
        public int statusid { get; set; }
        public string? status_desc { get; set; }
    }

    public partial class V_MODULE_STATUSES
    {
        [Key]
        public int statusid { get; set; }
        public string? status_desc { get; set; }
        public int moduleid { get; set; }
        public int? status_level { get; set; }
    }
}
