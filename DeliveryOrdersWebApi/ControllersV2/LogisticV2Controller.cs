using Microsoft.AspNetCore.Authorization;
using System.Web;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using LES_USER_ADMINISTRATION_LIB.DAL;
using Logistic_Management_Lib.DAL;
using Logistic_Management_Lib;
using LeSDataMain;
using LES_USER_ADMINISTRATION_LIB.Model;
using Logistic_Management_Lib.Model;
using DeliveryOrdersWebApi.Model;
using eSupplier_Lib.Data;

namespace DeliveryOrdersWebApi.Controllers
{
    [Route("api/V2/Logistic")]
    [ApiController]
    [Authorize]
    public class LogisticV2Controller : Controller
    {
        IConfiguration configuration;
        private readonly LogisticDbContext _dbContext;
        private readonly UserAdminDbContext _dbContextAdmin;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly LogisticManagementV2Class _routineMiddleware;
        private readonly ESupplierConlashContext _dbesupplier;


        string ModuleName = "";
        public DataRoutine _routine { get; set; }

        public LogisticV2Controller(LogisticDbContext dbContext, UserAdminDbContext dbContextAdmin, ESupplierConlashContext esuppliercontext, IWebHostEnvironment webHostEnvironment, LogisticManagementV2Class _RouteMiddle)
        {
            CommonFunction.setLog("before - Logistic Management V2 ");
            _dbContext = dbContext;

            _routineMiddleware = _RouteMiddle;
            var configBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            configuration = configBuilder.Build();
            _dbContextAdmin = dbContextAdmin;
            _dbesupplier = esuppliercontext;
            _routine = new DataRoutine(_dbContext, _dbContextAdmin, _dbesupplier);
            ModuleName = LogisticDbContext.configuration.GetSection("AppSettings").GetSection("LOGISTIC_MODULE").Value;
            _webHostEnvironment = webHostEnvironment;
            CommonFunction.setLog("after -  Logistic Management V2");
        }

        #region Outbound and Delivery order 
        [HttpPost]
        [Route("GetModuleStatus")]
        public IActionResult GetModuleStatus(int Moduleid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetModuleStatus Process started for Moduleid " + Moduleid);
                object obj = _routineMiddleware.CallGetModuleStatus(Moduleid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetModuleStatus :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetModuleStatus function stopped successfully.");
            }
        }
        [HttpPost]
        [Route("GetDeliveryOrderListByCompanyId")]
        public IActionResult GetDeliveryOrderListByCompanyId(FilterDeliveryOrdersList modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrderList Process started");
                CommonFunction.setLog("GetDeliveryOrderList DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallGetDeliveryOrderList(modal);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrderList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrderList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrderListByCustomerId")]
        public IActionResult GetDeliveryOrderListByCustomerId(FilterDeliveryOrdersList modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrderList Process started");
                CommonFunction.setLog("GetDeliveryOrderList DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallGetDeliveryOrderListByCustomerid(modal);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrderList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrderList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetShipmentListByCompanyId")]
        public IActionResult GetShipmentListByCompanyId(FilterShipmentList modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetShipmentList process started");
                CommonFunction.setLog("GetShipmentList DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallGetShipmentList(modal);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetShipmentList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetShipmentList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetShipmentListByCustomerId")]
        public IActionResult GetShipmentListByCustomerId(FilterShipmentList modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetShipmentListByCustomerId process started");
                CommonFunction.setLog("GetShipmentListByCustomerId DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallGetShipmentListbycustomerId(modal);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetShipmentList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetShipmentList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetSiteConfigByModuleidAndCompanyid")]
        public IActionResult GetSiteConfigByModuleidAndCompanyid(int Moduleid, int companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetSiteConfigByModuleidAndCompanyid process started");
                object obj = _routineMiddleware.CallGetSiteConfigByModuleidAndCompanyid(Moduleid, companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetSiteConfigByModuleidAndCompanyid :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetSiteConfigByModuleidAndCompanyid function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrdersInfoByCompanyId")]
        public IActionResult GetDeliveryOrdersInfoByCompanyId(int DeliveryOrderid, int Companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrdersInfoByCompanyId Process started for DeliveryOrderid " + DeliveryOrderid + " and companyid " + Companyid);
                object obj = _routineMiddleware.CallGetVDeliveryOrdersInfo_By_Id(DeliveryOrderid, Companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrdersInfoByCompanyId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrdersInfoByCompanyId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrdersInfoByCustomerId")]
        public IActionResult GetDeliveryOrdersInfoByCustomerId(int DeliveryOrderid, int Companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrdersInfoByCustomerId Process started for DeliveryOrderid " + DeliveryOrderid + " and companyid " + Companyid);
                object obj = _routineMiddleware.CallGetVDeliveryOrdersInfo_By_Id(DeliveryOrderid, Companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrdersInfoByCustomerId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrdersInfoByCustomerId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrdersAddressByDeliveryOrderId")]
        public IActionResult GetDeliveryOrdersAddressByDeliveryOrderId(int DeliveryOrderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrdersAddressByDeliveryOrderId Process started for DeliveryOrderid " + DeliveryOrderid);
                object obj = _routineMiddleware.CallGetVDeliveryOrdersAddressEpodByDeliveryOrderId(DeliveryOrderid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrdersAddressByDeliveryOrderId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrdersAddressByDeliveryOrderId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetVDeliveryOrderLines")]
        public IActionResult GetVDeliveryOrderLines(int DeliveryOrderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetVDeliveryOrderLines Process started for DeliveryOrderid " + DeliveryOrderid);
                object obj = _routineMiddleware.CallGetVDeliveryOrderLinesByDeliveryOrderId(DeliveryOrderid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetVDeliveryOrderLines :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetVDeliveryOrderLines function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrderDocumentsByDeliveryOrderId")]
        public IActionResult GetDeliveryOrderDocumentsByDeliveryOrderId(int DeliveryOrderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrderDocumentsByDeliveryOrderId Process started for DeliveryOrderid " + DeliveryOrderid);
                object obj = _routineMiddleware.CallGetDeliveryOrderDocumentsByDeliveryOrderId(DeliveryOrderid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrderDocumentsByDeliveryOrderId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrderDocumentsByDeliveryOrderId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("PushDeliveryOrders")]
        public IActionResult PushDeliveryOrders(CreateDeliveryOrderModal _details)
        {
            try
            {
                object obj = null;
                responseMessage _response = new responseMessage();
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("PushDeliveryOrders Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContextAdmin);
                SM_ADDRESS _addCompany = _routineMiddleware.CallGetSmAddressByCode(_details.companycode);
                if (_addCompany != null && _addCompany.addr_type.ToLower() == "supplier")
                {
                    LES_COMPANY _company = _adminrtn.CallGetCompanyByAddressID(_addCompany.addressid);
                    if (_company != null)
                    {
                        _details.DeliveryOrderInfo.companyid = _company.companyid;
                        CommonFunction.setLog("Assigning CompanyId '" + _company.companyid + "' from Address Code '" + _details.companycode + "'");
                        obj = _routineMiddleware.CallPushDeliveryOrders(_details);
                    }
                    else
                    {
                        _response.status = "FAIL";
                        _response.isSuccess = false;
                        _response.message = "ERROR : " + "Unable to get Company details from company code :" + _details.companycode;
                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR : " + "Unable to get Company details from company code :" + _details.companycode, "", "", "", "");
                        obj = _response;
                    }
                }
                else
                {
                    _response.status = "FAIL";
                    _response.isSuccess = false;
                    _response.message = "ERROR : " + "Unable to get Company Address details from company code :" + _details.companycode;
                    LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR : " + "Unable to get Company Address details from company code :" + _details.companycode, "", "", "", "");
                    obj = _response;
                }
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on PushDeliveryOrders :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("PushDeliveryOrders function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("CreateDeliveryOrderDocument")]
        public IActionResult CreateDeliveryOrderDocument(Delivery_Order_Documents _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("CreateDeliveryOrderDocument Process started");
                object obj = _routineMiddleware.CallAddDeliveryOrderAttachment(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on CreateDeliveryOrderDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("CreateDeliveryOrderDocument function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("RemoveDeliveryOrderDocument")]
        public IActionResult RemoveDeliveryOrderDocument(Remove_Delivery_Order_Documents _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("RemoveDeliveryOrderDocument Process started");
                object obj = _routineMiddleware.CallRemoveDeliveryOrderAttachment(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on RemoveDeliveryOrderDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("RemoveDeliveryOrderDocument function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("UpdateEpodDeliveryOrderLines")]
        public IActionResult UpdateEpodDeliveryOrderLines(Update_EPOD_DeliveryOrderItems _itemdata)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateEpodDeliveryOrderLines Process started");
                object obj = _routineMiddleware.CallUpdateEpodDeliveryOrderLines(_itemdata);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateEpodDeliveryOrderLines :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UpdateEpodDeliveryOrderLines function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("UpdateAssignShipmentToDeliveryOrder")]
        public IActionResult UpdateAssignShipmentToDeliveryOrder(AssignDeliverOrder _orderdata)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateAssignShipmentToDeliveryOrder Process started");
                object obj = _routineMiddleware.CallUpdateAssignShipmenttoDeliveryOrder(_orderdata);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateAssignShipmentToDeliveryOrder :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UpdateAssignShipmentToDeliveryOrder function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("UpdateUnAssignShipmentToDeliveryOrder")]
        public IActionResult UpdateUnAssignShipmentToDeliveryOrder(AssignDeliverOrder _orderdata)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateUnAssignShipmentToDeliveryOrder Process started");
                object obj = _routineMiddleware.CallUpdateUnAssignShipmenttoDeliveryOrder(_orderdata);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateUnAssignShipmentToDeliveryOrder :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UpdateUnAssignShipmentToDeliveryOrder function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetEPODDDeliveryOrderInfoLinesByDeliveryOrderId")]
        public IActionResult GetEPODDDeliveryOrderInfoLinesByDeliveryOrderId(int deliveryOrderId)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetEPODDDeliveryOrderInfoLinesByDeliveryOrderId Process started");
                object obj = _routineMiddleware.CallGetEPODDeliveryOrderLinesByDeliveryOrderId(deliveryOrderId);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetEPODDDeliveryOrderInfoLinesByDeliveryOrderId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetEPODDDeliveryOrderInfoLinesByDeliveryOrderId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrdersDropDownByCompanyIdandCustomerid")]
        public IActionResult GetDeliveryOrdersDropDownByCompanyIdandCustomerid(int companyid, int customerid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrdersDropDownByCompanyIdandCustomerid Process started");
                object obj = _routineMiddleware.CallGetDeliveryOrdersDropDownByCompanyIdandCustomerid(companyid, customerid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrdersDropDownByCompanyIdandCustomerid :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrdersDropDownByCompanyIdandCustomerid function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrdersDropDownByVerification")]
        public IActionResult GetDeliveryOrdersDropDownByVerification(DeliveryOrdersDropDownVerification modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrdersDropDownByVerification Process started");
                object obj = _routineMiddleware.CallGetDeliveryOrdersDropDownByVerification(modal);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrdersDropDownByVerification :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrdersDropDownByVerification function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("UploadDeliveryOrderDocument")]
        public IActionResult UploadDeliveryOrderDocument(AttachDocumentsDataModal _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UploadDeliveryOrderDocument Process started");
                object obj = _routineMiddleware.CallCreateDeliveryOrderAttachmentDetails(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UploadDeliveryOrderDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UploadDeliveryOrderDocument function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("DownloadDeliveryOrderDocument")]
        public IActionResult DownloadDeliveryOrderDocument(AttachDocumentsDataModal _document)
        {
            object obj = null;
            try
            {
                string FileName = "";
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("DownloadDeliveryOrderDocument Process started");
                responseMessage objData = (responseMessage)_routineMiddleware.CallDownloadDeliveryOrderAttachmentDetails(_document);
                if (objData != null)
                {
                    //string FinalDocPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["DOWNLOAD_PATH"];
                    //if (FinalDocPath != null || FinalDocPath != "")
                    //{
                    //    FinalDocPath = FinalDocPath + @"\\DeliveryOrders\\" + objData.Companyid + "\\" + objData.Document_Name;
                    //    FileName = _webHostEnvironment.WebRootPath + "\\" + FinalDocPath;
                    //}
                    //else
                    //{
                    //    FinalDocPath = @"Download\\DeliveryOrders\\" + objData.Companyid + "\\" + objData.Document_Name;
                    //    FileName = _webHostEnvironment.WebRootPath + "\\" + FinalDocPath;
                    //}
                    //if (!Directory.Exists(Path.GetDirectoryName(FileName)))
                    //    Directory.CreateDirectory(Path.GetDirectoryName(FileName));
                    //byte[] _arr = Convert.FromBase64String(objData.Base64Data);

                    //System.IO.File.WriteAllBytes(FileName, _arr);
                    //if (System.IO.File.Exists(FileName))
                    //{
                    //    FileName = FileName.Replace(_webHostEnvironment.WebRootPath, "");
                    //}
                    //else
                    //{
                    //    FileName = "";
                    //}
                    //if (FileName != null && FileName != "")
                    //{
                    //    string contentType = objData.FileType;
                    //    string downloadName = objData.Document_Name;
                    //    var FileData = System.IO.File.OpenRead(FileName);
                    //    obj = File(FileData, contentType, downloadName);

                    //}
                    //else
                    //{
                    //    obj = new { result = false, msg = "Unable to Download File " + objData.Document_Name, filename = FileName };

                    //}
                    obj = objData.data;
                }
                return Json(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on DownloadDeliveryOrderDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("DownloadDeliveryOrderDocument function stopped successfully.");
            }
        }

        #region Shipment Details
        [HttpPost]
        [Route("GetCustomerInfoListByCompanyId")]
        public IActionResult GetCustomerInfoListByCompanyId(int companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetCustomerInfoList Process started for CompanyID :" + companyid);
                object obj = _routineMiddleware.CallGetAllCustomerDetailsByCompanyId(companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetCustomerInfoList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetCustomerInfoList function stopped successfully.");
            }

        }

        [HttpPost]
        [Route("GetCustomerInfoListByCustomerId")]
        public IActionResult GetCustomerInfoListbyCustomerId(int companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetCustomerInfoList Process started for CompanyID :" + companyid);
                var addrId = _dbContextAdmin.les_company.Where(x => x.companyid == companyid).FirstOrDefault();
                //var custId = _dbContext.lesv_customers.Where(x => x.addressid == addrId.addressid).FirstOrDefault();
                object obj = _routineMiddleware.CallGetAllCustomerDetailsByCustomerId(addrId.addressid);

                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetCustomerInfoListbyCustomerId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetCustomerInfoList function stopped successfully.");
            }

        }

        [HttpPost]
        [Route("GetShipmentInfo")]
        public IActionResult GetShipmentInfo(int Shipmentid, int Companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetShipmentInfo Process started for Shipmentid :" + Shipmentid + " Companyid : " + Companyid);
                object obj = _routineMiddleware.CallGetShipmentDetailsById(Shipmentid, Companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetShipmentInfo :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetShipmentInfo function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetPrintShipmentInfo")]
        public IActionResult GetPrintShipmentInfo(int Shipmentid, int Companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetPrintShipmentInfo Process started for Shipmentid :" + Shipmentid + " Companyid : " + Companyid);
                object obj = _routineMiddleware.CallGetPrintShipmentDetailsById(Shipmentid, Companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetPrintShipmentInfo :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetPrintShipmentInfo function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetVShipmentTripPlan")]
        public IActionResult GetVShipmentTripPlan(int Shipmentid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetVShipmentTripPlan Process started for Shipmentid " + Shipmentid);
                object obj = _routineMiddleware.CallGetVShipmentTripPlanByShipmentId(Shipmentid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetVShipmentTripPlan :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetVShipmentTripPlan function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrderListByShipmentId")]
        public IActionResult GetDeliveryOrderListByShipmentId(int ShipmentId)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrderListByShipmentId Process started for Shipmentid " + ShipmentId);
                object obj = _routineMiddleware.CallGetVShipmentDeliveryOrdersByShipmentId(ShipmentId);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrderListByShipmentId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrderListByShipmentId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetShipmentDocumentByShipmentId")]
        public IActionResult GetShipmentDocumentByShipmentId(int ShipmentId)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetShipmentDocumentByShipmentId Process started for Shipmentid " + ShipmentId);
                object obj = _routineMiddleware.CallGetShipmentDocumentByShipmentId(ShipmentId);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetShipmentDocumentByShipmentId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetShipmentDocumentByShipmentId function stopped successfully.");
            }
        }
        [HttpPost]
        [Route("GetShipmentDOdocumentsByshipmentid")]
        public IActionResult GetShipmentDOdocumentsByshipmentid(int ShipmentId)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetShipmentDOdocumentsByshipmentid Process started for Shipmentid " + ShipmentId);
                object obj = _routineMiddleware.CallGetShipmentDOByShipmentId(ShipmentId);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetShipmentDOdocumentsByshipmentid :" + ex.Message);
                return BadRequest(ex.Message);

            }
            finally
            {
                CommonFunction.setLog("GetShipmentDOdocumentsByshipmentid function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("CreateShipmentDetails")]
        public IActionResult CreateShipmentDetails(CreateShipmentOrderModal shipmentData)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("CreateShipmentDetails Process started");
                object obj = _routineMiddleware.CallCreateOutboundShipment(shipmentData);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on CreateShipmentDetails :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("CreateShipmentDetails function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("UpdateShipmentDetails")]
        public IActionResult UpdateShipmentDetails(UpdateShipmentOrderModal shipmentData)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateShipmentDetails Process started");
                object obj = _routineMiddleware.CallUpdateOutboundShipment(shipmentData);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateShipmentDetails :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UpdateShipmentDetails function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("CreateShipmentDocument")]
        public IActionResult CreateShipmentDocument(Shipment_Documents _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("CreateShipmentDocument Process started");
                object obj = _routineMiddleware.CallAddShipmentAttachment(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on CreateShipmentDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("CreateShipmentDocument function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("RemoveShipmentDocument")]
        public IActionResult RemoveShipmentDocument(Remove_Shipment_Documents _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("RemoveShipmentDocument Process started");
                object obj = _routineMiddleware.CallRemoveShipmentAttachment(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on RemoveShipmentDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("RemoveShipmentDocument function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("UpdateEPODShipmentDetails")]
        public IActionResult UpdateEPODShipmentDetails(EPOD_ShipmentDetails _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("Update EPOD Shipment Details Process started");
                object obj = _routineMiddleware.CallUpdateEPODShipmentDetails(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Update EPOD Shipment Details :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("Update EPOD Shipment Details function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetShipmentDropDownByCompanyId")]
        public IActionResult GetShipmentDropDownByCompanyId(int companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetShipmentDropDownByCompanyId Process started");
                object obj = _routineMiddleware.CallGetShipmentDropDownByCompanyId(companyid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetShipmentDropDownByCompanyId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetShipmentDropDownByCompanyId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetNewShipmentWithDOList")]
        public IActionResult GetNewShipmentWithDOList(deliveryOrderListModal details)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetNewShipmentWithDOList Process started");
                object obj = _routineMiddleware.CallGetNewShipmentWithDOList(details);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetNewShipmentWithDOList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetNewShipmentWithDOList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("UploadShipmentDocument")]
        public IActionResult UploadShipmentDocument(AttachDocumentsDataModal _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UploadShipmentDocument Process started");
                object obj = _routineMiddleware.CallCreateShipmentAttachmentDetails(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UploadShipmentDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UploadShipmentDocument function stopped successfully.");
            }
        }
        [HttpPost]
        [Route("UploadDeliveryOrderDocuments")]
        public IActionResult UploadDeliveryOrderDocuments(IFormFileCollection _documents)
        {
            try
            {
                if (_documents.Count > 0)
                {
                    CommonFunction.setLog("=====================================================");
                    CommonFunction.setLog("UploadDeliveryOrderDocuments Process started");

                    object obj = _routineMiddleware.CallUploadDeliveryOrderDocuments(_documents);
                    //object ListData = _routine.();
                    return Ok(obj);
                }
                else
                {
                    throw new Exception("No file selected!");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UploadDeliveryOrderDocuments :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("UploadInternalOrderDeliveryOrder")]
        public IActionResult UploadInternalOrderDeliveryOrder(AttachDocumentsDataModal _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UploadInboundShipmentDeliveryOrder Process started");
                object obj = _routineMiddleware.CallCreateInternalOrderShipmentDocument(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UploadInboundShipmentDeliveryOrder :" + ex.Message);
                return BadRequest(ex.Message);

            }
            finally
            {
                CommonFunction.setLog("UploadInboundShipmentDeliveryOrder function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("DownloadShipmentDocument")]
        public IActionResult DownloadShipmentDocument(AttachDocumentsDataModal _document)
        {
            object obj = null;
            try
            {
                string FileName = "";
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("DownloadShipmentDocument Process started");
                responseMessage objFile = (responseMessage)_routineMiddleware.CallDownloadShipmentAttachmentDetails(_document);
                if (objFile != null /*&& typeof(objData) == AttachDocumentsDataModal*/)
                {
                    //               string FinalDocPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["DOWNLOAD_PATH"];
                    //AttachDocumentsDataModal objData = (AttachDocumentsDataModal)objFile.data;
                    //if (FinalDocPath != null || FinalDocPath != "")
                    //               {
                    //                   FinalDocPath = FinalDocPath + @"\\Shipment\\" + objData.Companyid + "\\" + objData.Document_Name;
                    //                   FileName = _webHostEnvironment.WebRootPath + "\\" + FinalDocPath;
                    //               }
                    //               else
                    //               {
                    //                   FinalDocPath = @"Download\\Shipment\\" + objData.Companyid + "\\" + objData.Document_Name;
                    //                   FileName = _webHostEnvironment.WebRootPath + "\\" + FinalDocPath;
                    //               }
                    //               if (!Directory.Exists(Path.GetDirectoryName(FileName)))
                    //                   Directory.CreateDirectory(Path.GetDirectoryName(FileName));
                    //               byte[] _arr = Convert.FromBase64String(objData.Base64Data);

                    //               System.IO.File.WriteAllBytes(FileName, _arr);
                    //               if (System.IO.File.Exists(FileName))
                    //               {
                    //                   FileName = FileName.Replace(_webHostEnvironment.WebRootPath, "");
                    //               }
                    //               else
                    //               {
                    //                   FileName = "";
                    //               }
                    //               if (FileName != null && FileName != "")
                    //               {
                    //                   string contentType = objData.FileType;
                    //                   string downloadName = objData.Document_Name;
                    //                   var FileData = System.IO.File.OpenRead(FileName);
                    //                   obj =  File(FileData, contentType, downloadName);
                    //               }
                    //               else
                    //               {
                    //                   obj = new { result = false, msg = "Unable to Download File " + objData.Document_Name, filename = FileName };
                    //               }
                    obj = objFile.data;
                }
                return Json(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on DownloadShipmentDocument :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("DownloadShipmentDocument function stopped successfully.");
            }
        }
        [HttpPost]
        [Route("DownloadInboundDOAttachment")]
        public IActionResult DownloadInboundDOAttachment(AttachDocumentsDataModal _document)
        {
            object obj = null;
            try
            {
                string FileName = "";
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("DownloadInboundDOAttachment Process started");
                responseMessage objFile = (responseMessage)_routineMiddleware.CallDownloadShipmentDOattchament(_document);
                if (objFile != null /*&& typeof(objData) == AttachDocumentsDataModal*/)
                {
                    //               string FinalDocPath = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("AppSettings")["DOWNLOAD_PATH"];
                    //AttachDocumentsDataModal objData = (AttachDocumentsDataModal)objFile.data;
                    //if (FinalDocPath != null || FinalDocPath != "")
                    //               {
                    //                   FinalDocPath = FinalDocPath + @"\\Shipment\\" + objData.Companyid + "\\" + objData.Document_Name;
                    //                   FileName = _webHostEnvironment.WebRootPath + "\\" + FinalDocPath;
                    //               }
                    //               else
                    //               {
                    //                   FinalDocPath = @"Download\\Shipment\\" + objData.Companyid + "\\" + objData.Document_Name;
                    //                   FileName = _webHostEnvironment.WebRootPath + "\\" + FinalDocPath;
                    //               }
                    //               if (!Directory.Exists(Path.GetDirectoryName(FileName)))
                    //                   Directory.CreateDirectory(Path.GetDirectoryName(FileName));
                    //               byte[] _arr = Convert.FromBase64String(objData.Base64Data);

                    //               System.IO.File.WriteAllBytes(FileName, _arr);
                    //               if (System.IO.File.Exists(FileName))
                    //               {
                    //                   FileName = FileName.Replace(_webHostEnvironment.WebRootPath, "");
                    //               }
                    //               else
                    //               {
                    //                   FileName = "";
                    //               }
                    //               if (FileName != null && FileName != "")
                    //               {
                    //                   string contentType = objData.FileType;
                    //                   string downloadName = objData.Document_Name;
                    //                   var FileData = System.IO.File.OpenRead(FileName);
                    //                   obj =  File(FileData, contentType, downloadName);
                    //               }
                    //               else
                    //               {
                    //                   obj = new { result = false, msg = "Unable to Download File " + objData.Document_Name, filename = FileName };
                    //               }
                    obj = objFile.data;
                }
                return Json(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on DownloadInboundDOAttachment :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("DownloadInboundDOAttachment function stopped successfully.");
            }
        }
        #endregion Shipment Details
        #endregion Outbound and Delivery order


        #region Inbound Shipment 
        [HttpPost]
        [Route("GetInboundShipmentListByCompanyId")]
        public async Task<IActionResult> GetInboundShipmentListByCompanyId([FromBody] FilterInboundShipment modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInboundShipmentListByCompanyId process started");

                // Assuming CallGetInboundShipmentListByCompanyId is an async method
                object obj = await _routineMiddleware.CallGetInboundShipmentListByCompanyIdAsync(modal);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInboundShipmentListByCompanyId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetInboundShipmentListByCompanyId function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetInboundShipmentListByCustomerId")]
        public async Task<IActionResult> GetInboundShipmentListByCustomeridAsync(FilterInboundShipment modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInboundShipmentListByCustomerid process started");
                CommonFunction.setLog("GetInboundShipmentListByCustomerid DATA : " + getSerializeData(modal));

                object obj = await _routineMiddleware.CallGetInboundShipmentListByCustomerid(modal);

                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInboundShipmentListByCustomerid :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetInboundShipmentListByCustomerid function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetInboundShipmentDetails")]
        public IActionResult GetInboundShipmentDetails(int inboundshipmentid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInboundShipmentDetails Process started for Shipmentid " + inboundshipmentid);
                object obj = _routineMiddleware.GetInboundShipmentDetailsByShipmnentId(inboundshipmentid);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInboundShipmentDetails :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("GetLinkedPurchaseOrder")]
        public IActionResult GetLinkedPurchaseOrder(int inboundshipmentid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetLinkedPurchaseOrder Process started for Shipmentid " + inboundshipmentid);
                object obj = _routineMiddleware.GetLinkedPurchaseOrderbyShipmentid(inboundshipmentid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetLinkedPurchaseOrder :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("GetLinkedPurchaseOrderEsupplier")]
        public IActionResult GetLinkedPurchaseOrderEsupplier(int quotationid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetLinkedPurchaseOrderEsupplier Process started for quotation " + quotationid);
                object obj = _routineMiddleware.GetInternalOrderDetailsEsupplier(quotationid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetLinkedPurchaseOrder :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("InsertPOfromEsupplierTologiLink")]
        public IActionResult InsertPOfromEsupplierTologiLink(int quotationid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("InsertPOfromEsupplierTologiLink Process started for quotation  " + quotationid);
                object obj = _routineMiddleware.getinsertEsupplierPotoLogiLink(quotationid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on InsertPOfromEsupplierTologiLink :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("GetInternalOrderLines")]
        public IActionResult GetInternalOrderLines(int InternalOrderId)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInternalOrderLines Process started for internal order id  " + InternalOrderId);
                object obj = _routineMiddleware.GetInternalOrderLinesbyPOid(InternalOrderId);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInternalOrderLines :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("GetInternalOrderLineseSupplier")]
        public IActionResult GetInternalOrderLineseSupplier(int quotationid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInternalOrderLineseSupplier Process started for internal order id  " + quotationid);
                object obj = _routineMiddleware.GetInternalOrderLineseSupplier(quotationid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInternalOrderLineseSupplier :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("GetInboundShipmentDetailsESupplier")]
        public IActionResult GetInboundShipmentDetailsESupplier(int quotationid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInboundShipmentDetailsESupplier Process started for quotation id  " + quotationid);
                object obj = _routineMiddleware.GetinboundShipmentdetailsEsupplier(quotationid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInboundShipmentDetailsESupplier :" + ex.Message);
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        [Route("LoadVRemainingInternalOrderLines")]
        public IActionResult LoadVRemainingInternalOrderLines(int internalorderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("LoadVRemainingInternalOrderLines Process started for internal order id  " + internalorderid);
                object obj = _routineMiddleware.getvremaininginternalOrders(internalorderid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on LoadVRemainingInternalOrderLines :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetInboundShipmentByquotationId")]
        public IActionResult GetInboundShipmentByquotationId(int quotationid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetInboundShipmentByquotationId Process started for Quotationid  " + quotationid);
                object obj = _routineMiddleware.GetInboundShipmentByquotation(quotationid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetInboundShipmentByquotationId :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("AssignPOlinesToDO")]
        public IActionResult AssignPOlinesToDO(AssignDoToPO_Inbound modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AssignPOlinesToDO Process started! ");
                object obj = _routineMiddleware.AssignPOLinesToDo(modal);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on AssignPOlinesToDO :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("GetDeliveryOrdersByInternalOrderId")]
        public IActionResult GetDeliveryOrdersByInternalOrderId(int internalorderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("LoadVRemainingInternalOrderLines Process started for internal order id  " + internalorderid);
                object obj = _routineMiddleware.GetDeliveryOrdersByInternalOrderId(internalorderid);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on LoadVRemainingInternalOrderLines :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("UnAssignPOToDeliveryOrder")]
        public IActionResult UnAssignPOToDeliveryOrder(int deliveryorderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UnAssignPOToDeliveryOrder Process started");
                object obj = _routineMiddleware.CallUnAssignPOToDeliveryOrder(deliveryorderid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UnAssignPOToDeliveryOrder :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UnAssignPOToDeliveryOrder function stopped successfully.");
            }
        }
        [HttpGet]
        [Route("GetRemainingPOlinesCount")]
        public IActionResult GetRemainingPOlinesCount(int internalorderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetRemainingPOlinesCount Process started");
                object obj = _routineMiddleware.CallGetRemainingPOlines(internalorderid);
                return Ok(obj);

            }
            catch(Exception ex)
            {
                CommonFunction.setLog("Error on GetRemainingPOlinesCount :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetRemainingPOlinesCount function stopped successfully.");
            }
        }
        [HttpGet]
        [Route("GetRemainingPOlinesCountbyInboundId")]
        public IActionResult GetRemainingPOlinesCountbyInboundId(int inboundshipmentid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetRemainingPOlinesCountbyInboundId Process started");
                object obj = _routineMiddleware.CallGetRemainingPOlinesbyInboundId(inboundshipmentid);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetRemainingPOlinesCount :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetRemainingPOlinesCount function stopped successfully.");
            }
        }
        [HttpGet]
        [Route("GetDeliveryOrderCount")]
        public IActionResult GetDeliveryOrderCount(int internalorderid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrderCount Process started");
                object obj = _routineMiddleware.CallGetDeliveryOrderCount(internalorderid);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrderCount :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrderCount function stopped successfully.");
            }
        }
        [HttpGet]
        [Route("GetDeliveryOrderCountbyInboundId")]
        public IActionResult GetDeliveryOrderCountbyInboundId(int inboundshipmentid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetDeliveryOrderCountbyInboundId Process started");
                object obj = _routineMiddleware.CallGetDeliveryOrderCountbyInboundId(inboundshipmentid);
                return Ok(obj);

            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetDeliveryOrderCountbyInboundId :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetDeliveryOrderCountbyInboundId function stopped successfully.");
            }
        }
        [HttpPost]
        [Route("ReleaseDeliveryOrder")]
        public IActionResult ReleaseDeliveryOrder(ReleasedData data)
        {
            try
            {

                //var data = getDeserializeData(modalData, typeof(ReleasedData)) as ReleasedData;

                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("ReleaseDeliveryOrder Process started");
                object obj = _routineMiddleware.CallReleaseDeliveryOrder(data);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on ReleaseDeliveryOrder :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("ReleaseDeliveryOrder function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("ReleaseInboundShipment")]
        public IActionResult ReleaseInboundShipment(AssignDoToPO_Inbound modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AssignPOlinesToDO Process started! ");
                object obj = _routineMiddleware.ReleasePODO(modal);
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on AssignPOlinesToDO :" + ex.Message);
                return BadRequest(ex.Message);
            }
        }
        #endregion Inbound Shipment

        #region MAST_ANCHORAGE

        [HttpPost]
        [Route("GetAnchorageList")]
        public IActionResult GetAnchorageList()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetAnchorageList Process started");
                object obj = _routineMiddleware.CallGetAllAnchorage();
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetAnchorageList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("AddAnchorage")]
        public IActionResult AddAnchorage(Mast_Anchorage _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AddAnchorage Process started");
                CommonFunction.setLog("Mast_Anchorage DATA : " + getSerializeData(_details));
                if (_details.AnchorageDescription != "" && _details.AnchorageCode != "")
                {
                    List<Mast_Anchorage> _lstAnchorage = (List<Mast_Anchorage>)_routineMiddleware.CallGetAllAnchorage();
                    if ((_lstAnchorage.FirstOrDefault(x => x.AnchorageCode == _details.AnchorageCode)) != null)
                    {
                        throw new Exception("Anchorage Code '" + _details.AnchorageCode + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallAddAnchorage(_details);
                        //object ListData = _routine.();
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Anchorage added successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Anchorage '" + _details.AnchorageCode + "' added successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("Anchorage details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on AddAnchorage :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on AddAnchorage :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on AddAnchorage: " + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("AddAnchorage function stopped successfully.");
            }
            return Ok(obj);
        }

        [HttpPost]
        [Route("UpdateAnchorage")]
        public IActionResult UpdateAnchorage(Update_Anchorage _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateAnchorage Process started");
                CommonFunction.setLog("Update_Anchorage DATA : " + getSerializeData(_details));
                if (_details.AnchorageDescription != "" && _details.AnchorageCode != "")
                {
                    List<Mast_Anchorage> _lstAnchorage = (List<Mast_Anchorage>)_routineMiddleware.CallGetAllAnchorage();
                    if ((_lstAnchorage.FirstOrDefault(x => x.AnchorageCode == _details.AnchorageCode && x.AnchorageId != _details.AnchorageId)) != null)
                    {
                        throw new Exception("Anchorage Code '" + _details.AnchorageCode + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallUpdateAnchorage(_details);
                        //object ListData = _routine.();
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Anchorage Updated successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Anchorage '" + _details.AnchorageCode + "' Updated successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("Anchorage details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateAnchorage :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on UpdateAnchorage :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on UpdateAnchorage :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("UpdateAnchorage function stopped successfully.");
            }
            return Ok(obj);
        }

        #endregion

        #region MAST_GOODS_RETURN_REASONS

        [HttpPost]
        [Route("GetGoodsReturnReasonsList")]
        public IActionResult GetGoodsReturnReasonsList()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetGoodsReturnReasonsList Process started");
                object obj = _routineMiddleware.CallGetAllGoodsReturnReasons();
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetGoodsReturnReasonsList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetGoodsReturnReasonsList function stopped successfully.");
            }

        }

        [HttpPost]
        [Route("AddGoodsReturnReasons")]
        public IActionResult AddGoodsReturnReasons(Mast_Goods_Return_Reasons _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AddGoodsReturnReasons Process started");
                if (_details.GrnReasonCode != "" && _details.GrnReasonDescription != "")
                {
                    List<Mast_Goods_Return_Reasons> List = (List<Mast_Goods_Return_Reasons>)_routineMiddleware.CallGetAllGoodsReturnReasons();
                    if ((List.FirstOrDefault(x => x.GrnReasonCode == _details.GrnReasonCode)) != null)
                    {
                        throw new Exception("Grn Reason Code '" + _details.GrnReasonCode + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallAddGoodsReturnReasons(_details);
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Goods Return Reasons '" + _details.GrnReasonCode + "' Added successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Goods Return Reasons '" + _details.GrnReasonCode + "' Added successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("GoodsReturnReasons details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on AddGoodsReturnReasons :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on AddGoodsReturnReasons :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on AddGoodsReturnReasons :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("AddGoodsReturnReasons function stopped successfully.");
            }
            return Ok(obj);
        }

        [HttpPost]
        [Route("UpdateGoodsReturnReasons")]
        public IActionResult UpdateGoodsReturnReasons(Update_Goods_Return_Reasons _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateGoodsReturnReasons Process started");
                if (_details.GrnReasonCode != "" && _details.GrnReasonDescription != "")
                {
                    List<Mast_Goods_Return_Reasons> List = (List<Mast_Goods_Return_Reasons>)_routineMiddleware.CallGetAllGoodsReturnReasons();
                    if ((List.FirstOrDefault(x => x.GrnReasonCode == _details.GrnReasonCode && x.GrnReasonId != _details.GrnReasonId)) != null)
                    {
                        throw new Exception("Grn Reason Code '" + _details.GrnReasonCode + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallUpdateGoodsReturnReasons(_details);
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Goods Return Reasons Updated successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Goods Return Reasons '" + _details.GrnReasonCode + "' Updated successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("GoodsReturnReasons details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateGoodsReturnReasons :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on UpdateGoodsReturnReasons :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on UpdateGoodsReturnReasons :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("UpdateGoodsReturnReasons function stopped successfully.");
            }
            return Ok(obj);
        }

        #endregion

        #region MAST_TRANSPORT_TYPE

        [HttpPost]
        [Route("GetTransportTypeList")]
        public IActionResult GetTransportTypeList()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetTransportTypeList Process started");
                object obj = _routineMiddleware.CallGetAllTransportType();
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetGoodsReturnReasonsList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetTransportTypeList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("AddTransportType")]
        public IActionResult AddTransportType(MAST_TRANSPORT_TYPE _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AddTransportType Process started");
                if (_details.transport_type_code != "" && _details.transport_type_description != "")
                {
                    List<MAST_TRANSPORT_TYPE> List = (List<MAST_TRANSPORT_TYPE>)_routineMiddleware.CallGetAllTransportType();
                    if ((List.FirstOrDefault(x => x.transport_type_code == _details.transport_type_code)) != null)
                    {
                        throw new Exception("Transport type Code '" + _details.transport_type_code + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallAddTransportType(_details);
                        //object ListData = _routine.();
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Transport Type '" + _details.transport_type_code + "' Updated successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Transport Type '" + _details.transport_type_code + "' added successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("TransportType details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on AddTransportType :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on Add Transport Type :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on Add Transport Type :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("AddTransportType function stopped successfully.");
            }
            return Ok(obj);
        }

        [HttpPost]
        [Route("UpdateTransportType")]
        public IActionResult UpdateTransportType(Update_Transport_Type _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateTransportType Process started");

                if (_details.transport_type_code != "" && _details.transport_type_description != "")
                {
                    List<MAST_TRANSPORT_TYPE> List = (List<MAST_TRANSPORT_TYPE>)_routineMiddleware.CallGetAllTransportType();
                    if ((List.FirstOrDefault(x => x.transport_type_code == _details.transport_type_code && x.transport_type_id != _details.transport_type_id)) != null)
                    {
                        throw new Exception("TransportType Code '" + _details.transport_type_code + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallUpdateTransportType(_details);
                        //object ListData = _routine.();
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Transport Type Updated successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Transport Type '" + _details.transport_type_code + "' Updated successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("TransportType details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateTransportType :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on Update Transport Type :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on Update Transport Type :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("UpdateTransportType function stopped successfully.");
            }
            return Ok(obj);
        }

        #endregion

        #region MASTER_VESSEL

        [HttpPost]
        [Route("GetVesselList")]
        public IActionResult GetVesselList()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetVesselList Process started");

                object obj = _routineMiddleware.CallGetAllVessels();
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetVesselList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("AddVessels")]
        public IActionResult AddVessels(Mast_Vessel _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AddVessels Process started");

                if (_details.VesselCode != "" && _details.VesselName != "")
                {
                    List<Mast_Vessel> List = (List<Mast_Vessel>)_routineMiddleware.CallGetAllVessels();
                    if ((List.FirstOrDefault(x => x.VesselCode == _details.VesselCode)) != null)
                    {
                        throw new Exception("Vessel Code '" + _details.VesselCode + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallAddVessels(_details);
                        //object ListData = _routine.();
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Vessel Code '" + _details.VesselCode + "' Updated successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Vessel Code '" + _details.VesselCode + "' added successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("Vessels details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on AddVessels :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on Add Vessels :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on Add Vessels :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("AddVessels function stopped successfully.");
            }
            return Ok(obj);
        }

        [HttpPost]
        [Route("UpdateVessels")]
        public IActionResult UpdateVessels(Update_Vessels _details)
        {
            responseMessage obj = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateVessels Process started");


                if (_details.VesselCode != "" && _details.VesselName != "")
                {
                    List<Mast_Vessel> List = (List<Mast_Vessel>)_routineMiddleware.CallGetAllVessels();
                    if ((List.FirstOrDefault(x => x.VesselCode == _details.VesselCode && x.VesselId != _details.VesselId)) != null)
                    {
                        throw new Exception("Vessel Code '" + _details.VesselCode + "' already present.");
                    }
                    else
                    {
                        object val = _routineMiddleware.CallUpdateVessels(_details);
                        //object ListData = _routine.();
                        if (convert.ToInt(val) > 0)
                        {
                            obj.status = "SUCCESS";
                            obj.isSuccess = true;
                            obj.message = "Vessel Updated successfully.";
                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "vessel code '" + _details.VesselCode + "' Updated successfully.", "", "", "", "");
                        }
                    }
                }
                else
                {
                    throw new Exception("TransportType details are invalid.");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateTransportType :" + ex.Message);
                obj.status = "FAIL";
                obj.isSuccess = false;
                obj.message = "Error on Update Transport Type :" + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error on Update Transport Type :" + ex.Message, "", "", "", "");
            }
            finally
            {
                CommonFunction.setLog("UpdateTransportType function stopped successfully.");
            }
            return Ok(obj);
        }

        #endregion

        #region CUSTOMER

        [HttpPost]
        [Route("GetCustomerListDetailsByCompanyId")]
        public IActionResult CallGetCustomerListDetailsByCompanyId(int companyid)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetCustomerListDetailsByCompanyId Process started");
                object obj = _routineMiddleware.CallGetCustomerListDetailsByCompanyId(companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetCustomerListDetailsByCompanyId function stopped successfully.");
            }
        }

        #endregion

        #region EPOD

        [HttpPost]
        [Route("GenerateQRCode")]
        public IActionResult GenerateQRCode(QRModal contentData)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GenerateQRCode Process started");
                CommonFunction.setLog("GenerateQRCode DATA : " + getSerializeData(contentData));
                object obj = _routineMiddleware.CallGenerateQRCode(contentData);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GenerateQRCode :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GenerateQRCode function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetVesselAuthenticationCrew")]
        public IActionResult GetVesselAuthenticationCrew(VesselAuthenticationParameter _paramVal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetVesselAuthenticationCrew Process started");
                string strValue = getSerializeData(_paramVal);

                CommonFunction.setLog("VesselAuthenticationParameter DATA : " + strValue);
                VesselAuthenticationModalViews _vslAuth = new VesselAuthenticationModalViews();
                UserAdminClass _adminrtn = new UserAdminClass(_dbContextAdmin);

                Logistic_Management_Lib.Model.Shipment _shipmentData = (Logistic_Management_Lib.Model.Shipment)_routineMiddleware.CallGetShipmentByShipmentid(_paramVal.shipmentid);
                if (_shipmentData != null)
                {
                    V_Shipment_Info _shipmentDetails = (V_Shipment_Info)_routineMiddleware.CallGetShipmentDetailsById(_paramVal.shipmentid, convert.ToInt(_shipmentData.CompanyId));
                    if (_shipmentDetails != null && (_shipmentDetails.shipment_statusid == convert.ToInt(Status.READYTOSHIP) || _shipmentDetails.shipment_statusid == convert.ToInt(Status.SHIPPED) || _shipmentDetails.shipment_statusid == convert.ToInt(Status.VERIFICATION) || _shipmentDetails.shipment_statusid == convert.ToInt(Status.COMPLETED)))
                    {
                        List<V_COMPANY_DETAILS_DATA> _lstUserCompany = new List<V_COMPANY_DETAILS_DATA>();

                        if (convert.ToInt(_paramVal.userid) > 0)
                        {
                            _lstUserCompany = (List<V_COMPANY_DETAILS_DATA>)_adminrtn.CallGetusercompanylinkByUserId(convert.ToInt(_shipmentDetails.companyid), convert.ToInt(_paramVal.userid));
                        }
                        else
                        {
                            _lstUserCompany = (List<V_COMPANY_DETAILS_DATA>)_adminrtn.CallDefaultVesselusercompanylinkByCompanyid(convert.ToInt(_shipmentDetails.companyid));  // getting Vessel UserType Company details by companyid

                        }
                        if (_lstUserCompany.Count() > 0)
                        {
                            V_COMPANY_DETAILS_DATA CompanyData = _lstUserCompany.FirstOrDefault(x => x.CompanyId == _shipmentDetails.companyid);
                            if (CompanyData != null)
                            {
                                CompanyData.CustomerId = GetCustomerIdFromCompanyId(convert.ToInt(CompanyData.CompanyId));
                                if (_paramVal.latitude != "" && _paramVal.longitude != "")
                                {
                                    if (_paramVal.useremailid != "" && _paramVal.crewname != "" && _paramVal.vesselimo != "" && _paramVal.role != "")
                                    {
                                        List<LES_USER_ADMINISTRATION_LIB.Model.V_APPLICATION_MODULE_ACCESS> slUserAccess = null;
                                        bool CheckLoginMail = _routineMiddleware.CallCheckEpodAccessLogs(_paramVal.shipmentid, _paramVal.useremailid);

                                        slUserAccess = (List<LES_USER_ADMINISTRATION_LIB.Model.V_APPLICATION_MODULE_ACCESS>)_adminrtn.CallGetVApplicationModuleAccessBycompanyandUseridForEpod(convert.ToInt(_shipmentDetails.companyid), convert.ToInt(_paramVal.userid));
                                        if (slUserAccess == null || slUserAccess.Count == 0)
                                        {
                                            slUserAccess = new();
                                            if (convert.ToInt(_paramVal.userid) > 0)
                                            {
                                                //No Access
                                            }
                                            else
                                            {
                                                var obj = (LES_USER_ADMINISTRATION_LIB.Model.V_APPLICATION_MODULE_ACCESS)_adminrtn.CallGetDefaultVApplicationModuleAccessBycompanyandUsertypeidandUseridForEpod(convert.ToInt(_shipmentDetails.companyid), convert.ToInt(CompanyData.UserTypeId));
                                                slUserAccess.Add(obj);
                                            }
                                        }
                                        if (_routineMiddleware.CallAddEpodAccessLogs(_shipmentDetails.shipmentid, convert.ToInt(_paramVal.userid), _paramVal.useremailid.ToLower(), _paramVal.latitude, _paramVal.longitude, _paramVal.crewname.ToUpper(), _paramVal.vesselimo, _paramVal.role.ToUpper()))
                                        {
                                            CommonFunction.setLog("EPOD Access log set successfully for User Email : " + _paramVal.useremailid);
                                            _vslAuth.userid = convert.ToInt(_paramVal.userid);
                                            _vslAuth.username = convert.ToString(_paramVal.crewname);
                                            //_vslAuth.UserCode = convert.ToString(_userdetails.ex_usercode);
                                            _vslAuth.useremailid = convert.ToString(_paramVal.useremailid);
                                            _vslAuth.defaultcompanyid = convert.ToString(CompanyData.CompanyId);
                                            _vslAuth.crewname = convert.ToString(_paramVal.crewname);
                                            _vslAuth.role = convert.ToString(_paramVal.role);
                                            _vslAuth.vesselimo = convert.ToString(_paramVal.vesselimo);
                                            _vslAuth.shipmentid = convert.ToInt(_paramVal.shipmentid);

                                            _vslAuth.les_company_details = CompanyData;
                                            _vslAuth.shipmentInfo = _shipmentDetails;
                                            _vslAuth.list_Application_Module_Access = slUserAccess;
                                            if (!CheckLoginMail)
                                            {
                                                strValue = HttpUtility.UrlEncode(strValue);
                                                if (strValue.Contains("."))
                                                {
                                                    strValue = strValue.Replace(".", "%2E");
                                                }
                                                string encriptData = Logistic_Management_Lib.GlobalTools.EncodePassword(strValue);
                                                if (encriptData != "")
                                                {
                                                    string mailpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("SEND_MAIL_PATH").Value);
                                                    string BccMail = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("BCC_MAIL").Value);
                                                    string CCMail = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("CC_MAIL").Value);
                                                    string loginPortalUrl = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("EPOD_LOGIN_PORTAL_URL").Value);
                                                    string EpodLoginTemplate = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("EPOD_LOGIN_TEMPLATE").Value);

                                                    if (System.IO.File.Exists(EpodLoginTemplate))
                                                    {
                                                        string htmlData = System.IO.File.ReadAllText(EpodLoginTemplate);
                                                        string base64Str = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(encriptData));
                                                        loginPortalUrl = loginPortalUrl + "?shipmentdata=" + HttpUtility.UrlEncode(base64Str);

                                                        htmlData = htmlData.Replace("#SHIPMENT_NO#", convert.ToString(_shipmentData.OrderNo)).Replace("#VESSEL_NAME#", convert.ToString(_shipmentDetails.vessel_name)).Replace("#COMPANY_NAME#", convert.ToString(CompanyData.Company_Description)).Replace("#CUSTOMER_NAME#", convert.ToString(_shipmentDetails.cust_name)).Replace("#LINK#", convert.ToString(loginPortalUrl));
                                                        LeSDataMain.LeSDM.SendMailQueueFile("", "EPOD_SHIPMENT_LOGIN", _shipmentData.OrderNo, _shipmentDetails.vessel_name, "Login", _paramVal.useremailid, "", CCMail, BccMail, CompanyData.Company_Description, _shipmentDetails.cust_name, htmlData, mailpath, "1", "Shipment for REF : " + _shipmentData.OrderNo + " VESSEL : " + _shipmentDetails.vessel_name + " received From : " + CompanyData.Company_Description + " To : " + CompanyData.Company_Description);
                                                        CommonFunction.setLog("Login Mail send successfully to Email-Id " + _paramVal.useremailid + " with Email Link " + loginPortalUrl);
                                                    }
                                                    else
                                                    {
                                                        CommonFunction.setLog("Unable to get Mail Template");
                                                    }
                                                }
                                                else
                                                {
                                                    CommonFunction.setLog("Unable to send mail");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to set Access log for User Email : " + _paramVal.useremailid);
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to set Access log for User Email : " + _paramVal.useremailid);
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get User Location details");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to find company details");
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get company List");
                        }
                    }
                    else
                    {
                        if (_shipmentDetails == null)
                        {
                            throw new Exception("Shipment details is Invalid");
                        }
                        else if (_shipmentDetails.shipment_statusid == convert.ToInt(Status.COMPLETED))
                        {
                            throw new Exception("Shipment details is COMPLETED");
                        }
                        else if (_shipmentDetails.shipment_statusid == convert.ToInt(Status.CANCELLED))
                        {
                            throw new Exception("Shipment details is CANCELLED");
                        }
                        else
                        {
                            throw new Exception("Shipment details is in Invalid Status");
                        }
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipment Info.");
                }
                return Ok(_vslAuth);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetVesselAuthenticationCrew :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetVesselAuthenticationCrew function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("EpodLoginByVesselAuthenticationCrewEncryptData")]
        public IActionResult EpodLoginByVesselAuthenticationCrewEncryptData(VesselAuthenticationUrlParameter Data)
        {
            object _vslAuth = null;
            responseMessage _response = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("EpodLoginByVesselAuthenticationCrewEncryptData Process started");
                string strValue = getSerializeData(Data);

                CommonFunction.setLog("VesselAuthenticationUrlParameter DATA : " + strValue);
                if (Data.EncryptData != "" && Data.latitude != "" && Data.longitude != "")
                {
                    byte[] arrData = null;

                    arrData = Convert.FromBase64String(HttpUtility.UrlDecode(Data.EncryptData));
                    string normalString = System.Text.Encoding.UTF8.GetString(arrData);
                    string decodedString = Logistic_Management_Lib.GlobalTools.DecodePassword(normalString);
                    decodedString = HttpUtility.UrlDecode(decodedString);
                    if (decodedString.Contains("%2E")) decodedString = decodedString.Replace("%2E", ".");
                    object _objData = getDeserializeData(decodedString.ToLower(), typeof(VesselAuthenticationParameter));
                    if (_objData != null && _objData.GetType() == typeof(VesselAuthenticationParameter))
                    {
                        VesselAuthenticationParameter _paramVal = (VesselAuthenticationParameter)_objData;
                        _paramVal.latitude = Data.latitude;
                        _paramVal.longitude = Data.longitude;
                        _paramVal.crewname = _paramVal.crewname.ToUpper();
                        _paramVal.role = _paramVal.role.ToUpper();
                        _vslAuth = GetVesselAuthenticationCrew(_paramVal);

                    }
                    else
                    {
                        throw new Exception("Unable to get proper values.");
                    }
                    return Ok(_vslAuth);
                }
                else
                {
                    throw new Exception("Invalid data");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on EpodLoginByVesselAuthenticationCrewEncryptData : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("EpodLoginByVesselAuthenticationCrewEncryptData Process stopped");
            }
        }
        [HttpPost]
        [Route("GetVerifiedDOList")]
        public IActionResult GetVerifiedDOList(ShipmentData shipmentData)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetVerifiedDOList Process started for shipmentid:" + shipmentData.shipmentid + " and companyid :" + shipmentData.companyid);
                object obj = _routineMiddleware.CallGetVerifiedDOList(shipmentData.shipmentid, shipmentData.companyid);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetVerifiedDOList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("CreateEncodeOfficeEPODUrl")]
        public IActionResult CreateEncodeOfficeEPODUrl(VesselAuthenticationParameter Data)
        {
            object _vslAuth = null;
            responseMessage _response = new responseMessage();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("CreateEncodeOfficeEPODUrl Process started");
                string strValue = getSerializeData(Data);

                CommonFunction.setLog("VesselAuthenticationParameter DATA : " + strValue);
                if (convert.ToInt(Data.userid) > 0 && Data.useremailid != "" && Data.role != "")
                {
                    strValue = HttpUtility.UrlEncode(strValue);
                    if (strValue.Contains("."))
                    {
                        strValue = strValue.Replace(".", "%2E");
                    }
                    string encriptData = Logistic_Management_Lib.GlobalTools.EncodePassword(strValue);
                    if (encriptData != "")
                    {
                        string loginPortalUrl = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("EPOD_LOGIN_PORTAL_URL").Value);
                        string base64Str = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(encriptData));
                        _vslAuth = loginPortalUrl + "?shipmentdata=" + HttpUtility.UrlEncode(base64Str);
                        CommonFunction.setLog("URL DATA : " + _vslAuth);
                    }
                }
                else
                {
                    throw new Exception("Invalid data");
                }
                return Ok(_vslAuth);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on CreateEncodeOfficeEPODUrl : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("CreateEncodeOfficeEPODUrl Process stopped");
            }


        }

        [HttpPost]
        [Route("GetCompanyDetails")]
        public IActionResult GetCompanyDetails(int companyid)
        {
            COMPANY_INFO_DATA _CompData = new COMPANY_INFO_DATA();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetCompanyDetails Process started for company id " + companyid);
                UserAdminClass _adminrtn = new UserAdminClass(_dbContextAdmin);
                List<V_COMPANY_DETAILS_DATA> _lstUserCompany = (List<V_COMPANY_DETAILS_DATA>)_adminrtn.CallGetusercompanylinkByCompanyid(convert.ToInt(companyid));
                if (_lstUserCompany.Count > 0)
                {
                    V_COMPANY_DETAILS_DATA _data = _lstUserCompany.FirstOrDefault();
                    if (_data != null && _data.AddressId > 0)
                    {
                        _CompData = GetCompanyAddressDetails(_data);
                    }
                }
                return Ok(_CompData);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetCompanyDetails :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetCompanyDetails function stopped successfully.");
            }
        }
        private COMPANY_INFO_DATA GetCompanyAddressDetails(V_COMPANY_DETAILS_DATA _data)
        {
            COMPANY_INFO_DATA _CompData = new COMPANY_INFO_DATA();
            SM_ADDRESS _address = (SM_ADDRESS)_routineMiddleware.CallSmAddressById(convert.ToInt(_data.AddressId));
            if (_address != null)
            {
                _CompData.CompanyId = _data.CompanyId;
                _CompData.Company_Code = _data.Company_Code;
                _CompData.Company_Description = _data.Company_Description;
                _CompData.AddressId = _data.AddressId;

                _CompData.base64Logo = _data.base64Logo;
                _CompData.base64LogoName = convert.ToString(_data.base64LogoName);
                _CompData.base64LogoType = _data.base64LogoType;

                _CompData.base64minLogo = _data.base64minLogo;
                _CompData.base64minLogoName = convert.ToString(_data.base64minLogoName);
                _CompData.base64minLogoType = _data.base64minLogoType;

                _CompData.base64printLogo = _data.base64printLogo;
                _CompData.base64printLogoName = convert.ToString(_data.base64printLogoName);
                _CompData.base64printLogoType = _data.base64printLogoType;

                _CompData.addr_code = _address.addr_code;
                _CompData.addr_name = _address.addr_name;
                _CompData.contact_person = _address.contact_person;
                _CompData.address1 = _address.address1;
                _CompData.address2 = _address.address2;
                _CompData.address3 = _address.address3;
                _CompData.address4 = _address.address4;
                _CompData.addr_city = _address.addr_city;
                _CompData.addr_country = _address.addr_country;
                _CompData.addr_zipcode = _address.addr_zipcode;
                _CompData.addr_phone1 = _address.addr_phone1;
                _CompData.addr_phone2 = _address.addr_phone2;
                _CompData.addr_fax = _address.addr_fax;
                _CompData.addr_telex = _address.addr_telex;
                _CompData.addr_email = _address.addr_email;
                _CompData.addr_mobilephone = _address.addr_mobilephone;
                _CompData.addr_type = _address.addr_type;

            }
            return _CompData;
        }

        private Companyinfodata GetCompanyAddressInfoDetails(V_COMPANY_DETAILS_DATA _data)
        {
            Companyinfodata _CompData = new Companyinfodata();
            SM_ADDRESS _address = (SM_ADDRESS)_routineMiddleware.CallSmAddressById(convert.ToInt(_data.AddressId));
            if (_address != null)
            {
                _CompData.CompanyId = _data.CompanyId;
                _CompData.Company_Code = _data.Company_Code;
                _CompData.Company_Description = _data.Company_Description;
                _CompData.AddressId = _data.AddressId;

                _CompData.base64Logo = _data.base64Logo;
                _CompData.base64LogoName = convert.ToString(_data.base64LogoName);
                _CompData.base64LogoType = _data.base64LogoType;

                _CompData.base64minLogo = _data.base64minLogo;
                _CompData.base64minLogoName = convert.ToString(_data.base64minLogoName);
                _CompData.base64minLogoType = _data.base64minLogoType;

                _CompData.base64printLogo = _data.base64printLogo;
                _CompData.base64printLogoName = convert.ToString(_data.base64printLogoName);
                _CompData.base64printLogoType = _data.base64printLogoType;

                _CompData.addr_code = _address.addr_code;
                _CompData.addr_name = _address.addr_name;
                _CompData.contact_person = _address.contact_person;
                _CompData.address1 = _address.address1;
                _CompData.address2 = _address.address2;
                _CompData.address3 = _address.address3;
                _CompData.address4 = _address.address4;
                _CompData.addr_city = _address.addr_city;
                _CompData.addr_country = _address.addr_country;
                _CompData.addr_zipcode = _address.addr_zipcode;
                _CompData.addr_phone1 = _address.addr_phone1;
                _CompData.addr_phone2 = _address.addr_phone2;
                _CompData.addr_fax = _address.addr_fax;
                _CompData.addr_telex = _address.addr_telex;
                _CompData.addr_email = _address.addr_email;
                _CompData.addr_mobilephone = _address.addr_mobilephone;
                _CompData.addr_type = _address.addr_type;

            }
            return _CompData;
        }
        private int GetCustomerIdFromCompanyId(int companyid)
        {
            int CustId = 0;
            var lesCompany = _dbContextAdmin.les_company.Where(x => x.companyid == companyid).FirstOrDefault();
            if (lesCompany != null && lesCompany.addressid > 0)
            {
                var customer = _dbContext.les_customers.Where(x => x.addressid == lesCompany.addressid).FirstOrDefault();
                if (customer != null && customer.customerid > 0)
                {
                    CustId = customer.customerid;
                }
            }
            return CustId;
        }

        [HttpPost]
        [Route("EpodUpdateShippedStatus")]
        public IActionResult EpodUpdateShippedStatus(UpdateEpodStatusModal modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("EpodUpdateShippedStatus Process started");
                CommonFunction.setLog("UpdateEpodStatusModal DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallEpodUpdateShippedStatus(modal.shipmentid, modal.userid, modal.latitude, modal.longitude, modal.emailid, modal.username, modal.vesselimo, modal.role);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on EpodUpdateShippedStatus :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("EpodUpdateShippedStatus function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("EpodUpdateVerificationStatus")]
        public IActionResult EpodUpdateVerificationStatus(UpdateEpodStatusModal modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("EpodUpdateVerificationStatus Process started");
                CommonFunction.setLog("UpdateEpodStatusModal DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallEpodUpdateVerificationStatus(modal.shipmentid, modal.userid, modal.latitude, modal.longitude, modal.emailid, modal.username, modal.vesselimo, modal.role);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on EpodUpdateVerificationStatus :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("EpodUpdateVerificationStatus function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("EpodUpdateConfirmedStatus")]
        public IActionResult EpodUpdateConfirmedStatus(UpdateEpodStatusModal modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("EpodUpdateConfirmedStatus Process started");
                CommonFunction.setLog("UpdateEpodStatusModal DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallEpodUpdateConfirmedStatus(modal.shipmentid, modal.userid, modal.latitude, modal.longitude, modal.emailid, modal.username, modal.vesselimo, modal.role);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on EpodUpdateConfirmedStatus :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("EpodUpdateConfirmedStatus function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetEpodShipmentListByComapnyId")]
        public IActionResult GetEpodShipmentListByComapnyId(FilterShipmentList modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("EpodFilterList Process started");
                CommonFunction.setLog("UpdateEpodStatusModal DATA : " + getSerializeData(modal));
                object obj = _routineMiddleware.CallGetEPODShipmentList(modal);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetEpodShipmentList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetEpodShipmentList function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetEpodShipmentListByCustomerId")]
        public IActionResult GetEpodShipmentListByCustomerId(FilterShipmentList modal)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("EpodFilterList Process started");
                CommonFunction.setLog("UpdateEpodStatusModal DATA : " + getSerializeData(modal));

                object obj = _routineMiddleware.CallGetEPODShipmentListBycustomerid(modal);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetEpodShipmentList :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetEpodShipmentList function stopped successfully.");
            }
        }
        #endregion

        #region PRINT

        [HttpPost]
        [Route("GetPrintGRNReport")]
        public IActionResult GetPrintGRNReport(fData _data)
        {

            try
            {
                PrintGoodsReturnReportModal _PrintData = new PrintGoodsReturnReportModal();
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetPrintGRNReport Process started for Shipment id " + _data.shipmentid + " company id " + _data.companyid);
                UserAdminClass _adminrtn = new UserAdminClass(_dbContextAdmin);
                List<V_COMPANY_DETAILS_DATA> _lstUserCompany = (List<V_COMPANY_DETAILS_DATA>)_adminrtn.CallGetusercompanylinkByCompanyid(convert.ToInt(_data.companyid));
                if (_lstUserCompany.Count > 0)
                {
                    V_COMPANY_DETAILS_DATA _cdata = _lstUserCompany.FirstOrDefault();
                    if (_cdata != null && _cdata.AddressId > 0)
                    {
                        _PrintData = (PrintGoodsReturnReportModal)_routineMiddleware.CallPrintGoodsReturnReport(_data.shipmentid, _data.companyid);
                        Companyinfodata _CompData = GetCompanyAddressInfoDetails(_cdata);
                        _PrintData.companydata = _CompData;
                    }
                }
                return Ok(_PrintData);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetPrintGRNReport :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetPrintGRNReport function stopped successfully.");
            }
        }




        #endregion

        #region Export

        [HttpGet]
        [Route("GetLogisticExportData")]
        public IActionResult GetLogisticExportData()
        {

            try
            {
                ExportDataModal _exportData = new ExportDataModal();
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetLogisticExportData Process started.");
                _exportData = (ExportDataModal)_routineMiddleware.CallLogisticExportData();
                return Ok(_exportData);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on GetLogisticExportData :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetLogisticExportData function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("UploadShipmentGRNReport")]
        public IActionResult UploadShipmentGRNReport(AttachDocumentsDataModal _document)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UploadShipmentGRNReport Process started");
                object obj = _routineMiddleware.CallUpdateShipmentGRNAttachmentDetails(_document);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UploadShipmentGRNReport :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UploadShipmentGRNReport function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("DownloadShipmentGRNReport")]
        public IActionResult DownloadShipmentGRNReport(AttachDocumentsDataModal _document)
        {
            object obj = null;
            try
            {
                string FileName = "";
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("DownloadShipmentGRNReport Process started");
                responseMessage objData = (responseMessage)_routineMiddleware.CallDownloadGRNShipmentAttachmentDetails(_document);
                if (objData != null)
                {
                    obj = objData.data;
                }
                return Json(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on DownloadShipmentGRNReport :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("DownloadShipmentGRNReport function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("UpdateInitialReceiptMarker")]
        public IActionResult UpdateInitialReceiptMarker(UpdateInitialExportedMarker _data)
        {
            try
            {
                string FileName = "";
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateInitialReceiptMarker Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContextAdmin);

                if (convert.ToInt(_data.companyid) > 0)
                {
                    List<V_COMPANY_DETAILS_DATA> _companyUserData = (List<V_COMPANY_DETAILS_DATA>)_adminrtn.CallGetusercompanylinkByCompanyid(convert.ToInt(_data.companyid));
                    if (_companyUserData.Count > 0)
                    {
                        _data.company_desc = _companyUserData.FirstOrDefault().Company_Description;
                        _data.emailids = string.Join(", ", _companyUserData.Where(x => (x.UserTypeId == 2 || x.UserTypeId == 5 || x.UserTypeId == 10) && x.mail_notification == 1).Select(x => x.ex_emailid.ToLower()).Distinct().ToList());
                    }
                    responseMessage objData = (responseMessage)_routineMiddleware.CallUpdateInitialReceiptMarker(_data);

                    return Json(objData);
                }
                else
                {
                    throw new Exception("Unable to get company details");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateInitialReceiptMarker :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UpdateInitialReceiptMarker function stopped successfully.");
            }
        }


        [HttpPost]
        [Route("UpdateFinalReceiptMarker")]
        public IActionResult UpdateFinalReceiptMarker(UpdateFinalExportedMarker _data)
        {
            object obj = null;
            try
            {
                string FileName = "";
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateFinalReceiptMarker Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContextAdmin);

                if (convert.ToInt(_data.companyid) > 0)
                {
                    List<V_COMPANY_DETAILS_DATA> _companyUserData = (List<V_COMPANY_DETAILS_DATA>)_adminrtn.CallGetusercompanylinkByCompanyid(convert.ToInt(_data.companyid));
                    if (_companyUserData.Count > 0)
                    {
                        _data.company_desc = _companyUserData.FirstOrDefault().Company_Description;
                        _data.emailids = string.Join(", ", _companyUserData.Where(x => (x.UserTypeId == 2 || x.UserTypeId == 5 || x.UserTypeId == 10) && x.mail_notification == 1).Select(x => x.ex_emailid.ToLower()).Distinct().ToList());
                    }
                    responseMessage objData = (responseMessage)_routineMiddleware.CallUpdateFinalReceiptMarker(_data);
                    if (objData != null)
                    {
                        obj = objData.data;
                    }
                    return Json(obj);
                }
                else
                {
                    throw new Exception("Unable to get company details");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UpdateFinalReceiptMarker :" + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UpdateFinalReceiptMarker function stopped successfully.");
            }
        }

        #endregion

        private string getSerializeData(object data)
        {
            string _Data = "";
            try
            {
                _Data = JsonConvert.SerializeObject(data);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on getSerializeData : " + ex.Message + " Stack Trace : " + ex.StackTrace);
            }
            return _Data;
        }

        private object getDeserializeData(string _jsonData, System.Type ObjectType)
        {
            object obj = null;
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.NullValueHandling = NullValueHandling.Ignore;
                settings.DefaultValueHandling = DefaultValueHandling.Ignore;
                obj = JsonConvert.DeserializeObject(_jsonData, ObjectType, settings);
            }
            catch (Newtonsoft.Json.JsonException ex)
            {
                CommonFunction.setLog("GetDataObject Error for " + convert.ToString(ObjectType) + " :" + ex.Message);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("GetDataObject Error for " + convert.ToString(ObjectType) + " :" + ex.Message);
            }
            return obj;
        }

        public class ReleasedData
        {
            public int deliveryOrderid { get; set; }
            public int internalOrderId { get; set; }
            public int inboundShipmentId { get; set; }
            public int createdBy { get; set; }
        }

        public class FilterInboundShipment
        {
            public int companyid { get; set; }
            public string shipmentno { get; set; } = "";
            public string quicksearchvalue { get; set; } = "";
            public int statusid { get; set; }
            public int pono { get; set; }
            public int customerid { get; set; } = 0;
            public string custCode { get; set; } = "";
            public string custName { get; set; } = "";
            public int transTypeid { get; set; }
            public string jobno { get; set; } = "";
            public string vesselName { get; set; } = "";
            public string dtFrom { get; set; } = "";
            public string dtTo { get; set; } = "";
            public int skip { get; set; }
            public int pagesize { get; set; }
            public string? sortcolumn { get; set; }
            public string? sortingorder { get; set; }
            public bool isDeliveryToday { get; set; } = false;
            public bool isDeliveryin3days { get; set; } = false;
            public bool isDeliveryThisWeek { get; set; } = false;
        }
    }



    public class LogisticManagementV2Class : Logistic_Management_Lib.DataRoutine
    {
        private readonly LogisticDbContext _dbContext;
        public LogisticManagementV2Class(LogisticDbContext dbContext, UserAdminDbContext userAdminDb, ESupplierConlashContext esuppliercontext)
        : base(dbContext, userAdminDb, esuppliercontext)
        {

        }
        public object CallGetModuleStatus(int ModuleId)
        {
            return Get_ModuleStatuses_By_moduleId(ModuleId);
        }
        public object CallGetDeliveryOrderList(FilterDeliveryOrdersList modal)
        {
            string strdata = JsonConvert.SerializeObject(modal);
            var obj = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterDeliveryOrdersList>(strdata);
            return Get_V_Delivery_Orders_Info_By_companyId_Filter(obj);
        }
        public object CallGetDeliveryOrderListByCustomerid(FilterDeliveryOrdersList modal)
        {
            string strdata = JsonConvert.SerializeObject(modal);
            var obj = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterDeliveryOrdersList>(strdata);
            return Get_V_Delivery_Orders_Info_By_customerId_Filter(obj);
        }

        public object CallGetShipmentList(FilterShipmentList modal)
        {
            var strdata = JsonConvert.SerializeObject(modal);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterShipmentList>(strdata);
            return Get_V_Shipment_Info_By_companyId_Filter(Modal);
        }
        public async Task<object> CallGetInboundShipmentListByCompanyIdAsync(LogisticV2Controller.FilterInboundShipment modal)
        {
            var strdata = JsonConvert.SerializeObject(modal);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterInboundShipment>(strdata);

            // Assuming Get_InboundShipment_FilterByCompanyid is an async method
            return await Get_InboundShipment_FilterByCompanyidAsync(Modal);
        }

        public async Task<object> CallGetInboundShipmentListByCustomerid(LogisticV2Controller.FilterInboundShipment modal)
        {
            var strdata = JsonConvert.SerializeObject(modal);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterInboundShipment>(strdata);
            return await Get_InboundShipment_FilterByCustomeridAsync(Modal);
        }
        public object CallGetShipmentListbycustomerId(FilterShipmentList modal)
        {
            var strdata = JsonConvert.SerializeObject(modal);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterShipmentList>(strdata);
            return Get_V_Shipment_Info_By_customerid_Filter(Modal);
        }

        public object CallGetSiteConfigByModuleidAndCompanyid(int moduleid, int companyid)
        {
            return GetSiteConfigByModuleidAndCompanyid(moduleid, companyid);
        }

        public object CallGetVDeliveryOrdersInfo_By_Id(int Deliveryorderid, int companyid)
        {
            return GetVDeliveryOrdersInfo_By_Id(Deliveryorderid, companyid);
        }
        public object CallGetVDeliveryOrdersAddressEpodByDeliveryOrderId(int Deliveryorderid)
        {
            return GetVDeliveryOrdersAddressEpodByDeliveryOrderId(Deliveryorderid);
        }

        public object CallGetVDeliveryOrderLinesByDeliveryOrderId(int Deliveryorderid)
        {
            return GetVDeliveryOrderLinesByDeliveryOrderId(Deliveryorderid);
        }

        public object CallGetDeliveryOrderDocumentsByDeliveryOrderId(int Deliveryorderid)
        {
            return GetDeliveryOrderDocumentsByDeliveryOrderId(Deliveryorderid);
        }
        public SM_ADDRESS CallGetSmAddressByCode(string addrCode)
        {
            return GetSmAddressByCode(addrCode);
        }
        public object CallPushDeliveryOrders(CreateDeliveryOrderModal _details)
        {
            return PushDeliveryOrders(_details);
        }
        public object CallAddDeliveryOrderAttachment(Delivery_Order_Documents _details)
        {
            return AddDeliveryOrderAttachment(_details);
        }
        public object CallRemoveDeliveryOrderAttachment(Remove_Delivery_Order_Documents _details)
        {
            return RemoveDeliveryOrderAttachment(_details);
        }
        public object CallUpdateEpodDeliveryOrderLines(Update_EPOD_DeliveryOrderItems itemdetails)
        {
            return UpdateEpodDeliveryOrderLines(itemdetails);
        }
        public object CallUpdateAssignShipmenttoDeliveryOrder(AssignDeliverOrder orderdetails)
        {
            return UpdateAssignShipmenttoDeliveryOrder(orderdetails);
        }
        public object CallUpdateUnAssignShipmenttoDeliveryOrder(AssignDeliverOrder orderdetails)
        {
            return UpdateUnAssignShipmenttoDeliveryOrder(orderdetails);
        }

        public object CallUnAssignPOToDeliveryOrder(int deliveryorderid)
        {
            return UpdateUnAssignDOtoDeliveryOrder(deliveryorderid);
        }
        public object CallReleaseDeliveryOrder(DeliveryOrdersWebApi.Controllers.LogisticV2Controller.ReleasedData data)
        {
            var strdata = JsonConvert.SerializeObject(data);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.ReleasedData>(strdata);
            return UpdateReleaseDeliveryOrder(Modal);
        }
        public object CallGetEPODDeliveryOrderLinesByDeliveryOrderId(int? id)
        {
            return GetEPODDeliveryOrderLinesByDeliveryOrderId(id);
        }
        public object CallGetDeliveryOrdersDropDownByCompanyIdandCustomerid(int? companyid, int? customerid)
        {
            return Get_Delivery_Orders_DropDown_By_companyIdandCustomerid(companyid, customerid);
        }
        public object CallGetDeliveryOrdersDropDownByVerification(DeliveryOrdersDropDownVerification details)
        {
            return Get_Delivery_Orders_DropDown_By_Verification(details.companyid, details.customerid, details.Jobno, details.VesselName, details.VesselETA);
        }
        public object CallDownloadDeliveryOrderAttachmentDetails(AttachDocumentsDataModal _data)
        {
            return DownloadDeliveryOrderAttachmentDetails(_data);
        }
        public object CallCreateDeliveryOrderAttachmentDetails(AttachDocumentsDataModal _data)
        {
            return CreateDeliveryOrderAttachmentDetails(_data);
        }
        public object CallGetAllCustomerDetailsByCompanyId(int companyid)
        {
            return GetAllCustomerDetailsByCompanyId(companyid);
        }
        public object CallGetAllCustomerDetailsByCustomerId(int? addrid)
        {
            return GetAllCustomerDetailsByCustomerId(addrid);
        }
        public object CallGetShipmentDetailsById(int ShipmentId, int Companyid)
        {
            return Get_V_Shipment_Info_By_ShipmentId(ShipmentId, Companyid);
        }
        public object CallGetPrintShipmentDetailsById(int ShipmentId, int Companyid)
        {
            return Get_Print_Shipment_Info_By_ShipmentId(ShipmentId, Companyid);
        }
        public object CallGetVShipmentTripPlanByShipmentId(int Shipmentid)
        {
            return GetVShipmentTripPlanByShipmentId(Shipmentid);
        }
        public object CallGetVShipmentDeliveryOrdersByShipmentId(int ShipmentId)
        {
            return GetVShipmentDeliveryOrdersByShipmentId(ShipmentId);
        }
        public object CallGetShipmentDocumentByShipmentId(int Shipmentid)
        {
            return GetShipmentDocumentByShipmentId(Shipmentid);
        }
        public object CallGetShipmentDOByShipmentId(int shipmentid)
        {
            return GetShipmentDODocumentByShipmentId(shipmentid);
        }
        public object GetInboundShipmentDetailsByShipmnentId(int shipmnetId)
        {
            return GetVInboundShipmentDetails(shipmnetId);
        }
        public object GetinboundShipmentdetailsEsupplier(int quotationid)
        {
            return GetVInboundShipmentDetailsFromesupplier(quotationid);
        }
        public object GetInternalOrderDetailsEsupplier(int quotationid)
        {
            return GetlinkedpurchaseorderdetailsEsupplier(quotationid);
        }
        public object GetInternalOrderLineseSupplier(int quotationid)
        {
            return GetLinkedpurchaseOrderByEsupplier(quotationid);
        }
        public object GetInboundShipmentByquotation(int quotationid)
        {
            return GetInboundShipmentFromQuotation(quotationid);
        }
        public object getvremaininginternalOrders(int internalorderid)
        {
            return LoadRemainingInternalOrderLines(internalorderid);
        }
        public object GetDeliveryOrdersByInternalOrderId(int internalorderid)
        {
            return LoadDeliveryOrdersByInternalOrderLines(internalorderid);
        }
        public object getinsertEsupplierPotoLogiLink(int quotationid)
        {
            return ImportPofromEsupplierToLogiLink(quotationid);
        }
        public object AssignPOLinesToDo(AssignDoToPO_Inbound modal)
        {
            return AssignDOtoPOInbound(modal);
        }
        public object CallGetRemainingPOlines(int internalorderid)
        {
            return GetRemainingPOlinesCount(internalorderid);
        }
        public object CallGetRemainingPOlinesbyInboundId(int inboundshipmentid)
        {
            return GetRemainingPOlinesCountbyInboundId(inboundshipmentid);
        }
        public object CallGetDeliveryOrderCount(int internalorderid)
        {
            return GetDeliveryOrderCount(internalorderid);
        }
        public object CallGetDeliveryOrderCountbyInboundId(int inboundshipmentid)
        {
            return GetDeliveryOrderCountbyInboundId(inboundshipmentid);
        }
        public object ReleasePODO(AssignDoToPO_Inbound modal)
        {
            return CallReleasePODO(modal);
        }
        public object GetLinkedPurchaseOrderbyShipmentid(int inboundshipmentid)
        {
            return GetLinkedPurchaseOrdersbyShipId(inboundshipmentid);
        }
        public object GetInternalOrderLinesbyPOid(int internalorderid)
        {
            return GetLinkedInternalOrderLinesbyPOId(internalorderid);
        }
        public object CallCreateOutboundShipment(CreateShipmentOrderModal _details)
        {
            return CreateOutboundShipment(_details);
        }
        public object CallUpdateOutboundShipment(UpdateShipmentOrderModal _details)
        {
            return UpdateOutboundShipment(_details);
        }
        public object CallAddShipmentAttachment(Shipment_Documents _details)
        {
            return AddShipmentAttachment(_details);
        }
        public object CallRemoveShipmentAttachment(Remove_Shipment_Documents _details)
        {
            return RemoveShipmentAttachment(_details);
        }
        public object CallUpdateEPODShipmentDetails(EPOD_ShipmentDetails _data)
        {
            return UpdateEPODShipmentDetails(_data);
        }
        public object CallGetShipmentDropDownByCompanyId(int? companyid)
        {
            return Get_Shipment_DropDown_By_CompanyId(companyid);
        }
        public object CallGetNewShipmentWithDOList(deliveryOrderListModal delOrderList)
        {
            return GetNewShipmentWithDOList(delOrderList);
        }
        public object CallCreateShipmentAttachmentDetails(AttachDocumentsDataModal _data)
        {
            return CreateShipmentAttachmentDetails(_data);
        }
        public object CallUploadDeliveryOrderDocuments(IFormFileCollection _attachments)
        {
            return UploadDeliveryOrderDocuments(_attachments);
        }
        public object CallCreateInternalOrderShipmentDocument(AttachDocumentsDataModal _data)
        {
            return CreateInternalOrderDeliveryOrderDetails(_data);
        }
        public object CallDownloadShipmentAttachmentDetails(AttachDocumentsDataModal _data)
        {
            return DownloadShipmentAttachmentDetails(_data);
        }
        public object CallDownloadShipmentDOattchament(AttachDocumentsDataModal _data)
        {
            return DownloadShipmentDOAttachmentDetails(_data);
        }
        public object CallGetAllAnchorage()
        {
            return GetAllAnchorage();
        }
        public int CallAddAnchorage(Mast_Anchorage _details)
        {
            return AddAnchorage(_details);
        }
        public int CallUpdateAnchorage(Update_Anchorage _details)
        {
            return UpdateAnchorage(_details);
        }
        public object CallGetAllGoodsReturnReasons()
        {
            return GetAllGoodsReturnReasons();
        }
        public int CallAddGoodsReturnReasons(Mast_Goods_Return_Reasons _details)
        {
            return AddGoodsReturnReasons(_details);
        }
        public int CallUpdateGoodsReturnReasons(Update_Goods_Return_Reasons _details)
        {
            return UpdateGoodsReturnReasons(_details);
        }
        public object CallGetAllTransportType()
        {
            return GetAllTransportType();
        }
        public int CallAddTransportType(MAST_TRANSPORT_TYPE _details)
        {
            return AddTransportType(_details);
        }
        public int CallUpdateTransportType(Update_Transport_Type _details)
        {
            return UpdateTransportType(_details);
        }
        public object CallGetAllVessels()
        {
            return GetAllVessels();
        }
        public int CallAddVessels(Mast_Vessel _details)
        {
            return AddVessels(_details);
        }

        public int CallUpdateVessels(Update_Vessels _details)
        {
            return UpdateVessels(_details);
        }
        public object CallGetCustomerListDetailsByCompanyId(int? companyid)
        {
            return GetCustomerListDetailsByCompanyId(companyid);
        }
        public object CallGenerateQRCode(QRModal contentdata)
        {
            return GenerateQRCode(contentdata);
        }
        public object CallGetShipmentByShipmentid(int shipmentid)
        {
            return GetShipmentByShipmentid(shipmentid);
        }
        public bool CallCheckEpodAccessLogs(int shipmentid, string emailid)
        {
            return Check_Epod_Access_Logs(shipmentid, emailid);
        }
        public bool CallAddEpodAccessLogs(int shipmentid, int userid, string emailid, string lat, string lon, string crueName = "", string VesselIMO = "", string Role = "")
        {
            return AddEpod_Access_Logs(shipmentid, userid, emailid, lat, lon, crueName, VesselIMO, Role);
        }
        public object CallGetVerifiedDOList(int shipmentid, int companyid)
        {
            return GetVerifiedDOList(shipmentid, companyid);
        }
        public object CallSmAddressById(int addressid)
        {
            return GetSmAddressById(addressid);
        }
        public object CallEpodUpdateShippedStatus(int shipmentid, int userid, string lat, string lon, string emailid = "", string username = "", string vesselimo = "", string role = "")
        {
            return Epod_Update_Shipped_Status(shipmentid, userid, lat, lon, emailid, username, vesselimo, role);
        }
        public object CallEpodUpdateVerificationStatus(int shipmentid, int userid, string lat, string lon, string emailid = "", string username = "", string vesselimo = "", string role = "")
        {
            return Epod_Update_Verification_Status(shipmentid, userid, lat, lon, emailid, username, vesselimo, role);
        }
        public object CallEpodUpdateConfirmedStatus(int shipmentid, int userid, string lat, string lon, string emailid = "", string username = "", string vesselimo = "", string role = "")
        {
            return Epod_Update_Confirmed_Status(shipmentid, userid, lat, lon, emailid, username, vesselimo, role);
        }
        public object CallGetEPODShipmentList(FilterShipmentList modal)
        {
            var strdata = JsonConvert.SerializeObject(modal);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterShipmentList>(strdata);

            return Get_EPOD_Shipment_Info_By_companyId_Filter(Modal);
        }
        public object CallGetEPODShipmentListBycustomerid(FilterShipmentList modal)
        {
            var strdata = JsonConvert.SerializeObject(modal);
            var Modal = JsonConvert.DeserializeObject<Logistic_Management_Lib.FilterShipmentList>(strdata);

            return Get_EPOD_Shipment_Info_By_customerId_Filter(Modal);
        }
        public object CallPrintGoodsReturnReport(int shipmentid, int customerid)
        {
            return PrintGoodsReturnReport(shipmentid, customerid);
        }
        public object CallLogisticExportData()
        {
            return Logistic_ExportData();
        }
        public object CallUpdateShipmentGRNAttachmentDetails(AttachDocumentsDataModal _data)
        {
            return UpdateShipmentGRNAttachmentDetails(_data);
        }
        public object CallDownloadGRNShipmentAttachmentDetails(AttachDocumentsDataModal _data)
        {
            return DownloadGRNShipmentAttachmentDetails(_data);
        }
        public object CallUpdateInitialReceiptMarker(UpdateInitialExportedMarker _data)
        {
            return UpdateInitialReceiptMarker(_data);
        }
        public object CallUpdateFinalReceiptMarker(UpdateFinalExportedMarker _data)
        {
            return UpdateFinalReceiptMarker(_data);
        }



    }
}