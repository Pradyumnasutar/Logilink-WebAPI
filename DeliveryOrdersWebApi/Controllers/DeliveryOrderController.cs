using DeliveryOrdersWebApi.Controllers;
using DeliveryOrdersWebApi.DAL;
using DeliveryOrdersWebApi.Model;
using ImageMagick;
using LeSDataMain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Text;



namespace DeliveryOrdersWebApi.Controllers
{

    [Route("api/V1/DeliveryOrder")]
    [ApiController]
    [Authorize]
    public class DeliveryOrderController : ControllerBase
    {
        IConfiguration configuration;
        private readonly DeliveryOrderDbContext _dbContext;

        public DeliveryOrderController(DeliveryOrderDbContext dbContext)
        {
            CommonFunction.setLog("before - delivery order");
            _dbContext = dbContext;
            var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            configuration = configBuilder.Build();
            CommonFunction.setLog("after - delivery order");
        }

        [HttpPost]
        [Route("getData")]
        public IActionResult getData(GET_DELIVERY_ORDERS modal, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("getData with  GET_DELIVERY_ORDERS ");
                CommonFunction.Set_Client_Data_on_Log_Authentication(modal, AUTHENTICATION_KEY);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");


                CommonFunction.setLog("getData Process started.");
                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {

                    List<V_EPOD_DELIVERY_ORDERS> _deliveryList = new List<V_EPOD_DELIVERY_ORDERS>();
                    if (modal.DriverID != null && convert.ToInt(modal.DriverID) > 0)
                    {
                        Driver_Profile_Tab _driver = _dbContext.Driver_Profile_Tab.Find(modal.DriverID);
                        if (_driver != null && _driver.driverprofile_id != null && convert.ToInt(_driver.driverprofile_id) > 0)
                        {
                            CommonFunction.setLog("Driver found " + _driver.driver_name);
                        }
                        else
                        {
                            return BadRequest("Unable to get Driver details.");
                        }
                    }
                    else
                    {
                        return BadRequest("Unable to get Driver details.");
                    }

                    if (modal.status == -1)
                    {
                        _deliveryList = _dbContext.V_EPOD_DELIVERY_ORDERS.Where(x => x.Driver_Id == modal.DriverID).ToList();
                        _deliveryList = _deliveryList.Where(x => x.EPOD_STATUS != null && (x.EPOD_STATUS == 20 || x.EPOD_STATUS == 18 || x.EPOD_STATUS == 11)).ToList();
                    }
                    else
                    {
                        _deliveryList = _dbContext.V_EPOD_DELIVERY_ORDERS.Where(x => x.EPOD_STATUS == modal.status && x.Driver_Id == modal.DriverID).ToList();
                    }
                    if (_deliveryList.Count() == 0)
                        return NotFound("Not a Single Delivery Order Record Found");
                    return Ok(_deliveryList);
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on getData - " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("getData function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetFilterData")]
        public IActionResult GetFilterData(GET_DELIVERY_ORDERS_FILTER modal, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetFilterData with  GET_DELIVERY_ORDERS_FILTER");
                CommonFunction.Set_Client_Data_on_Log_Authentication(modal, AUTHENTICATION_KEY);

                CommonFunction.setLog("GetFilterData Process started.");

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                List<V_EPOD_DELIVERY_ORDERS> _deliveryList = new List<V_EPOD_DELIVERY_ORDERS>();

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    DateTime dtFrom = convert.ToDateTime(modal.dt_From, "dd/MM/yyyy");
                    DateTime dtTo = convert.ToDateTime(modal.dt_To, "dd/MM/yyyy").AddDays(1).AddSeconds(-1);

                    if (dtFrom == DateTime.MinValue)
                    {
                        throw new Exception("Invalid From date format");
                    }
                    if (dtTo == DateTime.MinValue)
                    {
                        throw new Exception("Invalid To date format");
                    }

                    if (dtFrom > dtTo)
                    {
                        throw new Exception("Invalid From date should not be greater than To date");
                    }
                    dtTo = dtTo.AddDays(1).Date.AddSeconds(-1);
                    if (modal.DriverID != null && convert.ToInt(modal.DriverID) > 0)
                    {
                        Driver_Profile_Tab _driver = _dbContext.Driver_Profile_Tab.Find(modal.DriverID);
                        if (_driver != null && _driver.driverprofile_id != null && convert.ToInt(_driver.driverprofile_id) > 0)
                        {
                            CommonFunction.setLog("Driver found " + _driver.driver_name);
                        }
                        else
                        {
                            return BadRequest("Unable to get Driver details.");
                        }
                    }
                    else
                    {
                        return BadRequest("Unable to get Driver details.");
                    }

                    if (modal.status == -1)
                    {
                        _deliveryList = _dbContext.V_EPOD_DELIVERY_ORDERS.Where(x => x.Driver_Id == modal.DriverID).ToList();
                        _deliveryList = _deliveryList.Where(x => x.EPOD_STATUS != null && (x.EPOD_STATUS == 20 || x.EPOD_STATUS == 18 || x.EPOD_STATUS == 11)).ToList();
                    }
                    else
                    {
                        _deliveryList = _dbContext.V_EPOD_DELIVERY_ORDERS.Where(x => x.EPOD_STATUS == modal.status && x.Driver_Id == modal.DriverID).ToList();
                    }
                    if (_deliveryList.Count() > 0)
                    {
                        List<V_EPOD_DELIVERY_ORDERS> _newDataLst = new List<V_EPOD_DELIVERY_ORDERS>();
                        List<V_EPOD_DELIVERY_ORDERS> dataLst1 = _deliveryList.Where(x => x.PLANNED_FROM >= dtFrom && x.PLANNED_FROM <= dtTo).ToList();

                        if (dataLst1.Count() > 0)
                        {
                            foreach (V_EPOD_DELIVERY_ORDERS dlOrder in dataLst1)
                            {
                                if (_newDataLst.Count() > 0)
                                {
                                    if (_newDataLst.Where(x => x.DELIVERY_ORDER_ID == dlOrder.DELIVERY_ORDER_ID).Count() == 0)
                                    {
                                        _newDataLst.Add(dlOrder);
                                    }
                                }
                                else
                                {
                                    _newDataLst.Add(dlOrder);
                                }
                            }
                        }
                        List<V_EPOD_DELIVERY_ORDERS> dataLst3 = _deliveryList.Where(x => x.ACTUAL_START >= dtFrom && x.ACTUAL_START <= dtTo).ToList();
                        if (dataLst3.Count() > 0)
                        {
                            foreach (V_EPOD_DELIVERY_ORDERS dlOrder in dataLst3)
                            {
                                if (_newDataLst.Count() > 0)
                                {
                                    if (_newDataLst.Where(x => x.DELIVERY_ORDER_ID == dlOrder.DELIVERY_ORDER_ID).Count() == 0)
                                    {
                                        _newDataLst.Add(dlOrder);
                                    }
                                }
                                else
                                {
                                    _newDataLst.Add(dlOrder);
                                }
                            }
                        }
                        _deliveryList = _newDataLst;
                    }
                    if (_deliveryList.Count() == 0)
                        return NotFound("Not a Single Delivery Order Record Found");
                    return Ok(_deliveryList);
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetFilterData - " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetFilterData function stopped successfully.");
            }
        }

        [HttpGet("{DeliveryOrderId}")]
        public IActionResult GetOrder(int DeliveryOrderId, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("GetOrder Process started.");
                CommonFunction.setLog("GetOrder with  DeliveryOrderId : " + DeliveryOrderId);


                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    CommonFunction.setLog("AUTHENTICATION success.");
                    int sCustomer_ID = 0;
                    ProofOfDeliveryDocument _ProofHeaderData = new ProofOfDeliveryDocument();
                    DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                    _model.deliveryOrder = _dbContext.V_EPOD_DELIVERY_ORDERS.Find(DeliveryOrderId);
                    CommonFunction.setLog("log1.");
                    _model.driver_Allocation = _dbContext.V_Driver_Allocation.Where(x => x.tripdetailid == _model.deliveryOrder.TRIPDETAILID && x.tripid == _model.deliveryOrder.TRIPID).ToList();
                    _model.shipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _model.deliveryOrder.TRIPID).ToList();
                    _model.module_statuses = _dbContext.V_MODULE_STATUSES.Where(x => x.moduleid == 1008).ToList();
                    _model.deliverOrderAddress = _dbContext.V_Delivery_Orders_Address.Where(x => x.DeliveryOrderId == DeliveryOrderId).ToList();
                    _model.Customers = _dbContext.Customers.Find(_model.deliveryOrder.CUSTOMERID);
                    CommonFunction.setLog("log2.");
                    _model.EndCustomers = _dbContext.Customers.Find(_model.deliveryOrder.END_CUSTOMERID);
                    List<DELIVERY_ORDER_DOCUMENTS> lstDeliveryOrder = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == DeliveryOrderId && x.Is_Delete != 1).ToList();
                    _model.UserReview = _dbContext.USER_REVIEW.FirstOrDefault(x => x.DELIVERY_ORDER_ID == _model.deliveryOrder.DELIVERY_ORDER_ID);
                    List<sDELIVERY_ORDER_DOCUMENTS> lstAttach = new List<sDELIVERY_ORDER_DOCUMENTS>();
                    CommonFunction.setLog("log3.");
                    foreach (DELIVERY_ORDER_DOCUMENTS _attach in lstDeliveryOrder)
                    {
                        sDELIVERY_ORDER_DOCUMENTS sData = new sDELIVERY_ORDER_DOCUMENTS();
                        sData.DELIVERY_ORDER_ID = _attach.DELIVERY_ORDER_ID;
                        sData.Document_Path = null;
                        sData.Document_Name = _attach.Document_Name;
                        sData.Document_No = _attach.Document_No;
                        sData.CREATED_DATE = _attach.CREATED_DATE;
                        sData.UPDATED_DATE = _attach.UPDATED_DATE;
                        sData.Delivery_Document_ID = _attach.Delivery_Document_ID;
                        sData.Document_Title = _attach.Document_Title;
                        sData.Document_Type = _attach.Document_Type;
                        if (System.IO.File.Exists(_attach.Document_Path))
                        {
                            System.Drawing.Image img = System.Drawing.Image.FromFile(_attach.Document_Path);
                            System.Drawing.Image cImg = resizeImage(img, new Size(300, 300));
                            byte[] data = null;
                            using (MemoryStream ms = new MemoryStream())
                            {
                                cImg.Save(ms, ImageFormat.Png);
                                data = ms.ToArray();
                            }
                            Byte[] bytes = data;
                            string file = Convert.ToBase64String(bytes);
                            sData.Base64Data = file;
                        }
                        lstAttach.Add(sData);
                    }
                    _model.sDELIVERY_ORDER_DOCUMENTS = lstAttach;

                    if (_model.EndCustomers != null && convert.ToInt(_model.EndCustomers.Customer_ID) > 0)
                    {
                        sCustomer_ID = _model.EndCustomers.Customer_ID;
                    }
                    else if (_model.Customers != null && convert.ToInt(_model.Customers.Customer_ID) > 0)
                    {
                        sCustomer_ID = _model.Customers.Customer_ID;
                    }
                    if (sCustomer_ID > 0)
                    {
                        CustomerAddress CustAddr = _dbContext.Customer_Address.FirstOrDefault(x => x.CustomerId == sCustomer_ID && x.Addr_Type.ToUpper() == "DELIVERY");
                        if (CustAddr != null && CustAddr.CustomerAddressId > 0)
                        {
                            //_ProofHeaderData.Recivedby = CustAddr.contact_person;
                            if (CustAddr.CONTACT_PERSONID != null && convert.ToInt(CustAddr.CONTACT_PERSONID) > 0)
                            {
                                Mast_Persons _persons = _dbContext.Mast_Persons.Find((int)CustAddr.CONTACT_PERSONID);
                                if (_persons != null)
                                {
                                    _ProofHeaderData.Recivedby = _persons.Full_Name;
                                }
                            }
                        }
                        if (_model.UserReview != null)
                        {
                            if (_model.UserReview.Review_By != null && _model.UserReview.Review_By != "")
                            {
                                _ProofHeaderData.Recivedby = _model.UserReview.Review_By;
                            }
                        }
                    }
                    _ProofHeaderData.ActualStart = _model.deliveryOrder.ACTUAL_START;
                    _ProofHeaderData.ActualEnd = _model.deliveryOrder.ACTUAL_END;
                    _model.ProofOfDeliveryDocument = _ProofHeaderData;

                    if (_model.deliveryOrder == null)
                        return NotFound($"Order Details with Id {DeliveryOrderId} is not found");
                    return Ok(_model);
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetOrder for DeliveryOrderId '" + DeliveryOrderId + "' ERROR : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetOrder function stopped successfully.");
            }

        }

        [HttpPost]
        [Route("Get_Order_Details")]
        public IActionResult Get_Order_Details(GET_DELIVERY_ORDERS_DETAILS details, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("Get_Order_Details Process started.");
                CommonFunction.setLog("GetOrder with  DeliveryOrderId : " + details.DeliveryOrderId + " and " + details.DriverID);
                CommonFunction.Set_Client_Data_on_Log_Authentication(details, AUTHENTICATION_KEY);

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {

                    if (details.DeliveryOrderId == null)
                    {
                        throw new Exception("Invalid Delivery Order ID");
                    }
                    if (details.DriverID == null)
                    {
                        throw new Exception("Invalid Driver ID");
                    }
                    DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                    _model = Get_EPOD_Details(details.DeliveryOrderId, details.DriverID);
                    if (_model.deliveryOrder == null)
                        return NotFound($"Order Details with Id {details.DeliveryOrderId} is not found");
                    return Ok(_model);
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Get_Order_Details for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Get_Order_Details function stopped successfully.");
            }

        }

        [HttpPost]
        [Route("Login_EPOD")]
        public IActionResult Login_EPOD(Login_Data _data, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                CommonFunction.setLog("Login_EPOD Process started.");
                CommonFunction.setLog("Login_EPOD with Login_Data : ");
                CommonFunction.Set_Client_Data_on_Log_Authentication(_data, AUTHENTICATION_KEY);


                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    if (_data == null && _data.UserId == "")
                    {
                        return BadRequest("UserId is blank");
                    }
                    if (_data == null && _data.password == "")
                    {
                        return BadRequest("password is blank");
                    }
                    string sPassword = GlobalTools.EncodePassword(_data.password);
                    SM_EXTERNAL_USERS _UserData = _dbContext.SM_EXTERNAL_USERS.FirstOrDefault(x => x.EX_USERCODE == _data.UserId && x.EX_PASSWORD == sPassword);
                    if (_UserData == null && convert.ToInt(_UserData.EX_USERID) == 0)
                    {

                        return NotFound("Unable to get Login using Userid : " + _data.UserId);
                    }
                    else
                    {
                        if (_UserData.ePOD_Access == 1)
                        {
                            CommonFunction.setLog("User : " + _UserData.EX_USERNAME + " have successfully Login to WMS EPOD");
                            CommonFunction.SetAudit("Login_EPOD", "Updated", "", "User : " + _UserData.EX_USERNAME + " have successfully Login to WMS EPOD", "");
                            return Ok(_UserData);
                        }
                        else
                        {
                            throw new Exception("EPOD Access for User  : " + _data.UserId + " is denied.");
                        }
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Login_EPOD with Login_Data ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("Login_EPOD", "Error", "", "Error on Login_EPOD with Login_Data for UserCode : " + _data.UserId + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Login_EPOD function stopped successfully.");
            }
        }

        //[HttpPost]
        //[Route("Accept_EPOD")]
        //public IActionResult Accept_EPOD(Accept_EPOD_Info details)
        //{
        //    try
        //    {
        //        HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        //       CommonFunction.setLog("Accept_EPOD with DeliveryOrderId : " + details.DeliveryOrderId + " and Driver ID : " + details.DriverID);
        //        DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
        //        DELIVERY_ORDERS _delivOrder = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
        //        List<Driver_Allocation> driver_Allocation_List = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID).ToList();
        //        Driver_Allocation MainDriverExt = driver_Allocation_List.FirstOrDefault(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID && x.driver_id == details.DriverID);
        //        Driver_Allocation MainDriver = MainDriverExt;

        //        int update = -1;
        //        if (MainDriverExt != null)
        //        {
        //            if (_delivOrder != null)
        //            {
        //                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
        //                executionStrategy.Execute(() =>
        //                {
        //                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
        //                    {
        //                        try
        //                        {
        //                            _delivOrder.ACTUAL_START = DateTime.Now;
        //                            _delivOrder.UPDATE_DATE = DateTime.Now;
        //                            _delivOrder.EPOD_STATUS = 18;
        //                            _delivOrder.STATUSID = 19;
        //                            _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
        //                            update = _dbContext.SaveChanges();
        //                            if (update > 0)
        //                            {
        //                                foreach (Driver_Allocation _driverAllocationData in driver_Allocation_List)
        //                                {
        //                                    Driver_Allocation _driverAllocationExist = _driverAllocationData;
        //                                    _driverAllocationData.is_Present = 0;
        //                                    _driverAllocationData.updated_date = DateTime.Now;
        //                                    _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationData);
        //                                    update = _dbContext.SaveChanges();
        //                                }

        //                                foreach (int _driverAllocationId in details.DriverAllocationIdList)
        //                                {
        //                                    Driver_Allocation _driverAllocationExist = driver_Allocation_List.FirstOrDefault(x => x.driverallocationid == _driverAllocationId);
        //                                    if (_driverAllocationExist != null)
        //                                    {
        //                                        Driver_Allocation _driverAllocationdata = driver_Allocation_List.FirstOrDefault(x => x.driverallocationid == _driverAllocationId);
        //                                        _driverAllocationdata.is_Present = 1;
        //                                        _driverAllocationdata.updated_date = DateTime.Now;
        //                                        _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationdata);
        //                                        update = _dbContext.SaveChanges();
        //                                    }
        //                                }
        //                                MainDriver.is_Present = 1;
        //                                MainDriver.updated_date = DateTime.Now;
        //                                _dbContext.Entry(MainDriverExt).CurrentValues.SetValues(MainDriver);
        //                                update = _dbContext.SaveChanges();
        //                            }
        //                            dbContextTransaction.Commit();
        //                        }
        //                        catch (Exception ex)
        //                        {
        //                            dbContextTransaction.Rollback();
        //                            CommonFunction.setLog("Error while creating Accept EPOD : " + ex.Message);
        //                            throw ex;
        //                        }
        //                    }
        //                });
        //                if (update > 0)
        //                {
        //                    DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
        //                    _model = Get_EPOD_Details(details.DeliveryOrderId, details.DriverID);
        //                    if (_model.deliveryOrder == null)
        //                        return NotFound($"Order Details with Id {details.DeliveryOrderId} is not found");
        //                    return Ok(_model);
        //                }
        //                else
        //                {
        //                    throw new Exception("Unable to save Accept DELIVERY_ORDERS");
        //                }
        //            }
        //            else
        //            {
        //                throw new Exception("Unable to get DELIVERY_ORDERS");
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("Unable to get Main Driver.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //       CommonFunction.setLog("Error on Accept_EPOD for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
        //        return BadRequest(ex.Message);
        //    }
        //}

        [HttpPost]
        [Route("Accept_EPOD_With_AbsentAttendant")]
        public IActionResult Accept_EPOD_With_AbsentAttendant(Accept_EPOD_Info details, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("Accept_EPOD_With_AbsentAttendant Process Started.");
                CommonFunction.setLog("Accept_EPOD with DeliveryOrderId : " + details.DeliveryOrderId + " and Driver ID : " + details.DriverID);
                CommonFunction.Set_Client_Data_on_Log_Authentication(details, AUTHENTICATION_KEY);

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    Driver_Profile_Tab _dr = _dbContext.Driver_Profile_Tab.Find(details.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    List<Driver_Allocation> driver_Allocation_List = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID).ToList();
                    Driver_Allocation MainDriverExt = driver_Allocation_List.FirstOrDefault(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID && x.driver_id == details.DriverID);
                    Driver_Allocation MainDriver = MainDriverExt;
                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    List<Mast_STATUSES> mStatus = _dbContext.mast_statuses.ToList();

                    List<int?> lstcustorderLineids = delivOrderShipmentLines.Select(x => x.CustOrderLineId).ToList();
                    List<int?> lstSalesPartId = delivOrderShipmentLines.Select(x => x.SalesPartId).ToList();
                    List<int?> lstShipmentid = delivOrderShipmentLines.Select(x => x.ShipmentId).ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<int?> lsttriplineid = delivOrderShipmentLines.Select(x => x.triplineid).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();

                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();
                    List<PartInventoryStock> partinventorystock = _dbContext.PART_INVENTORY_STOCK.Where(x => lstCustomerid.Contains((int)x.customerid) /*x.customerid == _delivOrderExist.CUSTOMERID*/ && lstSalesPartId.Contains(x.SalesPartId)).ToList();
                    // List<Shipment> shipments = _dbContext.Shipment.Where(x => lstShipmentid.Contains(x.ShipmentId) && x.Is_Delete != 1).ToList();
                    // List<ShipmentLines> shipmentLines = _dbContext.Shipment_Lines.Where(x => lstShipmentlineid.Contains(x.ShipmentLineId) && x.Is_Delete != 1).ToList();
                    // List<CustomerOrderLine> custOrderLines = _dbContext.Customer_Order_line.Where(x => lstSalesPartId.Contains(x.SalesPartId) && lstcustorderLineids.Contains(x.CustOrderLineId) && x.Is_Delete != 1).ToList();
                    // List<int?> lstcustorderids = custOrderLines.Select(x => x.OrderId).ToList();
                    // List<CustomerOrders> lstcustOrders = _dbContext.Customer_Orders.Where(x => lstcustorderids.Contains(x.OrderId) && x.CustomerId == _delivOrder.CUSTOMERID && x.Is_Delete != 1).ToList();

                    Vehicle_Trip_Details tripDetails = _dbContext.Vehicle_Trip_Details.FirstOrDefault(x => x.tripdetailid == _delivOrder.TRIPDETAILID && x.tripid == _delivOrder.TRIPID);


                    if (_delivOrder.STATUSID != 2)
                    {
                        throw new Exception("Unable to accept Delivery order as Delivery Order Status is on '" + mStatus.FirstOrDefault(x => x.statusid == _delivOrder.STATUSID).status_desc + "'.");
                    }

                    int update = -1;
                    if (MainDriverExt != null)
                    {
                        if (_delivOrder != null)
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        DateTime _dtAcceptDate = convert.ToDateTime(details.accept_trip_date, "dd/MM/yyyy HH:mm");
                                        if (_dtAcceptDate == DateTime.MinValue)
                                        {
                                            throw new Exception("End Trip Date is invalid.");
                                        }

                                        _delivOrder.ACTUAL_START = _dtAcceptDate;
                                        _delivOrder.ACTUAL_END = null;
                                        _delivOrder.UPDATE_DATE = DateTime.Now;
                                        _delivOrder.EPOD_STATUS = 18;
                                        _delivOrder.STATUSID = 19;
                                        _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                        update = _dbContext.SaveChanges();
                                        if (update > 0)
                                        {
                                            foreach (Driver_Allocation _driverAllocationData in driver_Allocation_List)
                                            {
                                                Driver_Allocation _driverAllocationExist = _driverAllocationData;
                                                _driverAllocationData.is_Present = 1;
                                                _driverAllocationData.updated_date = DateTime.Now;
                                                _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationData);
                                                update = _dbContext.SaveChanges();
                                            }
                                            foreach (int _driverAllocationId in details.DriverAllocationIdList)
                                            {
                                                Driver_Allocation _driverAllocationExist = driver_Allocation_List.FirstOrDefault(x => x.driverallocationid == _driverAllocationId);
                                                Driver_Allocation _driverAllocationdata = _driverAllocationExist;
                                                if (_driverAllocationExist != null)
                                                {
                                                    _driverAllocationdata.is_Present = 0;
                                                    _driverAllocationdata.updated_date = DateTime.Now;
                                                    _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationdata);
                                                    update = _dbContext.SaveChanges();
                                                }
                                            }
                                            Vehicle_Trip_Details tripDetailsExt = tripDetails;
                                            tripDetails.statusid = 19;
                                            tripDetails.updated_date = DateTime.Now;
                                            _dbContext.Entry(tripDetailsExt).CurrentValues.SetValues(tripDetails);

                                            foreach (V_DELIVERY_ORDER_SHIPMENTLINES delivOrderShipmentlines in delivOrderShipmentLines)
                                            {
                                                List<PartInventoryStockDetails> lstpartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId).ToList();
                                                if (lstpartStockDetails != null && lstpartStockDetails.Count() > 0)
                                                {
                                                    for (int i = 0; i < lstpartStockDetails.Count(); i++)
                                                    {
                                                        PartInventoryStockDetails partStockDetails = lstpartStockDetails[i];
                                                        PartInventoryStockDetails partStockDetailsExt = lstpartStockDetails[i];
                                                        PartInventoryStock partStock = partinventorystock.FirstOrDefault(x => x.SalesPartId == delivOrderShipmentlines.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID);
                                                        if (partStock != null)
                                                        {
                                                            partStockDetails.qty_intransit_to_location = 1;
                                                            partStockDetails.UPDATED_DATE = DateTime.Now;
                                                            partStockDetails.stock_statusid = 30;  //In Transit Status
                                                            _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                                            update = _dbContext.SaveChanges();

                                                            List<PartInventoryStockDetails> lstPartstockData = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID).ToList();

                                                            double qty_reserved = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.shipmentid) > 0 && convert.ToInt(x.qty_intransit_to_location) == 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                            double qty_intransit = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.qty_intransit_to_location) > 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));

                                                            PartInventoryStock partStockExt = partStock;
                                                            if (convert.ToFloat(partStock.QTY_RESERVED) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                            {
                                                                double reserveqty = convert.ToFloat(partStock.QTY_RESERVED) - convert.ToFloat(partStockDetails.QUANTITY);
                                                                //partStock.QTY_RESERVED = reserveqty;
                                                                //partStock.QTY_INTRANSIT = convert.ToFloat(partStock.QTY_INTRANSIT) + convert.ToFloat(partStockDetails.QUANTITY);

                                                                partStock.QTY_RESERVED = qty_reserved;
                                                                partStock.QTY_INTRANSIT = qty_intransit;
                                                                partStock.UPDATED_DATE = DateTime.Now;
                                                                _dbContext.Entry(partStockExt).CurrentValues.SetValues(partStock);
                                                                update = _dbContext.SaveChanges();
                                                            }
                                                            else
                                                            {
                                                                throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity reserver '" + convert.ToFloat(partStock.QTY_RESERVED) + "' is less than quantity Shipment '" + convert.ToFloat(partStockDetails.QUANTITY) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            throw new Exception("Unable to get PartInventoryStock details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                        }
                                                    }

                                                    //Shipment shipment = shipments.FirstOrDefault(x => x.ShipmentId == delivOrderShipmentlines.ShipmentId);
                                                    //if (shipment != null)
                                                    //{
                                                    //    Shipment shipmentExt = shipment;
                                                    //    shipment.Shipment_StatusId = _delivOrder.STATUSID;
                                                    //    shipment.Updated_Date = DateTime.Now;
                                                    //    _dbContext.Entry(shipmentExt).CurrentValues.SetValues(shipment);
                                                    //}
                                                    //else
                                                    //{
                                                    //    throw new Exception("Unable to get Shipment details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                    //}

                                                    //ShipmentLines shipmentLine = shipmentLines.FirstOrDefault(x => x.ShipmentId == delivOrderShipmentlines.ShipmentId && x.ShipmentLineId == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId);
                                                    //if (shipmentLine != null)
                                                    //{
                                                    //    ShipmentLines shipmentLineExt = shipmentLine;
                                                    //    shipmentLine.Item_Status = _delivOrder.STATUSID;
                                                    //    shipmentLine.Updated_Date = DateTime.Now;
                                                    //    _dbContext.Entry(shipmentLineExt).CurrentValues.SetValues(shipmentLine);
                                                    //}
                                                    //else
                                                    //{
                                                    //    throw new Exception("Unable to get ShipmentLines for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                    //}

                                                    //CustomerOrderLine custOrderLine = custOrderLines.FirstOrDefault(x => x.CustOrderLineId == delivOrderShipmentlines.CustOrderLineId);
                                                    //if (custOrderLine != null)
                                                    //{
                                                    //    CustomerOrderLine custOrderLineExt = custOrderLine;
                                                    //    custOrderLine.Item_Status = _delivOrder.STATUSID;
                                                    //    custOrderLine.Updated_Date = DateTime.Now;
                                                    //    _dbContext.Entry(custOrderLineExt).CurrentValues.SetValues(custOrderLine);
                                                    //}
                                                    //else
                                                    //{
                                                    //    throw new Exception("Unable to get CustomerOrderLine for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                    //}

                                                    //CustomerOrders custOrder = lstcustOrders.FirstOrDefault(x => x.CustomerId == delivOrderShipmentlines.CUSTOMERID && x.OrderId == custOrderLine.OrderId);
                                                    //if (custOrder != null)
                                                    //{
                                                    //    CustomerOrders custOrderExt = custOrder;
                                                    //    custOrder.StatusId = _delivOrder.STATUSID;
                                                    //    custOrder.Updated_Date = DateTime.Now;
                                                    //    _dbContext.Entry(custOrderExt).CurrentValues.SetValues(custOrder);
                                                    //}
                                                    //else
                                                    //{
                                                    //    throw new Exception("Unable to get CustomerOrders for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                    //}
                                                }
                                                else
                                                {
                                                    throw new Exception("Unable to get PartInventoryStockDetails for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                }
                                            }
                                            MainDriver.is_Present = 1;
                                            MainDriver.updated_date = DateTime.Now;
                                            _dbContext.Entry(MainDriverExt).CurrentValues.SetValues(MainDriver);
                                            update = _dbContext.SaveChanges();
                                        }
                                        dbContextTransaction.Commit();
                                        CommonFunction.setLog("Driver : '" + _dr.driver_name + "' have Accepted Delivery order no " + _delivOrder.DELIVERY_ORDER_NO);
                                        CommonFunction.SetAudit("Accept_EPOD_With_AbsentAttendant", "Updated", "", "Driver : '" + _dr.driver_name + "' have Accepted Delivery order no " + _delivOrder.DELIVERY_ORDER_NO, "");

                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        CommonFunction.setLog("Error while creating Accept EPOD : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                            if (update > 0)
                            {
                                DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                                _model = Get_EPOD_Details(details.DeliveryOrderId, details.DriverID);
                                if (_model.deliveryOrder == null)
                                    return NotFound($"Order Details with Id {details.DeliveryOrderId} is not found");
                                return Ok(_model);
                            }
                            else
                            {
                                throw new Exception("Unable to save Accept DELIVERY_ORDERS");
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get DELIVERY_ORDERS");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get Main Driver.");
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Accept_EPOD_With_AbsentAttendant for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("Accept_EPOD_With_AbsentAttendant", "Error", "", "Error on Accept_EPOD_With_AbsentAttendant for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Login_WMS stopped successfully.");
            }
        }


        [HttpPost]
        [Route("Absent_Attendant_Remarks")]
        public IActionResult Absent_Attendant_Remarks(Attendent_Remarks_Info details, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                CommonFunction.setLog("Absent_Attendant_Remarks Process Started.");
                CommonFunction.setLog("Absent_Attendant_Remarks with Delivery Order Id : " + details.DeliveryOrderId + " and Driver Id : " + details.DriverID + " and Driver Allocation Id : " + details.DriverAllocationId);
                CommonFunction.Set_Client_Data_on_Log_Authentication(details, AUTHENTICATION_KEY);

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    Driver_Profile_Tab _dr = _dbContext.Driver_Profile_Tab.Find(details.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);

                    Driver_Allocation _driverAllocationdata = _dbContext.Driver_Allocation.FirstOrDefault(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID && x.driverallocationid == details.DriverAllocationId);
                    Driver_Allocation _driverAllocationExist = _driverAllocationdata;
                    int update = -1;
                    if (_driverAllocationdata != null)
                    {
                        if (_delivOrder != null)
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        _driverAllocationdata.is_Present = 0;
                                        _driverAllocationdata.EPOD_Driver_Remarks = details.Remarks;
                                        _driverAllocationdata.updated_date = DateTime.Now;
                                        _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationdata);
                                        update = _dbContext.SaveChanges();
                                        dbContextTransaction.Commit();
                                        CommonFunction.setLog("Driver : '" + _dr.driver_name + "' have added Absent Attendant Remarks Delivery order no " + _delivOrder.DELIVERY_ORDER_NO);
                                        CommonFunction.SetAudit("Absent_Attendant_Remarks", "Updated", "", "Driver : '" + _dr.driver_name + "' have added Absent Attendant Remarks Delivery order no " + _delivOrder.DELIVERY_ORDER_NO, "");
                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        CommonFunction.setLog("Error while Updating Absent Attendent Remarks : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                            if (update > 0)
                            {
                                DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                                _model = Get_EPOD_Details(details.DeliveryOrderId, details.DriverID);
                                if (_model.deliveryOrder == null)
                                    return NotFound($"Order Details with Id {details.DeliveryOrderId} is not found");
                                return Ok(_model);
                            }
                            else
                            {
                                throw new Exception("Unable to save Absent_Attendent_Remarks");
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get Absent_Attendent_Remarks");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get Main Driver.");
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Absent_Attendent_Remarks for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("Absent_Attendant_Remarks", "Error", "", "Error on Absent_Attendant_Remarks for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Absent_Attendent_Remarks function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("EndTrip_EPOD")]
        public IActionResult EndTrip_EPOD(GET_DELIVERY_ORDERS_DETAILS details, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("EndTrip_EPOD Process Started.");
                CommonFunction.setLog("EndTrip_EPOD with DeliveryOrderId : " + details.DeliveryOrderId + " and Driver ID : " + details.DriverID);
                CommonFunction.Set_Client_Data_on_Log_Authentication(details, AUTHENTICATION_KEY);

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    Driver_Profile_Tab _dr = _dbContext.Driver_Profile_Tab.Find(details.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    int update = -1;
                    List<DELIVERY_ORDER_DOCUMENTS> lstDocument = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == details.DeliveryOrderId && x.Is_Delete != 1).ToList();

                    USER_REVIEW _extUserReview = _dbContext.USER_REVIEW.FirstOrDefault(x => x.DELIVERY_ORDER_ID == details.DeliveryOrderId);

                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    List<int?> lstcustorderLineids = delivOrderShipmentLines.Select(x => x.CustOrderLineId).ToList();
                    List<int?> lstSalesPartId = delivOrderShipmentLines.Select(x => x.SalesPartId).ToList();
                    List<int?> lstShipmentid = delivOrderShipmentLines.Select(x => x.ShipmentId).ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<int?> lsttriplineid = delivOrderShipmentLines.Select(x => x.triplineid).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();

                    Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                    Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;

                    List<Mast_STATUSES> mStatus = _dbContext.mast_statuses.ToList();
                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) /*x.customerid == _delivOrderExist.CUSTOMERID*/ && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();
                    List<PartInventoryStock> partinventorystock = _dbContext.PART_INVENTORY_STOCK.Where(x => lstCustomerid.Contains((int)x.customerid) && lstSalesPartId.Contains(x.SalesPartId)).ToList();
                    //List<Shipment> shipments = _dbContext.Shipment.Where(x => lstShipmentid.Contains(x.ShipmentId) && x.Is_Delete != 1).ToList();
                    //List<ShipmentLines> shipmentLines = _dbContext.Shipment_Lines.Where(x => lstShipmentlineid.Contains(x.ShipmentLineId) && x.Is_Delete != 1).ToList();
                    //List<CustomerOrderLine> custOrderLines = _dbContext.Customer_Order_line.Where(x => lstSalesPartId.Contains(x.SalesPartId) && lstcustorderLineids.Contains(x.CustOrderLineId) && x.Is_Delete != 1).ToList();
                    //List<int?> lstcustorderids = custOrderLines.Select(x => x.OrderId).ToList();
                    //List<CustomerOrders> lstcustOrders = _dbContext.Customer_Orders.Where(x => lstcustorderids.Contains(x.OrderId) && x.CustomerId == _delivOrder.CUSTOMERID && x.Is_Delete != 1).ToList();

                    Vehicle_Trip_Details tripDetails = _dbContext.Vehicle_Trip_Details.FirstOrDefault(x => x.tripdetailid == _delivOrder.TRIPDETAILID && x.tripid == _delivOrder.TRIPID);

                    List<Mast_SITE_CONFIG> SiteConfig = _dbContext.Mast_SITE_CONFIG.Where(x => x.SiteId == _delivOrder.SITEID && x.ModuleId == 1008).ToList();
                    if (SiteConfig.Count > 0)
                    {
                        Mast_SITE_CONFIG _sitePhoto = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1003);
                        Mast_SITE_CONFIG _siteSignature = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1005);
                        Mast_SITE_CONFIG _sitePhotoCount = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1006);
                        Mast_SITE_CONFIG _siteSignatureCount = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1007);
                        int PhotoCount = lstDocument.Where(x => x.Document_Title.ToUpper() == "PHOTO" && x.Is_Delete != 1).ToList().Count();
                        int SignatureCount = lstDocument.Where(x => x.Document_Title.ToUpper() == "SIGNATURE" && x.Is_Delete != 1).ToList().Count();

                        if (_sitePhoto != null && _sitePhoto.Param_Value != null && _sitePhoto.Param_Value.ToUpper() == "YES")
                        {
                            if (_sitePhotoCount != null && _sitePhotoCount.Param_Value != null && convert.ToInt(_sitePhotoCount.Param_Value) >= 0)
                            {
                                if (PhotoCount == 0)
                                {
                                    throw new Exception("Atleast 1 Delivery Photo Document is required to end trip.");
                                }
                                if (convert.ToInt(_sitePhotoCount.Param_Value) >= PhotoCount)
                                {
                                    CommonFunction.setLog("Delivery Order can add photos");
                                }
                                else
                                {
                                    throw new Exception("Site is not allowed to add photos more than " + convert.ToInt(_sitePhotoCount.Param_Value));
                                }
                            }
                        }
                        else
                        {
                            CommonFunction.setLog("Delivery Order can End trip without Photos");
                        }

                        if (_siteSignature != null && _siteSignature.Param_Value != null && _siteSignature.Param_Value.ToUpper() == "YES")
                        {
                            if (_siteSignatureCount != null && _siteSignatureCount.Param_Value != null && convert.ToInt(_siteSignatureCount.Param_Value) >= 0)
                            {
                                if (SignatureCount == 0)
                                {
                                    throw new Exception("Atleast 1 Delivery Signature Document is required to end trip.");
                                }
                                if (convert.ToInt(_siteSignatureCount.Param_Value) >= SignatureCount)
                                {
                                    CommonFunction.setLog("Delivery Order can add signature ");
                                }
                                else
                                {
                                    throw new Exception("Site is not allowed to add Signature more than " + convert.ToInt(_siteSignatureCount.Param_Value));
                                }
                            }
                            if (_extUserReview == null)
                            {
                                throw new Exception("Delivery Order can not end trip without user review.");
                            }
                        }
                        else
                        {
                            CommonFunction.setLog("Delivery Order can End trip without Signature");
                        }
                    }

                    if (_delivOrder != null)
                    {
                        if (_delivOrder.STATUSID != 19)
                        {
                            throw new Exception("Unable to End Delivery order as Delivery Order Status is on '" + mStatus.FirstOrDefault(x => x.statusid == _delivOrder.STATUSID).status_desc + "'.");
                        }

                        List<Driver_Allocation> DriverAllocationList = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrder.TRIPDETAILID).ToList();
                        List<DO_OT_APPROVAL> _Do_Ot_Approval = _dbContext.DO_OT_APPROVAL.Where(x => x.DELIVERY_ORDER_ID == details.DeliveryOrderId).ToList();
                        List<int> shipmentLinesId = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrder.TRIPID).Select(x => x.ShipmentLineId).ToList();
                        List<PartInventoryStockDetails> partinventoryStockDetail = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => shipmentLinesId.Contains((int)(x.shipmentlineid)) && lstCustomerid.Contains((int)x.customerid)).ToList();
                        var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                        executionStrategy.Execute(() =>
                        {
                            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    DateTime _dtEndDate = convert.ToDateTime(details.end_trip_date, "dd/MM/yyyy HH:mm");
                                    if (_dtEndDate == DateTime.MinValue)
                                    {
                                        throw new Exception("End Trip Date is invalid.");
                                    }
                                    _delivOrder.ACTUAL_END = _dtEndDate;
                                    _delivOrder.UPDATE_DATE = DateTime.Now;
                                    _delivOrder.EPOD_STATUS = 11;
                                    _delivOrder.exported = 1;
                                    _delivOrder.STATUSID = 4;
                                    _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                    update = _dbContext.SaveChanges();

                                    DateTime dateTime1 = convert.ToDateTime(_delivOrder.ACTUAL_START);
                                    DateTime dateTime2 = convert.ToDateTime(_delivOrder.ACTUAL_END);

                                    TimeSpan timeDifference = dateTime2 - dateTime1;
                                    // Get the difference in minutes
                                    double HourDifference = timeDifference.TotalHours;

                                    #region Driver OT Calculation 

                                    //foreach (Driver_Allocation _drAllocation in DriverAllocationList)
                                    //{
                                    //    List<V_DRIVER_COMMISSION_LINK_LINES> driverCommissionLines = _dbContext.V_DRIVER_COMMISSION_LINK_LINES.Where(x => x.DriverProfileid == _drAllocation.driver_id).ToList();
                                    //    List<V_DRIVER_COMMISSION_LINK_LINES> driverCommissionLines1 = driverCommissionLines.Where(x => x.VALIDFROM <= _delivOrder.ACTUAL_START && x.VALIDTO >= _delivOrder.ACTUAL_END).ToList();
                                    //    if (driverCommissionLines1.Count() > 0)
                                    //    {
                                    //        double commssionHour = convert.ToFloat(driverCommissionLines1.Min(x => x.maxhoures));  // Min Hours from which Commission will be calculated;
                                    //        DO_OT_APPROVAL DO_Ot_Approval_Data = _Do_Ot_Approval.FirstOrDefault(x => x.DriverProfile_id == _drAllocation.driver_id);
                                    //        if (HourDifference > commssionHour)
                                    //        {
                                    //            double driverOtHr = HourDifference - commssionHour;
                                    //            convert.ToFloat(driverOtHr);

                                    //            if (DO_Ot_Approval_Data != null)
                                    //            {
                                    //                DO_OT_APPROVAL DO_Ot_Approval_Data_Ext = DO_Ot_Approval_Data;
                                    //                DO_Ot_Approval_Data.DriverProfile_id = _drAllocation.driver_id;
                                    //                DO_Ot_Approval_Data.DELIVERY_ORDER_ID = details.DeliveryOrderId;
                                    //                DO_Ot_Approval_Data.Updated_Date = DateTime.Now;
                                    //                DO_Ot_Approval_Data.Actual_Total_Hours = convert.ToFloat(string.Format("{0:0.00}", HourDifference));
                                    //                DO_Ot_Approval_Data.Driver_OT_Hours = convert.ToFloat(string.Format("{0:0.00}", driverOtHr));
                                    //                DO_Ot_Approval_Data.Approve_Driver_OT_Hours = convert.ToFloat(string.Format("{0:0.00}", driverOtHr));
                                    //                _dbContext.Entry(DO_Ot_Approval_Data_Ext).CurrentValues.SetValues(DO_Ot_Approval_Data);

                                    //                _delivOrder.UPDATE_DATE = DateTime.Now;
                                    //                _delivOrder.STATUSID = 21;
                                    //                _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);   // Updating if OT calualation is required

                                    //                update = _dbContext.SaveChanges();
                                    //            }
                                    //            else
                                    //            {
                                    //                DO_Ot_Approval_Data = new DO_OT_APPROVAL();
                                    //                DO_Ot_Approval_Data.DriverProfile_id = _drAllocation.driver_id;
                                    //                DO_Ot_Approval_Data.DELIVERY_ORDER_ID = details.DeliveryOrderId;
                                    //                DO_Ot_Approval_Data.Updated_Date = DateTime.Now;
                                    //                DO_Ot_Approval_Data.Created_Date = DateTime.Now;
                                    //                DO_Ot_Approval_Data.Actual_Total_Hours = convert.ToFloat(string.Format("{0:0.00}", HourDifference));
                                    //                DO_Ot_Approval_Data.Driver_OT_Hours = convert.ToFloat(string.Format("{0:0.00}", driverOtHr));
                                    //                DO_Ot_Approval_Data.Approve_Driver_OT_Hours = convert.ToFloat(string.Format("{0:0.00}", driverOtHr));
                                    //                _dbContext.DO_OT_APPROVAL.Add(DO_Ot_Approval_Data);

                                    //                _delivOrder.UPDATE_DATE = DateTime.Now;
                                    //                _delivOrder.STATUSID = 21;
                                    //                _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);   // Updating if OT calualation is required

                                    //                update = _dbContext.SaveChanges();
                                    //            }
                                    //        }
                                    //        if (DO_Ot_Approval_Data == null || DO_Ot_Approval_Data.Driver_OT_Hours == 0)
                                    //        {
                                    //            DateTime _dt = _dtEndDate;
                                    //            _delivOrder.UPDATE_DATE = _dt;
                                    //            _delivOrder.DO_Complete_Date = _dt;
                                    //            _delivOrder.STATUSID = 11;
                                    //            _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                    //            update = _dbContext.SaveChanges();
                                    //            foreach (PartInventoryStockDetails _inventory in partinventoryStockDetail)
                                    //            {
                                    //                PartInventoryStockDetails _inventoryExt = _inventory;
                                    //                _inventory.DATE_OUT = _dt;
                                    //                _inventory.UPDATED_DATE = _dt;
                                    //                _dbContext.Entry(_inventoryExt).CurrentValues.SetValues(_inventory);
                                    //                update = _dbContext.SaveChanges();
                                    //            }
                                    //        }
                                    //    }
                                    //}

                                    #endregion

                                    #region Delivery Order Complete

                                    DateTime _dt = _dtEndDate;
                                    _delivOrder.UPDATE_DATE = _dt;
                                    _delivOrder.DO_Complete_Date = _dt;
                                    _delivOrder.STATUSID = 11;
                                    _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                    update = _dbContext.SaveChanges();
                                    //foreach (PartInventoryStockDetails _inventory in partinventoryStockDetail)
                                    //{
                                    //    PartInventoryStockDetails _inventoryExt = _inventory;
                                    //    _inventory.DATE_OUT = _dt;
                                    //    _inventory.UPDATED_DATE = _dt;
                                    //    _dbContext.Entry(_inventoryExt).CurrentValues.SetValues(_inventory);
                                    //    update = _dbContext.SaveChanges();
                                    //}

                                    #endregion

                                    int RejectedDO = 0;
                                    foreach (V_DELIVERY_ORDER_SHIPMENTLINES delivOrderShipmentlines in delivOrderShipmentLines)
                                    {
                                        int lstRejectedShipmentLinecount = 0;
                                        ShipmentLines _shipmentLine = _dbContext.Shipment_Lines.Find(delivOrderShipmentlines.ShipmentLineId);
                                        List<PartInventoryStockDetails> lstpartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId).ToList(); // stock_statusid 24 is rejected
                                        if (lstpartStockDetails != null && lstpartStockDetails.Count() > 0)
                                        {
                                            for (int i = 0; i < lstpartStockDetails.Count(); i++)
                                            {
                                                PartInventoryStockDetails partStockDetails = lstpartStockDetails[i];
                                                PartInventoryStockDetails partStockDetailsExt = lstpartStockDetails[i];
                                                Vehicle_Trip_lines _Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Find(delivOrderShipmentlines.triplineid);
                                                Vehicle_Trip_lines _Vehicle_Trip_LinesExt = _Vehicle_Trip_Lines;

                                                PartInventoryStock partStock = partinventorystock.FirstOrDefault(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID);
                                                if (partStock != null)
                                                {
                                                    if (partStockDetails.stock_statusid == 24)
                                                    {
                                                        lstRejectedShipmentLinecount++;
                                                    }
                                                    else
                                                    {
                                                        partStockDetails.qty_intransit_to_location = null;
                                                        partStockDetails.DATE_OUT = _dt;
                                                        partStockDetails.UPDATED_DATE = DateTime.Now;
                                                        partStockDetails.stock_statusid = 4;  // delivered Status
                                                        _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                                        update = _dbContext.SaveChanges();
                                                        PartInventoryStock partStockExt = partStock;
                                                        if (convert.ToFloat(partStock.QTY_INTRANSIT) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                        {
                                                            List<PartInventoryStockDetails> lstPartstockData = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID).ToList();
                                                            double? qty_reserved = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.shipmentid) > 0 && convert.ToInt(x.qty_intransit_to_location) == 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                            double? intransitqty = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.qty_intransit_to_location) > 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                            double? inhandqty = convert.ToFloat(lstPartstockData.Where(x => x.DATE_OUT == null).Sum(x => x.QUANTITY));

                                                            //double? deliveredqty = convert.ToFloat(_dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID && x.shipmentid > 0 && x.qty_intransit_to_location == 0 && x.DATE_OUT != null).Sum(x => x.QUANTITY));
                                                            //double intransitqty = convert.ToFloat(partStock.QTY_INTRANSIT) - convert.ToFloat(partStockDetails.QUANTITY);
                                                            //partStock.QTY_RESERVED = reserveqty;
                                                            partStock.QTY_RESERVED = qty_reserved;
                                                            partStock.QTY_INTRANSIT = intransitqty;
                                                            if (convert.ToFloat(partStock.QTY_IN_HAND) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                            {
                                                                partStock.QTY_IN_HAND = inhandqty;
                                                                if (_shipmentLine != null)
                                                                {
                                                                    _shipmentLine.Delivered_Qty = convert.ToFloat(_shipmentLine.Delivered_Qty) + convert.ToFloat(partStockDetails.QUANTITY);
                                                                    _shipmentLine.Updated_Date = DateTime.Now;
                                                                    _dbContext.Shipment_Lines.Update(_shipmentLine);
                                                                    update = _dbContext.SaveChanges();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity in hand '" + convert.ToFloat(partStock.QTY_IN_HAND) + "' is less than DO shipment qty '" + convert.ToFloat(delivOrderShipmentlines.qty) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                            }

                                                            partStock.UPDATED_DATE = DateTime.Now;
                                                            _dbContext.Entry(partStockExt).CurrentValues.SetValues(partStock);
                                                            update = _dbContext.SaveChanges();
                                                        }
                                                        else
                                                        {
                                                            throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity In transit '" + convert.ToFloat(partStock.QTY_INTRANSIT) + "' is less than DO shipment qty '" + convert.ToFloat(delivOrderShipmentlines.qty) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    throw new Exception("Unable to get PartInventoryStock details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                }

                                                if (lstRejectedShipmentLinecount > 0)
                                                {
                                                    _Vehicle_Trip_Lines.updated_date = DateTime.Now;
                                                    _Vehicle_Trip_Lines.statusid = 24;
                                                    _dbContext.Entry(_Vehicle_Trip_LinesExt).CurrentValues.SetValues(_Vehicle_Trip_Lines);
                                                    update = _dbContext.SaveChanges();
                                                    RejectedDO++;
                                                }
                                            }

                                            if (RejectedDO > 0)
                                            {
                                                Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                                                Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;
                                                _Trip_Details.statusid = 24;
                                                _Trip_Details.updated_date = DateTime.Now;
                                                _dbContext.Entry(_Trip_DetailsExt).CurrentValues.SetValues(_Trip_Details);
                                                update = _dbContext.SaveChanges();

                                                _delivOrder.UPDATE_DATE = DateTime.Now;
                                                _delivOrder.STATUSID = 24;
                                                _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                                update = _dbContext.SaveChanges();
                                            }

                                            //Shipment shipment = shipments.FirstOrDefault(x => x.ShipmentId == delivOrderShipmentlines.ShipmentId);
                                            //if (shipment != null)
                                            //{
                                            //    Shipment shipmentExt = shipment;
                                            //    shipment.Shipment_StatusId = 4;
                                            //    shipment.Updated_Date = DateTime.Now;
                                            //    _dbContext.Entry(shipmentExt).CurrentValues.SetValues(shipment);
                                            //}
                                            //else
                                            //{
                                            //    throw new Exception("Unable to get Shipment details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                            //}

                                            //ShipmentLines shipmentLine = shipmentLines.FirstOrDefault(x => x.ShipmentId == delivOrderShipmentlines.ShipmentId && x.ShipmentLineId == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId);
                                            //if (shipmentLine != null)
                                            //{
                                            //    ShipmentLines shipmentLineExt = shipmentLine;
                                            //    shipmentLine.Item_Status = 4;
                                            //    shipmentLine.Updated_Date = DateTime.Now;
                                            //    _dbContext.Entry(shipmentLineExt).CurrentValues.SetValues(shipmentLine);
                                            //}
                                            //else
                                            //{
                                            //    throw new Exception("Unable to get ShipmentLines for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                            //}

                                            //CustomerOrderLine custOrderLine = custOrderLines.FirstOrDefault(x => x.CustOrderLineId == delivOrderShipmentlines.CustOrderLineId);
                                            //if (custOrderLine != null)
                                            //{
                                            //    CustomerOrderLine custOrderLineExt = custOrderLine;
                                            //    custOrderLine.Item_Status = 4;
                                            //    custOrderLine.Updated_Date = DateTime.Now;
                                            //    _dbContext.Entry(custOrderLineExt).CurrentValues.SetValues(custOrderLine);
                                            //}
                                            //else
                                            //{
                                            //    throw new Exception("Unable to get CustomerOrderLine for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                            //}

                                            //CustomerOrders custOrder = lstcustOrders.FirstOrDefault(x => x.CustomerId == delivOrderShipmentlines.CUSTOMERID && x.OrderId == custOrderLine.OrderId);
                                            //if (custOrder != null)
                                            //{
                                            //    CustomerOrders custOrderExt = custOrder;
                                            //    custOrder.StatusId = 4;
                                            //    custOrder.Updated_Date = DateTime.Now;
                                            //    _dbContext.Entry(custOrderExt).CurrentValues.SetValues(custOrder);
                                            //}
                                            //else
                                            //{
                                            //    throw new Exception("Unable to get CustomerOrders for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                            //}
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get PartInventoryStockDetails for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                        }
                                    }
                                    Vehicle_Trip_Details tripDetailsExt = tripDetails;
                                    tripDetails.statusid = _delivOrder.STATUSID;
                                    tripDetails.updated_date = DateTime.Now;
                                    _dbContext.Entry(tripDetailsExt).CurrentValues.SetValues(tripDetails);
                                    update = _dbContext.SaveChanges();
                                    dbContextTransaction.Commit();

                                    CommonFunction.setLog("Driver : '" + _dr.driver_name + "' have successfully EndTrip for Delivery order no " + _delivOrder.DELIVERY_ORDER_NO);
                                    CommonFunction.SetAudit("EndTrip_EPOD", "Updated", "", "Driver : '" + _dr.driver_name + "' have successfully EndTrip for Delivery order no " + _delivOrder.DELIVERY_ORDER_NO, "");
                                }
                                catch (Exception ex)
                                {
                                    dbContextTransaction.Rollback();
                                    CommonFunction.setLog("Error while Ending Trip EPOD : " + ex.Message);
                                    throw ex;
                                }
                            }
                        });
                        if (update > 0)
                        {
                            DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                            _model = Get_EPOD_Details(details.DeliveryOrderId, details.DriverID);

                            if (_model.deliveryOrder == null)
                                return NotFound($"Order Details with Id {details.DeliveryOrderId} is not found");
                            return Ok(_model);
                        }
                        else
                        {
                            throw new Exception("Unable to save End Trip DELIVERY_ORDERS");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get DELIVERY_ORDERS");
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on EndTrip_EPOD for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("EndTrip_EPOD", "Error", "", "Error on EndTrip_EPOD for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("EndTrip_EPOD function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("EndTrip_EPOD_TRIP_ONLY")]
        public IActionResult EndTrip_EPOD_TRIP_ONLY(GET_DELIVERY_ORDERS_DETAILS details, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("EndTrip_EPOD_TRIP_ONLY Process Started.");
                CommonFunction.setLog("EndTrip_EPOD_TRIP_ONLY with DeliveryOrderId : " + details.DeliveryOrderId + " and Driver ID : " + details.DriverID);
                CommonFunction.Set_Client_Data_on_Log_Authentication(details, AUTHENTICATION_KEY);


                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    Driver_Profile_Tab _dr = _dbContext.Driver_Profile_Tab.Find(details.DriverID);
                    V_DELIVERY_ORDERS _vDelivOrder = _dbContext.V_DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _dbContext.DELIVERY_ORDERS.Find(details.DeliveryOrderId);
                    int update = -1;
                    List<DELIVERY_ORDER_DOCUMENTS> lstDocument = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == details.DeliveryOrderId && x.Is_Delete != 1).ToList();

                    USER_REVIEW _extUserReview = _dbContext.USER_REVIEW.FirstOrDefault(x => x.DELIVERY_ORDER_ID == details.DeliveryOrderId);

                    if (_vDelivOrder.order_types.ToUpper() == "TRIP")
                    {

                        List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                        List<int?> lstcustorderLineids = delivOrderShipmentLines.Select(x => x.CustOrderLineId).ToList();
                        List<int?> lstSalesPartId = delivOrderShipmentLines.Select(x => x.SalesPartId).ToList();
                        List<int?> lstShipmentid = delivOrderShipmentLines.Select(x => x.ShipmentId).ToList();
                        List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                        List<int?> lsttriplineid = delivOrderShipmentLines.Select(x => x.triplineid).ToList();
                        List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();

                        Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                        Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;

                        List<Mast_STATUSES> mStatus = _dbContext.mast_statuses.ToList();
                        List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) /*x.customerid == _delivOrderExist.CUSTOMERID*/ && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();
                        List<PartInventoryStock> partinventorystock = _dbContext.PART_INVENTORY_STOCK.Where(x => lstCustomerid.Contains((int)x.customerid) && lstSalesPartId.Contains(x.SalesPartId)).ToList();

                        Vehicle_Trip_Details tripDetails = _dbContext.Vehicle_Trip_Details.FirstOrDefault(x => x.tripdetailid == _delivOrder.TRIPDETAILID && x.tripid == _delivOrder.TRIPID);

                        if (_delivOrder != null)
                        {
                            if (_delivOrder.STATUSID != 19)
                            {
                                throw new Exception("Unable to End Delivery order as Delivery Order Status is on '" + mStatus.FirstOrDefault(x => x.statusid == _delivOrder.STATUSID).status_desc + "'.");
                            }

                            List<Driver_Allocation> DriverAllocationList = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrder.TRIPDETAILID).ToList();
                            List<DO_OT_APPROVAL> _Do_Ot_Approval = _dbContext.DO_OT_APPROVAL.Where(x => x.DELIVERY_ORDER_ID == details.DeliveryOrderId).ToList();
                            List<int> shipmentLinesId = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrder.TRIPID).Select(x => x.ShipmentLineId).ToList();
                            List<PartInventoryStockDetails> partinventoryStockDetail = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => shipmentLinesId.Contains((int)(x.shipmentlineid)) && lstCustomerid.Contains((int)x.customerid)).ToList();
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        DateTime _dtEndDate = convert.ToDateTime(details.end_trip_date, "dd/MM/yyyy HH:mm");
                                        if (_dtEndDate == DateTime.MinValue)
                                        {
                                            throw new Exception("End Trip Date is invalid.");
                                        }
                                       
                                        _delivOrder.ACTUAL_END = _dtEndDate;
                                        _delivOrder.UPDATE_DATE = DateTime.Now;
                                        _delivOrder.EPOD_STATUS = 11;
                                        _delivOrder.DO_Complete_Date = _dtEndDate;
                                        _delivOrder.STATUSID = 11;
                                        _delivOrder.exported = 1;
                                        _dbContext.Entry(_delivOrder).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                                        update = _dbContext.SaveChanges();

                                        DateTime dateTime1 = convert.ToDateTime(_delivOrder.ACTUAL_START);
                                        DateTime dateTime2 = convert.ToDateTime(_delivOrder.ACTUAL_END);
                                        Vehicle_Trip_Details tripDetailsExt = tripDetails;
                                        tripDetails.statusid = _delivOrder.STATUSID;
                                        tripDetails.updated_date = DateTime.Now;
                                        _dbContext.Entry(tripDetailsExt).CurrentValues.SetValues(tripDetails);
                                        update = _dbContext.SaveChanges();

                                        dbContextTransaction.Commit();

                                        CommonFunction.setLog("Driver : '" + _dr.driver_name + "' have successfully EndTrip for TRIP_ONLY Delivery order no " + _delivOrder.DELIVERY_ORDER_NO);
                                        CommonFunction.SetAudit("EndTrip_EPOD_TRIP_ONLY", "Updated", "", "Driver : '" + _dr.driver_name + "' have successfully EndTrip for TRIP_ONLY Delivery order no " + _delivOrder.DELIVERY_ORDER_NO, "");
                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        CommonFunction.setLog("Error while Ending Trip EPOD : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                            if (update > 0)
                            {
                                DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                                _model = Get_EPOD_Details(details.DeliveryOrderId, details.DriverID);

                                if (_model.deliveryOrder == null)
                                    return NotFound($"Order Details with Id {details.DeliveryOrderId} is not found");
                                return Ok(_model);
                            }
                            else
                            {
                                throw new Exception("Unable to save End Trip DELIVERY_ORDERS");
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get DELIVERY_ORDERS");
                        }
                    }
                    else
                    {
                        throw new Exception("Invalid Order Type");
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on EndTrip_EPOD_TRIP_ONLY for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("EndTrip_EPOD_TRIP_ONLY", "Error", "", "Error on EndTrip_EPOD_TRIP_ONLY for DeliveryOrderId '" + details.DeliveryOrderId + "' ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("EndTrip_EPOD_TRIP_ONLY function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("Update_Attachment")]
        public IActionResult Update_Attachment(vDELIVERY_ORDER_DOCUMENTS DeliveryDoc, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("Update_Attachment Process Started.");

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                CommonFunction.setLog("Update_Attachment with DELIVERY_ORDER_ID : " + DeliveryDoc.DELIVERY_ORDER_ID + " Driver Id : " + DeliveryDoc.DriverID + " Attachment Name : " + DeliveryDoc.Document_Name + " Title : " + DeliveryDoc.Document_Title);
                CommonFunction.Set_Client_Data_on_Log_Authentication(DeliveryDoc, AUTHENTICATION_KEY);

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {

                    int DeliveryOrderId = convert.ToInt(DeliveryDoc.DELIVERY_ORDER_ID);
                    Driver_Profile_Tab _dr = _dbContext.Driver_Profile_Tab.Find(DeliveryDoc.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(DeliveryDoc.DELIVERY_ORDER_ID);
                    DELIVERY_ORDERS _delivOrder = _dbContext.DELIVERY_ORDERS.Find(DeliveryDoc.DELIVERY_ORDER_ID);
                    int update = -1;
                    if (_delivOrder != null)
                    {
                        if (DeliveryDoc.Document_Name == "")
                        {
                            return BadRequest("Document_Name is empty");
                        }
                        string strPath = configuration.GetSection("AppSettings").GetSection("ePOD_Document_Path").Value;
                        DELIVERY_ORDER_DOCUMENTS _Document = new DELIVERY_ORDER_DOCUMENTS();
                        List<DELIVERY_ORDER_DOCUMENTS> lstDocument = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == DeliveryDoc.DELIVERY_ORDER_ID && x.Is_Delete != 1).ToList();
                        List<Mast_SITE_CONFIG> SiteConfig = _dbContext.Mast_SITE_CONFIG.Where(x => x.SiteId == _delivOrder.SITEID && x.ModuleId == 1008).ToList();
                        var _ext_Document = lstDocument.FirstOrDefault(x => x.DELIVERY_ORDER_ID == DeliveryDoc.DELIVERY_ORDER_ID && x.Delivery_Document_ID == _Document.Delivery_Document_ID);
                        if (SiteConfig.Count > 0)
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {

                                    try
                                    {
                                        Mast_SITE_CONFIG _sitePhoto = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1003);
                                        Mast_SITE_CONFIG _siteSignature = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1005);
                                        Mast_SITE_CONFIG _sitePhotoCount = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1006);
                                        Mast_SITE_CONFIG _siteSignatureCount = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1007);
                                        int PhotoCount = lstDocument.Where(x => x.Document_Title.ToUpper() == "PHOTO" && x.Is_Delete != 1).ToList().Count();
                                        int SignatureCount = lstDocument.Where(x => x.Document_Title.ToUpper() == "SIGNATURE" && x.Is_Delete != 1).ToList().Count();

                                        if (DeliveryDoc.Document_Title.ToUpper() == "PHOTO")
                                        {

                                            if (_sitePhoto != null && _sitePhoto.Param_Value != null && _sitePhoto.Param_Value.ToUpper() == "YES")
                                            {
                                                if (_sitePhotoCount != null && _sitePhotoCount.Param_Value != null && _sitePhotoCount.Param_Value.ToUpper() == "MAX")
                                                {
                                                    CommonFunction.setLog("Delivery Order can add maximum photos");
                                                }
                                                else if (_sitePhotoCount != null && _sitePhotoCount.Param_Value != null && convert.ToInt(_sitePhotoCount.Param_Value) >= 0)
                                                {
                                                    if (convert.ToInt(_sitePhotoCount.Param_Value) > PhotoCount)
                                                    {
                                                        CommonFunction.setLog("Delivery Order can add photos");
                                                    }
                                                    else
                                                    {
                                                        throw new Exception("Site is not allowed to add photos more than " + convert.ToInt(_sitePhotoCount.Param_Value));
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Site is not allowed to add Photos.");
                                            }
                                        }
                                        else if (DeliveryDoc.Document_Title.ToUpper() == "SIGNATURE")
                                        {
                                            if (_siteSignature != null && _siteSignature.Param_Value != null && _siteSignature.Param_Value.ToUpper() == "YES")
                                            {
                                                if (_siteSignatureCount != null && _siteSignatureCount.Param_Value != null && _siteSignatureCount.Param_Value.ToUpper() == "MAX")
                                                {
                                                    CommonFunction.setLog("Delivery Order can add maximum Signature");
                                                }
                                                else if (_siteSignatureCount != null && _siteSignatureCount.Param_Value != null && convert.ToInt(_siteSignatureCount.Param_Value) >= 0)
                                                {
                                                    if (convert.ToInt(_siteSignatureCount.Param_Value) > SignatureCount)
                                                    {
                                                        CommonFunction.setLog("Delivery Order can add signature ");
                                                    }
                                                    else
                                                    {
                                                        throw new Exception("Site is not allowed to add Signature more than " + convert.ToInt(_siteSignatureCount.Param_Value));
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Site is not allowed to add Signature.");
                                            }
                                        }

                                        if (_ext_Document == null)
                                        {
                                            _Document.DELIVERY_ORDER_ID = DeliveryDoc.DELIVERY_ORDER_ID;
                                            if (DeliveryDoc.Base64Data != "")
                                            {
                                                byte[] _sbytes = Convert.FromBase64String(DeliveryDoc.Base64Data);
                                                if (!Directory.Exists(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID)) Directory.CreateDirectory(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID);
                                                System.IO.File.WriteAllBytes(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID + "\\" + DeliveryDoc.Document_Name, _sbytes);
                                                if (System.IO.File.Exists(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID + "\\" + DeliveryDoc.Document_Name))
                                                {

                                                    int? DocumentNo = 0;
                                                    if (lstDocument.Max(x => x.Document_No) != null && lstDocument.Max(x => x.Document_No) > 0)
                                                    {
                                                        DocumentNo = lstDocument.Max(x => x.Document_No) + 1;
                                                    }
                                                    else
                                                    {
                                                        DocumentNo = 1000 + 1;
                                                    }

                                                    _Document.Document_Type = Path.GetExtension(DeliveryDoc.Document_Name).Replace(".", "");
                                                    _Document.Document_Name = DeliveryDoc.Document_Name;
                                                    _Document.Document_Path = strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID + "\\" + DeliveryDoc.Document_Name;
                                                    _Document.Document_Title = DeliveryDoc.Document_Title;
                                                    _Document.DELIVERY_ORDER_ID = DeliveryDoc.DELIVERY_ORDER_ID;
                                                    _Document.Document_No = DocumentNo;
                                                    _Document.CREATED_DATE = DateTime.Now;
                                                    _Document.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.DELIVERY_ORDER_DOCUMENTS.Add(_Document);
                                                    update = _dbContext.SaveChanges();
                                                }
                                                else
                                                {
                                                    throw new Exception("Unable to save file " + DeliveryDoc.Document_Name);
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Base64Data is empty");
                                            }
                                        }
                                        else
                                        {
                                            byte[] _sbytes = Convert.FromBase64String(DeliveryDoc.Base64Data);
                                            if (Directory.Exists(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID)) Directory.CreateDirectory(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID);
                                            System.IO.File.WriteAllBytes(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID + "\\" + DeliveryDoc.Document_Name, _sbytes);
                                            if (System.IO.File.Exists(strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID + "\\" + DeliveryDoc.Document_Name))
                                            {
                                                _Document.Delivery_Document_ID = _ext_Document.Delivery_Document_ID;
                                                _Document.Document_Type = Path.GetExtension(DeliveryDoc.Document_Name).Replace(".", "");
                                                _Document.Document_Name = DeliveryDoc.Document_Name;
                                                _Document.Document_Path = strPath + "\\" + DeliveryDoc.DELIVERY_ORDER_ID + "\\" + DeliveryDoc.Document_Name;
                                                _Document.Document_Title = DeliveryDoc.Document_Title;
                                                _Document.DELIVERY_ORDER_ID = DeliveryDoc.DELIVERY_ORDER_ID;
                                                _Document.Document_No = 1000 + (lstDocument.Count() + 1);
                                                _Document.CREATED_DATE = _ext_Document.CREATED_DATE;
                                                _Document.UPDATED_DATE = DateTime.Now;
                                                _dbContext.Entry(_ext_Document).CurrentValues.SetValues(_Document);
                                                update = _dbContext.SaveChanges();
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to save file " + DeliveryDoc.Document_Name);
                                            }
                                        }
                                        //update = _dbContext.SaveChanges();
                                        dbContextTransaction.Commit();

                                        CommonFunction.setLog("Driver : '" + _dr.driver_name + "' have successfully added " + DeliveryDoc.Document_Title.ToUpper() + " delivery document for Delivery order no " + _delivOrder.DELIVERY_ORDER_NO);
                                        CommonFunction.SetAudit("EndTrip_EPOD", "Updated", "", "Driver : '" + _dr.driver_name + "' have successfully added " + DeliveryDoc.Document_Title.ToUpper() + " delivery document for Delivery order no " + _delivOrder.DELIVERY_ORDER_NO, "");
                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        CommonFunction.setLog("Error while Update_Attachment : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Unable to get Site Config Please contact Admin.");
                        }
                        if (update > 0)
                        {
                            DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                            _model = Get_EPOD_Details(DeliveryDoc.DELIVERY_ORDER_ID, DeliveryDoc.DriverID);
                            if (_model.deliveryOrder == null)
                                return NotFound($"Order Details with Id {DeliveryOrderId} is not found");
                            return Ok(_model);
                        }
                        else
                        {
                            throw new Exception("Unable to save Attachement name " + DeliveryDoc.Document_Name);
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get DELIVERY_ORDERS");
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Update_Attachment for DeliveryDoc data ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("Update_Attachment", "Error", "", "Error on Update_Attachment for DeliveryOrderId '" + DeliveryDoc.DELIVERY_ORDER_ID + "' ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Update_Attachment function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("Remove_Attachment")]
        public IActionResult Remove_Attachment(vDELIVERY_ORDER_DOCUMENTS DeliveryDoc, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                CommonFunction.setLog("Remove_Attachment Process Started.");
                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                CommonFunction.setLog("Remove_Attachment with DELIVERY_ORDER_ID : " + DeliveryDoc.DELIVERY_ORDER_ID + " Driver Id : " + DeliveryDoc.DriverID + " Delivery Document ID : " + DeliveryDoc.Delivery_Document_ID);
                int DeliveryOrderId = convert.ToInt(DeliveryDoc.DELIVERY_ORDER_ID);
                CommonFunction.Set_Client_Data_on_Log_Authentication(DeliveryDoc, AUTHENTICATION_KEY);

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    Driver_Profile_Tab _dr = _dbContext.Driver_Profile_Tab.Find(DeliveryDoc.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(DeliveryDoc.DELIVERY_ORDER_ID);
                    DELIVERY_ORDER_DOCUMENTS _existingDocData = _dbContext.DELIVERY_ORDER_DOCUMENTS.Find(DeliveryDoc.Delivery_Document_ID);
                    DELIVERY_ORDER_DOCUMENTS _DocData = _dbContext.DELIVERY_ORDER_DOCUMENTS.Find(DeliveryDoc.Delivery_Document_ID);
                    int update = -1;
                    if (_delivOrderExist != null)
                    {
                        if (_existingDocData != null)
                        {
                            if (DeliveryDoc.Document_Name == "")
                            {
                                return BadRequest("Document_Name is empty");
                            }

                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        _DocData.Is_Delete = 1;
                                        _DocData.UPDATED_DATE = DateTime.Now;
                                        _dbContext.Entry(_existingDocData).CurrentValues.SetValues(_DocData);
                                        update = _dbContext.SaveChanges();
                                        dbContextTransaction.Commit();

                                        CommonFunction.setLog("Driver : '" + _dr.driver_name + "' have successfully removed " + DeliveryDoc.Document_Title.ToUpper() + " delivery document for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                        CommonFunction.SetAudit("Remove_Attachment", "Updated", "", "Driver : '" + _dr.driver_name + "' have successfully removed " + DeliveryDoc.Document_Title.ToUpper() + " delivery document for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        CommonFunction.setLog("Error while Remove_Attachment : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });

                            if (update > 0)
                            {
                                DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
                                _model = Get_EPOD_Details(DeliveryDoc.DELIVERY_ORDER_ID, DeliveryDoc.DriverID);
                                if (_model.deliveryOrder == null)
                                    return NotFound($"Order Details with Id {DeliveryOrderId} is not found");
                                return Ok(_model);
                            }
                            else
                            {
                                throw new Exception("Unable to remove Attachement name " + _existingDocData.Document_Name);
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get DELIVERY_ORDER_DOCUMENT");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get DELIVERY_ORDERS");
                    }
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Remove_Attachment for DeliveryDoc data ERROR : " + ex.Message + " StackTrace : " + ex.StackTrace);
                CommonFunction.SetAudit("Remove_Attachment", "Error", "", "Error on Remove_Attachment for DeliveryOrderId : " + DeliveryDoc.DELIVERY_ORDER_ID + " and Driver Id : " + DeliveryDoc.DriverID + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Remove_Attachment function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("PostUserReviews")]
        public IActionResult PostUserReviews(dUSER_REVIEW model, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                CommonFunction.setLog("UserReviews Process Started.");
                CommonFunction.setLog("UserReviews with dUSER_REVIEW : ");
                CommonFunction.Set_Client_Data_on_Log_Authentication(model, AUTHENTICATION_KEY);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {

                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(model.DELIVERY_ORDER_ID);
                    if (model == null || model.DELIVERY_ORDER_ID <= 0)
                    {
                        if (model == null)
                            return BadRequest("Invaild Model Data");

                        else
                            return BadRequest($"Delivery Order  Id {model.DELIVERY_ORDER_ID} is not Valid");
                    }
                    USER_REVIEW _review = new USER_REVIEW();
                    var _extUserReview = _dbContext.USER_REVIEW.FirstOrDefault(x => x.DELIVERY_ORDER_ID == model.DELIVERY_ORDER_ID);
                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                if (_extUserReview == null)
                                {
                                    _review.DELIVERY_ORDER_ID = model.DELIVERY_ORDER_ID;
                                    _review.Review_Value = model.Review_Value;
                                    _review.User_Remarks = model.User_Remarks;
                                    _review.CREATED_DATE = DateTime.Now;
                                    _review.UPDATED_DATE = DateTime.Now;
                                    _review.Review_By = model.Review_By;
                                    _dbContext.USER_REVIEW.Add(_review);
                                }
                                else
                                {
                                    _review.User_Review_ID = _extUserReview.User_Review_ID;
                                    _review.DELIVERY_ORDER_ID = model.DELIVERY_ORDER_ID;
                                    _review.Review_Value = model.Review_Value;
                                    _review.User_Remarks = model.User_Remarks;
                                    _review.UPDATED_DATE = DateTime.Now;
                                    _review.Review_By = model.Review_By;
                                    _dbContext.Entry(_extUserReview).CurrentValues.SetValues(_review);
                                }
                                _dbContext.SaveChanges();
                                dbContextTransaction.Commit();
                                CommonFunction.setLog("User review have been added successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                CommonFunction.SetAudit("UserReviews", "Updated", "", "User review have been added successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                CommonFunction.setLog("Error while PostUserReviews : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                    return Ok($"User Review with Delivery Order Id {model.DELIVERY_ORDER_ID} Updated Successfully");
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UserReviews - " + ex.Message);
                CommonFunction.SetAudit("UserReviews", "Error", "", "Error on UserReviews for DeliveryOrderId : " + model.DELIVERY_ORDER_ID + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("PostUserReviews stopped successfully.");
            }
        }

        [HttpPost]
        [Route("Trip_Suspended")]
        public IActionResult Trip_Suspended(Driver_Data_Remarks model, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                CommonFunction.setLog("Trip_Suspended Process Started.");
                CommonFunction.Set_Client_Data_on_Log_Authentication(model, AUTHENTICATION_KEY);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    int update = 0;
                    Driver_Profile_Tab _diverDetais = _dbContext.Driver_Profile_Tab.Find(model.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(model.DELIVERY_ORDER_ID);
                    DELIVERY_ORDERS _delivOrder = _delivOrderExist;
                    if (_diverDetais == null)
                    {
                        throw new Exception("Invalid Diver");
                    }
                    if (_delivOrderExist == null)
                    {
                        throw new Exception("Invalid Delivery Order");
                    }
                    else
                    {
                        if (_delivOrderExist.EPOD_STATUS != 18) // In progress 
                        {
                            throw new Exception("EPOD status is invalid");
                        }
                    }
                    if (model == null || model.DELIVERY_ORDER_ID <= 0)
                    {
                        if (model == null)
                            return BadRequest("Invaild Model Data");

                        else
                            return BadRequest($"Delivery Order  Id {model.DELIVERY_ORDER_ID} is not Valid");
                    }

                    List<Driver_Allocation> driver_Allocation_List = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID).ToList();
                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    List<int?> lstcustorderLineids = delivOrderShipmentLines.Select(x => x.CustOrderLineId).ToList();
                    List<int?> lstSalesPartId = delivOrderShipmentLines.Select(x => x.SalesPartId).ToList();
                    List<int?> lstShipmentid = delivOrderShipmentLines.Select(x => x.ShipmentId).ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<int?> lsttriplineid = delivOrderShipmentLines.Select(x => x.triplineid).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();

                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();
                    List<PartInventoryStock> partinventorystock = _dbContext.PART_INVENTORY_STOCK.Where(x => lstCustomerid.Contains((int)x.customerid) /*x.customerid == _delivOrderExist.CUSTOMERID*/ && lstSalesPartId.Contains(x.SalesPartId)).ToList();

                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                _delivOrder.STATUSID = 28;
                                _delivOrder.EPOD_STATUS = 28;
                                _delivOrder.UPDATE_DATE = DateTime.Now;
                                _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                _dbContext.SaveChanges();

                                DRIVER_REMARKS _driverRmk = new DRIVER_REMARKS();
                                _driverRmk.statusid = 28;
                                _driverRmk.created_date = convert.ToDateTime(model.datetime, "dd/MM/yyyy HH:mm");
                                _driverRmk.update_date = DateTime.Now;
                                _driverRmk.delivery_order_id = model.DELIVERY_ORDER_ID;
                                _driverRmk.driver_remark = model.Driver_Remarks;
                                _driverRmk.driver_id = model.DriverID;
                                _driverRmk.update_by = model.DriverID;
                                _driverRmk.created_by = model.DriverID;
                                _dbContext.Driver_remarks.Add(_driverRmk);
                                _dbContext.SaveChanges();

                                foreach (Driver_Allocation _driverAllocationData in driver_Allocation_List)
                                {
                                    Driver_Allocation _driverAllocationExist = _driverAllocationData;
                                    _driverAllocationData.is_Present = 0;
                                    _driverAllocationData.EPOD_Driver_Remarks = null;
                                    _driverAllocationData.updated_date = DateTime.Now;
                                    _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationData);
                                    update = _dbContext.SaveChanges();
                                }

                                foreach (V_DELIVERY_ORDER_SHIPMENTLINES delivOrderShipmentlines in delivOrderShipmentLines)
                                {
                                    List<PartInventoryStockDetails> lstpartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId).ToList();
                                    if (lstpartStockDetails != null && lstpartStockDetails.Count() > 0)
                                    {
                                        for (int i = 0; i < lstpartStockDetails.Count(); i++)
                                        {
                                            PartInventoryStockDetails partStockDetails = lstpartStockDetails[i];
                                            PartInventoryStockDetails partStockDetailsExt = lstpartStockDetails[i];
                                            PartInventoryStock partStock = partinventorystock.FirstOrDefault(x => x.SalesPartId == delivOrderShipmentlines.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID);
                                            if (partStock != null)
                                            {
                                                partStockDetails.qty_intransit_to_location = null;
                                                partStockDetails.UPDATED_DATE = DateTime.Now;
                                                partStockDetails.stock_statusid = 6; // Back to Reserver status
                                                _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                                update = _dbContext.SaveChanges();

                                                List<PartInventoryStockDetails> lstPartstockData = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID).ToList();

                                                double qty_reserved = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.shipmentid) > 0 && convert.ToInt(x.qty_intransit_to_location) == 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                double qty_intransit = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.qty_intransit_to_location) > 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));

                                                PartInventoryStock partStockExt = partStock;
                                                if (convert.ToFloat(partStock.QTY_INTRANSIT) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                {
                                                    //double reserveqty = convert.ToFloat(partStock.QTY_RESERVED) - convert.ToFloat(partStockDetails.QUANTITY);
                                                    //partStock.QTY_RESERVED = reserveqty;
                                                    //partStock.QTY_INTRANSIT = convert.ToFloat(partStock.QTY_INTRANSIT) + convert.ToFloat(partStockDetails.QUANTITY);

                                                    partStock.QTY_RESERVED = qty_reserved;
                                                    partStock.QTY_INTRANSIT = qty_intransit;
                                                    partStock.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.Entry(partStockExt).CurrentValues.SetValues(partStock);
                                                    update = _dbContext.SaveChanges();
                                                }
                                                else
                                                {
                                                    throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity reserver '" + convert.ToFloat(partStock.QTY_RESERVED) + "' is less than quantity Shipment '" + convert.ToFloat(partStockDetails.QUANTITY) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to get PartInventoryStock details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get PartInventoryStockDetails for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                    }
                                }
                                dbContextTransaction.Commit();
                                CommonFunction.setLog("Driver " + _diverDetais.driver_name + " have suspened order successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                CommonFunction.SetAudit("Trip_Suspended", "Updated", "", "Driver " + _diverDetais.driver_name + " have suspened order successfully  for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                CommonFunction.setLog("Error while Trip_Suspended : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                    return Ok($"Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO + " suspened successfully");
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Trip_Suspended - " + ex.Message);
                CommonFunction.SetAudit("Trip_Suspended", "Error", "", "Error on Trip_Suspended for DeliveryOrderId : " + model.DELIVERY_ORDER_ID + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Trip_Suspended stopped successfully.");
            }
        }

        [HttpPost]
        [Route("Trip_Returned")]
        public IActionResult Trip_Returned(Driver_Data_Remarks model, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");

                CommonFunction.setLog("Trip_Returned Process Started.");
                CommonFunction.Set_Client_Data_on_Log_Authentication(model, AUTHENTICATION_KEY);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    int update = 0;
                    Driver_Profile_Tab _diverDetais = _dbContext.Driver_Profile_Tab.Find(model.DriverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(model.DELIVERY_ORDER_ID);
                    DELIVERY_ORDERS _delivOrder = _delivOrderExist;
                    if (_diverDetais == null)
                    {
                        throw new Exception("Invalid Diver");
                    }
                    if (_delivOrderExist == null)
                    {
                        throw new Exception("Invalid Delivery Order");
                    }
                    else
                    {
                        if (_delivOrderExist.EPOD_STATUS != 18) // In progress 
                        {
                            throw new Exception("EPOD status is invalid");
                        }
                    }
                    if (model == null || model.DELIVERY_ORDER_ID <= 0)
                    {
                        if (model == null)
                            return BadRequest("Invaild Model Data");

                        else
                            return BadRequest($"Delivery Order  Id {model.DELIVERY_ORDER_ID} is not Valid");
                    }

                    List<Driver_Allocation> driver_Allocation_List = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID).ToList();
                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    List<int?> lstcustorderLineids = delivOrderShipmentLines.Select(x => x.CustOrderLineId).ToList();
                    List<int?> lstSalesPartId = delivOrderShipmentLines.Select(x => x.SalesPartId).ToList();
                    List<int?> lstShipmentid = delivOrderShipmentLines.Select(x => x.ShipmentId).ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<int?> lsttriplineid = delivOrderShipmentLines.Select(x => x.triplineid).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();

                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();
                    List<PartInventoryStock> partinventorystock = _dbContext.PART_INVENTORY_STOCK.Where(x => lstCustomerid.Contains((int)x.customerid) /*x.customerid == _delivOrderExist.CUSTOMERID*/ && lstSalesPartId.Contains(x.SalesPartId)).ToList();

                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                _delivOrder.STATUSID = 29;
                                _delivOrder.EPOD_STATUS = 29;
                                _delivOrder.DO_Complete_Date = convert.ToDateTime(model.datetime, "dd/MM/yyyy HH:mm");
                                _delivOrder.UPDATE_DATE = DateTime.Now;
                                _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                _dbContext.SaveChanges();

                                DRIVER_REMARKS _driverRmk = new DRIVER_REMARKS();
                                _driverRmk.statusid = 29;
                                _driverRmk.created_date = convert.ToDateTime(model.datetime, "dd/MM/yyyy HH:mm");
                                _driverRmk.update_date = DateTime.Now;
                                _driverRmk.delivery_order_id = model.DELIVERY_ORDER_ID;
                                _driverRmk.driver_remark = model.Driver_Remarks;
                                _driverRmk.driver_id = model.DriverID;
                                _driverRmk.update_by = model.DriverID;
                                _driverRmk.created_by = model.DriverID;
                                _dbContext.Driver_remarks.Add(_driverRmk);
                                _dbContext.SaveChanges();

                                Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                                Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;
                                ////List <Vehicle_Trip_lines> _lst_Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Where(x=> x.tripid == _delivOrder.TRIPID).ToList();
                                List<V_DELIVERY_ORDER_SHIPMENTLINES> _lst_Vehicle_Trip_Lines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.DELIVERY_ORDER_ID == model.DELIVERY_ORDER_ID).ToList();


                                foreach (V_DELIVERY_ORDER_SHIPMENTLINES delivOrderShipmentlines in delivOrderShipmentLines)
                                {
                                    List<PartInventoryStockDetails> lstpartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId).ToList();
                                    if (lstpartStockDetails != null && lstpartStockDetails.Count() > 0)
                                    {
                                        for (int i = 0; i < lstpartStockDetails.Count(); i++)
                                        {
                                            PartInventoryStockDetails partStockDetails = lstpartStockDetails[i];
                                            PartInventoryStockDetails partStockDetailsExt = lstpartStockDetails[i];
                                            PartInventoryStock partStock = partinventorystock.FirstOrDefault(x => x.SalesPartId == delivOrderShipmentlines.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID);
                                            if (partStock != null)
                                            {
                                                partStockDetails.UPDATED_DATE = DateTime.Now;
                                                partStockDetails.stock_statusid = 29; // return status
                                                _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                                update = _dbContext.SaveChanges();

                                                PARTSTOCKDETAIL_REMARKS _newitemRemarks = new PARTSTOCKDETAIL_REMARKS();
                                                _newitemRemarks.updated_date = DateTime.Now;
                                                _newitemRemarks.created_date = DateTime.Now;
                                                _newitemRemarks.created_by = convert.ToInt(model.DriverID);
                                                _newitemRemarks.updated_by = convert.ToInt(model.DriverID);
                                                _newitemRemarks.module_id = 1007;
                                                _newitemRemarks.link_record_id = _delivOrder.DELIVERY_ORDER_ID;
                                                _newitemRemarks.link_record_id_2 = delivOrderShipmentlines.ShipmentLineId;
                                                _newitemRemarks.partstockdetailid = partStockDetails.PART_STOCK_DETAIL_ID;
                                                _newitemRemarks.remarks = model.Driver_Remarks;
                                                _dbContext.PARTSTOCKDETAIL_REMARKS.Add(_newitemRemarks);
                                                update = _dbContext.SaveChanges();

                                                List<PartInventoryStockDetails> lstPartstockData = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID).ToList();

                                                double qty_reserved = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.shipmentid) > 0 && convert.ToInt(x.qty_intransit_to_location) == 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                double qty_intransit = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.qty_intransit_to_location) > 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));

                                                PartInventoryStock partStockExt = partStock;
                                                if (convert.ToFloat(partStock.QTY_INTRANSIT) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                {
                                                    //double reserveqty = convert.ToFloat(partStock.QTY_RESERVED) - convert.ToFloat(partStockDetails.QUANTITY);
                                                    //partStock.QTY_RESERVED = reserveqty;
                                                    //partStock.QTY_INTRANSIT = convert.ToFloat(partStock.QTY_INTRANSIT) + convert.ToFloat(partStockDetails.QUANTITY);

                                                    partStock.QTY_RESERVED = qty_reserved;
                                                    partStock.QTY_INTRANSIT = qty_intransit;
                                                    partStock.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.Entry(partStockExt).CurrentValues.SetValues(partStock);
                                                    update = _dbContext.SaveChanges();
                                                }
                                                else
                                                {
                                                    throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity reserver '" + convert.ToFloat(partStock.QTY_RESERVED) + "' is less than quantity Shipment '" + convert.ToFloat(partStockDetails.QUANTITY) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to get PartInventoryStock details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get PartInventoryStockDetails for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                    }
                                }

                                if (_Trip_Details != null)
                                {
                                    _Trip_Details.statusid = 29;
                                    _Trip_Details.updated_date = DateTime.Now;
                                    _dbContext.Entry(_Trip_DetailsExt).CurrentValues.SetValues(_Trip_Details);
                                    _dbContext.SaveChanges();

                                    if (_lst_Vehicle_Trip_Lines.Count() > 0)
                                    {
                                        for (int i = 0; i < _lst_Vehicle_Trip_Lines.Count(); i++)
                                        {
                                            Vehicle_Trip_lines _Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Find(_lst_Vehicle_Trip_Lines[i].triplineid);
                                            Vehicle_Trip_lines _Vehicle_Trip_LinesExt = _Vehicle_Trip_Lines;
                                            _Vehicle_Trip_Lines.updated_date = DateTime.Now;
                                            _Vehicle_Trip_Lines.statusid = 29;
                                            _dbContext.Entry(_Vehicle_Trip_LinesExt).CurrentValues.SetValues(_Vehicle_Trip_Lines);
                                            _dbContext.SaveChanges();
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Trip Line not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Trip details not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                }

                                //foreach (Driver_Allocation _driverAllocationData in driver_Allocation_List)
                                //{
                                //    Driver_Allocation _driverAllocationExist = _driverAllocationData;
                                //    _driverAllocationData.is_Present = 0;
                                //    _driverAllocationData.EPOD_Driver_Remarks = null;
                                //    _driverAllocationData.updated_date = DateTime.Now;
                                //    _dbContext.Entry(_driverAllocationExist).CurrentValues.SetValues(_driverAllocationData);
                                //    update = _dbContext.SaveChanges();
                                //}



                                //foreach (V_DELIVERY_ORDER_SHIPMENTLINES delivOrderShipmentlines in delivOrderShipmentLines)
                                //{
                                //    List<PartInventoryStockDetails> lstpartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == delivOrderShipmentlines.ShipmentLineId && x.SalesPartId == delivOrderShipmentlines.SalesPartId).ToList();
                                //    if (lstpartStockDetails != null && lstpartStockDetails.Count() > 0)
                                //    {
                                //        for (int i = 0; i < lstpartStockDetails.Count(); i++)
                                //        {
                                //            PartInventoryStockDetails partStockDetails = lstpartStockDetails[i];
                                //            PartInventoryStockDetails partStockDetailsExt = lstpartStockDetails[i];
                                //            PartInventoryStock partStock = partinventorystock.FirstOrDefault(x => x.SalesPartId == delivOrderShipmentlines.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID);
                                //            if (partStock != null)
                                //            {
                                //                partStockDetails.qty_intransit_to_location = null;
                                //                partStockDetails.UPDATED_DATE = DateTime.Now;
                                //                _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                //                update = _dbContext.SaveChanges();

                                //                List<PartInventoryStockDetails> lstPartstockData = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == delivOrderShipmentlines.CUSTOMERID).ToList();

                                //                double qty_reserved = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.shipmentid) > 0 && convert.ToInt(x.qty_intransit_to_location) == 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                //                double qty_intransit = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.qty_intransit_to_location) > 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));

                                //                PartInventoryStock partStockExt = partStock;
                                //                if (convert.ToFloat(partStock.QTY_INTRANSIT) >= convert.ToFloat(partStockDetails.QUANTITY))
                                //                {
                                //                    //double reserveqty = convert.ToFloat(partStock.QTY_RESERVED) - convert.ToFloat(partStockDetails.QUANTITY);
                                //                    //partStock.QTY_RESERVED = reserveqty;
                                //                    //partStock.QTY_INTRANSIT = convert.ToFloat(partStock.QTY_INTRANSIT) + convert.ToFloat(partStockDetails.QUANTITY);

                                //                    partStock.QTY_RESERVED = qty_reserved;
                                //                    partStock.QTY_INTRANSIT = qty_intransit;
                                //                    partStock.UPDATED_DATE = DateTime.Now;
                                //                    _dbContext.Entry(partStockExt).CurrentValues.SetValues(partStock);
                                //                    update = _dbContext.SaveChanges();
                                //                }
                                //                else
                                //                {
                                //                    throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity reserver '" + convert.ToFloat(partStock.QTY_RESERVED) + "' is less than quantity Shipment '" + convert.ToFloat(partStockDetails.QUANTITY) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                //                }
                                //            }
                                //            else
                                //            {
                                //                throw new Exception("Unable to get PartInventoryStock details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                //            }
                                //        }
                                //    }
                                //    else
                                //    {
                                //        throw new Exception("Unable to get PartInventoryStockDetails for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                //    }
                                //}
                                dbContextTransaction.Commit();
                                CommonFunction.setLog("Driver " + _diverDetais.driver_name + " have returned order successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                CommonFunction.SetAudit("Trip_Returned", "Updated", "", "Driver " + _diverDetais.driver_name + " have returned order successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                CommonFunction.setLog("Error while Trip_Returned : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                    return Ok($"Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO + " returned successfully");
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Trip_Returned - " + ex.Message);
                CommonFunction.SetAudit("Trip_Returned", "Error", "", "Error on Trip_Returned for DeliveryOrderId : " + model.DELIVERY_ORDER_ID + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Trip_Returned stopped successfully.");
            }
        }

        [HttpPost]
        [Route("Trip_Rejected")]
        public IActionResult Trip_Rejected(DO_Reject_Details model, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("Trip_Rejected Process Started.");
                CommonFunction.Set_Client_Data_on_Log_Authentication(model, AUTHENTICATION_KEY);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    int update = 0;
                    Driver_Profile_Tab _diverDetais = _dbContext.Driver_Profile_Tab.Find(model.driverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(model.deliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _delivOrderExist;
                    USER_REVIEW _extUserReview = _dbContext.USER_REVIEW.FirstOrDefault(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId);
                    List<int?> lstRejectedPartStockDetailIds = model.rejectedItems.Select(x => x.partstockdetailid).Distinct().ToList();
                    List<int?> lstRejectedShipmentLineIds = model.rejectedItems.Select(x => x.shipmentlineid).Distinct().ToList();
                    CommonFunction.setLog("Rejected stockDetail - " + lstRejectedPartStockDetailIds.Count + ", RejectedShipmentLines - " + lstRejectedShipmentLineIds.Count);
                    List<DELIVERY_ORDER_DOCUMENTS> lstDocument = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId && x.Is_Delete != 1).ToList();
                    List<Mast_SITE_CONFIG> SiteConfig = _dbContext.Mast_SITE_CONFIG.Where(x => x.SiteId == _delivOrder.SITEID && x.ModuleId == 1008).ToList();
                    if (SiteConfig.Count > 0)
                    {
                        Mast_SITE_CONFIG _sitePhoto = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1003);
                        Mast_SITE_CONFIG _siteSignature = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1005);
                        Mast_SITE_CONFIG _sitePhotoCount = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1006);
                        Mast_SITE_CONFIG _siteSignatureCount = SiteConfig.FirstOrDefault(x => x.SiteConfig_ParamId == 1007);
                        int PhotoCount = lstDocument.Where(x => x.Document_Title.ToUpper() == "PHOTO" && x.Is_Delete != 1).ToList().Count();
                        int SignatureCount = lstDocument.Where(x => x.Document_Title.ToUpper() == "SIGNATURE" && x.Is_Delete != 1).ToList().Count();

                        if (_sitePhoto != null && _sitePhoto.Param_Value != null && _sitePhoto.Param_Value.ToUpper() == "YES")
                        {
                            if (_sitePhotoCount != null && _sitePhotoCount.Param_Value != null && convert.ToInt(_sitePhotoCount.Param_Value) >= 0)
                            {
                                if (PhotoCount == 0)
                                {
                                    throw new Exception("Atleast 1 Delivery Photo Document is required to end trip.");
                                }
                                if (convert.ToInt(_sitePhotoCount.Param_Value) >= PhotoCount)
                                {
                                    CommonFunction.setLog("Delivery Order can add photos");
                                }
                                else
                                {
                                    throw new Exception("Site is not allowed to add photos more than " + convert.ToInt(_sitePhotoCount.Param_Value));
                                }
                            }
                        }
                        else
                        {
                            CommonFunction.setLog("Delivery Order can End trip without Photos");
                        }

                        if (_siteSignature != null && _siteSignature.Param_Value != null && _siteSignature.Param_Value.ToUpper() == "YES")
                        {
                            if (_siteSignatureCount != null && _siteSignatureCount.Param_Value != null && convert.ToInt(_siteSignatureCount.Param_Value) >= 0)
                            {
                                if (SignatureCount == 0)
                                {
                                    throw new Exception("Atleast 1 Delivery Signature Document is required to end trip.");
                                }
                                if (convert.ToInt(_siteSignatureCount.Param_Value) >= SignatureCount)
                                {
                                    CommonFunction.setLog("Delivery Order can add signature ");
                                }
                                else
                                {
                                    throw new Exception("Site is not allowed to add Signature more than " + convert.ToInt(_siteSignatureCount.Param_Value));
                                }
                            }
                            if (_extUserReview == null)
                            {
                                throw new Exception("Delivery Order can not end trip without user review.");
                            }
                        }
                        else
                        {
                            CommonFunction.setLog("Delivery Order can End trip without Signature");
                        }
                    }

                    if (_diverDetais == null)
                    {
                        throw new Exception("Invalid Diver");
                    }
                    if (_delivOrderExist == null)
                    {
                        throw new Exception("Invalid Delivery Order");
                    }
                    else
                    {
                        if (_delivOrderExist.EPOD_STATUS != 18) // In progress 
                        {
                            throw new Exception("EPOD status is invalid");
                        }
                    }
                    if (model == null || model.deliveryOrderId <= 0)
                    {
                        if (model == null)
                            return BadRequest("Invaild Model Data");

                        else
                            return BadRequest($"Delivery Order  Id {model.deliveryOrderId} is not Valid");
                    }
                    DateTime _dtEndDate = convert.ToDateTime(model.end_trip_date, "dd/MM/yyyy HH:mm");
                    if (_dtEndDate == DateTime.MinValue)
                    {
                        throw new Exception("End Trip Date is invalid.");
                    }

                    //List<Driver_Allocation> driver_Allocation_List = _dbContext.Driver_Allocation.Where(x => x.tripdetailid == _delivOrderExist.TRIPDETAILID && x.tripid == _delivOrderExist.TRIPID).ToList();
                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    //List<int?> lstcustorderLineids = delivOrderShipmentLines.Select(x => x.CustOrderLineId).ToList();
                    List<int?> lstSalesPartId = delivOrderShipmentLines.Select(x => x.SalesPartId).ToList();
                    List<int?> lstShipmentid = delivOrderShipmentLines.Select(x => x.ShipmentId).ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<int?> lsttriplineid = delivOrderShipmentLines.Select(x => x.triplineid).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();

                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();
                    List<PartInventoryStock> partinventorystock = _dbContext.PART_INVENTORY_STOCK.Where(x => lstCustomerid.Contains((int)x.customerid) /*x.customerid == _delivOrderExist.CUSTOMERID*/ && lstSalesPartId.Contains(x.SalesPartId)).ToList();

                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                                Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;
                                ////List<Vehicle_Trip_lines> _lst_Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Where(x => x.tripid == _delivOrder.TRIPID).ToList();
                                List<V_DELIVERY_ORDER_SHIPMENTLINES> _lst_Vehicle_Trip_Lines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId).ToList();

                                if (_Trip_Details != null)
                                {
                                    _Trip_Details.statusid = 24;
                                    _Trip_Details.updated_date = DateTime.Now;
                                    _dbContext.Entry(_Trip_DetailsExt).CurrentValues.SetValues(_Trip_Details);
                                    _dbContext.SaveChanges();

                                    if (_lst_Vehicle_Trip_Lines.Count() > 0)
                                    {
                                        int nDOItemComplete = 1;
                                        string cDORejectRemarks = "";
                                        CommonFunction.setLog("DO line itemscount - " + _lst_Vehicle_Trip_Lines.Count());

                                        for (int i = 0; i < _lst_Vehicle_Trip_Lines.Count(); i++)
                                        {
                                            //Vehicle_Trip_lines _Vehicle_Trip_Lines = _lst_Vehicle_Trip_Lines[i];
                                            Vehicle_Trip_lines _Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Find(_lst_Vehicle_Trip_Lines[i].triplineid);
                                            Vehicle_Trip_lines _Vehicle_Trip_LinesExt = _Vehicle_Trip_Lines;

                                            List<PartInventoryStockDetails> lstpartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == _Vehicle_Trip_Lines.shipmentlineid && x.SalesPartId == _Vehicle_Trip_Lines.salespartid).ToList();
                                            string cRejectReason = "";
                                            CommonFunction.setLog("DO line partStock count - " + lstpartStockDetails.Count());

                                            if (lstpartStockDetails != null && lstpartStockDetails.Count() > 0)
                                            {
                                                ShipmentLines _shipmentLine = _dbContext.Shipment_Lines.Find(_Vehicle_Trip_Lines.shipmentlineid);
                                                nDOItemComplete = 1;
                                                if (lstRejectedShipmentLineIds.Contains(_Vehicle_Trip_Lines.shipmentlineid))
                                                    cRejectReason += "Line [" + _Vehicle_Trip_Lines.lineno + "], PartNo. [" + _shipmentLine.Source_PartNo + "] item rejected ";

                                                for (int j = 0; j < lstpartStockDetails.Count(); j++)
                                                {
                                                    PartInventoryStockDetails partStockDetails = lstpartStockDetails[j];
                                                    PartInventoryStockDetails partStockDetailsExt = lstpartStockDetails[j];

                                                    if (lstRejectedPartStockDetailIds.Contains(partStockDetails.PART_STOCK_DETAIL_ID)) // RejetedItems
                                                    {
                                                        nDOItemComplete = 0;
                                                        List<RejectedItems> _Items = model.rejectedItems.Where(x => x.partstockdetailid == partStockDetails.PART_STOCK_DETAIL_ID).ToList();
                                                        if (_Items.Count > 0)
                                                            if (!string.IsNullOrWhiteSpace(_Items[0].remarks))
                                                                if (!string.IsNullOrWhiteSpace(partStockDetails.SERIAL))
                                                                    cRejectReason += Environment.NewLine + "Serial No. -" + partStockDetails.SERIAL + " | " + _Items[0].remarks;
                                                                else if (!cRejectReason.Contains(_Items[0].remarks)) cRejectReason += Environment.NewLine + _Items[0].remarks;

                                                        partStockDetails.UPDATED_DATE = DateTime.Now;
                                                        partStockDetails.stock_statusid = 24;
                                                        _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                                        update = _dbContext.SaveChanges();

                                                        PARTSTOCKDETAIL_REMARKS _updateitemRemarks = _dbContext.PARTSTOCKDETAIL_REMARKS.FirstOrDefault(x => x.module_id == 1007 && x.partstockdetailid == partStockDetails.PART_STOCK_DETAIL_ID && x.link_record_id == model.deliveryOrderId && x.link_record_id_2 == _shipmentLine.ShipmentLineId);
                                                        if (_updateitemRemarks != null)
                                                        {
                                                            _updateitemRemarks.updated_date = DateTime.Now;
                                                            _updateitemRemarks.created_by = convert.ToInt(model.driverID);
                                                            _updateitemRemarks.updated_by = convert.ToInt(model.driverID);
                                                            _updateitemRemarks.module_id = 1007;
                                                            _updateitemRemarks.link_record_id = model.deliveryOrderId;
                                                            _updateitemRemarks.link_record_id_2 = _shipmentLine.ShipmentLineId;
                                                            _updateitemRemarks.partstockdetailid = partStockDetails.PART_STOCK_DETAIL_ID;
                                                            _updateitemRemarks.remarks = _Items[0].remarks;
                                                            _dbContext.Entry(_updateitemRemarks).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                                                            update = _dbContext.SaveChanges();
                                                        }
                                                        else
                                                        {
                                                            PARTSTOCKDETAIL_REMARKS _newitemRemarks = new PARTSTOCKDETAIL_REMARKS();
                                                            _newitemRemarks.updated_date = DateTime.Now;
                                                            _newitemRemarks.created_date = DateTime.Now;
                                                            _newitemRemarks.created_by = convert.ToInt(model.driverID);
                                                            _newitemRemarks.updated_by = convert.ToInt(model.driverID);
                                                            _newitemRemarks.module_id = 1007;
                                                            _newitemRemarks.link_record_id = model.deliveryOrderId;
                                                            _newitemRemarks.link_record_id_2 = _shipmentLine.ShipmentLineId;
                                                            _newitemRemarks.partstockdetailid = partStockDetails.PART_STOCK_DETAIL_ID;
                                                            _newitemRemarks.remarks = _Items[0].remarks;
                                                            _dbContext.PARTSTOCKDETAIL_REMARKS.Add(_newitemRemarks);
                                                            update = _dbContext.SaveChanges();
                                                        }

                                                        CommonFunction.setLog("Update stock detail - " + lstpartStockDetails[j].PART_STOCK_DETAIL_ID);
                                                    }
                                                    else if (convert.ToInt(partStockDetails.PART_STOCK_DETAIL_ID) > 0)
                                                    {
                                                        #region DO Complete Item Stock Detail 
                                                        PartInventoryStock partStock = partinventorystock.FirstOrDefault(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == partStockDetails.customerid);
                                                        if (partStock != null)
                                                        {
                                                            partStockDetails.qty_intransit_to_location = null;
                                                            partStockDetails.DATE_OUT = _dtEndDate;
                                                            partStockDetails.UPDATED_DATE = DateTime.Now;
                                                            partStockDetails.stock_statusid = 4;
                                                            _dbContext.Entry(partStockDetailsExt).CurrentValues.SetValues(partStockDetails);
                                                            update = _dbContext.SaveChanges();
                                                            PartInventoryStock partStockExt = partStock;
                                                            if (convert.ToFloat(partStock.QTY_INTRANSIT) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                            {
                                                                List<PartInventoryStockDetails> lstPartstockData = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => x.SalesPartId == partStockDetails.SalesPartId && x.PARTLOCATIONID == partStockDetails.PARTLOCATIONID && x.customerid == partStockDetails.customerid).ToList();
                                                                double? qty_reserved = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.shipmentid) > 0 && convert.ToInt(x.qty_intransit_to_location) == 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                                double? intransitqty = convert.ToFloat(lstPartstockData.Where(x => convert.ToInt(x.qty_intransit_to_location) > 0 && x.DATE_OUT == null).Sum(x => x.QUANTITY));
                                                                double? inhandqty = convert.ToFloat(lstPartstockData.Where(x => x.DATE_OUT == null).Sum(x => x.QUANTITY));

                                                                partStock.QTY_RESERVED = qty_reserved;
                                                                partStock.QTY_INTRANSIT = intransitqty;
                                                                if (convert.ToFloat(partStock.QTY_IN_HAND) >= convert.ToFloat(partStockDetails.QUANTITY))
                                                                {
                                                                    partStock.QTY_IN_HAND = inhandqty;
                                                                    if (_shipmentLine != null)
                                                                    {
                                                                        _shipmentLine.Delivered_Qty = convert.ToFloat(_shipmentLine.Delivered_Qty) + convert.ToFloat(partStockDetails.QUANTITY);
                                                                        _shipmentLine.Updated_Date = DateTime.Now;
                                                                        _dbContext.Shipment_Lines.Update(_shipmentLine);
                                                                        update = _dbContext.SaveChanges();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity in hand '" + convert.ToFloat(partStock.QTY_IN_HAND) + "' is less than DO shipment qty '" + convert.ToFloat(_shipmentLine.Delivered_Qty) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                                }

                                                                partStock.UPDATED_DATE = DateTime.Now;
                                                                _dbContext.Entry(partStockExt).CurrentValues.SetValues(partStock);
                                                                update = _dbContext.SaveChanges();
                                                            }
                                                            else
                                                            {
                                                                throw new Exception("Part Inventory Stock [ID:" + partStock.PARTSTOCKID + "] quantity In transit '" + convert.ToFloat(partStock.QTY_INTRANSIT) + "' is less than DO shipment qty '" + convert.ToFloat(_shipmentLine.Delivered_Qty) + "' for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                            }
                                                        }
                                                        else
                                                        {
                                                            throw new Exception("Unable to get PartInventoryStock details for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                                        }
                                                        #endregion
                                                    }
                                                } // forEach PartStock Detail
                                            }

                                            // If Rejected Item
                                            if (lstRejectedShipmentLineIds.Count > 0 && lstRejectedShipmentLineIds.Contains(_Vehicle_Trip_Lines.shipmentlineid))
                                            {
                                                _Vehicle_Trip_Lines.updated_date = DateTime.Now;
                                                _Vehicle_Trip_Lines.statusid = 24;

                                                _dbContext.Entry(_Vehicle_Trip_LinesExt).CurrentValues.SetValues(_Vehicle_Trip_Lines);
                                                _dbContext.SaveChanges();

                                                if (!string.IsNullOrWhiteSpace(cRejectReason))
                                                    if (!string.IsNullOrWhiteSpace(cDORejectRemarks))
                                                        cDORejectRemarks += Environment.NewLine + cRejectReason;
                                                    else cDORejectRemarks = cRejectReason;
                                                CommonFunction.setLog("LineItem - " + _Vehicle_Trip_Lines.lineno + " rejected");
                                            }
                                            else if (nDOItemComplete == 1) // DO Complete Item
                                            {
                                                _Vehicle_Trip_Lines.updated_date = DateTime.Now;
                                                _Vehicle_Trip_Lines.statusid = 4;

                                                _dbContext.Entry(_Vehicle_Trip_LinesExt).CurrentValues.SetValues(_Vehicle_Trip_Lines);
                                                _dbContext.SaveChanges();
                                                CommonFunction.setLog("LineItem - " + _Vehicle_Trip_Lines.lineno + " fully delivered");
                                            }
                                        } // TripLines

                                        _delivOrder.STATUSID = 24;
                                        _delivOrder.ACTUAL_END = _dtEndDate;
                                        _delivOrder.EPOD_STATUS = 24;
                                        _delivOrder.UPDATE_DATE = DateTime.Now;
                                        _delivOrder.DO_Complete_Date = _dtEndDate;
                                        _dbContext.Entry(_delivOrderExist).CurrentValues.SetValues(_delivOrder);
                                        _dbContext.SaveChanges();

                                        DRIVER_REMARKS _driverRmk = new DRIVER_REMARKS();
                                        _driverRmk.statusid = 24;
                                        _driverRmk.created_date = convert.ToDateTime(model.end_trip_date, "dd/MM/yyyy HH:mm");
                                        _driverRmk.update_date = DateTime.Now;
                                        _driverRmk.delivery_order_id = model.deliveryOrderId;
                                        _driverRmk.driver_remark = cDORejectRemarks;
                                        _driverRmk.driver_id = model.driverID;
                                        _driverRmk.update_by = model.driverID;
                                        _driverRmk.created_by = model.driverID;
                                        _dbContext.Driver_remarks.Add(_driverRmk);
                                        _dbContext.SaveChanges();
                                    }
                                    else
                                    {
                                        throw new Exception("Trip Line not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Trip details not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                }


                                dbContextTransaction.Commit();
                                CommonFunction.setLog("Driver " + _diverDetais.driver_name + " have rejected order successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                CommonFunction.SetAudit("Trip_Rejected", "Updated", "", "Driver " + _diverDetais.driver_name + " have rejected order successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                CommonFunction.setLog("Error while Trip_Rejected : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                    return Ok($"Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO + " rejected successfully");
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Trip_Rejected - " + ex.Message);
                CommonFunction.SetAudit("Trip_Rejected", "Error", "", "Error on Trip_Rejected for DeliveryOrderId : " + model.deliveryOrderId + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Trip_Rejected stopped successfully.");
            }
        }


        [HttpPost]
        [Route("Add_Reject_Item")]
        public IActionResult Add_Reject_Item(Reject_Item_Details model, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("Add_Reject_Item Process Started.");
                CommonFunction.Set_Client_Data_on_Log(model);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY);
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    int update = 0;
                    Driver_Profile_Tab _diverDetais = _dbContext.Driver_Profile_Tab.Find(model.driverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(model.deliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _delivOrderExist;
                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<DELIVERY_ORDER_DOCUMENTS> lstDocument = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId && x.Is_Delete != 1).ToList();
                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();

                    if (_diverDetais == null)
                    {
                        throw new Exception("Invalid Diver");
                    }
                    if (_delivOrderExist == null)
                    {
                        throw new Exception("Invalid Delivery Order");
                    }
                    else
                    {
                        if (_delivOrderExist.EPOD_STATUS != 18) // In progress 
                        {
                            throw new Exception("EPOD status is invalid");
                        }
                    }
                    if (model == null || model.deliveryOrderId <= 0)
                    {
                        if (model == null)
                            return BadRequest("Invaild Model Data");

                        else
                            return BadRequest($"Delivery Order  Id {model.deliveryOrderId} is not Valid");
                    }
                    
                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                                Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;
                                ////List<Vehicle_Trip_lines> _lst_Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Where(x => x.tripid == _delivOrder.TRIPID).ToList();
                                List<V_DELIVERY_ORDER_SHIPMENTLINES> _lst_Vehicle_Trip_Lines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId).ToList();

                                if (_Trip_Details != null)
                                {
                                    if (_lst_Vehicle_Trip_Lines.Count() > 0)
                                    {
                                        int nDOItemComplete = 1;
                                        string cDORejectRemarks = "";

                                        for (int i = 0; i < model.rejectedItems.Count(); i++)
                                        {
                                            RejectedItems _rejItemData = model.rejectedItems[i];
                                            List<PartInventoryStockDetails> lstSelectedPartStockDetails = new List<PartInventoryStockDetails>();
                                            if (convert.ToInt(_rejItemData.partstockdetailid) > 0)
                                            {
                                                lstSelectedPartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == _rejItemData.shipmentlineid && x.SalesPartId == _rejItemData.salespartid && x.PART_STOCK_DETAIL_ID == convert.ToInt(_rejItemData.partstockdetailid)).ToList();
                                                List<PARTSTOCKDETAIL_REMARKS> lstPartStockRemarks = _dbContext.PARTSTOCKDETAIL_REMARKS.Where(x => x.module_id == 1007 && x.partstockdetailid == convert.ToInt(_rejItemData.partstockdetailid) && x.link_record_id == model.deliveryOrderId && x.link_record_id_2 == _rejItemData.shipmentlineid).ToList();
                                                foreach (PARTSTOCKDETAIL_REMARKS _delRmks in lstPartStockRemarks)
                                                {
                                                    PartInventoryStockDetails lstPartStockDetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Find(_delRmks.partstockdetailid);
                                                    lstPartStockDetails.stock_statusid = 30; //In Transit
                                                    lstPartStockDetails.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.SaveChanges();

                                                    _dbContext.PARTSTOCKDETAIL_REMARKS.Remove(_delRmks);
                                                    _dbContext.SaveChanges();
                                                }
                                            }
                                            else
                                            {
                                                lstSelectedPartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == _rejItemData.shipmentlineid && x.SalesPartId == _rejItemData.salespartid).OrderBy(x => x.DATE_IN).Take(convert.ToInt(_rejItemData.rejectedqty)).ToList();
                                                List<PARTSTOCKDETAIL_REMARKS> lstPartStockRemarks = _dbContext.PARTSTOCKDETAIL_REMARKS.Where(x => x.module_id == 1007 && x.link_record_id == model.deliveryOrderId && x.link_record_id_2 == _rejItemData.shipmentlineid).ToList();
                                                foreach (PARTSTOCKDETAIL_REMARKS _delRmks in lstPartStockRemarks)
                                                {
                                                    PartInventoryStockDetails lstPartStockDetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Find(_delRmks.partstockdetailid);
                                                    lstPartStockDetails.stock_statusid = 30;
                                                    lstPartStockDetails.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.SaveChanges();

                                                    _dbContext.PARTSTOCKDETAIL_REMARKS.Remove(_delRmks);
                                                    _dbContext.SaveChanges();
                                                }
                                            }

                                            string cRejectReason = "";

                                            if (lstSelectedPartStockDetails != null && lstSelectedPartStockDetails.Count() > 0)
                                            {
                                                ShipmentLines _shipmentLine = _dbContext.Shipment_Lines.Find(_rejItemData.shipmentlineid);
                                                cRejectReason += "Line [" + _shipmentLine.Line_No + "], PartNo. [" + _shipmentLine.Source_PartNo + "] item rejected ";

                                                for (int j = 0; j < lstSelectedPartStockDetails.Count(); j++)
                                                {
                                                    PartInventoryStockDetails partStockDetails = lstSelectedPartStockDetails[j];
                                                    PartInventoryStockDetails partStockDetailsExt = lstSelectedPartStockDetails[j];

                                                    nDOItemComplete = 0;
                                                    RejectedItems _Items = model.rejectedItems[i];

                                                    partStockDetails.UPDATED_DATE = DateTime.Now;
                                                    partStockDetails.stock_statusid = 24;
                                                    CommonFunction.setLog("Update stock detail - " + lstSelectedPartStockDetails[j].PART_STOCK_DETAIL_ID);
                                                    update = _dbContext.SaveChanges();

                                                    PARTSTOCKDETAIL_REMARKS _updateitemRemarks = _dbContext.PARTSTOCKDETAIL_REMARKS.FirstOrDefault(x => x.module_id == 1007 && x.partstockdetailid == partStockDetails.PART_STOCK_DETAIL_ID && x.link_record_id == model.deliveryOrderId && x.link_record_id_2 == _shipmentLine.ShipmentLineId);
                                                    if (_updateitemRemarks != null)
                                                    {
                                                        _updateitemRemarks.updated_date = DateTime.Now;
                                                        _updateitemRemarks.created_by = convert.ToInt(model.driverID);
                                                        _updateitemRemarks.updated_by = convert.ToInt(model.driverID);
                                                        _updateitemRemarks.module_id = 1007;
                                                        _updateitemRemarks.link_record_id = model.deliveryOrderId;
                                                        _updateitemRemarks.link_record_id_2 = _shipmentLine.ShipmentLineId;
                                                        _updateitemRemarks.partstockdetailid = partStockDetails.PART_STOCK_DETAIL_ID;
                                                        _updateitemRemarks.remarks = _Items.remarks;
                                                        _dbContext.Entry(_updateitemRemarks).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                                                        update = _dbContext.SaveChanges();
                                                    }
                                                    else
                                                    {
                                                        PARTSTOCKDETAIL_REMARKS _newitemRemarks = new PARTSTOCKDETAIL_REMARKS();
                                                        _newitemRemarks.updated_date = DateTime.Now;
                                                        _newitemRemarks.created_date = DateTime.Now;
                                                        _newitemRemarks.created_by = convert.ToInt(model.driverID);
                                                        _newitemRemarks.updated_by = convert.ToInt(model.driverID);
                                                        _newitemRemarks.module_id = 1007;
                                                        _newitemRemarks.link_record_id = model.deliveryOrderId;
                                                        _newitemRemarks.link_record_id_2 = _shipmentLine.ShipmentLineId;
                                                        _newitemRemarks.partstockdetailid = partStockDetails.PART_STOCK_DETAIL_ID;
                                                        _newitemRemarks.remarks = _Items.remarks;
                                                        _dbContext.PARTSTOCKDETAIL_REMARKS.Add(_newitemRemarks);
                                                        update = _dbContext.SaveChanges();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Trip Line not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Trip details not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                }
                                dbContextTransaction.Commit();
                                CommonFunction.setLog("Driver " + _diverDetais.driver_name + " have rejected Item successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                CommonFunction.SetAudit("Add_Reject_Item", "Updated", "", "Driver " + _diverDetais.driver_name + " have rejected Item order successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                CommonFunction.setLog("Error while Add_Reject_Item : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                    return Ok($"Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO + " Item rejected successfully");
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Add_Reject_Item - " + ex.Message);
                CommonFunction.SetAudit("Add_Reject_Item", "Error", "", "Error on Add_Reject_Item for DeliveryOrderId : " + model.deliveryOrderId + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Add_Reject_Item stopped successfully.");
            }
        }


        [HttpPost]
        [Route("Remove_Reject_Item")]
        public IActionResult Remove_Reject_Item(Reject_Item_Details model, [FromHeader] string AUTHENTICATION_KEY)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("Remove_Reject_Item Process Started.");
                CommonFunction.Set_Client_Data_on_Log(model);

                HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

                CommonFunction.setLog("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY);
                bool value = CommonFunction.Check_AUTHENTICATION_KEY(AUTHENTICATION_KEY);
                if (value)
                {
                    int update = 0;
                    Driver_Profile_Tab _diverDetais = _dbContext.Driver_Profile_Tab.Find(model.driverID);
                    DELIVERY_ORDERS _delivOrderExist = _dbContext.DELIVERY_ORDERS.Find(model.deliveryOrderId);
                    DELIVERY_ORDERS _delivOrder = _delivOrderExist;
                    List<V_DELIVERY_ORDER_SHIPMENTLINES> delivOrderShipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripid == _delivOrderExist.TRIPID && x.DELIVERY_ORDER_ID == _delivOrderExist.DELIVERY_ORDER_ID).ToList();
                    List<int?> lstCustomerid = delivOrderShipmentLines.Select(x => x.CUSTOMERID).Distinct().ToList();
                    List<int> lstShipmentlineid = delivOrderShipmentLines.Select(x => x.ShipmentLineId).ToList();
                    List<DELIVERY_ORDER_DOCUMENTS> lstDocument = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId && x.Is_Delete != 1).ToList();
                    List<PartInventoryStockDetails> partInventorystockdetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Where(x => lstCustomerid.Contains((int)x.customerid) && x.shipmentid == _delivOrderExist.SHIPMENTID && lstShipmentlineid.Contains((int)x.shipmentlineid)).ToList();

                    if (_diverDetais == null)
                    {
                        throw new Exception("Invalid Diver");
                    }
                    if (_delivOrderExist == null)
                    {
                        throw new Exception("Invalid Delivery Order");
                    }
                    else
                    {
                        if (_delivOrderExist.EPOD_STATUS != 18) // In progress 
                        {
                            throw new Exception("EPOD status is invalid");
                        }
                    }
                    if (model == null || model.deliveryOrderId <= 0)
                    {
                        if (model == null)
                            return BadRequest("Invaild Model Data");

                        else
                            return BadRequest($"Delivery Order  Id {model.deliveryOrderId} is not Valid");
                    }

                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                Vehicle_Trip_Details _Trip_Details = _dbContext.Vehicle_Trip_Details.Find(_delivOrder.TRIPDETAILID);
                                Vehicle_Trip_Details _Trip_DetailsExt = _Trip_Details;
                                ////List<Vehicle_Trip_lines> _lst_Vehicle_Trip_Lines = _dbContext.Vehicle_Trip_lines.Where(x => x.tripid == _delivOrder.TRIPID).ToList();
                                List<V_DELIVERY_ORDER_SHIPMENTLINES> _lst_Vehicle_Trip_Lines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.DELIVERY_ORDER_ID == model.deliveryOrderId).ToList();

                                if (_Trip_Details != null)
                                {
                                    if (_lst_Vehicle_Trip_Lines.Count() > 0)
                                    {
                                        int nDOItemComplete = 1;
                                        string cDORejectRemarks = "";

                                        for (int i = 0; i < model.rejectedItems.Count(); i++)
                                        {
                                            RejectedItems _rejItemData = model.rejectedItems[i];
                                            List<PartInventoryStockDetails> lstSelectedPartStockDetails = new List<PartInventoryStockDetails>();
                                            if (convert.ToInt(_rejItemData.partstockdetailid) > 0)
                                            {
                                                lstSelectedPartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == _rejItemData.shipmentlineid && x.SalesPartId == _rejItemData.salespartid && x.PART_STOCK_DETAIL_ID == convert.ToInt(_rejItemData.partstockdetailid)).ToList();
                                                List<PARTSTOCKDETAIL_REMARKS> lstPartStockRemarks = _dbContext.PARTSTOCKDETAIL_REMARKS.Where(x => x.module_id == 1007 && x.partstockdetailid == convert.ToInt(_rejItemData.partstockdetailid) && x.link_record_id == model.deliveryOrderId && x.link_record_id_2 == _rejItemData.shipmentlineid).ToList();
                                                foreach (PARTSTOCKDETAIL_REMARKS _delRmks in lstPartStockRemarks)
                                                {
                                                    PartInventoryStockDetails lstPartStockDetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Find(_delRmks.partstockdetailid);
                                                    lstPartStockDetails.stock_statusid = 30; //In Transit
                                                    lstPartStockDetails.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.SaveChanges();

                                                    _dbContext.PARTSTOCKDETAIL_REMARKS.Remove(_delRmks);
                                                    _dbContext.SaveChanges();
                                                }
                                            }
                                            else
                                            {
                                                lstSelectedPartStockDetails = partInventorystockdetails.Where(x => x.shipmentlineid == _rejItemData.shipmentlineid && x.SalesPartId == _rejItemData.salespartid && x.stock_statusid == 24).OrderBy(x => x.DATE_IN).Take(convert.ToInt(_rejItemData.rejectedqty)).ToList();
                                                List<int> _lstpartStockdetailid = lstSelectedPartStockDetails.Select(x => x.PART_STOCK_DETAIL_ID).Distinct().ToList();
                                                List<PARTSTOCKDETAIL_REMARKS> lstPartStockRemarks = _dbContext.PARTSTOCKDETAIL_REMARKS.Where(x => _lstpartStockdetailid.Contains(x.partstockdetailid.GetValueOrDefault()) && x.module_id == 1007 && x.link_record_id == model.deliveryOrderId && x.link_record_id_2 == _rejItemData.shipmentlineid).ToList();
                                                foreach (PARTSTOCKDETAIL_REMARKS _delRmks in lstPartStockRemarks)
                                                {
                                                    PartInventoryStockDetails lstPartStockDetails = _dbContext.PART_INVENTORY_STOCK_DETAILS.Find(_delRmks.partstockdetailid);
                                                    lstPartStockDetails.stock_statusid = 30; //In Transit
                                                    lstPartStockDetails.UPDATED_DATE = DateTime.Now;
                                                    _dbContext.SaveChanges();

                                                    _dbContext.PARTSTOCKDETAIL_REMARKS.Remove(_delRmks);
                                                    _dbContext.SaveChanges();
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Trip Line not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Trip details not found for Delivery Order No : " + _delivOrder.DELIVERY_ORDER_NO);
                                }
                                dbContextTransaction.Commit();
                                CommonFunction.setLog("Driver " + _diverDetais.driver_name + " have remove rejected Item successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO);
                                CommonFunction.SetAudit("Remove_Reject_Item", "Updated", "", "Driver " + _diverDetais.driver_name + " have remove rejected item successfully for Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO, "");
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                CommonFunction.setLog("Error while Remove_Reject_Item : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                    return Ok($"Delivery order no " + _delivOrderExist.DELIVERY_ORDER_NO + " rejected Item removed successfully");
                }
                else
                {
                    throw new Exception("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY + " is invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Remove_Reject_Item - " + ex.Message);
                CommonFunction.SetAudit("Remove_Reject_Item", "Error", "", "Error on Remove_Reject_Item for DeliveryOrderId : " + model.deliveryOrderId + " ERROR : " + ex.Message, "");
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Remove_Reject_Item stopped successfully.");
            }
        }


        //[HttpPut]
        //public IActionResult Put(DELIVERY_ORDERS model, [FromHeader] string AUTHENTICATION_KEY)
        //{
        //    try
        //    {
        //        CommonFunction.setLog("=====================================================");

        //        CommonFunction.setLog("Put with DELIVERY_ORDERS : ");
        //        string _dataValueStr = JsonConvert.SerializeObject(model);
        //        CommonFunction.setLog("Data : " + _dataValueStr);
        //        HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
        //        if (model == null || model.DELIVERY_ORDER_ID <= 0)
        //        {
        //            if (model == null)
        //                return BadRequest("Invaild Model Data");

        //            else
        //                return BadRequest($"Delivery Order  Id {model.DELIVERY_ORDER_ID} is not Valid");
        //        }

        //        var deliveryData = _dbContext.DELIVERY_ORDERS.Find(model.DELIVERY_ORDER_ID);

        //        if (deliveryData == null)
        //            return NotFound($"Delivery Order Details with Id {model.DELIVERY_ORDER_ID} is not found");

        //        deliveryData.DELIVERY_ORDER_NO = model.DELIVERY_ORDER_NO;
        //        deliveryData.SHIPMENTID = model.SHIPMENTID;
        //        deliveryData.SITEID = model.SITEID;
        //        deliveryData.TRIPDETAILID = model.TRIPDETAILID;
        //        deliveryData.TRIPID = model.TRIPID;
        //        deliveryData.REMARKS = model.REMARKS;
        //        deliveryData.CREATED_DATE = model.CREATED_DATE;
        //        deliveryData.UPDATE_DATE = model.UPDATE_DATE;
        //        _dbContext.SaveChanges();

        //        return Ok($"Delivery Order with Id {model.DELIVERY_ORDER_ID} Updated Successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        CommonFunction.setLog("Error on Put function - " + ex.Message);
        //        CommonFunction.SetAudit("Put", "Error", "", "Error on Put for DeliveryOrderId : " + model.DELIVERY_ORDER_ID + " ERROR : " + ex.Message, "");
        //        return BadRequest(ex.Message);
        //    }
        //    finally
        //    {
        //        CommonFunction.setLog("Put function stopped successfully.");
        //    }
        //}

        private static System.Drawing.Image resizeImage(System.Drawing.Image imgToResize, Size size)
        {
            //Get the image current width  
            try
            {
                int sourceWidth = imgToResize.Width;
                //Get the image current height  
                int sourceHeight = imgToResize.Height;
                float nPercent = 0;
                float nPercentW = 0;
                float nPercentH = 0;
                //Calulate  width with new desired size  
                nPercentW = ((float)size.Width / (float)sourceWidth);
                //Calculate height with new desired size  
                nPercentH = ((float)size.Height / (float)sourceHeight);
                if (nPercentH < nPercentW)
                    nPercent = nPercentH;
                else
                    nPercent = nPercentW;
                //New Width  
                int destWidth = (int)(sourceWidth * nPercent);
                //New Height  
                int destHeight = (int)(sourceHeight * nPercent);
                Bitmap b = new Bitmap(destWidth, destHeight);
                Graphics g = Graphics.FromImage((System.Drawing.Image)b);
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                // Draw image with new width and height  
                g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
                g.Dispose();

                return (System.Drawing.Image)b;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private DeliveryOrderDetailsView Get_EPOD_Details(int? DeliveryOrderId, int? DriverId)
        {

            int sCustomer_ID = 0;
            ProofOfDeliveryDocument _ProofHeaderData = new ProofOfDeliveryDocument();
            DeliveryOrderDetailsView _model = new DeliveryOrderDetailsView();
            try
            {
                _model.deliveryOrder = _dbContext.V_EPOD_DELIVERY_ORDERS.FirstOrDefault(x => x.DELIVERY_ORDER_ID == DeliveryOrderId && x.Driver_Id == DriverId);
                _model.driver_Allocation = _dbContext.V_Driver_Allocation.Where(x => x.tripdetailid == _model.deliveryOrder.TRIPDETAILID && x.tripid == _model.deliveryOrder.TRIPID && x.driver_id != DriverId).ToList();
                _model.shipmentLines = _dbContext.V_DELIVERY_ORDER_SHIPMENTLINES.Where(x => x.tripdetailid == _model.deliveryOrder.TRIPDETAILID).ToList();
                List<int> shipmentLinesIds = _model.shipmentLines.Select(x => x.ShipmentLineId).Distinct().ToList();
                _model.ordershipmentLines = _dbContext.V_DELIVERY_ORDER_CUSTOMER_ORDERLINES.Where(x => x.tripid == _model.deliveryOrder.TRIPID).ToList();

                _model.module_statuses = _dbContext.V_MODULE_STATUSES.Where(x => x.moduleid == 1008).ToList();
                _model.deliverOrderAddress = _dbContext.V_Delivery_Orders_Address.Where(x => x.DeliveryOrderId == DeliveryOrderId).ToList();
                _model.Customers = _dbContext.Customers.Find(_model.deliveryOrder.CUSTOMERID);
                _model.EndCustomers = _dbContext.Customers.Find(_model.deliveryOrder.END_CUSTOMERID);
                _model.PartInventoryStockDetails = _dbContext.V_PART_INVENTORY_STOCK_DETAILS.Where(x => shipmentLinesIds.Contains((int)x.shipmentlineid)).Select(x => new epod_Reject_V_PartInventoryStockDetails
                {
                    part_stock_detail_id = x.PART_STOCK_DETAIL_ID,
                    salespartid = x.SalesPartId,
                    shipmentlineid = x.shipmentlineid,
                    serial = x.SERIAL,
                    receive_with_serials = x.RECEIVE_WITH_SERIALS,
                    stock_status_text = x.stock_status_text,
                    stock_statusid = x.stock_statusid,
                    remarks = _dbContext.PARTSTOCKDETAIL_REMARKS.FirstOrDefault(a => a.module_id == 1007 && a.partstockdetailid == x.PART_STOCK_DETAIL_ID && a.link_record_id == DeliveryOrderId && a.link_record_id_2 == x.shipmentlineid).remarks
                }).ToList();

                if (_model.PartInventoryStockDetails.Where(x => x.stock_statusid == 24 || x.stock_statusid == 29).ToList().Count() > 0)
                {
                    _model.current_Status = _model.PartInventoryStockDetails.FirstOrDefault(x => x.stock_statusid == 24 || x.stock_statusid == 29).stock_status_text;
                }
                else
                {
                    _model.current_Status = _model.deliveryOrder.STATUS_TEXT;
                }
                 List<DELIVERY_ORDER_DOCUMENTS> lstDeliveryOrder = _dbContext.DELIVERY_ORDER_DOCUMENTS.Where(x => x.DELIVERY_ORDER_ID == DeliveryOrderId && x.Is_Delete != 1).ToList();
                _model.UserReview = _dbContext.USER_REVIEW.FirstOrDefault(x => x.DELIVERY_ORDER_ID == _model.deliveryOrder.DELIVERY_ORDER_ID);
                List<sDELIVERY_ORDER_DOCUMENTS> lstAttach = new List<sDELIVERY_ORDER_DOCUMENTS>();
                foreach (DELIVERY_ORDER_DOCUMENTS _attach in lstDeliveryOrder)
                {
                    sDELIVERY_ORDER_DOCUMENTS sData = new sDELIVERY_ORDER_DOCUMENTS();
                    sData.DELIVERY_ORDER_ID = _attach.DELIVERY_ORDER_ID;
                    sData.Document_Path = null;
                    sData.Document_Name = _attach.Document_Name;
                    sData.Document_No = _attach.Document_No;
                    sData.CREATED_DATE = _attach.CREATED_DATE;
                    sData.UPDATED_DATE = _attach.UPDATED_DATE;
                    sData.Delivery_Document_ID = _attach.Delivery_Document_ID;
                    sData.Document_Title = _attach.Document_Title;
                    sData.Document_Type = _attach.Document_Type;
                    if (System.IO.File.Exists(_attach.Document_Path))
                    {
                        try
                        {
                            using (System.Drawing.Image img = System.Drawing.Image.FromFile(_attach.Document_Path))
                            {
                                System.Drawing.Image cImg = resizeImage(img, new Size(300, 300));
                                byte[] data = null;
                                using (MemoryStream ms = new MemoryStream())
                                {
                                    cImg.Save(ms, ImageFormat.Png);
                                    data = ms.ToArray();
                                }
                                Byte[] bytes = data;
                                string file = Convert.ToBase64String(bytes);
                                sData.Base64Data = file;
                            }
                        }
                        catch (Exception ex)
                        {
                            if (ex.Message.ToLower().Contains("out of memory"))
                            {
                                using (MagickImage image = new MagickImage(_attach.Document_Path))
                                {
                                    image.Resize(300, 300);
                                    image.Format = MagickFormat.Png;
                                    //image.Write(outputFilePath);
                                    byte[] data = null;
                                    using (MemoryStream ms = new MemoryStream())
                                    {
                                        // Save the resized image to the memory stream in PNG format
                                        image.Format = MagickFormat.Png;
                                        image.Write(ms);
                                        data = ms.ToArray();
                                        // Do further processing or save the memoryStream to a file or use it as needed
                                    }
                                    Byte[] bytes = data;
                                    string file = Convert.ToBase64String(bytes);
                                    sData.Base64Data = file;
                                }
                            }
                        }
                    }
                    lstAttach.Add(sData);
                }
                _model.sDELIVERY_ORDER_DOCUMENTS = lstAttach;

                if (_model.EndCustomers != null && convert.ToInt(_model.EndCustomers.Customer_ID) > 0)
                {
                    sCustomer_ID = _model.EndCustomers.Customer_ID;
                }
                else if (_model.Customers != null && convert.ToInt(_model.Customers.Customer_ID) > 0)
                {
                    sCustomer_ID = _model.Customers.Customer_ID;
                }
                if (sCustomer_ID > 0)
                {
                    CustomerAddress CustAddr = _dbContext.Customer_Address.FirstOrDefault(x => x.CustomerId == sCustomer_ID && x.Addr_Type.ToUpper() == "DELIVERY");
                    if (CustAddr != null && CustAddr.CustomerAddressId > 0)
                    {
                        //_ProofHeaderData.Recivedby = CustAddr.contact_person;
                        if (CustAddr.CONTACT_PERSONID != null && convert.ToInt(CustAddr.CONTACT_PERSONID) > 0)
                        {
                            Mast_Persons _persons = _dbContext.Mast_Persons.Find((int)CustAddr.CONTACT_PERSONID);
                            if (_persons != null)
                            {
                                _ProofHeaderData.Recivedby = _persons.Full_Name;
                            }
                        }
                    }
                    if (_model.UserReview != null)
                    {
                        if (_model.UserReview.Review_By != null && _model.UserReview.Review_By != "")
                        {
                            _ProofHeaderData.Recivedby = _model.UserReview.Review_By;
                        }
                    }
                }
                _ProofHeaderData.ActualStart = _model.deliveryOrder.ACTUAL_START;
                _ProofHeaderData.ActualEnd = _model.deliveryOrder.ACTUAL_END;
                _model.ProofOfDeliveryDocument = _ProofHeaderData;

            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                throw new Exception("Error on Get_EPOD_Details " + ex.Message);
            }
            return _model;
        }

    }

    public class Attendent_Remarks_Info
    {
        public int? DeliveryOrderId { get; set; }
        public int? DriverID { get; set; }
        public int? DriverAllocationId { get; set; }
        public string? Remarks { get; set; }
    }

    public class ProofOfDeliveryDocument
    {
        public string? Recivedby { get; set; }
        public DateTime? PlannedFrom { get; set; }
        public DateTime? PlannedTo { get; set; }
        public DateTime? ActualStart { get; set; }
        public DateTime? ActualEnd { get; set; }
        public double? CustOTCharge { get; set; }
        public double? DriverOverTime { get; set; }
    }
}
