using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DeliveryOrdersWebApi.Model
{
    public partial class Mast_SITE_CONFIG
    {
        
        [Key]
        public int SiteConfigId { get; set; }
        public int? ModuleId { get; set; }
        public int? SiteId { get; set; }
        public int? SiteConfig_ParamId { get; set; }
        public string? SiteConfig_Param_Code { get; set; }
        public string? Param_Value { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        
       
    }
}
