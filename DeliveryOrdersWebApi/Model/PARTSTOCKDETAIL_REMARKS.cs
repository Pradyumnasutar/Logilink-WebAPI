using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class PARTSTOCKDETAIL_REMARKS
    {
        [Key]
        public int partstockdetail_remark_id { get; set; }
        public int? partstockdetailid { get; set; }
        public int? link_record_id { get; set; }
        public int? module_id { get; set; }
        public string? remarks { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }
        public int? link_record_id_2 { get; set; }
    }
}
