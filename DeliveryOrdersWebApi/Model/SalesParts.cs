using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class salesparts
    {
        [Key]
        public int salespartid { get; set; }
        public string? catalog_no { get; set; }
        public string? catalog_desc { get; set; }
        public string? partname { get; set; }
        public string? uom { get; set; }
        public string? part_number { get; set; }
        public double? part_price { get; set; }
        public double? part_price_incl_tax { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? sales_part_type { get; set; }
        public int? driver_allocation_required { get; set; }
        public int? used_for_purchase { get; set; }
        public int? part_status { get; set; }
        public double? min_sales_qty { get; set; }
        public int? currencyid { get; set; }
        public string? remarks { get; set; }
        public int? taxid { get; set; }
        public int? salegroupid { get; set; }
        //public string? TAX_CODE { get; set; }
        public int? expiry_date_required { get; set; }
        public int? receive_with_serials { get; set; }
        public int? receive_with_lots { get; set; }
        public double? m3 { get; set; }
        public double? weight { get; set; }
        public int? product_codeid { get; set; }
        public int? product_familyid { get; set; }
        public int? stock_codeid { get; set; }
        public string? cust_part_no { get; set; }
        public string? cust_part_desc { get; set; }
        public double? length { get; set; }
        public double? height { get; set; }
        public double? width { get; set; }
    }

    public partial class v_salesparts
    {
        [Key]
        public int part_site_link_id { get; set; }
        public int salespartid { get; set; }
        public string? catalog_no { get; set; }
        public string? catalog_desc { get; set; }
        public string? partname { get; set; }
        public string? uom { get; set; }
        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? sales_part_type { get; set; }
        public int? driver_allocation_required { get; set; }
        public int? used_for_purchase { get; set; }
        public double? part_price { get; set; }
        public string? part_number { get; set; }
        public double? part_price_incl_tax { get; set; }
        public int? part_status { get; set; }
        public int? siteid { get; set; }
        public string? site_name { get; set; }
        public string? site_code { get; set; }
        public double? min_sales_qty { get; set; }
        public string? remarks { get; set; }
        public int? currencyid { get; set; }
        public string? curr_code { get; set; }
        public string? currency { get; set; }
        public int? taxid { get; set; }
        public string? tax_code { get; set; }
        public int? salegroupid { get; set; }
        public string? salegroupcode { get; set; }
        public string? salegroupdesc { get; set; }
        public int? expiry_date_required { get; set; }
        public int? receive_with_serials { get; set; }
        public int? receive_with_lots { get; set; }
        public double? m3 { get; set; }
        public int? inventory_type { get; set; }

        public double? weight { get; set; }
        public int? product_codeid { get; set; }
        public int? product_familyid { get; set; }
        public int? stock_codeid { get; set; }
        public string? cust_part_no { get; set; }
        public string? cust_part_desc { get; set; }
        public double? length { get; set; }
        public double? height { get; set; }
        public double? width { get; set; }



    }
}
