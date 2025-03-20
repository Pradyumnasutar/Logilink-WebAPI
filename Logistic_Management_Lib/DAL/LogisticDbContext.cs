using Logistic_Management_Lib.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.DAL
{
    public class LogisticDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public static IConfiguration configuration { get; set; }
        public LogisticDbContext(DbContextOptions<LogisticDbContext> options) : base(options)
        {

        }

        //public DbExecutionStrategy GetCustomExecutionStrategy()
        //{
        //    // You can adjust the retry settings as needed (e.g., number of retries and delay between retries)
        //    int maxRetryCount = 5;
        //    TimeSpan maxDelay = TimeSpan.FromSeconds(30);
        //    return new CustomExecutionStrategy(maxRetryCount, maxDelay);
        //}

        #region tables
        public virtual DbSet<les_Customers> les_customers { get; set; }
        public DbSet<Shipment> shipment { get; set; }
        public DbSet<Shipment_Documents> shipment_documents { get; set; }
        public DbSet<Shipment_Vessel_Info> shipment_vessel_info { get; set; }
        public DbSet<Delivery_Orders> delivery_orders { get; set; }
        public DbSet<Delivery_Order_Info> delivery_order_info { get; set; }
        public DbSet<Delivery_Order_Documents> delivery_order_documents { get; set; }
        public DbSet<Delivery_Order_Lines> delivery_order_lines { get; set; }
        public DbSet<Mast_Anchorage> mast_anchorage { get; set; }
        public DbSet<Mast_Goods_Return_Reasons> mast_goods_return_reasons { get; set; }
        public DbSet<Mast_Vessel> mast_vessel { get; set; }
        public DbSet<Module_Status> module_status { get; set; }
        public DbSet<Mast_STATUSES> mast_statuses { get; set; }
        public DbSet<MAST_TRANSPORT_TYPE> mast_transport_type { get; set; }
        public DbSet<Mast_SITE_CONFIG> mast_site_config { get; set; }
        public DbSet<Driver_Allocation> driver_allocation { get; set; }
        public DbSet<Vehicle_Trip_Details> Vehicle_Trip_Details { get; set; }
        public DbSet<Vehicle_Trip_Planning> Vehicle_Trip_Planning { get; set; }
        public DbSet<Epod_Access_Log> Epod_Access_Log { get; set; }
        public DbSet<SM_ADDRESS> Sm_Address { get; set; }

        public DbSet<Delivery_Orders_Address> Delivery_Orders_Address { get; set; }

		#endregion

		#region Views
		public virtual DbSet<V_Shipment_Info> v_shipment_info { get; set; }
		public virtual DbSet<VRemainingInternalOrderLines> VRemainingInternalOrderLines { get; set; }
        public DbSet<V_Delivery_Orders_Info> v_delivery_orders_info { get; set; }
        public DbSet<V_MODULE_STATUSES> v_module_statuses { get; set; }
        public DbSet<V_SHIPMENT_TRIP_PLAN> v_shipment_trip_plan { get; set; }
        public DbSet<V_DELIVERY_ORDERS_ADDRESS_EPOD> v_delivery_orders_address_epod { get; set; }
        public DbSet<V_SHIPMENT_DELIVERY_ORDERS> v_shipment_delivery_orders { get; set; }
        public DbSet<V_DELIVERY_ORDER_LINES> v_delivery_order_lines { get; set; }
        public DbSet<lesv_Customers> lesv_customers { get; set; }
        public DbSet<InboundShipment>inboundShipment { get; set; }
        public DbSet<V_INBOUND_SHIPMENTS> v_inbound_shipments { get; set; }
        public DbSet<INTERNAL_ORDERS> internal_orders { get; set; }
        public DbSet<Internal_Order_Line> Internal_Order_Line { get; set; }



        #endregion

    }

    //public class CustomExecutionStrategy : DbExecutionStrategy
    //{
    //    public CustomExecutionStrategy(int maxRetryCount, TimeSpan maxDelay) : base(maxRetryCount, maxDelay)
    //    {

    //    }
    //    protected override bool ShouldRetryOn(Exception exception)
    //    {
    //        // Determine if the exception is a transient fault that should be retried
    //        // You can customize this logic based on the specific exceptions you want to handle
    //        return true;
    //    }
    //}
}
