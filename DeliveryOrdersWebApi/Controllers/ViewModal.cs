using Microsoft.AspNetCore.Mvc;
using DeliveryOrdersWebApi.Model;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Controllers
{

    public class DeliveryOrderDetailsView
    {
        public Model.V_EPOD_DELIVERY_ORDERS deliveryOrder { get; set; }
        public IEnumerable<Model.V_DELIVERY_ORDER_SHIPMENTLINES> shipmentLines { get; set; }
        public IEnumerable<Model.V_DELIVERY_ORDER_CUSTOMER_ORDERLINES> ordershipmentLines { get; set; }
        public IEnumerable<Model.V_Driver_Allocation> driver_Allocation { get; set; }
        public IEnumerable<Model.V_MODULE_STATUSES> module_statuses { get; set; }
        public IEnumerable<Model.V_Delivery_Orders_Address> deliverOrderAddress { get; set; }
        public IEnumerable<Model.V_Available_Drivers> availableDrivers { get; set; }
        public Model.Customers Customers { get; set; }
        public Model.Customers EndCustomers { get; set; }
        public IEnumerable<Model.sDELIVERY_ORDER_DOCUMENTS> sDELIVERY_ORDER_DOCUMENTS { get; set; }
        public ProofOfDeliveryDocument ProofOfDeliveryDocument { get; set; }
        public Model.USER_REVIEW UserReview { get; set; }
        public IEnumerable< Model.epod_Reject_V_PartInventoryStockDetails> PartInventoryStockDetails { get; set; }
        public string? current_Status { get; set; }
    }

    public class WMS_Login_View
    {
        public Model.SM_EXTERNAL_USERS external_User { get; set; }
        public List<Model.MAST_COMPANY> Mast_Company { get; set; }

    }


    public class All_Locations
    {
        public List<ALL_LOCATION> lst_All_Location { get; set; }
        public Model.MAST_COMPANY Mast_Company { get; set; }
    }

    public class Arrival_Locations
    {
        public List<Model.MAST_SALES_PARTS_LOCATION> lst_Arrival_Location { get; set; }
        public Model.MAST_COMPANY Mast_Company { get; set; }
    }

    public class Main_Locations
    {
        public List<Model.MAST_SALES_PARTS_LOCATION> lst_Main_Location { get; set; }
        public Model.MAST_COMPANY Mast_Company { get; set; }
    }

    public class ModalViewSelectedParts
    {
        public List<Model.Customer_Info> customer_info { get; set; }
        public List<Model.StockType_Info_by_Customer> stocktype_info_by_customer { get; set; }
        public List<Model.Select_PartInventoryStockDetails> partlist { get; set; }
    }

    public class PartInventoryStockDetailsFilter {
        public List<Model.Customer_Info> customer_info { get; set; }
        public List<Model.MAST_SALES_PARTS_LOCATION> lst_Location { get; set; }

    }

    public class OpenPartInventoryStockDetails
    {
        public V_PartInventoryStock _PartInventoryStock { get; set; }
        public V_PartInventoryStockDetails _PartInventoryStockDetails { get; set; }
        public List<Stock_Quality> _StockType { get; set; }

    }

    public class userData
    {
        public int? userid { get; set; }
    }

    public class AuditData
    {
        public int? UserId { get; set; }
        public string? ModuleName { get; set; }
        public string? Action { get; set; }

        public string? Message { get; set; }

    }

    public class InternalOrderData
    {
        public int? orderid { get; set; }
        public string? order_no { get; set; }
    }

    public class Driver_Data_Remarks
    {
        public string? datetime { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public int? DriverID { get; set; }
        public string? Driver_Remarks { get; set; }
    }

    public class DO_Reject_Details
    {
        public string? end_trip_date { get; set; }
        public int? deliveryOrderId { get; set; }
        public int? driverID { get; set; }
        public List<RejectedItems> rejectedItems { get; set; }
    }

    public class Reject_Item_Details
    {
        public int? deliveryOrderId { get; set; }
        public int? driverID { get; set; }
        public List<RejectedItems> rejectedItems { get; set; }
    }

    public class RejectedItems
    {
        public int? partstockdetailid { get; set; }
        public int? salespartid { get; set; }
        public int? triplineid { get; set; }
        public int? shipmentlineid { get; set; }
        public double? rejectedqty { get; set; }
        public string? remarks { get; set; }

    }

    public class PartListInfo
    {
        public int? shipmentid { get; set; }

        public int? locationid { get; set; }

    }

    public class PartListInfoOutbound
    {
        public int? userid { get; set; }

        public int? shipmentid { get; set; }

        public int? locationid { get; set; }

    }

    #region Inbound Register

    public class Internal_Order_WMS
    {
        public int? internalorderid { get; set; }
        public string? internal_order_no { get; set; }
        public int? order_code_id { get; set; }
        public string? order_code { get; set; }
        public string? description { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public int? siteid { get; set; }
        public string? site_name { get; set; }

    }

    public class Inbound_Data
    {
        public int? UserId { get; set; }
        public int? customerid { get; set; }
        public int? SiteId { get; set; }
        public int? order_code_id { get; set; }
        public int? SALESPARTID { get; set; }
        public string? CUST_PART_NO { get; set; }
        public string? OrderNo { get; set; }

    }

    public class Inbound_List_Filter
    {
        public Model.MAST_COMPANY Mast_Company { get; set; }
        public List<Model.Mast_Site> Mast_Site { get; set; }
        public List<Model.Mast_ORDER_CODE> Mast_ORDER_CODE { get; set; }
        public List<Model.CustomersFilter> Customers { get; set; }
        public List<Internal_Order_WMS> INTERNAL_ORDERS { get; set; }
    }

    public class Inbound_Item_Filter
    {
        public List<V_INTERNAL_ORDER_LINE> INTERNAL_ORDER_LINES { get; set; }
    }

    public class Inbound_Line_Details
    {
        public Model.MAST_COMPANY Mast_Company { get; set; }
        public List<Stock_Quality> Mast_Stock_type { get; set; }
        public Model.V_INTERNAL_ORDER_LINE V_INTERNAL_ORDER_LINE_Details { get; set; }
        public Model.MAST_SALES_PARTS_LOCATION Arrival_Location { get; set; }

    }

    public class Inbound_Order_Item
    {
        public int? UserId { get; set; }
        public int? order_id { get; set; }
        public string? CUST_PART_NO { get; set; }
    }

    public class Inbound_Details_Data
    {
        public int? UserId { get; set; }
        public int? internallineid { get; set; }

    }

    public class Update_Inbound_Stock_Data
    {
        public int? UserId { get; set; }
        public int? internallineid { get; set; }
        public List<Inbound_Stock_Items> items { get; set; }
    }

    public class Inbound_Stock_Items
    {
        public double? recvqty { get; set; }
        public string? marking { get; set; }
        public int? stocktypeid { get; set; }
        public string? locationcode { get; set; }
        public string? serialno { get; set; }
        public string? batchno { get; set; }
        public string? receivedDate { get; set; }
        public string? expireDate { get; set; }
    }

    public class Update_Inbound_Stock_Data_Inbulk
    {
        public int? UserId { get; set; }
        public int? internallineid { get; set; }
        public List<Inbound_Stock_Items_Inbulk> items { get; set; }
    }

    public class Inbound_Stock_Items_Inbulk
    {
        public double? recvqty { get; set; }
        public string? locationcode { get; set; }
        public string? receivedDate { get; set; }

    }


    #endregion

    #region Outbound Pick List

    public class Outbound_Order_WMS
    {
        public int shipmentid { get; set; }
        public string? order_no { get; set; }
        public string? receiver_type { get; set; }
        public string? status { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public int? siteid { get; set; }
        public string? site_name { get; set; }
        public string? created_date { get; set; }

    }

    public class Outbound_List_Filter
    {
        public Model.MAST_COMPANY Mast_Company { get; set; }
        public List<Model.Mast_Site> Mast_Site { get; set; }
        public List<Model.Mast_STATUSES> List_Status { get; set; }
        public List<Model.CustomersFilter> Customers { get; set; }
        public List<Outbound_Order_WMS> Outbound_orders { get; set; }
    }

    public class Outbound_Line_Details
    {
        public Model.MAST_COMPANY Mast_Company { get; set; }
        public Model.V_SHIPMENT V_shipment { get; set; }
        public IEnumerable<Model.V_SHIPMENT_LINES> SHIPMENT_LINES { get; set; }
        public IEnumerable<Model.ShipmentAddress> shipmentAddresses { get; set; }
        public Model.ShipmentAddress ReceiverAddress { get; set; }
        public IEnumerable<PartShipmentLines> ListPartShipmentLines { get; set; }

    }

    public class Shipment_Line_Picked_Item_Details_Serial
    {
        public PartShipmentLines ShipmentLineDetails { get; set; }
        public List<PickList_Inventory_Serial> PickedPartStockDetailSerial { get; set; }
    }

    public class Shipment_Line_Picked_Item_Details_NonSerial
    {
        public PartShipmentLines ShipmentLineDetails { get; set; }
        public List<PickList_Inventory_NonSerial> PickedPartStockDetailNonSerial { get; set; }
    }

    public class PartShipmentLines
    {
        public int salespartid { get; set; }
        public string partnumber { get; set; }
        public string partname { get; set; }
        public int shipmentid { get; set; }
        public int shipmentlineid { get; set; }
        public int siteid { get; set; }
        public string sitename { get; set; }
        public string uom { get; set; }
        public double weight { get; set; }
        public double m3 { get; set; }
        public string customername { get; set; }
        public int customerid { get; set; }
        public double qty_to_pick { get; set; }
        public double reserve_qty { get; set; }
        public double pick_qty { get; set; }
        public double connected_sourceqty { get; set; }
        public int receive_with_serial { get; set; }
    }

    public class Select_Items_Data_For_Pincking
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? shipmentid { get; set; }
        public int? shipmentlineid { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately
    }

    public class Outbound_Data
    {
        public int? UserId { get; set; }
        public int? customerid { get; set; }
        public int? siteid { get; set; }
        public int statusid { get; set; }
        public int? salespartid { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately
        public string? orderno { get; set; }

    }

    public class PickList_Inventory_Serial
    {
        public int salespartid { get; set; }
        public string? partname { get; set; }
        public string? part_number { get; set; }
        public string? serial { get; set; }
        public int? partlocationid { get; set; }
        public string? partlocation_code { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public double? pickedqty { get; set; }
        public int? shipmentid { get; set; }
        public int? shipmentlineid { get; set; }
    }

    public class PickList_Inventory_NonSerial
    {
        public int salespartid { get; set; }
        public string partname { get; set; }
        public string part_number { get; set; }
        public int partlocationid { get; set; }
        public string partlocation_code { get; set; }
        public int customerid { get; set; }
        public string customer_name { get; set; }
        public double reservedqty { get; set; }
        public double totalqty { get; set; }
        public double pickedqty { get; set; }
        public int shipmentid { get; set; }
        public int shipmentlineid { get; set; }
    }

    public class Picklist_Non_Serial_PartStock_ByLocation
    {
        public List<Picklist_Locations> pick_locationList { get; set; }
        public List<PickList_Inventory_NonSerial> pick_NonSerialInventoryStockList { get; set; }

    }

    public class Picklist_Locations
    {
        public int? locationid { get; set; }
        public string? location_code { get; set; }
    }

    public class Outbound_Order_Item
    {
        public int? UserId { get; set; }
        public int? shipmentid { get; set; }
        public string? CUST_PART_NO { get; set; }
    }

    public class Shipment_Picked_Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? shipmentid { get; set; }
        public int? shipmentlineid { get; set; }
    }

    public class Remove_Picked_Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public string? serial { get; set; }
        public int? partlocationid { get; set; }
        public int? customerid { get; set; }
        public int? shipmentid { get; set; }
        public int? shipmentlineid { get; set; }
        public double? removedQty { get; set; }
    }

    public class Picked_Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public string? serial { get; set; }
        public int? partlocationid { get; set; }
        public int? customerid { get; set; }
        public int? shipmentid { get; set; }
        public int? shipmentlineid { get; set; }
        public double? selecteddQty { get; set; }
    }

    public class Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? siteid { get; set; }
        public int? customerid { get; set; }
    }

    public class Inventory_Summary_By_Location
    {
        public int salespartid { get; set; }
        public string partname { get; set; }
        public string part_number { get; set; }
        public int partlocationid { get; set; }
        public string partlocation_code { get; set; }
        public string partlocation_desc { get; set; }
        public int customerid { get; set; }
        public string customer_name { get; set; }
        public double availableqty { get; set; }
       
    }

    #endregion

    #region Self-Collect Pick list

    public class SelfCollect_Order_WMS
    {
        public int orderid { get; set; }
        public string? order_no { get; set; }
        public string? status { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public int? siteid { get; set; }
        public string? site_name { get; set; }
        public string? created_date { get; set; }

    }

    public class SelfCollect_List_Filter
    {
        public Model.MAST_COMPANY Mast_Company { get; set; }
        public List<Model.Mast_Site> Mast_Site { get; set; }
        public List<Model.Mast_STATUSES> List_Status { get; set; }
        public List<Model.CustomersFilter> Customers { get; set; }
        public List<SelfCollect_Order_WMS> selfcollect_orders { get; set; }
    }

    public class SelfCollect_Line_Details
    {
        public Model.MAST_COMPANY Mast_Company { get; set; }
        public Model.V_CustomerOrders V_CustomerOrders { get; set; }
        public IEnumerable<Model.CustomerOrderLine> Customer_Orders_LINES { get; set; }
        public IEnumerable<PartOrderLines> ListPartOrderLines { get; set; }

    }

    public class PartOrderLines
    {
        public int salespartid { get; set; }
        public string partnumber { get; set; }
        public string partname { get; set; }
        public int orderid { get; set; }
        public int orderlineid { get; set; }
        public int siteid { get; set; }
        public string sitename { get; set; }
        public string uom { get; set; }
        public double weight { get; set; }
        public double m3 { get; set; }
        public string customername { get; set; }
        public int customerid { get; set; }
        public double qty_to_pick { get; set; }
       // public double reserve_qty { get; set; }
        public double pick_qty { get; set; }
        public double connected_sourceqty { get; set; }
        public int receive_with_serial { get; set; }
    }

    public class SelfCollect_Order_Item
    {
        public int? UserId { get; set; }
        public int? Orderid { get; set; }
        public string? CUST_PART_NO { get; set; }
    }

    public class Order_Picked_Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? orderid { get; set; }
        public int? orderlineid { get; set; }
    }

    public class CustOrder_Line_Picked_Item_Details_Serial
    {
        public PartOrderLines CustOrderLineDetails { get; set; }
        public List<Cust_Order_PickList_Inventory_Serial> PickedPartStockDetailSerial { get; set; }
    }

    public class CustOrder_Line_Picked_Item_Details_NonSerial
    {
        public PartOrderLines CustOrderLineDetails { get; set; }
        public List<Cust_Order_PickList_Inventory_NonSerial> PickedPartStockDetailNonSerial { get; set; }
    }

    public class Cust_Order_PickList_Inventory_Serial
    {
        public int salespartid { get; set; }
        public string? partname { get; set; }
        public string? part_number { get; set; }
        public string? serial { get; set; }
        public int? partlocationid { get; set; }
        public string? partlocation_code { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public double? pickedqty { get; set; }
        public int? orderid { get; set; }
        public int? orderlineid { get; set; }
    }

    public class Cust_Order_PickList_Inventory_NonSerial
    {
        public int salespartid { get; set; }
        public string partname { get; set; }
        public string part_number { get; set; }
        public int partlocationid { get; set; }
        public string partlocation_code { get; set; }
        public int customerid { get; set; }
        public string customer_name { get; set; }
        public double reservedqty { get; set; }
        public double totalqty { get; set; }
        public double pickedqty { get; set; }
        public int orderid { get; set; }
        public int orderlineid { get; set; }
    }

    public class Select_Cust_Order_Items_Data_For_Pincking
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? orderid { get; set; }
        public int? orderlineid { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately
    }

    public class Cust_Order_Picked_Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public string? serial { get; set; }
        public int? partlocationid { get; set; }
        public int? customerid { get; set; }
        public int? orderid { get; set; }
        public int? orderlineid { get; set; }
        public double? selecteddQty { get; set; }
    }

    public class Cust_Order_Picklist_Non_Serial_PartStock_ByLocation
    {
        public List<Picklist_Locations> pick_locationList { get; set; }
        public List<Cust_Order_PickList_Inventory_NonSerial> pick_NonSerialInventoryStockList { get; set; }

    }

    public class Cust_Order_Remove_Picked_Items_Data
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public string? serial { get; set; }
        public int? partlocationid { get; set; }
        public int? customerid { get; set; }
        public int? orderid { get; set; }
        public int? orderlineid { get; set; }
        public double? removedQty { get; set; }
    }

    public class PartListInfoSelfCollect
    {
        public int? userid { get; set; }

        public int? orderid { get; set; }

        public int? locationid { get; set; }

    }

    public class Complete_SelfCollectData
    {
        public int? userid { get; set; }
        public int? customerorderid { get; set; }

    }
    #endregion

    #region Receive In Bulk

    public class SetInbulkLocationPartsData
    {
        public int? UserId { get; set; }
        public int? Locationid { get; set; }
        public string OrderNo { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately

    }

    public class Modal_Serial_Inbulk_PartInventoryStockDetails
    {
        public select_PartInventoryStockDetails_Inbulk _partStockDetail_Inbulk { get; set; }
        public List<Stock_Quality> _StockType { get; set; }
    }

    #endregion

    #region Select Parts from Location

    #endregion

    #region  Move Parts from Location

    public class SetLocationPartsData
    {
        public int? UserId { get; set; }
        public int? Locationid { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately
    }

    #endregion

    #region  Putway 

    #endregion

    #region  Update Inventory 
    public class PartData
    {
        public int userid { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately
        public int? customerid { get; set; }
        public int? locationid { get; set; }
        public string? orderno { get; set; }
    }
    #endregion

    #region One step Putaway

    #endregion 

    #region Reject Return Register

    public class All_OrderList
    {
        public List<Order_Number> lst_All_Orders { get; set; }
        
    }

    public class Order_Number
    {
        public int? id { get; set; }
        public string? number { get; set; }
}

    public class Reject_Return_List_Data
    {
        public int? userid { get; set; }
        public int? customerid { get; set; }
        public int? siteid { get; set; }
        public int? salespartid { get; set; }
        public string? scannedpartnumber { get; set; }
        public string? scannedSerialNo { get; set; }
        public string? orderno { get; set; }

    }

    public class Return_DeliveryOrder_List_Filter
    {
        public List<Model.Mast_Site> Mast_Site { get; set; }
        public List<Model.CustomersFilter> Customers { get; set; }
        public List<Return_Reject_Order_WMS> Return_Reject_Delivery_Orders { get; set; }
    }

    public class V_PartInventoryStockDetails_With_Remarks
    {
        public int PART_STOCK_DETAIL_ID { get; set; }
        public int? SalesPartId { get; set; }
        public int? LOGTYPE { get; set; }
        public DateTime? LOGDATE { get; set; }
        public double? QUANTITY { get; set; }
        public string UOM { get; set; }
        public string PART_NUMBER { get; set; }
        public string PARTNAME { get; set; }
        public int? PARTLOCATIONID { get; set; }
        public string PARTLOCATION_CODE { get; set; }
        public double? LOGPRICE { get; set; }
        public string CURR_CODE { get; set; }
        public string LOGNOTE { get; set; }
        public int? SITEID { get; set; }
        public string SITE_CODE { get; set; }
        public int? OrderId { get; set; }
        public string TRANS_TYPE { get; set; }
        public DateTime? DATE_IN { get; set; }
        public DateTime? DATE_OUT { get; set; }
        public int? AGE_DAYS { get; set; }
        public double? M3 { get; set; }
        public string SERIAL { get; set; }
        public string BATCH { get; set; }
        public System.Nullable<DateTime> EXPIRY_DATE { get; set; }
        public int? Shipmentid { get; set; }
        public string internal_order_no { get; set; }
        public string shipmentno { get; set; }
        public DateTime? order_date { get; set; }
        public int? RECEIVE_WITH_SERIALS { get; set; }
        public int? RECEIVE_WITH_LOTS { get; set; }
        public int? EXPIRY_DATE_REQUIRED { get; set; }
        public int? PICKED_QTY { get; set; }
        public int? shipmentlineid { get; set; }
        public int? internallineid { get; set; }
        public int? customerid { get; set; }
        public string customer_name { get; set; }
        public int? EXPIRY_DAYS { get; set; }
        public string marking { get; set; }
        public int? stock_typeid { get; set; }
        public string stock_type { get; set; }
        public string partlocation_descr { get; set; }

        public int? part_supply_control { get; set; }
        public int? part_auto_reservation_control { get; set; }
        public int? part_manual_reservation_control { get; set; }
        public int? part_order_issue_control { get; set; }
        public int? part_nonorder_issue_control { get; set; }
        public int? part_counting_control { get; set; }
        public int? validity { get; set; }
        public int? part_scrap_control { get; set; }
        public int? qty_intransit_to_location { get; set; }
        public string status_text { get; set; }
        public int? stock_statusid { get; set; }
        public string stock_status_text { get; set; }
        public string remarks { get; set; }
        public int? reject_qty { get; set; }

    }

    public class Return_Reject_Order_WMS
    {
        public int? delivery_order_id { get; set; }
        public string? delivery_order_no { get; set; }
        public int? shipmentid { get; set; }
        public int? tripid { get; set; }
        public int? tripdetailid { get; set; }
        public int? customerid { get; set; }
        public int? siteid { get; set; }
        public string? site_name { get; set; }
        public int? trip_plan_no { get; set; }
        public int? statusid { get; set; }
        public string? status_desc { get; set; }
        public DateTime? delivery_date { get; set; }
        public DateTime? do_complete_date { get; set; }
    }

    public class Return_Reject_Register_Items_data
    {
        public int? userid { get; set; }
        public int? tripdetailid { get; set; }
        public int? delivery_order_id { get; set; }
        public string? scannedpartnumber { get; set; }
        public string? scannedSerialNo { get; set; }
    }

    public class Return_Reject_Delivery_Items
    {
        public List<V_DELIVERY_ORDER_SHIPMENTLINES_REJECT_RETURN_View> Delivery_Items_Lines { get; set; }
    }

    public class V_DELIVERY_ORDER_SHIPMENTLINES_REJECT_RETURN_View
    {
        public int ShipmentLineId { get; set; }
        public int? SalesPartId { get; set; }
        public int? ShipmentId { get; set; }
        public int? OrderId { get; set; }
        public int? CustOrderLineId { get; set; }
        //public string Source_Ref1 { get; set; }
        //public string Source_Ref2 { get; set; }
        //public string Source_RefType { get; set; }
        public string Source_PartNo { get; set; }
        public string Source_PartDescr { get; set; }
        public double? Connected_SourceQty { get; set; }
        public double? Inventory_Qty { get; set; }
        public double? Reserved_Qty { get; set; }
        public double? Picked_Qty { get; set; }
        public double? Delivered_Qty { get; set; }
        //public DateTime? Planned_ship_date { get; set; }
        //public DateTime? Created_Date { get; set; }
        //public DateTime? Updated_Date { get; set; }
        public int? Item_Status { get; set; }
       // public DateTime? Planned_Delivery_Date { get; set; }
        public int? triplineid { get; set; }
        public int? tripid { get; set; }
        public int? lineno { get; set; }
        public double? qty { get; set; }
        public string uom { get; set; }
        public string Customer_Name { get; set; }
        //public string End_Customer_Name { get; set; }
        //public string Customer_Code { get; set; }
        //public string End_Customer_Code { get; set; }
        public int? CUSTOMERID { get; set; }
        public int? END_CUSTOMERID { get; set; }
        public int? Vehicle_TonnageId { get; set; }
        public int? Trailer_TypeId { get; set; }
        public string Vehicle_Tonnage { get; set; }
        public string Trailer_Type { get; set; }
        public int? DELIVERY_ORDER_ID { get; set; }
        public double? reject_return_Qty { get; set; }
        public double? registered_Qty { get; set; }
        public double? qty_to_register { get; set; }
        public int? receive_with_serial { get; set; }
        public int? curr_partStock_statusId { get; set; }
    }

    public class Return_Reject_Register_Items_List
    {
        public int? userid { get; set; }
        public int? delivery_order_id { get; set; }
        public int? salespartid { get; set; }
        public int? shipmentlineid { get; set; }
        
    }

    public class Reject_Return_Items_With_Remarks
    {
        public int part_stock_detail_id { get; set; }
        public int? salespartid { get; set; }
        public double? quantity { get; set; }
        public string uom { get; set; }
        public string part_number { get; set; }
        public string partname { get; set; }
        public int? partlocationid { get; set; }
        public string partlocation_code { get; set; }
        public string partlocation_descr { get; set; }
        public string curr_code { get; set; }
        public int? siteid { get; set; }
        public string site_code { get; set; }
        public int? orderid { get; set; }
        public string serial { get; set; }
        public int? shipmentid { get; set; }
        public string shipmentno { get; set; }
        public int? receive_with_serials { get; set; }
        public int? picked_qty { get; set; }
        public int? shipmentlineid { get; set; }
        public int? internallineid { get; set; }
        public int? customerid { get; set; }
        public string customer_name { get; set; }
        public int? expiry_days { get; set; }
        public string marking { get; set; }
        public int? stock_typeid { get; set; }
        public string stock_type { get; set; }
        public string status_text { get; set; }
        public int? stock_statusid { get; set; }
        public string stock_status_text { get; set; }
        public string remarks { get; set; }
        public int? reject_qty { get; set; }

    }

    public class modal_Reject_Retuen_Items
    {
        public List<Stock_Quality> stock_quality_list { get; set; }
        public List<ALL_LOCATION> lst_All_Location { get; set; }
        public List<Reject_Return_Items_With_Remarks> lst_Reject_Return_Items_With_Remarks { get; set; }
    }

    public class Stock_Quality
    {
        public int STOCK_TYPEID { get; set; }
        public string? STOCK_TYPE_DESCRIPTION { get; set; }
    }

    public class ALL_LOCATION
    {
        public int? PARTLOCATIONID { get; set; }
        public string? PARTLOCATION_CODE { get; set; }
        public string? PARTLOCATION_DESCR { get; set; }
        public int is_arrival_location { get; set; }

    }

    public class Select_Items_Data_For_Return_Reject_Register
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? shipmentlineid { get; set; }
        public int? delivery_order_id { get; set; }
        public string? scannedpartno { get; set; }
        public string? scannedserialno { get; set; } // Updated to check serial number separately
    }

    public class Return_Register_Inventory_Serial
    {
        public int? part_stock_detail_id { get; set; }
        public int? salespartid { get; set; }
        public string? partname { get; set; }
        public string? part_number { get; set; }
        public string? serial { get; set; }
        public string? uom { get; set; }
        public int? partlocationid { get; set; }
        public string? partlocation_code { get; set; }
        public int? stock_typeid { get; set; }
        public string? stock_type { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public double? total_return_qty { get; set; }
        public double? reservedqty { get; set; }
        public int? shipmentlineid { get; set; }
        public string? remarks { get; set; }
        public double? reject_qty { get; set; }
        public double? reserved_qty { get; set; }
        public string? partlocation_descr { get; set; }
        public string? stock_status_text { get; set; }

    }

    public class Return_Register_Inventory_NonSerial
    {

        public int? salespartid { get; set; }
        public string? partname { get; set; }
        public string? part_number { get; set; }
        public string? uom { get; set; }
        public int? partlocationid { get; set; }
        public string? partlocation_code { get; set; }
        public int? stock_typeid { get; set; }
        public string? stock_type { get; set; }
        public int? customerid { get; set; }
        public string? customer_name { get; set; }
        public double? total_return_qty { get; set; }
        public double? reservedqty { get; set; }
        public int? shipmentlineid { get; set; }
        public string? remarks { get; set; }
        public double? reject_qty { get; set; }
        public double? reserved_qty { get; set; }
        public string? partlocation_descr { get; set; }
        public string? stock_status_text { get; set; }
    }


    public class Save_Items_Data_For_Return_Reject_Register
    {
        public int? UserId { get; set; }
        public int? salespartid { get; set; }
        public int? part_stock_detail_id { get; set; }
        public int? shipmentlineid { get; set; }
        public int? delivery_order_id { get; set; }
        public int? locationid { get; set; }
        public int? stocktypeid { get; set; }

    }

    public class RegisterReturnItemData
    {
        public int id { get; set; }
        public int stocktypeid { get; set; }
        public int locationid { get; set; }
    }

    #endregion


    public class getLocationData
    {
        public int? UserId { get; set; }
    }

    public class getLocationScannerData
    {
        public int? UserId { get; set; }
        public string? LocationCode { get; set; }
    }

    public class getLocationPartsData
    {
        public int? UserId { get; set; }
        public int? Locationid { get; set; }
    }

    public class SetLocationPartsDataByCustomer
    {
        public int? UserId { get; set; }
        public int? locationid { get; set; }
        public int partstockid { get; set; }
        public int? customerid { get; set; }
        public int? salespartid { get; set; }
        public int? stocktypeid { get; set; }
        public string? scannedPartNum { get; set; }
        public string? serialNum { get; set; }
        public int? selected_qty { get; set; }
    }

    public class SetLocationPartsDataByCustomer_putaway
    {
        public int? UserId { get; set; }
        public int? locationid { get; set; }
        public int partstockid { get; set; }
        public int? customerid { get; set; }
        public int? salespartid { get; set; }
        public int? stocktypeid { get; set; }
        public int? Orderid { get; set; }
        public string? scannedPartNum { get; set; }
        public string? serialNum { get; set; }
        public int? selected_qty { get; set; }
    }

    public class RemoveLocationPartsDataByCustomer
    {
        public int? UserId { get; set; }
        public int? locationid { get; set; }
        public int partstockid { get; set; }
        public int? customerid { get; set; }
        public int? salespartid { get; set; }
        public int? stocktypeid { get; set; }
        public string? serialNum { get; set; }
        public int? remove_qty { get; set; }
    }

    public class RemoveLocationPartsDataByCustomer_Putaway
    {
        public int? UserId { get; set; }
        public int? locationid { get; set; }
        public int partstockid { get; set; }
        public int? customerid { get; set; }
        public int? salespartid { get; set; }
        public int? stocktypeid { get; set; }
        public int? orderid { get; set; }
        public string? serialNum { get; set; }
        public int? remove_qty { get; set; }
    }


}
