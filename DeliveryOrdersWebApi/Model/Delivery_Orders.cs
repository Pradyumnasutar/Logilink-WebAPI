using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DeliveryOrdersWebApi.Model
{
    public class DELIVERY_ORDERS
    {
        [Key]
        public int DELIVERY_ORDER_ID { get; set; }
        public string? DELIVERY_ORDER_NO { get; set; }
        public int? SHIPMENTID { get; set; }
        //public string JOB_ORDER_NO { get; set;}
        public int? SITEID { get; set; }
        public int? TRIPDETAILID { get; set; }
        public int? TRIPID { get; set; }
        public string? REMARKS { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public int? STATUSID { get; set; }
        public int? CUSTOMERID { get; set; }
        public int? Dispatched_Advise_Sent { get; set; }
        public int? END_CUSTOMERID { get; set; }
        public int? EPOD_STATUS { get; set; }
        public DateTime? PLANNED_FROM { get; set; }
        public DateTime? PLANNED_TO { get; set; }
        public DateTime? ACTUAL_START { get; set; }
        public DateTime? ACTUAL_END { get; set; }
        public int? orderid { get; set; }
        public int? IsAuto { get; set; }//09/08/2023
        public int? SMS_INDICATOR { get; set; }
        public int? WHATSAPP_INDICATOR { get; set; }
        public DateTime? DO_Complete_Date { get; set; }
        public string? INSTRUCTIONS { get; set; } // 29/08/2023-Raviprasad 
        public int? exported { get; set; }

    }

    //public class V_DELIVERY_ORDERS
    //{
    //    [Key]
    //    public int DELIVERY_ORDER_ID { get; set; }
    //    public string? DELIVERY_ORDER_NO { get; set; }
    //    public int? SHIPMENTID { get; set; }
    //    //public string JOB_ORDER_NO { get; set; }
    //    public int? SITEID { get; set; }
    //    public int? TRIPDETAILID { get; set; }
    //    public int? TRIPID { get; set; }
    //    public string? REMARKS { get; set; }
    //    public DateTime? CREATED_DATE { get; set; }
    //    public DateTime? UPDATE_DATE { get; set; }
    //    public DateTime? DELIVERY_DATE { get; set; }
    //    public int? STATUSID { get; set; }
    //    public string? SHIPMENT_ORDER_NO { get; set; }
    //    public string? STATUS_DESC { get; set; }
    //    public int? TRIP_PLAN_NO { get; set; }
    //    public string? Site_Name { get; set; }
    //    public string? STATUS_TEXT { get; set; }
    //    public string? LOT { get; set; }
    //    public string? LOCATION_FROM { get; set; }
    //    public string? LOCATION_TO { get; set; }
    //    public DateTime? ETA_ETD { get; set; }
    //    public int? VehicleTypeId { get; set; }
    //    public string? Vehicle_Type { get; set; }
    //    public double? Tonnage { get; set; }
    //    public DateTime? TO_DO_DATE { get; set; }
    //    public int? CUSTOMERID { get; set; }
    //    public int? Dispatched_Advise_Sent { get; set; }
    //    public int? END_CUSTOMERID { get; set; }
    //    public int? EPOD_STATUS { get; set; }
    //    public DateTime? PLANNED_FROM { get; set; }
    //    public DateTime? PLANNED_TO { get; set; }
    //    public DateTime? ACTUAL_START { get; set; }
    //    public DateTime? ACTUAL_END { get; set; }
    //    public string? EPOD_STATUS_TEXT { get; set; }
    //}

    public class V_DELIVERY_ORDERS
    {
        [Key]
        public int DELIVERY_ORDER_ID { get; set; }
        public string? DELIVERY_ORDER_NO { get; set; }
        public int? SHIPMENTID { get; set; }
        //public string JOB_ORDER_NO { get; set; }
        public int? SITEID { get; set; }
        public int? TRIPDETAILID { get; set; }
        public int? TRIPID { get; set; }
        public string? REMARKS { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public int? STATUSID { get; set; }
        public string? SHIPMENT_ORDER_NO { get; set; }
        public string? STATUS_DESC { get; set; }
        public int? TRIP_PLAN_NO { get; set; }
        public string? Site_Name { get; set; }
        public string? STATUS_TEXT { get; set; }
        public string? LOT { get; set; }
        public string? LOCATION_FROM { get; set; }
        public string? LOCATION_TO { get; set; }
        public DateTime? ETA_ETD { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? Vehicle_Type { get; set; }
        public double? Tonnage { get; set; }
        public DateTime? TO_DO_DATE { get; set; }
        public int? CUSTOMERID { get; set; }
        public int? Dispatched_Advise_Sent { get; set; }
        public int? END_CUSTOMERID { get; set; }
        public int? EPOD_STATUS { get; set; }
        public DateTime? PLANNED_FROM { get; set; }
        public DateTime? PLANNED_TO { get; set; }
        public DateTime? ACTUAL_START { get; set; }
        public DateTime? ACTUAL_END { get; set; }
        public string? EPOD_STATUS_TEXT { get; set; }
        public int? orderid { get; set; }
        public int? IsAuto { get; set; }
        public int? CompanyId { get; set; }
        public int? SMS_INDICATOR { get; set; }
        public int? WHATSAPP_INDICATOR { get; set; }
        public string? INSTRUCTIONS { get; set; }
        public int? billtype { get; set; }
        public DateTime? do_complete_date { get; set; }
        public string? order_types { get; set; }
    }


    public class V_EPOD_DELIVERY_ORDERS
    {
        [Key]
        public int DELIVERY_ORDER_ID { get; set; }
        public string? DELIVERY_ORDER_NO { get; set; }
        public int? SHIPMENTID { get; set; }
        //public string JOB_ORDER_NO { get; set; }
        public int? SITEID { get; set; }
        public int? TRIPDETAILID { get; set; }
        public int? TRIPID { get; set; }
        public string? REMARKS { get; set; }
        public DateTime? CREATED_DATE { get; set; }
        public DateTime? UPDATE_DATE { get; set; }
        public DateTime? DELIVERY_DATE { get; set; }
        public int? STATUSID { get; set; }
        public string? SHIPMENT_ORDER_NO { get; set; }
        public string? STATUS_DESC { get; set; }
        public int? TRIP_PLAN_NO { get; set; }
        public string? Site_Name { get; set; }
        public string? STATUS_TEXT { get; set; }
        public string? LOT { get; set; }
        public string? LOCATION_FROM { get; set; }
        public string? LOCATION_TO { get; set; }
        public DateTime? ETA_ETD { get; set; }
        public int? VehicleTypeId { get; set; }
        public string? Vehicle_Type { get; set; }
        public double? Tonnage { get; set; }
        public DateTime? TO_DO_DATE { get; set; }
        public int? CUSTOMERID { get; set; }
        public int? Dispatched_Advise_Sent { get; set; }
        public int? END_CUSTOMERID { get; set; }
        public int? EPOD_STATUS { get; set; }
        public DateTime? PLANNED_FROM { get; set; }
        public DateTime? PLANNED_TO { get; set; }
        public DateTime? ACTUAL_START { get; set; }
        public DateTime? ACTUAL_END { get; set; }
        public string? EPOD_STATUS_TEXT { get; set; }
        public int? Driver_Id { get; set; }
        public string? Driver_Name { get; set; }
        public string? Vehicle_no { get; set; }
        public string? A_Role { get; set; }
        public string? CHASSIS_NO { get; set; }
        public string? Order_types { get; set; }
        public DateTime? DO_Complete_Date { get; set; }

    }

    public class GET_DELIVERY_ORDERS
    {
        public int? status { get; set; }
        public int? DriverID { get; set; }
    }

    public class GET_DELIVERY_ORDERS_DETAILS
    {
        public int? DeliveryOrderId { get; set; }
        public int? DriverID { get; set; }
        public string? end_trip_date { get; set; }
    }

    public class Accept_EPOD_Info
    {
        public int? DeliveryOrderId { get; set; }
        public int? DriverID { get; set; }
        public List<int> DriverAllocationIdList { get; set; }
        public string? accept_trip_date { get; set; }
    }

    public class GET_DELIVERY_ORDERS_FILTER
    {
        public int? status { get; set; }
        public int? DriverID { get; set; }
        public string? dt_From { get; set; }
        public string? dt_To { get; set; }
    }

}
