using System;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public partial class PartInventoryStock
    {
        [Key]
        public int PARTSTOCKID { get; set; }
        public System.Nullable<int> SalesPartId { get; set; }
        public System.Nullable<double> QTY_IN_HAND { get; set; }
        public System.Nullable<double> QTY_RESERVED { get; set; }
        public System.Nullable<double> QTY_INTRANSIT { get; set; }
        public System.Nullable<double> PART_PRICE { get; set; }
        public System.Nullable<int> PARTLOCATIONID { get; set; }
        public System.Nullable<int> CURRENCYID { get; set; }
        public System.Nullable<DateTime> UPDATED_DATE { get; set; }
        public System.Nullable<DateTime> CREATED_DATE { get; set; }
        public System.Nullable<int> SITEID { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? LOT_NO { get; set; }
        public string? BATCH_NO { get; set; }
        public double? M3 { get; set; }
        public System.Nullable<DateTime> EXPIRY_DATE { get; set; }
        public int? customerid { get; set; }
    }

    public class V_PartInventoryStock
    {
        [Key]
        public int PARTSTOCKID { get; set; }
        public System.Nullable<int> SalesPartId { get; set; }
        public System.Nullable<double> QTY_IN_HAND { get; set; }
        public System.Nullable<double> QTY_RESERVED { get; set; }
        public System.Nullable<double> QTY_INTRANSIT { get; set; }
        public string? PARTLOCATION_DESCR { get; set; }
        public string? PARTLOCATION_CODE { get; set; }
        public string? CURR_CODE { get; set; }
        public System.Nullable<DateTime> CREATED_DATE { get; set; }
        public string? SITE_CODE { get; set; }
        public string? SERIAL_NO { get; set; }
        public string? LOT_NO { get; set; }
        public string? BATCH_NO { get; set; }
        public string? PART_NUMBER { get; set; }
        public string? PARTNAME { get; set; }
        public string? UOM { get; set; }
        public System.Nullable<int> SITEID { get; set; }
        public System.Nullable<int> PARTLOCATIONID { get; set; }
        public double? M3 { get; set; }
        public System.Nullable<DateTime> EXPIRY_DATE { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
    }

    public class PartInventoryStockDetails
    {
        [Key]
        public int PART_STOCK_DETAIL_ID { get; set; }
        public int? SalesPartId { get; set; }
        public int? LOGTYPE { get; set; }
        public DateTime? LOGDATE { get; set; }
        public int? USERID { get; set; }
        public double? QUANTITY { get; set; }
        public string? UOM { get; set; }
        public int? PARTLOCATIONID { get; set; }
        public double? LOGPRICE { get; set; }
        public int? CURRENCYID { get; set; }
        public double? LOGEXCHRATE { get; set; }
        public string? LOGNOTE { get; set; }
        public DateTime? UPDATED_DATE { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public int? SITEID { get; set; }
        public int? OrderId { get; set; }
        public string? TRANS_TYPE { get; set; }
        public DateTime? DATE_IN { get; set; }
        public DateTime? DATE_OUT { get; set; }
        public double? M3 { get; set; }
        public string? SERIAL { get; set; }
        public string? BATCH { get; set; }
        public System.Nullable<DateTime> EXPIRY_DATE { get; set; }
        public int? internallineid { get; set; }
        public int? shipmentlineid { get; set; }
        public int? shipmentid { get; set; }
        public int? PICKED_QTY { get; set; }
        public int? customerid { get; set; }
        public string? marking { get; set; }
        public double? weight { get; set; }
        public int? stock_typeid { get; set; }
        public int? qty_intransit_to_location { get; set; }
        public double? dimension { get; set; }
        public int? grn_exported { get; set; }
        public int? pick_exported { get; set; }
        public int? move_exported { get; set; }
        public int? receive_with_bulk { get; set; }
        public int? stock_statusid { get; set; }

        public int? CustomerOrderId { get; set; }
        public int? CustomerOrderLineId { get; set; }

    }

  
    public class V_PartInventoryStockDetails
    {
        [Key]
        public int PART_STOCK_DETAIL_ID { get; set; }
        public int? SalesPartId { get; set; }
        public int? LOGTYPE { get; set; }
        public DateTime? LOGDATE { get; set; }
        public double? QUANTITY { get; set; }
        public string? UOM { get; set; }
        public string? PART_NUMBER { get; set; }
        public string? PARTNAME { get; set; }
        public int? PARTLOCATIONID { get; set; }
        public string? PARTLOCATION_CODE { get; set; }
        public double? LOGPRICE { get; set; }
        public string? CURR_CODE { get; set; }
        public string? LOGNOTE { get; set; }
        public int? SITEID { get; set; }
        public string? SITE_CODE { get; set; }
        public int? OrderId { get; set; }
        public string? TRANS_TYPE { get; set; }
        public DateTime? DATE_IN { get; set; }
        public DateTime? DATE_OUT { get; set; }
        public int? AGE_DAYS { get; set; }
        public double? M3 { get; set; }
        public string? SERIAL { get; set; }
        public string? BATCH { get; set; }
        public System.Nullable<DateTime> EXPIRY_DATE { get; set; }
        public int? Shipmentid { get; set; }
        public string? internal_order_no { get; set; }
        public string? shipmentno { get; set; }
        public DateTime? order_date { get; set; }
        public int? RECEIVE_WITH_SERIALS { get; set; }
        public int? PICKED_QTY { get; set; }
        public int? shipmentlineid { get; set; }
        public int? internallineid { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public int? EXPIRY_DAYS { get; set; }
        public string? marking { get; set; }
        public int? stock_typeid { get; set; }
        public string? stock_type { get; set; }
        public string? partlocation_descr { get; set; }
        public int? qty_intransit_to_location { get; set; }
        public string? status_text { get; set; }
        public int? part_supply_control { get; set; }
        public int? part_auto_reservation_control { get; set; }
        public int? part_manual_reservation_control { get; set; }
        public int? part_order_issue_control { get; set; }
        public int? part_nonorder_issue_control { get; set; }
        public int? part_counting_control { get; set; }
        public int? validity { get; set; }
        public int? part_scrap_control { get; set; }
        public int? receive_with_lots { get; set; }
        public int? expiry_date_required { get; set; }
        public int? receive_with_bulk { get; set; }
        public int? stock_statusid { get; set; }
        public string? stock_status_text { get; set; }

        public int? CustomerOrderId { get; set; }
        public int? CustomerOrderLineId { get; set; }
    }

    public class Select_PartInventoryStockDetails
    {
        public int? salespartid { get; set; }
        public double? quantity { get; set; }
        public double? quantity_in_hand { get; set; }
        public int? partstockid { get; set; }
        public string? uom { get; set; }
        public string? part_number { get; set; }
        public string? partname { get; set; }
        public int? partlocationid { get; set; }
        public string? partlocation_code { get; set; }
        public int? siteid { get; set; }
        public string? site_code { get; set; }
        public int? orderid { get; set; }
        public string? orderno { get; set; }
        public double? m3 { get; set; }
        public string? serial { get; set; }
        public string? batch { get; set; }
        public System.Nullable<DateTime> expiry_date { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public int? stock_typeid { get; set; }
        public string? stock_type { get; set; }
        public string? partlocation_descr { get; set; }

        public int? receive_with_serial { get; set; }
        public int? receive_with_lots { get; set; }
        public int? expiry_date_required { get; set; }
        public int? receive_with_bulk { get; set; }

        public double? order_quantity { get; set; }
        public double? order_rec_quantity { get; set; }
        public double? quantity_inbulk_to_be_receive { get; set; }

        public string? receive_date { get; set; }
        public DateTime? updated_date { get; set; }
    }
     
    public class select_PartInventoryStockDetails_Inbulk
    {
        public int? salespartid { get; set; }
        public double? order_quantity { get; set; }
        public double? order_rec_quantity { get; set; }
        public double? quantity_in_hand { get; set; }
        public double? quantity_inbulk_to_be_receive{ get; set; }
        public int? partstockid { get; set; }
        public string? uom { get; set; }
        public string? part_number { get; set; }
        public string? partname { get; set; }
        public int? partlocationid { get; set; }
        public string? partlocation_code { get; set; }
        public int? siteid { get; set; }
        public string? site_code { get; set; }
        public int? orderid { get; set; }
        public string? orderno { get; set; }
        public double? m3 { get; set; }
        public string? serial { get; set; }
        public string? batch { get; set; }
        public System.Nullable<DateTime> expiry_date { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public int? stock_typeid { get; set; }
        public string? stock_type { get; set; }
        public string? partlocation_descr { get; set; }
        public int? receive_with_lots { get; set; }
        public int? expiry_date_required { get; set; }
        public int? receive_with_serials { get; set; }
        public int? receive_with_bulk { get; set; }
        public string? receive_date { get; set; }
    }

   

    public class Save_Inbulk_Details
    {
        public int UserId { get; set; }
        public int? orderid { get; set; }
        public int? salespartid { get; set; }
        public int? partlocationid { get; set; }
        public int? stocktypeid { get; set; }
        public string? serial { get; set; }
        public string? batch { get; set; }
        public string? marking { get; set; }
        public string expiry_date { get; set; }
        public double? selected_qty { get; set; }
    }

    public class Single_Step_Save_Inbulk_Details
    {
        public int UserId { get; set; }
        public int? orderid { get; set; }
        public int? salespartid { get; set; }
        public int? partlocationid { get; set; }
        public int? stocktypeid { get; set; }
        public string? serial { get; set; }
        public string? batch { get; set; }
        public string? marking { get; set; }
        public string expiry_date { get; set; }
        public double? selected_qty { get; set; }
        public int? finalpartlocationid { get; set; }
    }

    public class Single_Step_Move_Details
    {
        public int UserId { get; set; }
        public int? orderid { get; set; }
        public int? salespartid { get; set; }
        public int? partlocationid { get; set; }
        public int? stocktypeid { get; set; }
        public string? serial { get; set; }
        public string? batch { get; set; }
        public string? marking { get; set; }
        public string expiry_date { get; set; }
        public double? selected_qty { get; set; }
        public int? finalpartlocationid { get; set; }
    }

    public class Customer_Info
    {
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
    }

    public class StockType_Info_by_Customer
    {
        public int? customerid { get; set; }
        public int? stocktypeid { get; set; }
        public string? stocktypecode { get; set; }
    }

    public class Customer_Info_EqualityComparer : IEqualityComparer<Customer_Info>
    {
        public bool Equals(Customer_Info x, Customer_Info y)
        {
            return x.customerid == y.customerid && x.customer_name == y.customer_name;
        }

        public int GetHashCode(Customer_Info obj)
        {
            return obj.customerid.GetHashCode() ^ obj.customer_name.GetHashCode();
        }
    }

  
    //public class StockType_Info_by_Customer_EqualityComparer : IEqualityComparer<StockType_Info_by_Customer>
    //{
    //    public bool Equals(StockType_Info_by_Customer x, StockType_Info_by_Customer y)
    //    {
    //        return x.customerid == y.customerid && x.stocktypeid == y.stocktypeid && x.stocktypecode == y.stocktypecode;
    //    }

    //    public int GetHashCode(StockType_Info_by_Customer obj)
    //    {
    //        return obj.customerid.GetHashCode() ^ obj.stocktypeid.GetHashCode() ^ obj.stocktypecode.GetHashCode();
    //    }
    //}

    public class StockType_Info_by_Customer_EqualityComparer<T> : IEqualityComparer<T> where T : class
    {
        public bool Equals(T x, T y)
        {
            if (ReferenceEquals(x, y))
                return true;
            if (x is null || y is null)
                return false;

            // Compare properties, considering null values
            return x.GetType().GetProperties()
                .All(prop =>
                {
                    var xValue = prop.GetValue(x);
                    var yValue = prop.GetValue(y);

                    return xValue == null && yValue == null || xValue?.Equals(yValue) == true;
                });
        }

        public int GetHashCode(T obj)
        {
            if (obj is null)
                return 0;

            // Hash properties, considering null values
            return obj.GetType().GetProperties()
                .Aggregate(17, (hash, prop) =>
                {
                    var value = prop.GetValue(obj);
                    return hash * 23 + (value?.GetHashCode() ?? 0);
                });
        }
    }


    public class epod_Reject_V_PartInventoryStockDetails
    {
        public int? part_stock_detail_id { get; set; }
        public int? salespartid { get; set; }
        public int? shipmentlineid { get; set; }
        public string? serial { get; set; }
        public int? receive_with_serials { get; set; }
        public string? stock_status_text { get; set; }
        public int? stock_statusid { get; set; }
        public string? remarks { get; set; }
    }

}
