using DeliveryOrdersWebApi.Model;
using LeSDataMain;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore.Storage;
//using System.Data.Entity.Infrastructure;

namespace DeliveryOrdersWebApi.DAL
{
    public class DeliveryOrderDbContext : DbContext
    {
        public DeliveryOrderDbContext(DbContextOptions<DeliveryOrderDbContext> options) : base(options)
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
        public DbSet<SM_EXTERNAL_USERS> SM_EXTERNAL_USERS { get; set; }
        public DbSet<CustomerAddress> Customer_Address { get; set; }
        public DbSet<DELIVERY_ORDERS> DELIVERY_ORDERS { get; set; }
        public DbSet<Driver_Profile_Tab> Driver_Profile_Tab { get; set; }
        public DbSet<Driver_Allocation> Driver_Allocation { get; set; }
        public DbSet<Mast_SITE_CONFIG> Mast_SITE_CONFIG { get; set; }
        public DbSet<Delivery_Orders_Address> Delivery_Orders_Address { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<USER_REVIEW> USER_REVIEW { get; set; }
        public DbSet<DELIVERY_ORDER_DOCUMENTS> DELIVERY_ORDER_DOCUMENTS { get; set; }
        public DbSet<DO_OT_APPROVAL> DO_OT_APPROVAL { get; set; }
        public DbSet<UserSiteLink> USER_SITE_LINK { get; set; }
        public DbSet<Mast_Site> Mast_Site { get; set; }
        public DbSet<MAST_COMPANY> Mast_Company { get; set; }

        public DbSet<V_CustomerOrders> V_Customer_Orders { get; set; }

        public DbSet<DRIVER_REMARKS> Driver_remarks { get; set; }
        public virtual DbSet<PartInventoryStock> PART_INVENTORY_STOCK { get; set; }
        public virtual DbSet<PartInventoryStockDetails> PART_INVENTORY_STOCK_DETAILS { get; set; }
        public DbSet<Mast_ORDER_CODE> Mast_ORDER_CODE { get; set; }
        public DbSet<INTERNAL_ORDER_LINE> INTERNAL_ORDER_LINE { get; set; }
        public DbSet<INTERNAL_ORDERS> INTERNAL_ORDERS { get; set; }
        public virtual DbSet<Mast_STATUSES> mast_statuses { get; set; }
        public virtual DbSet<CUSTOMERS_PART_LINK> CUSTOMERS_PART_LINK { get; set; }
        public virtual DbSet<Vehicle_Trip_Details> Vehicle_Trip_Details { get; set; }
        public virtual DbSet<Vehicle_Trip_Planning> Vehicle_Trip_Planning { get; set; }
        public virtual DbSet<Vehicle_Trip_lines> Vehicle_Trip_lines { get; set; }
        public virtual DbSet<CustomerOrderLine> Customer_Order_line { get; set; }
        public virtual DbSet<CustomerOrders> Customer_Orders { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<ShipmentLines> Shipment_Lines { get; set; }
        public virtual DbSet<ShipmentGeneral> Shipment_General { get; set; }
        public virtual DbSet<Mast_Persons> Mast_Persons { get; set; }
        public virtual DbSet<Mast_STOCK_CODE> Mast_STOCK_CODE { get; set; }
        public virtual DbSet<Mast_STOCK_TYPE> Mast_STOCK_TYPE { get; set; }
        public virtual DbSet<MAST_SALES_PARTS_LOCATION> MAST_SALES_PARTS_LOCATION { get; set; }
        public virtual DbSet<salesparts> SALES_PARTS { get; set; }
        public virtual DbSet<ShipmentAddress> Shipment_Address { get; set; }
        public virtual DbSet<PARTSTOCKDETAIL_REMARKS> PARTSTOCKDETAIL_REMARKS { get; set; }

        #endregion

        #region Views

        public DbSet<V_DELIVERY_ORDERS> V_DELIVERY_ORDERS { get; set; }
        public DbSet<V_EPOD_DELIVERY_ORDERS> V_EPOD_DELIVERY_ORDERS { get; set; }
        public DbSet<V_DELIVERY_ORDER_SHIPMENTLINES> V_DELIVERY_ORDER_SHIPMENTLINES { get; set; }
        public DbSet<V_DRIVER_COMMISSION_LINK_LINES> V_DRIVER_COMMISSION_LINK_LINES { get; set; }
        public DbSet<V_DELIVERY_ORDER_CUSTOMER_ORDERLINES> V_DELIVERY_ORDER_CUSTOMER_ORDERLINES { get; set; }
        public DbSet<V_Delivery_Orders_Address> V_Delivery_Orders_Address { get; set; }
        public DbSet<V_Available_Drivers> V_Available_Drivers { get; set; }
        public DbSet<V_MODULE_STATUSES> V_MODULE_STATUSES { get; set; }
        public DbSet<V_Driver_Allocation> V_Driver_Allocation { get; set; }
        //public DbSet<V_INTERNAL_ORDERS> V_INTERNAL_ORDERS { get; set; }
        public DbSet<V_INTERNAL_ORDER_LINE> V_INTERNAL_ORDER_LINE { get; set; }
        public virtual DbSet<V_Vehicle_Trip_lines> V_Vehicle_Trip_lines { get; set; }
        public virtual DbSet<V_Vehicle_Trip_Details> V_Vehicle_Trip_Details { get; set; }
        public virtual DbSet<V_PartInventoryStock> V_PART_INVENTORY_STOCK { get; set; }
        public virtual DbSet<V_PartInventoryStockDetails> V_PART_INVENTORY_STOCK_DETAILS { get; set; }
        public virtual DbSet<v_salesparts> V_SALES_PART { get; set; }
        public virtual DbSet<V_TRIP_PLAN> V_TRIP_PLAN { get; set; }
        public virtual DbSet<V_SHIPMENT> V_Shipment { get; set; }
        public virtual DbSet<V_SHIPMENT_LINES> V_Shipment_Lines { get; set; }
        public virtual DbSet<V_ShipmentAddress> V_Shipment_Address { get; set; }



        #endregion

        
    }

    public partial class GlobalTools
    {
        public static string cPWDecrypted = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@#$%^&*()[]-_~!+:,'{}";
        public static string cPWEncrypted = @"ZYXWV_ABCDE.-,+*)FGHIJKL(~&#}!MNOPQ%$RSTU@?>=<;:98765^]\[";

        public static bool IsSafeDataSet(System.Data.DataSet ds)
        {
            return GlobalTools.IsSafeDataSet(ds, 1);
        }

        public static bool IsSafeDataSet(System.Data.DataSet ds, int nbTables)
        {
            if ((((ds != null)
                        && (ds.Tables != null))
                        && (ds.Tables.Count == nbTables)))
            {
                for (int i = 0; (i < nbTables); i = (i + 1))
                {
                    if ((ds.Tables[i].Rows == null) || ((ds.Tables[i].Rows != null) && ds.Tables[i].Rows.Count == 0))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        public static string EncodePassword(string cPWD)
        {
            string cOut = ""; int i;
            try
            {
                for (i = 0; i < cPWD.Length; i++)
                {
                    cOut = cOut + cPWEncrypted[cPWDecrypted.IndexOf(char.ToUpper(cPWD[i]))];
                }
                return cOut;
            }
            catch { return ""; }
        }

        public static string DecodePassword(string cPWD)
        {
            string cOut = ""; int i;
            try
            {
                for (i = 0; i < cPWD.Length; i++)
                {
                    cOut = cOut + cPWDecrypted[cPWEncrypted.IndexOf(char.ToUpper(cPWD[i]))];
                }
                return cOut;
            }
            catch { return ""; }
        }

        public static string EncryptID(int Quotationid)
        {
            try
            {
                string _encryptVal = EncodePWD(Quotationid.ToString());
                if (_encryptVal.Trim().Length > 0)
                {
                    DateTime dtDateTime = DateTime.Now;
                    _encryptVal = EncodePWD(dtDateTime.ToString("ssmmHHyyMMMdd")) + "|" + _encryptVal + "|" + EncodePWD(dtDateTime.ToString("ddMMMyyHHmmss"));
                    byte[] byteArr = System.Text.Encoding.ASCII.GetBytes(_encryptVal.Trim());
                    return Convert.ToBase64String(byteArr);
                }
                else return "";
            }
            catch (Exception ex)
            {
                LeSDataMain.LeSDM.AddLog("Error in EncryptID() : " + ex.Message);
                return "";
            }
        }

        public static int DecryptID(string KeyID)
        {
            try
            {
                string decryptKeyID = "";
                if (KeyID.Trim().Length > 0)
                {
                    KeyID = KeyID.Replace("%2f", "/").Replace("%2F", "/");
                    KeyID = KeyID.Replace("%3d", "=").Replace("%3d", "=");
                    byte[] byteArr = Convert.FromBase64String(KeyID);
                    decryptKeyID = System.Text.Encoding.UTF8.GetString(byteArr);
                }
                if (decryptKeyID.Trim().Length > 0 && decryptKeyID.Split('|').Length > 2)
                {
                    string[] _keys = decryptKeyID.Split('|');
                    DateTime dt1 = DateTime.MinValue, dt2 = DateTime.MinValue;
                    DateTime.TryParseExact(DecodePassword(_keys[0]), "ssmmHHyyMMMdd", null, System.Globalization.DateTimeStyles.None, out dt1);
                    DateTime.TryParseExact(DecodePassword(_keys[2]), "ddMMMyyHHmmss", null, System.Globalization.DateTimeStyles.None, out dt2);

                    //if (dt1 != DateTime.MinValue && dt2 != DateTime.MinValue && dt1 == dt2)
                    if (dt1 != DateTime.MinValue && dt2 != DateTime.MinValue)
                    {
                        decryptKeyID = DecodePassword(_keys[1]);
                    }
                }
                //decryptKeyID = decryptKeyID.Replace("Key=", "");
                return convert.ToInt(decryptKeyID.Trim());
            }
            catch (Exception ex)
            {
                LeSDataMain.LeSDM.AddLog("Error in DecryptID() : " + ex.Message);
                return 0;
            }
        }

        public static string EncodePWD(string cPWD)
        {
            string cOut = ""; int i;
            try
            {
                for (i = 0; i < cPWD.Length; i++)
                {
                    cOut = cOut + cPWEncrypted[cPWDecrypted.IndexOf(char.ToUpper(cPWD[i]))];
                }
                return cOut;
            }
            catch { return ""; }
        }

        public static bool HasAccess(string UserAccessDetails, string ModuleID)
        {
            if (UserAccessDetails != null)
            {
                Dictionary<string, string> UserAccess = JsonConvert.DeserializeObject<Dictionary<string, string>>(UserAccessDetails);
                if (!UserAccess.ContainsKey(ModuleID) || (UserAccess.ContainsKey(ModuleID) && UserAccess[ModuleID] == "0")) return false;
                else return true;
            }
            else return false;
        }

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
