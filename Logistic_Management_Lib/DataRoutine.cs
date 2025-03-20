using LeSDataMain;
using Logistic_Management_Lib.DAL;
using Logistic_Management_Lib.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LES_USER_ADMINISTRATION_LIB;
using LES_USER_ADMINISTRATION_LIB.DAL;
using eSupplier_Lib;
using eSupplier_Lib.Data;
using Microsoft.EntityFrameworkCore.Query.Internal;
using eSupplier_Lib.Models;
using Microsoft.AspNetCore.Http;
using LES_USER_ADMINISTRATION_LIB.Model;


namespace Logistic_Management_Lib
{
    public class DataRoutine
    {
        LogisticDbContext _dbContext;
        UserAdminDbContext _dbContextUserAdmin;
        ESupplierConlashContext _dbesuppliercontext;
        string ModuleName { get; set; }
        public DataRoutine(LogisticDbContext dbContext, UserAdminDbContext userAdminDbContext, ESupplierConlashContext esuppliercontext)
        {
            _dbContext = dbContext;
            _dbContextUserAdmin = userAdminDbContext;
            _dbesuppliercontext = esuppliercontext;
            var configBuilder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            LogisticDbContext.configuration = configBuilder.Build();
            ModuleName = LogisticDbContext.configuration.GetSection("AppSettings").GetSection("LOGISTIC_MODULE").Value;
        }

        #region Mast_SITE_CONFIG
        protected List<Mast_SITE_CONFIG> GetAllSiteConfig()
        {
            return _dbContext.mast_site_config.ToList();
        }

        protected Mast_SITE_CONFIG GetSiteConfigById(int id)
        {
            Mast_SITE_CONFIG obj = _dbContext.mast_site_config.FirstOrDefault(x => x.siteconfigid == id);
            return obj;
        }

        protected List<Mast_SITE_CONFIG> GetSiteConfigByModuleidAndCompanyid(int moduleid, int companyid)
        {
            List<Mast_SITE_CONFIG> obj = _dbContext.mast_site_config.Where(x => x.moduleid == moduleid && x.companyid == companyid).ToList();
            return obj;
        }

        #endregion

        #region MAST_VESSEL
        //protected List<Mast_Vessel> GetAllVessel()
        //{
        //    return _dbContext.mast_vessel.ToList();
        //}

        protected Mast_Vessel GetVesselById(int id)
        {
            Mast_Vessel obj = _dbContext.mast_vessel.FirstOrDefault(x => x.VesselId == id);
            return obj;
        }

        protected List<VesselDetails> GetVesselDetails()
        {
            List<VesselDetails> obj = (List<VesselDetails>)_dbContext.mast_vessel.ToList().Select(x => new VesselDetails
            {
                VesselId = x.VesselId,
                VesselCode = x.VesselCode,
                VesselName = x.VesselName,
                ImoNo = x.ImoNo,
            }).ToList();
            return obj;
        }

        #endregion

        #region MAST_ANCHORAGE
        protected List<Mast_Anchorage> GetAllAnchorage()
        {
            return _dbContext.mast_anchorage.ToList();
        }

        protected Mast_Anchorage GetAnchorageById(int id)
        {
            Mast_Anchorage obj = _dbContext.mast_anchorage.FirstOrDefault(x => x.AnchorageId == id);
            return obj;
        }

        protected int AddAnchorage(Mast_Anchorage obj)
        {
            obj.CreatedDate = DateTime.Now;
            obj.UpdatedDate = DateTime.Now;
            _dbContext.mast_anchorage.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateAnchorage(Update_Anchorage obj)
        {
            Mast_Anchorage _upData = _dbContext.mast_anchorage.Find(obj.AnchorageId);
            _dbContext.Entry(_upData).CurrentValues.SetValues(obj);
            return _dbContext.SaveChanges();
        }

        protected int DeleteAnchorage(int id)
        {
            Mast_Anchorage module = _dbContext.mast_anchorage.FirstOrDefault(x => x.AnchorageId == id);
            _dbContext.mast_anchorage.Remove(module);
            return _dbContext.SaveChanges();
        }

        #endregion

        #region MAST_GOODS_RETURN_REASONS
        protected List<Mast_Goods_Return_Reasons> GetAllGoodsReturnReasons()
        {
            return _dbContext.mast_goods_return_reasons.ToList();
        }

        protected Mast_Goods_Return_Reasons GetGoodsReturnReasonsById(int id)
        {
            Mast_Goods_Return_Reasons obj = _dbContext.mast_goods_return_reasons.FirstOrDefault(x => x.GrnReasonId == id);
            return obj;
        }

        protected int AddGoodsReturnReasons(Mast_Goods_Return_Reasons obj)
        {
            _dbContext.mast_goods_return_reasons.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateGoodsReturnReasons(Update_Goods_Return_Reasons obj)
        {
            Mast_Goods_Return_Reasons _upDate = _dbContext.mast_goods_return_reasons.Find(obj.GrnReasonId);
            _dbContext.Entry(_upDate).CurrentValues.SetValues(obj);
            return _dbContext.SaveChanges();
        }

        protected int DeleteGoodsReturnReasons(int id)
        {
            Mast_Goods_Return_Reasons module = _dbContext.mast_goods_return_reasons.FirstOrDefault(x => x.GrnReasonId == id);
            _dbContext.mast_goods_return_reasons.Remove(module);
            return _dbContext.SaveChanges();
        }

        #endregion

        #region MAST_TRANSPORT_TYPE
        protected List<MAST_TRANSPORT_TYPE> GetAllTransportType()
        {
            return _dbContext.mast_transport_type.ToList();
        }

        protected MAST_TRANSPORT_TYPE GetTransportTypeById(int id)
        {
            MAST_TRANSPORT_TYPE obj = _dbContext.mast_transport_type.FirstOrDefault(x => x.transport_type_id == id);
            return obj;
        }

        protected int AddTransportType(MAST_TRANSPORT_TYPE obj)
        {
            _dbContext.mast_transport_type.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateTransportType(Update_Transport_Type obj)
        {
            MAST_TRANSPORT_TYPE _upDate = _dbContext.mast_transport_type.Find(obj.transport_type_id);
            _dbContext.Entry(_upDate).CurrentValues.SetValues(obj);
            return _dbContext.SaveChanges();
        }

        protected int DeleteTransportType(int id)
        {
            MAST_TRANSPORT_TYPE module = _dbContext.mast_transport_type.FirstOrDefault(x => x.transport_type_id == id);
            _dbContext.mast_transport_type.Remove(module);
            return _dbContext.SaveChanges();
        }

        #endregion

        #region VESSEL
        protected List<Mast_Vessel> GetAllVessels()
        {
            try
            {
                return _dbContext.mast_vessel.ToList();
            }
            catch (Exception ex)
            {
                setlog("Error on Get vessels : " + ex.Message);
                throw ex;
            }

        }

        protected int AddVessels(Mast_Vessel obj)
        {
            try
            {
                _dbContext.mast_vessel.Add(obj);
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                setlog("Error on Add vessels : " + ex.Message);
                throw ex;
            }
        }

        protected int UpdateVessels(Update_Vessels obj)
        {
            try
            {
                Mast_Vessel _upDate = _dbContext.mast_vessel.Find(obj.VesselId);
                _dbContext.Entry(_upDate).CurrentValues.SetValues(obj);
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                setlog("Error on Update vessels : " + ex.Message);
                throw ex;
            }

        }

        protected int DeleteVessels(int id)
        {
            try
            {
                Mast_Vessel module = _dbContext.mast_vessel.FirstOrDefault(x => x.VesselId == id);
                _dbContext.mast_vessel.Remove(module);
                return _dbContext.SaveChanges();
            }
            catch (Exception ex)
            {
                setlog("Error on Delete vessels : " + ex.Message);
                throw ex;
            }

        }
        #endregion

        #region DELIVERY_ORDER_DOCUMENTS
        protected List<Delivery_Order_Documents> GetAllDeliveryOrderDocuments()
        {
            return _dbContext.delivery_order_documents.ToList();
        }

        protected Delivery_Order_Documents GetDeliveryOrderDocumentsById(int id)
        {
            Delivery_Order_Documents obj = _dbContext.delivery_order_documents.FirstOrDefault(x => x.DeliveryDocumentId == id && x.IsDelete != 1);
            return obj;
        }

        protected List<Delivery_Order_Documents> GetDeliveryOrderDocumentsByDeliveryOrderId(int? id)
        {
            List<Delivery_Order_Documents> obj = _dbContext.delivery_order_documents.Where(x => x.DeliveryOrderId == id && x.IsDelete != 1).ToList();
            return obj;
        }

        protected int AddDeliveryOrderDocuments(Delivery_Order_Documents obj)
        {
            obj.CreatedDate = DateTime.Now;
            obj.UpdatedDate = DateTime.Now;
            _dbContext.delivery_order_documents.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateDeliveryOrderDocuments(Delivery_Order_Documents obj)
        {
            Delivery_Order_Documents _upDate = _dbContext.delivery_order_documents.Find(obj.DeliveryDocumentId);
            obj.UpdatedDate = DateTime.Now;
            _dbContext.Entry(_upDate).CurrentValues.SetValues(obj);
            return _dbContext.SaveChanges();
        }

        protected int DeleteDeliveryOrderDocuments(int id)
        {
            Delivery_Order_Documents module = _dbContext.delivery_order_documents.FirstOrDefault(x => x.DeliveryDocumentId == id);
            _dbContext.delivery_order_documents.Remove(module);
            return _dbContext.SaveChanges();
        }

        protected object AddDeliveryOrderAttachment(Delivery_Order_Documents _deliveryDoc)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                setlog("AddDeliveryOrderAttachment DATA : " + getSerializeData(_deliveryDoc));
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            Delivery_Orders _deliveryOrderExt = _dbContext.delivery_orders.Find(_deliveryDoc.DeliveryOrderId);
                            Delivery_Orders _deliveryOrder = _deliveryOrderExt;
                            if (_deliveryOrder != null)
                            {
                                if (convert.ToInt(_deliveryOrder.DeliveryOrderId) > 0 && convert.ToInt(_deliveryOrder.DeliveryOrderId) < 3)
                                {
                                    //_deliveryOrder.StatusId = convert.ToInt(Status.DRAFT);
                                    _deliveryOrder.UpdateDate = DateTime.Now;
                                    _deliveryOrder.updated_by = _deliveryDoc.created_by;
                                    _dbContext.Entry(_deliveryOrderExt).CurrentValues.SetValues(_deliveryOrder);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Invalid status of delivery order.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get delivery order details");
                            }

                            Delivery_Order_Documents _Document = new Delivery_Order_Documents();
                            _Document.DeliveryOrderId = _deliveryDoc.DeliveryOrderId;
                            _Document.DocumentName = _deliveryDoc.DocumentName;
                            _Document.DocumentNo = _deliveryDoc.DocumentNo;
                            _Document.DocumentPath = _deliveryDoc.DocumentPath;
                            _Document.DocumentTitle = _deliveryDoc.DocumentTitle;
                            _Document.created_by = _deliveryDoc.created_by;
                            _Document.updated_by = _deliveryDoc.created_by;
                            _Document.CreatedDate = DateTime.Now;
                            _Document.UpdatedDate = DateTime.Now;
                            _Document.DocumentType = _deliveryDoc.DocumentType;

                            _dbContext.delivery_order_documents.Add(_Document);
                            Updated += _dbContext.SaveChanges();
                            if (Updated > 0)
                            {
                                dbContextTransaction.Commit();
                                _response.data = _Document;
                                _response.status = "SUCCESS";
                                _response.isSuccess = true;
                                _response.message = "Delivery Order Document : " + _Document.DocumentName + " created successfully.";
                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order Document : " + _Document.DocumentName + " created successfully.", "", "", "", "");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error on Delivery Order Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while creating Delivery Order Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on creating Delivery Order Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object RemoveDeliveryOrderAttachment(Remove_Delivery_Order_Documents _deliveryDoc)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                setlog("RemoveDeliveryOrderAttachment DATA : " + getSerializeData(_deliveryDoc));
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            Delivery_Orders _deliveryOrderExt = _dbContext.delivery_orders.Find(_deliveryDoc.DeliveryOrderId);
                            Delivery_Orders _deliveryOrder = _deliveryOrderExt;
                            if (_deliveryOrder != null)
                            {
                                if (convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.OPEN) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.CONFIRMED) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.RELEASED) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.SHIPPED))
                                {
                                    //_deliveryOrder.StatusId = convert.ToInt(Status.DRAFT);
                                    _deliveryOrder.UpdateDate = DateTime.Now;
                                    _deliveryOrder.updated_by = _deliveryDoc.updated_by;
                                    _dbContext.Entry(_deliveryOrderExt).CurrentValues.SetValues(_deliveryOrder);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Invalid status of delivery order.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get delivery order details");
                            }

                            Delivery_Order_Documents _DocumentExt = _dbContext.delivery_order_documents.Find(_deliveryDoc.DeliveryDocumentId);
                            Delivery_Order_Documents _Document = _DocumentExt;
                            _Document.DeliveryOrderId = _deliveryDoc.DeliveryOrderId;
                            _Document.updated_by = _deliveryDoc.updated_by;
                            _Document.UpdatedDate = DateTime.Now;
                            _Document.IsDelete = 1;

                            _dbContext.Entry(_DocumentExt).CurrentValues.SetValues(_Document);
                            Updated += _dbContext.SaveChanges();
                            if (Updated > 0)
                            {
                                dbContextTransaction.Commit();
                                _response.data = _Document;
                                _response.status = "SUCCESS";
                                _response.isSuccess = true;
                                _response.message = "Delivery Order Document : " + _Document.DocumentName + " removed successfully.";
                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order Document : " + _Document.DocumentName + " removed successfully.", "", "", "", "");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error on RemoveDeliveryOrderAttachment : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while removing Delivery Order Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on removing Delivery Order Document : " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object CreateDeliveryOrderAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                string esupplerAttachmentpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("ESUPPLIER_ATTACHMENT_PATH").Value);
                setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            bool isUploaded = false;
                            Delivery_Orders _deliveryOrderExt = _dbContext.delivery_orders.FirstOrDefault(x => x.DeliveryOrderId == _data.DocRefId);
                            Delivery_Orders _deliveryOrder = _deliveryOrderExt;
                            if (_deliveryOrder != null)
                            {
                                if (convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.OPEN) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.CONFIRMED) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.RELEASED) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.SHIPPED) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.RECEIVED) || convert.ToInt(_deliveryOrder.StatusId) == convert.ToInt(Status.COMPLETED))
                                {
                                    _deliveryOrder.UpdateDate = DateTime.Now;
                                    _deliveryOrder.updated_by = _data.UpdatedBy;
                                    _dbContext.Entry(_deliveryOrderExt).CurrentValues.SetValues(_deliveryOrder);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Invalid status of delivery order.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get delivery order details");
                            }

                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _deliveryOrder.CompanyId && x.moduleid == 2 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value + "\\" + _deliveryOrder.CompanyId + "\\" + _deliveryOrder.DeliveryOrderId;
                                string _docPath = "\\" + _deliveryOrder.CompanyId + "\\" + _deliveryOrder.DeliveryOrderId;

                                Delivery_Order_Documents _Document = new Delivery_Order_Documents();
                                _Document.DeliveryOrderId = _data.DocRefId;
                                _Document.DocumentName = _data.Document_Name;
                                _Document.DocumentNo = _deliveryOrder.DeliveryOrderId;
                                _Document.DocumentPath = _docPath + "\\" + _data.Document_Name;
                                _Document.DocumentTitle = "DO_DOCUMNETS";
                                _Document.created_by = _data.UpdatedBy;
                                _Document.updated_by = _data.UpdatedBy;
                                _Document.CreatedDate = DateTime.Now;
                                _Document.UpdatedDate = DateTime.Now;

                                _Document.DocumentType = GetMimeType(Path.GetExtension(_data.Document_Name).ToUpper());
                                if (_data.Base64Data != null)
                                {
                                    byte[] _sbytes = Convert.FromBase64String(_data.Base64Data);
                                    if (!Directory.Exists(_savePath)) Directory.CreateDirectory(_savePath);
                                    System.IO.File.WriteAllBytes(_savePath + "\\" + _data.Document_Name, _sbytes);
                                    Directory.CreateDirectory(esupplerAttachmentpath);
                                    System.IO.File.WriteAllBytes(esupplerAttachmentpath + "\\" + _data.Document_Name, _sbytes);
                                    if (System.IO.File.Exists(_savePath + "\\" + _data.Document_Name))
                                    {
                                        isUploaded = true;
                                        setlog("File " + _docPath + "\\" + _data.Document_Name + " created successfully");
                                    }
                                }
                                if (isUploaded)
                                {
                                    _dbContext.delivery_order_documents.Add(_Document);
                                    Updated += _dbContext.SaveChanges();
                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _Document;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Delivery Order Document : " + _data.Document_Name + " created successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order Document : " + _data.Document_Name + " created successfully.", "", "", "", "");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get Upload File Data.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Upload File Data.");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while pushing Delivery Order Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while creating Delivery Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on creating Delivery Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object DownloadDeliveryOrderAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
            try
            {
                Delivery_Orders _orders = _dbContext.delivery_orders.Find(_data.DocRefId);
                if (_orders != null)
                {
                    Delivery_Order_Documents _deliveryOrderDocument = _dbContext.delivery_order_documents.FirstOrDefault(x => x.DeliveryDocumentId == _data.Docid && x.DeliveryOrderId == _data.DocRefId);
                    if (_deliveryOrderDocument != null)
                    {
                        Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _orders.CompanyId && x.moduleid == 13 && x.siteconfig_paramid == 1015);
                        if (mast_SITE_CONFIG != null)
                        {
                            string _savePath = mast_SITE_CONFIG.param_value;
                            if (_deliveryOrderDocument.DocumentPath != "")
                            {
                                if (File.Exists(_savePath + "\\" + _deliveryOrderDocument.DocumentPath))
                                {
                                    Byte[] bytes = File.ReadAllBytes(_savePath + "\\" + _deliveryOrderDocument.DocumentPath);
                                    string Base64file = Convert.ToBase64String(bytes);

                                    _data.Document_Name = Path.GetFileName(_savePath + "\\" + _deliveryOrderDocument.DocumentPath);
                                    _data.Base64Data = Base64file;
                                    _data.Companyid = _orders.CompanyId;
                                    _data.FileType = GetMimeType(Path.GetExtension(_deliveryOrderDocument.DocumentName));
                                    _response.data = _data;
                                    _response.status = "SUCCESS";
                                    _response.isSuccess = true;
                                    _response.message = "Attachment downloaded successfully";
                                    setlog("Attachment downloaded successfully by Userid : " + _data.UpdatedBy);
                                }
                                else
                                {
                                    throw new Exception("Unable to found Delivery order Attachment : '" + _deliveryOrderDocument.DocumentName + "'");
                                }
                            }
                            else
                            {
                                throw new Exception("Delivery order Document path is empty.");
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get Delivery Order Attachment path");
                        }
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipment details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while downloading Delivery order Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on downloading Delivery order Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        #endregion

        #region Delivery_Order_Info
        protected List<Delivery_Order_Info> GetAllDeliveryOrderInfo()
        {
            return _dbContext.delivery_order_info.ToList();
        }

        protected Delivery_Order_Info GetDeliveryOrderInfoById(int id)
        {
            Delivery_Order_Info obj = _dbContext.delivery_order_info.FirstOrDefault(x => x.delivery_order_id == id);
            return obj;
        }

        protected List<Delivery_Order_Info> GetDeliveryOrderInfoByDeliveryOrderId(int? id)
        {
            List<Delivery_Order_Info> obj = _dbContext.delivery_order_info.Where(x => x.delivery_order_id == id).ToList();
            return obj;
        }

        protected int AddDeliveryOrderInfo(Delivery_Order_Info obj)
        {
            _dbContext.delivery_order_info.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateDeliveryOrderInfo(Delivery_Order_Info obj)
        {
            Delivery_Order_Info _upDate = _dbContext.delivery_order_info.Find(obj.delivery_order_id);
            _dbContext.Entry(_upDate).CurrentValues.SetValues(obj);
            return _dbContext.SaveChanges();
        }

        protected int DeleteDeliveryOrderInfo(int id)
        {
            Delivery_Order_Info module = _dbContext.delivery_order_info.FirstOrDefault(x => x.delivery_order_id == id);
            _dbContext.delivery_order_info.Remove(module);
            return _dbContext.SaveChanges();
        }

        #endregion

        #region V_MODULE_STATUSES
        protected List<V_MODULE_STATUSES> GetAllModuleStatuses()
        {
            return _dbContext.v_module_statuses.ToList();
        }

        protected List<V_MODULE_STATUSES> Get_ModuleStatuses_By_moduleId(int moduleid)
        {
            List<V_MODULE_STATUSES> obj = _dbContext.v_module_statuses.Where(x => x.moduleid == moduleid).ToList();
            return obj;
        }

        #endregion

        #region LES_CUSTOMERS
        protected List<les_Customers> GetAllCustomers()
        {
            return _dbContext.les_customers.ToList();
        }
        protected les_Customers Get_Customers_By_customerid(int customerid)
        {
            les_Customers obj = _dbContext.les_customers.Find(customerid);
            return obj;
        }
        protected les_Customers Get_Customers_By_cust_code(string cust_code)
        {
            les_Customers obj = _dbContext.les_customers.FirstOrDefault(x => x.cust_code == cust_code);
            return obj;
        }

        protected les_Customers Get_Customers_By_cust_code_CompanyId(string cust_code, int CompanyId)
        {
            les_Customers obj = _dbContext.les_customers.FirstOrDefault(x => x.cust_code == cust_code && x.companyid == CompanyId);
            return obj;
        }

        protected List<LesCustomerDropdown> GetAllCustomerDetailsByCompanyId(int companyId)
        {

            return _dbContext.les_customers.Where(x => x.companyid == companyId).Select(x => new LesCustomerDropdown
            {
                customerid = x.customerid,
                cust_code = x.cust_code,
                cust_name = x.cust_name,
                cust_type = x.cust_type,
                companyid = 0
            }).ToList();
        }
        protected List<LesCustomerDropdown> GetAllCustomerDetailsByCustomerId(int? addrId)
        {

            //var custId = _dbContext.lesv_customers.Where(x => x.addressid == addrId).FirstOrDefault().customerid;
            var companies = _dbContext.lesv_customers.Where(x => x.addressid == addrId && x.cust_type == "Customer").Select(x => x.companyid).Distinct().ToList();
            var data = _dbContextUserAdmin.les_company.Where(x => companies.Contains(x.companyid)).Select(x => new LesCustomerDropdown
            {
                customerid = 0,
                cust_code = x.company_code,
                cust_name = x.company_description,
                cust_type = "Customer",
                companyid = x.companyid
            }).ToList();
            return data;
            //return _dbContext.lesv_customers.Where(x => x.addressid == addrId).Select(x => new LesCustomerDropdown
            //{
            //    //customerid = x.customerid,
            //    customerid = 0,
            //    cust_code = "",
            //    cust_name = x.company_name,
            //    cust_type = x.cust_type,
            //    companyid = x.companyid
            //}).ToList();
        }

        protected List<lesv_Customers> GetAllVCustomerDetailsByCompanyId(int companyId)
        {
            return _dbContext.lesv_customers.Where(x => x.companyid == companyId).ToList();
        }
        protected List<Customers_Grid> GetCustomerListDetailsByCompanyId(int? companyId)
        {
            return _dbContext.lesv_customers.Where(x => x.companyid == companyId).Select(x => new Customers_Grid
            {
                customerid = x.customerid,

                cust_code = x.cust_code,

                cust_name = x.cust_name,

                broker_code = x.broker_code,

                broker_name = x.broker_name,

                cust_type = x.cust_type,

                addr_state = x.addr_state,

                addr_country = x.addr_country,

                phone = x.phone,

                emailid = x.emailid,

                fax = x.fax,

                companyid = x.customerid,

                company_name = x.company_name,

                curr_code = x.curr_code,

                addr_type = x.addr_type

            }).ToList();
        }

        #endregion

        #region V_DELIVERY_ORDERS_INFO
        protected List<V_Delivery_Orders_Info> GetAll_V_Delivery_Orders_Info()
        {
            return _dbContext.v_delivery_orders_info.ToList();
        }

        protected V_Delivery_Orders_Info GetVDeliveryOrdersInfo_By_Id(int id, int companyid)
        {
            return _dbContext.v_delivery_orders_info.FirstOrDefault(x => x.delivery_order_id == id);
        }

        protected List<V_Delivery_Orders_Info> Get_V_Delivery_Orders_Info_By_companyId(int companyid)
        {
            List<V_Delivery_Orders_Info> obj = _dbContext.v_delivery_orders_info.Where(x => x.companyid == companyid).ToList();
            return obj;
        }

        protected StandardAPIresponse Get_V_Delivery_Orders_Info_By_companyId_Filter(FilterDeliveryOrdersList modal)
        {
            StandardAPIresponse Response = new StandardAPIresponse();
            var UserCompany = _dbContextUserAdmin.les_company.Where(x => x.companyid == modal.companyid).FirstOrDefault();            // Initialize query


            var obj = _dbContext.v_delivery_orders_info.AsQueryable();

            string sqlQuery = @"
            SELECT *
            FROM V_Delivery_Orders_Info
            WHERE companyid = @CompanyId
                AND (@CustCode IS NULL OR @CustCode = '' OR customer_no LIKE '%' + @CustCode + '%' OR customer_name LIKE '%' + @CustCode + '%')
                AND (@CustName IS NULL OR @CustName = '' OR customer_name LIKE '%' + @CustName + '%')
                AND (@DoNo IS NULL OR @DoNo = '' OR delivery_order_no LIKE '%' + @DoNo + '%')
                AND (@ShipmentNo IS NULL OR @ShipmentNo = '' OR order_no LIKE '%' + @ShipmentNo + '%')
                AND (@StatusId <= 0 OR statusid = @StatusId)
                
            ";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CompanyId", SqlDbType.Int) { Value = modal.companyid },
                new SqlParameter("@CustCode", SqlDbType.NVarChar) { Value = (object)modal.custCode ?? DBNull.Value },
                new SqlParameter("@CustName", SqlDbType.NVarChar) { Value = (object)modal.custName ?? DBNull.Value },
                new SqlParameter("@DoNo", SqlDbType.NVarChar) { Value = (object)modal.doNo ?? DBNull.Value },
                new SqlParameter("@ShipmentNo", SqlDbType.NVarChar) { Value = (object)modal.shipmentno ?? DBNull.Value },
                new SqlParameter("@StatusId", SqlDbType.Int) { Value = modal.statusid }
            };



            obj = obj.AsQueryable();
            obj = _dbContext.v_delivery_orders_info.FromSqlRaw(sqlQuery, sqlParameters);

            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                var arrquery = obj.ToArray();
                // Apply quick search logic
                arrquery = arrquery.Where(m =>
                {
                    string searchString = $"{m.delivery_order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.customer_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.customer_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.vessel_eta != null ? m.vessel_eta.Value.ToString("dd/MM/yyyy") : "")} " +
                                          $"{m.sales_order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.internal_dept?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.promised_delivery_date != null ? m.promised_delivery_date.Value.ToString("dd/MM/yyyy") : "")} " +
                                          $"{m.status_desc?.ToString().ToUpper() ?? ""} " +
                                          $"{m.sales_person_code?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.planned_ship_date != null ? m.planned_ship_date.Value.ToString("dd/MM/yyyy") : "")} " +
                                          $"{m.dept_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.jobno?.ToString().ToUpper() ?? ""}";

                    return searchString.IndexOf(searchValue.ToUpper(), StringComparison.OrdinalIgnoreCase) > -1;
                }).ToArray();
                obj = arrquery.AsQueryable(); ;
            }


            if (convert.ToString(modal.shipmentdate) != "")
            {
                var shipdate = convert.ToDateTime(modal.shipmentdate, "dd/MM/yyyy").Date;
                obj = obj.Where(x => x.shipmentdate == shipdate);
            }
            if (convert.ToString(modal.dtFrom) != "" && convert.ToString(modal.dtTo) != "")
            {
                var fromdt = convert.ToDateTime(modal.dtFrom, "dd/MM/yyyy").Date;
                var todt = convert.ToDateTime(modal.dtTo, "dd/MM/yyyy").Date;
                obj = obj.Where(x => x.vessel_eta >= fromdt && x.vessel_eta <= todt);
            }
            if (modal.unassignDO)
            {
                obj = obj.Where(x => x.shipmentid == null);
            }
            if (modal.customerid > 0)
            {
                obj = obj.Where(x => x.customerid == modal.customerid);
            }
            if (modal.shipment14days)
            {
                var daysahead = DateTime.Now.AddDays(-14);
                var todays = DateTime.Now;
                obj = obj.Where(x => x.shipmentdate >= daysahead && x.shipmentdate <= todays);
            }
            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                if (modal.sortingorder.ToLower() == "asc")
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": obj = obj.OrderBy(x => x.order_no); break;
                        case "delivery_order_no": obj = obj.OrderBy(x => x.delivery_order_no); break;
                        case "customer_no": obj = obj.OrderBy(x => x.customer_no); break;
                        case "customer_name": obj = obj.OrderBy(x => x.customer_name); break;
                        case "vessel_eta": obj = obj.OrderBy(x => x.vessel_eta); break;
                        case "vessel_name": obj = obj.OrderBy(x => x.vessel_name); break;
                        case "jobno": obj = obj.OrderBy(x => x.jobno); break;
                        case "internal_dept": obj = obj.OrderBy(x => x.internal_dept); break;
                        case "status_desc": obj = obj.OrderBy(x => x.status_desc); break;
                        case "sales_order_no": obj = obj.OrderBy(x => x.sales_order_no); break;
                        case "sales_person_code": obj = obj.OrderBy(x => x.sales_person_code); break;
                        case "planned_ship_date": obj = obj.OrderBy(x => x.planned_ship_date); break;
                        default: obj = obj.OrderBy(x => x.shipmentid); break;
                    }
                }
                else
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": obj = obj.OrderByDescending(x => x.order_no); break;
                        case "delivery_order_no": obj = obj.OrderByDescending(x => x.delivery_order_no); break;
                        case "customer_no": obj = obj.OrderByDescending(x => x.customer_no); break;
                        case "customer_name": obj = obj.OrderByDescending(x => x.customer_name); break;
                        case "vessel_eta": obj = obj.OrderByDescending(x => x.vessel_eta); break;
                        case "vessel_name": obj = obj.OrderByDescending(x => x.vessel_name); break;
                        case "jobno": obj = obj.OrderByDescending(x => x.jobno); break;
                        case "internal_dept": obj = obj.OrderByDescending(x => x.internal_dept); break;
                        case "status_desc": obj = obj.OrderByDescending(x => x.status_desc); break;
                        case "sales_order_no": obj = obj.OrderByDescending(x => x.sales_order_no); break;
                        case "sales_person_code": obj = obj.OrderByDescending(x => x.sales_person_code); break;
                        case "planned_ship_date": obj = obj.OrderByDescending(x => x.planned_ship_date); break;
                        default: obj = obj.OrderByDescending(x => x.shipmentid); break;
                    }
                }
            }



            obj = obj.AsQueryable();
            Response.totalRecords = obj.Count();
            var lsData = new List<V_Delivery_Orders_Info>();
            if (modal.pagesize > 0)
            {
                lsData = obj.Skip(modal.skip).Take(modal.pagesize).ToList();
            }
            else
            {
                lsData = obj.ToList();
            }
            lsData.ForEach(x =>
            {
                x.CompanyName = UserCompany.company_description;
                x.CompanyCode = UserCompany.company_code;
            });
            Response.data = lsData;
            Response.isSuccess = true;
            return Response;
        }
        protected StandardAPIresponse Get_V_Delivery_Orders_Info_By_customerId_Filter(FilterDeliveryOrdersList modal)
        {
            StandardAPIresponse Response = new StandardAPIresponse();

            var obj = _dbContext.v_delivery_orders_info.AsQueryable();

            string sqlQuery = @"
            SELECT *
            FROM V_Delivery_Orders_Info
            WHERE CUSTOMERID = @CustomerId
                AND (@CustCode IS NULL OR @CustCode = '' OR customer_no LIKE '%' + @CustCode + '%' OR customer_name LIKE '%' + @CustCode + '%')
                AND (@CustName IS NULL OR @CustName = '' OR customer_name LIKE '%' + @CustName + '%')
                AND (@DoNo IS NULL OR @DoNo = '' OR delivery_order_no LIKE '%' + @DoNo + '%')
                AND (@ShipmentNo IS NULL OR @ShipmentNo = '' OR order_no LIKE '%' + @ShipmentNo + '%')
                AND (@StatusId <= 0 OR statusid = @StatusId)
            ";
            SqlParameter[] sqlParameters = new SqlParameter[]
            {
                new SqlParameter("@CompanyId", SqlDbType.Int) { Value = modal.companyid },
                new SqlParameter("@CustomerId", SqlDbType.Int) { Value = modal.customerid },
                new SqlParameter("@CustCode", SqlDbType.NVarChar) { Value = (object)modal.custCode ?? DBNull.Value },
                new SqlParameter("@CustName", SqlDbType.NVarChar) { Value = (object)modal.custName ?? DBNull.Value },
                new SqlParameter("@DoNo", SqlDbType.NVarChar) { Value = (object)modal.doNo ?? DBNull.Value },
                new SqlParameter("@ShipmentNo", SqlDbType.NVarChar) { Value = (object)modal.shipmentno ?? DBNull.Value },
                new SqlParameter("@StatusId", SqlDbType.Int) { Value = modal.statusid }
            };



            obj = obj.AsQueryable();
            obj = _dbContext.v_delivery_orders_info.FromSqlRaw(sqlQuery, sqlParameters);

            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                var arrquery = obj.ToArray();
                // Apply quick search logic
                arrquery = arrquery.Where(m =>
                {
                    string searchString = $"{m.delivery_order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.customer_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.customer_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.vessel_eta != null ? m.vessel_eta.Value.ToString("dd/MM/yyyy") : "")} " +
                                          $"{m.sales_order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.internal_dept?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.promised_delivery_date != null ? m.promised_delivery_date.Value.ToString("dd/MM/yyyy") : "")} " +
                                          $"{m.status_desc?.ToString().ToUpper() ?? ""} " +
                                          $"{m.sales_person_code?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.planned_ship_date != null ? m.planned_ship_date.Value.ToString("dd/MM/yyyy") : "")} " +
                                          $"{m.dept_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.jobno?.ToString().ToUpper() ?? ""}";

                    return searchString.IndexOf(searchValue.ToUpper(), StringComparison.OrdinalIgnoreCase) > -1;
                }).ToArray();
                obj = arrquery.AsQueryable(); ;
            }

            if (modal.companyid > 0)
            {
                obj = obj.Where(x => x.companyid == modal.companyid);
            }
            if (convert.ToString(modal.shipmentdate) != "")
            {
                var shipdate = convert.ToDateTime(modal.shipmentdate, "dd/MM/yyyy").Date;
                obj = obj.Where(x => x.shipmentdate == shipdate);
            }
            if (convert.ToString(modal.dtFrom) != "" && convert.ToString(modal.dtTo) != "")
            {
                var fromdt = convert.ToDateTime(modal.dtFrom, "dd/MM/yyyy").Date;
                var todt = convert.ToDateTime(modal.dtTo, "dd/MM/yyyy").Date;
                obj = obj.Where(x => x.vessel_eta >= fromdt && x.vessel_eta <= todt);
            }
            if (modal.unassignDO)
            {
                obj = obj.Where(x => x.shipmentid == null);
            }
            if (modal.shipment14days)
            {
                var daysahead = DateTime.Now.AddDays(-14);
                var todays = DateTime.Now;
                obj = obj.Where(x => x.shipmentdate >= daysahead && x.shipmentdate <= todays);
            }
            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                if (modal.sortingorder.ToLower() == "asc")
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": obj = obj.OrderBy(x => x.order_no); break;
                        case "delivery_order_no": obj = obj.OrderBy(x => x.delivery_order_no); break;
                        case "customer_no": obj = obj.OrderBy(x => x.customer_no); break;
                        case "customer_name": obj = obj.OrderBy(x => x.customer_name); break;
                        case "vessel_eta": obj = obj.OrderBy(x => x.vessel_eta); break;
                        case "vessel_name": obj = obj.OrderBy(x => x.vessel_name); break;
                        case "jobno": obj = obj.OrderBy(x => x.jobno); break;
                        case "internal_dept": obj = obj.OrderBy(x => x.internal_dept); break;
                        case "status_desc": obj = obj.OrderBy(x => x.status_desc); break;
                        case "sales_order_no": obj = obj.OrderBy(x => x.sales_order_no); break;
                        case "sales_person_code": obj = obj.OrderBy(x => x.sales_person_code); break;
                        case "planned_ship_date": obj = obj.OrderBy(x => x.planned_ship_date); break;
                        default: obj = obj.OrderBy(x => x.shipmentid); break;
                    }
                }
                else
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": obj = obj.OrderByDescending(x => x.order_no); break;
                        case "delivery_order_no": obj = obj.OrderByDescending(x => x.delivery_order_no); break;
                        case "customer_no": obj = obj.OrderByDescending(x => x.customer_no); break;
                        case "customer_name": obj = obj.OrderByDescending(x => x.customer_name); break;
                        case "vessel_eta": obj = obj.OrderByDescending(x => x.vessel_eta); break;
                        case "vessel_name": obj = obj.OrderByDescending(x => x.vessel_name); break;
                        case "jobno": obj = obj.OrderByDescending(x => x.jobno); break;
                        case "internal_dept": obj = obj.OrderByDescending(x => x.internal_dept); break;
                        case "status_desc": obj = obj.OrderByDescending(x => x.status_desc); break;
                        case "sales_order_no": obj = obj.OrderByDescending(x => x.sales_order_no); break;
                        case "sales_person_code": obj = obj.OrderByDescending(x => x.sales_person_code); break;
                        case "planned_ship_date": obj = obj.OrderByDescending(x => x.planned_ship_date); break;
                        default: obj = obj.OrderByDescending(x => x.shipmentid); break;
                    }
                }
            }



            obj = obj.AsQueryable();
            Response.totalRecords = obj.Count();
            var lsData = new List<V_Delivery_Orders_Info>();
            if (modal.pagesize > 0)
            {
                lsData = obj.Skip(modal.skip).Take(modal.pagesize).ToList();
            }
            else
            {
                lsData = obj.ToList();
            }
            List<int?> CommonCompanies = lsData.Select(x => x.companyid).Distinct().ToList();
            var companies = _dbContextUserAdmin.les_company.Where(x => CommonCompanies.Contains(x.companyid)).ToList();
            lsData.ForEach(x =>
            {
                x.CompanyCode = companies.Where(y => y.companyid == x.companyid).FirstOrDefault().company_code ?? "";
                x.CompanyName = companies.Where(y => y.companyid == x.companyid).FirstOrDefault().company_description ?? "";
            });
            Response.data = lsData;
            Response.isSuccess = true;
            return Response;
        }

        private bool CompaireDate(Nullable<DateTime> dt1, Nullable<DateTime> dt2)
        {
            bool result = false;
            if (dt1 > dt2)
            {
                result = true;
            }
            return result;
        }

        protected List<V_Delivery_Orders_Info> Get_V_Delivery_Orders_Info_By_ShipmentId(int companyid, int ShipmentId)
        {
            List<V_Delivery_Orders_Info> obj = _dbContext.v_delivery_orders_info.Where(x => x.companyid == companyid && x.shipmentid == ShipmentId).ToList();
            return obj;
        }

        protected List<Delivery_Orders_DropDown> Get_Delivery_Orders_DropDown_By_companyIdandCustomerid(int? companyid, int? customerid)
        {
            List<Delivery_Orders_DropDown> obj = _dbContext.delivery_orders.Where(x => x.CompanyId == convert.ToInt(companyid) && x.StatusId != null && x.StatusId == convert.ToInt(Status.OPEN) && x != null && x.EndCustomerId == convert.ToInt(customerid)).Select(x => new Delivery_Orders_DropDown
            {
                delivery_order_id = x.DeliveryOrderId,
                delivery_order_no = x.DeliveryOrderNo
            }).ToList();
            return obj;
        }

        protected List<Delivery_Orders_DropDown> Get_Delivery_Orders_DropDown_By_Verification(int? companyid, int? customerid, string Jobno, string VesselName, string VesselETA)
        {
            List<V_Delivery_Orders_Info> lstdOrderInfo = _dbContext.v_delivery_orders_info.Where(x => x.end_customerid.GetValueOrDefault() == convert.ToInt(customerid)).ToList();
            lstdOrderInfo = lstdOrderInfo.Where(x => x.statusid == convert.ToInt(Status.OPEN) && convert.ToString(x.do_job_no).Trim() == convert.ToString(Jobno).Trim() && convert.ToString(x.vessel_name).Trim() == convert.ToString(VesselName).Trim() && convert.ToDateTime(x.vessel_eta).Date >= convert.ToDateTime(VesselETA, "dd/MM/yyyy").Date).ToList(); //&& convert.ToDateTime(x.vessel_eta).ToString("dd/MM/yyyy") == VesselETA
            List<Delivery_Orders_DropDown> obj = lstdOrderInfo.Select(x => new Delivery_Orders_DropDown
            {
                delivery_order_id = x.delivery_order_id,
                delivery_order_no = x.delivery_order_no
            }).ToList();
            return obj;
        }

        #endregion

        #region V_DELIVERY_ORDERS_ADDRESS_EPOD
        protected List<V_DELIVERY_ORDERS_ADDRESS_EPOD> GetAllVDeliveryOrdersAddressEpod()
        {
            return _dbContext.v_delivery_orders_address_epod.ToList();
        }

        protected V_DELIVERY_ORDERS_ADDRESS_EPOD GetVDeliveryOrdersAddressEpodById(int id)
        {
            V_DELIVERY_ORDERS_ADDRESS_EPOD obj = _dbContext.v_delivery_orders_address_epod.FirstOrDefault(x => x.deliveryorderaddressid == id);
            return obj;
        }

        protected object GetVDeliveryOrdersAddressEpodByDeliveryOrderId(int? id)
        {
            List<V_DELIVERY_ORDERS_ADDRESS_EPOD> obj = _dbContext.v_delivery_orders_address_epod.Where(x => x.deliveryorderid == id).ToList();
            if (obj.Count() == 0)
            {
                obj = null;
            }
            return obj;
        }

        #endregion

        #region V_SHIPMENT_DELIVERY_ORDERS
        protected List<V_SHIPMENT_DELIVERY_ORDERS> GetAllVShipmentDeliveryOrders()
        {
            return _dbContext.v_shipment_delivery_orders.ToList();
        }

        protected List<V_SHIPMENT_DELIVERY_ORDERS> GetVShipmentDeliveryOrdersByShipmentId(int id)
        {
            List<V_SHIPMENT_DELIVERY_ORDERS> obj = _dbContext.v_shipment_delivery_orders.Where(x => x.shipmentid == id).ToList();
            return obj;
        }

        protected List<verify_shipment_delivery_orders> GetVerifiedDOList(int shipmentid, int companyid)
        {
            List<verify_shipment_delivery_orders> obj = new List<verify_shipment_delivery_orders>();
            Shipment _shipmentData = _dbContext.shipment.FirstOrDefault(x => x.ShipmentId == shipmentid && x.CompanyId == companyid);
            if (_shipmentData != null)
            {
                List<V_SHIPMENT_DELIVERY_ORDERS> orderList = _dbContext.v_shipment_delivery_orders.Where(x => x.shipmentid == shipmentid).ToList();
                for (int i = 0; i < orderList.Count; i++)
                {
                    verify_shipment_delivery_orders _orderData = new verify_shipment_delivery_orders();
                    V_SHIPMENT_DELIVERY_ORDERS _doData = orderList[i];
                    _orderData.do_order_no = _doData.delivery_order_no;
                    _orderData.order_no = _doData.order_no;  //Shipment Order No
                    _orderData.delivery_order_id = _doData.delivery_order_id;
                    _orderData.verified = false; // setting default value as false;
                    if (_doData.do_verified_date == null)
                    {
                        _orderData.verified = false;
                    }
                    else
                    {
                        _orderData.verified = true;
                    }
                    obj.Add(_orderData);
                }
            }
            else
            {
                throw new Exception("Unable to get Shipment details.");
            }
            return obj;
        }

        protected V_SHIPMENT_DELIVERY_ORDERS GetVShipmentDeliveryOrdersByDeliveryOrderId(int? id)
        {
            V_SHIPMENT_DELIVERY_ORDERS obj = _dbContext.v_shipment_delivery_orders.FirstOrDefault(x => x.delivery_order_id == id);
            return obj;
        }

        #endregion

        #region V_DELIVERY_ORDER_LINES
        protected List<V_DELIVERY_ORDER_LINES> GetAllVDeliveryOrderLines()
        {
            return _dbContext.v_delivery_order_lines.ToList();
        }

        protected V_DELIVERY_ORDER_LINES GetVDeliveryOrderLinesByShipmentId(int id)
        {
            V_DELIVERY_ORDER_LINES obj = _dbContext.v_delivery_order_lines.Find(id);
            return obj;
        }

        protected List<V_DELIVERY_ORDER_LINES> GetVDeliveryOrderLinesByDeliveryOrderId(int? id)
        {
            List<V_DELIVERY_ORDER_LINES> obj = _dbContext.v_delivery_order_lines.Where(x => x.delivery_order_id == id).ToList();
            return obj;
        }

        protected EPODDeliveryOrderInfoLinesModal GetEPODDeliveryOrderLinesByDeliveryOrderId(int? id)
        {
            EPODDeliveryOrderInfoLinesModal _obj = new EPODDeliveryOrderInfoLinesModal();
            _obj._DOInfo = _dbContext.v_delivery_orders_info.Find(id);
            _obj._DOLines = _dbContext.v_delivery_order_lines.Where(x => x.delivery_order_id == id).ToList();
            return _obj;
        }

        protected object PushDeliveryOrders(CreateDeliveryOrderModal _details)
        {
            responseMessage _response = new responseMessage();
            try
            {
                if (_details.DeliveryOrderInfo != null && _details.DeliveryOrderLines != null && _details.DeliveryOrderLines.Count() > 0)
                {
                    int Updated = 0;
                    setlog("PushDeliveryOrders DATA : " + getSerializeData(_details));
                    les_Customers lesCustomer = Get_Customers_By_cust_code_CompanyId(_details.DeliveryOrderInfo.customer_no, convert.ToInt(_details.DeliveryOrderInfo.companyid));

                    if (lesCustomer != null)
                    {
                        if (convert.ToInt(_details.DeliveryOrderInfo.companyid) == 0)
                        {
                            throw new Exception("Unable to get valid companyid " + _details.DeliveryOrderInfo.companyid);
                        }
                        if (string.IsNullOrEmpty(_details.DeliveryOrderInfo.jobno))
                        {
                            throw new Exception("Please provide Job number for given delivery order :" + _details.DeliveryOrderInfo.delivery_order_no);
                        }
                        if (string.IsNullOrEmpty(_details.DeliveryOrderInfo.vessel_name))
                        {
                            throw new Exception("Please provide Vessel details for :" + _details.DeliveryOrderInfo.delivery_order_no);
                        }

                        var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                        executionStrategy.Execute(() =>
                        {
                            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    List<Delivery_Orders> _dupOrders = _dbContext.delivery_orders.Where(x => x.DeliveryOrderNo == _details.DeliveryOrderInfo.delivery_order_no).ToList();
                                    if (_dupOrders.Count() == 0)
                                    {
                                        Delivery_Orders _delOrder = new Delivery_Orders();
                                        _delOrder.DeliveryOrderNo = _details.DeliveryOrderInfo.delivery_order_no;
                                        _delOrder.EndCustomerId = lesCustomer.customerid;
                                        _delOrder.CompanyId = _details.DeliveryOrderInfo.companyid;
                                        _delOrder.UpdateDate = DateTime.Now;
                                        _delOrder.CreatedDate = DateTime.Now;
                                        _delOrder.StatusId = convert.ToInt(Status.OPEN);
                                        _delOrder.Exported = 0;

                                        _dbContext.delivery_orders.Add(_delOrder);
                                        Updated += _dbContext.SaveChanges();

                                        Delivery_Order_Info _delOrderInfo = new Delivery_Order_Info();
                                        _delOrderInfo.delivery_order_id = _delOrder.DeliveryOrderId;
                                        _delOrderInfo.currency_code = _details.DeliveryOrderInfo.currency_code;
                                        _delOrderInfo.customerid = lesCustomer.customerid;
                                        _delOrderInfo.customer_no = lesCustomer.cust_code;
                                        _delOrderInfo.customer_name = lesCustomer.cust_name;
                                        _delOrderInfo.sales_order_no = _details.DeliveryOrderInfo.sales_order_no;
                                        _delOrderInfo.pono = _details.DeliveryOrderInfo.pono;
                                        _delOrderInfo.do_job_no = _details.DeliveryOrderInfo.jobno;
                                        _delOrderInfo.posting_date = _details.DeliveryOrderInfo.posting_date == DateTime.MinValue ? null : _details.DeliveryOrderInfo.posting_date;
                                        _delOrderInfo.vessel_eta = _details.DeliveryOrderInfo.vessel_eta == DateTime.MinValue ? null : _details.DeliveryOrderInfo.vessel_eta;
                                        _delOrderInfo.dept_code = _details.DeliveryOrderInfo.dept_code;
                                        _delOrderInfo.promised_delivery_date = _details.DeliveryOrderInfo.promised_delivery_date == DateTime.MinValue ? null : _details.DeliveryOrderInfo.promised_delivery_date;
                                        _delOrderInfo.requested_delivery_date = _details.DeliveryOrderInfo.requested_delivery_date == DateTime.MinValue ? null : _details.DeliveryOrderInfo.requested_delivery_date;
                                        _delOrderInfo.location_code = _details.DeliveryOrderInfo.location_code;
                                        _delOrderInfo.mark_reference_no = _details.DeliveryOrderInfo.mark_reference_no;
                                        _delOrderInfo.sales_person_code = _details.DeliveryOrderInfo.sales_person_code;
                                        _delOrderInfo.quote_no = _details.DeliveryOrderInfo.quote_no;
                                        _delOrderInfo.packaging_unit_no = _details.DeliveryOrderInfo.packaging_unit_no;
                                        _delOrderInfo.internal_dept = _details.DeliveryOrderInfo.internal_dept;
                                        _delOrderInfo.shipmentdate = _details.DeliveryOrderInfo.shipmentdate == DateTime.MinValue ? null : _details.DeliveryOrderInfo.shipmentdate;
                                        _delOrderInfo.plannedshipmentdate = _details.DeliveryOrderInfo.plannedshipmentdate == DateTime.MinValue ? null : _details.DeliveryOrderInfo.plannedshipmentdate;
                                        _delOrderInfo.planneddeliverydate = _details.DeliveryOrderInfo.planneddeliverydate == DateTime.MinValue ? null : _details.DeliveryOrderInfo.planneddeliverydate;

                                        if (_details.DeliveryOrderInfo.vessel_name != "" || _details.DeliveryOrderInfo.vessel_code != "")
                                        {
                                            Mast_Vessel _vesselInfo = _dbContext.mast_vessel.FirstOrDefault(x => x.VesselName == _details.DeliveryOrderInfo.vessel_name);
                                            if (_vesselInfo == null && _details.DeliveryOrderInfo.vessel_code != null && _details.DeliveryOrderInfo.vessel_code != "")
                                            {
                                                _vesselInfo = _dbContext.mast_vessel.FirstOrDefault(x => x.VesselCode == _details.DeliveryOrderInfo.vessel_code);
                                            }
                                            if (_vesselInfo != null)
                                            {
                                                _delOrderInfo.vessel_id = convert.ToInt(_vesselInfo.VesselId);
                                            }
                                            else
                                            {
                                                if (_details.DeliveryOrderInfo.vessel_name != "" || _details.DeliveryOrderInfo.vessel_code != "")
                                                {
                                                    Mast_Vessel _vesselData = new Mast_Vessel();
                                                    _vesselData.VesselName = _details.DeliveryOrderInfo.vessel_name;
                                                    _vesselData.VesselCode = _details.DeliveryOrderInfo.vessel_code;
                                                    _vesselData.CreatedDate = DateTime.Now;
                                                    _vesselData.UpdatedDate = DateTime.Now;
                                                    _dbContext.mast_vessel.Add(_vesselData);
                                                    Updated += _dbContext.SaveChanges();

                                                    _delOrderInfo.vessel_id = convert.ToInt(_vesselData.VesselId);

                                                }
                                                else
                                                {
                                                    throw new Exception("Unable to get vessel info.");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get vessel info.");
                                        }

                                        _delOrderInfo.promised_delivery_date = _details.DeliveryOrderInfo.promised_delivery_date == DateTime.MinValue ? null : _details.DeliveryOrderInfo.promised_delivery_date;
                                        _delOrderInfo.location_code = _details.DeliveryOrderInfo.location_code;
                                        _delOrderInfo.requested_delivery_date = _details.DeliveryOrderInfo.requested_delivery_date == DateTime.MinValue ? null : _details.DeliveryOrderInfo.requested_delivery_date;

                                        _dbContext.delivery_order_info.Add(_delOrderInfo);
                                        Updated += _dbContext.SaveChanges();

                                        Delivery_Orders_Address _deliverOrderAddr = new Delivery_Orders_Address();
                                        _deliverOrderAddr.deliveryorderid = _delOrder.DeliveryOrderId;

                                        _dbContext.Delivery_Orders_Address.Add(_deliverOrderAddr);
                                        Updated += _dbContext.SaveChanges();


                                        if (_details.DeliveryOrderLines != null && _details.DeliveryOrderLines.Count() > 0)
                                        {
                                            for (int i = 0; i < _details.DeliveryOrderLines.Count(); i++)
                                            {
                                                Delivery_Order_Lines _delOrderLines = new Delivery_Order_Lines();
                                                _delOrderLines.DeliveryOrderId = _delOrder.DeliveryOrderId;
                                                _delOrderLines.ItemDescription = _details.DeliveryOrderLines[i].item_description;
                                                _delOrderLines.ItemRefNo = _details.DeliveryOrderLines[i].item_ref_no;
                                                _delOrderLines.ItemNo = _details.DeliveryOrderLines[i].item_no;
                                                _delOrderLines.Quantity = _details.DeliveryOrderLines[i].quantity;
                                                _delOrderLines.QuantityInvoiced = _details.DeliveryOrderLines[i].quantity_invoiced;
                                                _delOrderLines.Uom = _details.DeliveryOrderLines[i].uom;

                                                _dbContext.delivery_order_lines.Add(_delOrderLines);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get DeliveryOrderLines");
                                        }
                                        if (Updated > 0)
                                        {
                                            dbContextTransaction.Commit();
                                            _response.data = _delOrder;
                                            _response.status = "SUCCESS";
                                            _response.isSuccess = true;
                                            _response.message = "Delivery Order with order no : " + _details.DeliveryOrderInfo.delivery_order_no + " created successfully.";
                                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order with order no : " + _details.DeliveryOrderInfo.delivery_order_no + " created successfully.", "", "", "", "");

                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to create delivery order as Delivery Order No :'" + _details.DeliveryOrderInfo.delivery_order_no + "' already exist.");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    dbContextTransaction.Rollback();
                                    setlog("Error while pushing DeliveryOrders : " + ex.Message);
                                    throw ex;
                                }
                            }
                        });
                    }
                    else
                    {
                        throw new Exception("Unable to get Customer details.");
                    }
                }
                else
                {
                    throw new Exception("Invalid Deliveryorder details.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while pushing DeliveryOrders : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while pushing Delivery Orders : " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object UpdateEpodDeliveryOrderLines(Update_EPOD_DeliveryOrderItems lstItemDetails)
        {
            responseMessage _response = new responseMessage();
            try
            {
                if (convert.ToInt(lstItemDetails.DeliveryOrderId) > 0 && convert.ToInt(lstItemDetails.ShipmentId) > 0 && convert.ToInt(lstItemDetails.EPOD_ItemDetails.Count()) > 0)
                {
                    int Updated = 0;
                    setlog("UpdateEpodDeliveryOrderLines DATA : " + getSerializeData(lstItemDetails));
                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                Shipment shipment = _dbContext.shipment.Find(lstItemDetails.ShipmentId);
                                if (shipment != null)
                                {
                                    Delivery_Orders _delOrderExt = _dbContext.delivery_orders.FirstOrDefault(x => x.DeliveryOrderId == convert.ToInt(lstItemDetails.DeliveryOrderId) && x.ShipmentId == lstItemDetails.ShipmentId && x.CompanyId == shipment.CompanyId);
                                    Delivery_Orders _delOrder = _delOrderExt;
                                    if (_delOrder != null)
                                    {
                                        _delOrder.UpdateDate = DateTime.Now;
                                        _delOrder.updated_by = lstItemDetails.UpdatedBy;
                                        _dbContext.Entry(_delOrderExt).CurrentValues.SetValues(_delOrder);
                                        Updated += _dbContext.SaveChanges();
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get Delivery_Orders");
                                    }
                                    Delivery_Order_Info _delOrderInfoExt = _dbContext.delivery_order_info.FirstOrDefault(x => x.delivery_order_id == convert.ToInt(lstItemDetails.DeliveryOrderId));
                                    Delivery_Order_Info _delOrderInfo = _delOrderInfoExt;
                                    if (_delOrderInfo != null)
                                    {
                                        _delOrderInfo.good_return_remarks = lstItemDetails.GoodsReturnRemarks;
                                        _delOrderInfo.do_verified_date = DateTime.Now;
                                        _dbContext.Entry(_delOrderInfoExt).CurrentValues.SetValues(_delOrderInfo);
                                        Updated += _dbContext.SaveChanges();
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get Delivery_Order_Info");
                                    }
                                    foreach (EPODItemListField _item in lstItemDetails.EPOD_ItemDetails)
                                    {
                                        Delivery_Order_Lines _delivOrderLineExt = _dbContext.delivery_order_lines.Where(x => x.DeliveryOrderLinesId == _item.DeliveryOrderLinesId && x.DeliveryOrderId == _delOrderExt.DeliveryOrderId).FirstOrDefault();
                                        Delivery_Order_Lines _delivOrderLine = _delivOrderLineExt;

                                        if (_delivOrderLineExt != null)
                                        {
                                            _delivOrderLine.QuantityInvoiced = _item.QuantityInvoiced;
                                            _delivOrderLine.UpdatedBy = lstItemDetails.UpdatedBy;
                                            _delivOrderLine.UpdatedDate = DateTime.Now;
                                            if (convert.ToInt(_delivOrderLine.Quantity) != convert.ToInt(_item.QuantityInvoiced))
                                            {
                                                if (convert.ToInt(_item.GrnReasonId) == 0)
                                                {
                                                    throw new Exception("Unable to get GrnReason for item no " + _delivOrderLine.ItemNo);
                                                }
                                                else
                                                {
                                                    _delivOrderLine.GrnReasonId = _item.GrnReasonId;
                                                }
                                            }
                                            else
                                            {
                                                _item.GrnReasonId = null;
                                            }
                                            _delivOrderLine.QuantityInvoiced = _item.QuantityInvoiced;

                                            _delivOrderLine.EPOD_LINE_REMARKS = _item.Epod_line_remarks;
                                            _dbContext.Entry(_delivOrderLineExt).CurrentValues.SetValues(_delivOrderLine);
                                            Updated += _dbContext.SaveChanges();
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Delivery_Order_Lines");
                                        }
                                    }
                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _delOrder;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Delivery Order Lines with order no : " + _delOrder.DeliveryOrderNo + " updated successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order Lines with order no : " + _delOrder.DeliveryOrderNo + " updated successfully.", "", "", "", "");

                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get shipment details.");
                                }
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                setlog("Error while pushing UpdateEpodDeliveryOrderLines : " + ex.Message);
                                throw ex;
                            }
                        }
                    });
                }
                else
                {
                    throw new Exception("Invalid Delivery order details.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while Update EPOD DeliveryOrderLines : " + ex.Message + " Stack trace :" + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while Update EPOD Delivery OrderLines : " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        #endregion

        #region SHIPMENT
        protected object CreateOutboundShipment(CreateShipmentOrderModal _details)
        {
            responseMessage _response = new responseMessage();
            int isAuto = -1;
            try
            {
                if (_details.shipment_Info != null)
                {
                    int Updated = 0;
                    setlog("CreateOutboundShipment DATA : " + getSerializeData(_details));
                    if (convert.ToInt(_details.shipment_Info.companyid) == 0)
                    {
                        throw new Exception("Company Id not found");
                    }
                    if (convert.ToInt(_details.shipment_Info.receiverid) == 0)
                    {
                        throw new Exception("Please select Customer");
                    }

                    les_Customers lesCustomer = _dbContext.les_customers.Find(_details.shipment_Info.receiverid);
                    List<Mast_SITE_CONFIG> lstSiteConfig = _dbContext.mast_site_config.Where(x => x.moduleid == 1 && x.companyid == _details.shipment_Info.companyid).ToList();

                    string cAutoParamVal = "", ShipmentNo = "";
                    var AutoSiteParamDet = lstSiteConfig.Where(x => x.siteconfig_paramid == 1004).FirstOrDefault();
                    if (AutoSiteParamDet != null)
                    {
                        cAutoParamVal = AutoSiteParamDet.param_value.ToUpper();
                    }

                    if (lesCustomer != null)
                    {
                        var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                        executionStrategy.Execute(() =>
                        {
                            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    if (cAutoParamVal == "MANUAL")
                                    {
                                        var cInternalNo_Present = _dbContext.shipment.Where(x => x.CompanyId == _details.shipment_Info.companyid && x.OrderNo == _details.shipment_Info.order_no).FirstOrDefault();
                                        if (cInternalNo_Present == null)
                                        {
                                            ShipmentNo = _details.shipment_Info.order_no;
                                            isAuto = 0;
                                        }
                                        else throw new Exception("Shipment No. " + _details.shipment_Info.order_no + " is already present.");
                                    }
                                    else
                                    {
                                        int counter = 0;
                                        ShipmentNo = GetLatestShipmentOrderNo(convert.ToInt(_details.shipment_Info.companyid));
                                        var cInternalNo_Present = _dbContext.shipment.Where(x => x.CompanyId == _details.shipment_Info.companyid && x.OrderNo == ShipmentNo).FirstOrDefault();
                                        while (cInternalNo_Present != null && counter < 5)
                                        {
                                            ShipmentNo = GetLatestShipmentOrderNo(convert.ToInt(_details.shipment_Info.companyid));
                                            cInternalNo_Present = _dbContext.shipment.Where(x => x.CompanyId == _details.shipment_Info.companyid && x.OrderNo == ShipmentNo).FirstOrDefault();
                                            counter++;
                                        }
                                        if (cInternalNo_Present == null)
                                        {
                                            isAuto = 1;
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to created new Shipment no.");
                                        }
                                    }

                                    Shipment _shipment = new Shipment();
                                    if (convert.ToInt(_details.shipment_Info.receiverid) > 0)
                                    {
                                        _shipment.ReceiverId = _details.shipment_Info.receiverid;
                                    }
                                    else
                                    {
                                        les_Customers _customer = Get_Customers_By_cust_code_CompanyId(_details.shipment_Info.cust_code, convert.ToInt(_details.shipment_Info.companyid));
                                        if (_customer != null)
                                        {
                                            _shipment.ReceiverId = _customer.customerid;
                                        }

                                        else
                                        {
                                            throw new Exception("Unable to get Customer details.");
                                        }
                                    }
                                    _shipment.ShipmentNotes = _details.shipment_Info.shipment_notes;
                                    if (convert.ToString(ShipmentNo) == "")
                                    {
                                        throw new Exception("Unable to get Shipment Order No.");
                                    }
                                    _shipment.OrderNo = ShipmentNo;
                                    _shipment.CompanyId = _details.shipment_Info.companyid;
                                    _shipment.IsAuto = isAuto;
                                    if (convert.ToString(_details.shipment_Info.jobno) == "")
                                    {
                                        throw new Exception("Please enter Job No.");
                                    }
                                    _shipment.JobNo = _details.shipment_Info.jobno.Trim() == string.Empty ? throw new Exception("Please enter Job No.") : _details.shipment_Info.jobno;
                                    _shipment.ShipmentStatusId = convert.ToInt(Status.NEW); // default New status
                                    _shipment.UpdatedDate = DateTime.Now;
                                    _shipment.CreatedDate = DateTime.Now;
                                    _shipment.CreatedBy = _details.createdBy;
                                    _shipment.UpdatedBy = _details.createdBy;

                                    _shipment.PlannedDeliveryDate = convert.ToDateTime(_details.shipment_Info.planned_delivery_date, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.planned_delivery_date, "dd/MM/yyyy HH:mm");
                                    _shipment.PlannedShipDate = convert.ToDateTime(_details.shipment_Info.planned_ship_date, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.planned_ship_date, "dd/MM/yyyy HH:mm");

                                    _dbContext.shipment.Add(_shipment);
                                    Updated += _dbContext.SaveChanges();

                                    Shipment_Vessel_Info _shipmentVslInfo = new Shipment_Vessel_Info();
                                    _shipmentVslInfo.ShipmentId = _shipment.ShipmentId;
                                    _shipmentVslInfo.Agent = _details.shipment_Info.agent;
                                    _shipmentVslInfo.AgentContactPerson = _details.shipment_Info.agent_contact_person;
                                    _shipmentVslInfo.AgentContactNo = _details.shipment_Info.agent_contact_no;
                                    _shipmentVslInfo.AnchorageId = convert.ToInt(_details.shipment_Info.anchorage_id) == 0 ? null : _details.shipment_Info.anchorage_id;
                                    _shipmentVslInfo.CreatedDate = DateTime.Now;
                                    _shipmentVslInfo.UpdatedDate = DateTime.Now;
                                    _shipmentVslInfo.CreatedBy = _details.createdBy;
                                    _shipmentVslInfo.UpdatedBy = _details.createdBy;
                                    _shipmentVslInfo.VesselId = convert.ToInt(_details.shipment_Info.vessel_id) == 0 ? throw new Exception("Please enter Vessel Name.") : convert.ToInt(_details.shipment_Info.vessel_id);
                                    _shipmentVslInfo.DeliveryDate = convert.ToDateTime(_details.shipment_Info.delivery_date, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? throw new Exception("Please enter Delivery Date.") : convert.ToDateTime(_details.shipment_Info.delivery_date, "dd/MM/yyyy HH:mm");
                                    _shipmentVslInfo.CoParty = _details.shipment_Info.co_party;
                                    _shipmentVslInfo.SupplyBoat = _details.shipment_Info.supply_boat;
                                    _shipmentVslInfo.SupplyBoatContactNo = _details.shipment_Info.supply_boat_contact_no;
                                    _shipmentVslInfo.SupplyBoatContactPerson = _details.shipment_Info.supply_boat_contact_person;
                                    _shipmentVslInfo.VesselAta = convert.ToDateTime(_details.shipment_Info.vessel_ata, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.vessel_ata, "dd/MM/yyyy HH:mm");
                                    _shipmentVslInfo.VesselEta = convert.ToDateTime(_details.shipment_Info.vessel_eta, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? throw new Exception("Please enter Vessel ETA date") : convert.ToDateTime(_details.shipment_Info.vessel_eta, "dd/MM/yyyy HH:mm");
                                    _shipmentVslInfo.LoadingPoint = _details.shipment_Info.loading_point;
                                    _shipmentVslInfo.LoadingTime = convert.ToDateTime(_details.shipment_Info.loading_time, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.loading_time, "dd/MM/yyyy HH:mm");

                                    _dbContext.shipment_vessel_info.Add(_shipmentVslInfo);
                                    Updated += _dbContext.SaveChanges();


                                    Vehicle_Trip_Planning vehicle_Trip_Planning = new Vehicle_Trip_Planning();
                                    vehicle_Trip_Planning.shipmentid = _shipment.ShipmentId;
                                    vehicle_Trip_Planning.statusid = convert.ToInt(Status.DRAFT);
                                    _dbContext.Vehicle_Trip_Planning.Add(vehicle_Trip_Planning);
                                    Updated += _dbContext.SaveChanges();

                                    Vehicle_Trip_Details vehicle_Trip_Details = new Vehicle_Trip_Details();
                                    vehicle_Trip_Details.tripid = vehicle_Trip_Planning.tripid;
                                    vehicle_Trip_Details.estimate_packaging_unit = _details.shipment_trip_plan.estimate_packaging_unit;
                                    vehicle_Trip_Details.location_from = _details.shipment_trip_plan.location_from;
                                    vehicle_Trip_Details.location_to = _details.shipment_trip_plan.location_to;
                                    vehicle_Trip_Details.actual_delivery_start = convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_start, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_start, "dd/MM/yyyy");
                                    vehicle_Trip_Details.actual_delivery_end = convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_end, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_end, "dd/MM/yyyy");
                                    vehicle_Trip_Details.boarding_officer_name = _details.shipment_trip_plan.boarding_officer_name.Trim() == string.Empty ? null : _details.shipment_trip_plan.boarding_officer_name.Trim();
                                    vehicle_Trip_Details.transport_company = _details.shipment_trip_plan.transport_company;
                                    vehicle_Trip_Details.statusid = convert.ToInt(Status.DRAFT);
                                    vehicle_Trip_Details.ctm = _details.shipment_trip_plan.ctm;
                                    vehicle_Trip_Details.transport_type_id = convert.ToInt(_details.shipment_trip_plan.transport_type_id) == 0 ? null : convert.ToInt(_details.shipment_trip_plan.transport_type_id);

                                    _dbContext.Vehicle_Trip_Details.Add(vehicle_Trip_Details);
                                    Updated += _dbContext.SaveChanges();

                                    Driver_Allocation _driver_allocations = new Driver_Allocation();
                                    _driver_allocations.driver_name = _details.shipment_trip_plan.driver_name.Trim() == string.Empty ? null : _details.shipment_trip_plan.driver_name.Trim();
                                    _driver_allocations.driver_code = _details.shipment_trip_plan.driver_code == string.Empty ? null : _details.shipment_trip_plan.driver_code.Trim();
                                    _driver_allocations.vehicle_no = _details.shipment_trip_plan.vehicle_no == string.Empty ? null : _details.shipment_trip_plan.vehicle_no.Trim();
                                    _driver_allocations.driver_contact_no = _details.shipment_trip_plan.driver_contact_no;
                                    _driver_allocations.planned_from = convert.ToDateTime(_details.shipment_trip_plan.planned_from, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.planned_from, "dd/MM/yyyy");
                                    _driver_allocations.planned_to = convert.ToDateTime(_details.shipment_trip_plan.planned_to, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.planned_to, "dd/MM/yyyy");
                                    _driver_allocations.outsourced_contact_no = _details.shipment_trip_plan.outsourced_contact_no;
                                    _driver_allocations.outsourced_contact_person = _details.shipment_trip_plan.outsourced_contact_person;
                                    _driver_allocations.outsourced_vehicle_no = _details.shipment_trip_plan.outsourced_vehicle_no;
                                    _driver_allocations.allowance_amt = _details.shipment_trip_plan.allowance_amt;
                                    _driver_allocations.shipmentid = _shipment.ShipmentId;
                                    _driver_allocations.tripdetailid = vehicle_Trip_Details.tripdetailid;
                                    _driver_allocations.tripid = vehicle_Trip_Planning.tripid;

                                    _dbContext.driver_allocation.Add(_driver_allocations);
                                    Updated += _dbContext.SaveChanges();

                                    if (_details.shipment_document != null && _details.shipment_document.Count > 0)
                                    {
                                        foreach (Shipment_Documents _shipDoc in _details.shipment_document)
                                        {
                                            Shipment_Documents _shipmentDocument = new Shipment_Documents();
                                            _shipmentDocument.ShipmentId = _shipment.ShipmentId;
                                            _shipmentDocument.DocumentName = _shipDoc.DocumentName;
                                            _shipmentDocument.DocumentNo = _shipDoc.DocumentNo;
                                            _shipmentDocument.DocumentPath = _shipDoc.DocumentPath;
                                            _shipmentDocument.DocumentTitle = _shipDoc.DocumentTitle;
                                            _shipmentDocument.CreatedBy = _details.createdBy;
                                            _shipmentDocument.UpdatedBy = _details.createdBy;
                                            _shipmentDocument.CreatedDate = DateTime.Now;
                                            _shipmentDocument.UpdatedDate = DateTime.Now;
                                            _shipmentDocument.DocumentType = _shipDoc.DocumentType;

                                            _dbContext.shipment_documents.Add(_shipmentDocument);
                                            Updated += _dbContext.SaveChanges();
                                        }
                                    }

                                    if (_details.deliveryOrderIds.Count() > 0)
                                    {
                                        _shipment.ShipmentStatusId = convert.ToInt(Status.DRAFT);   // Setting DRAFT status as Shipment is attached with DO
                                        _shipment.UpdatedDate = DateTime.Now;
                                        _dbContext.Entry(_shipment).CurrentValues.SetValues(_shipment);
                                        Updated += _dbContext.SaveChanges();

                                        for (int i = 0; i < _details.deliveryOrderIds.Count(); i++)
                                        {
                                            Delivery_Orders _dOrder = _dbContext.delivery_orders.Find(_details.deliveryOrderIds[i]);
                                            if (_dOrder.StatusId == convert.ToInt(Status.OPEN) && _dOrder.CompanyId == _details.shipment_Info.companyid && _dOrder.EndCustomerId == _shipment.ReceiverId)
                                            {
                                                Delivery_Orders _dOrderExt = _dOrder;
                                                _dOrder.ShipmentId = _shipment.ShipmentId;
                                                _dOrder.StatusId = convert.ToInt(Status.CONFIRMED); // setting release status 
                                                _dOrder.UpdateDate = DateTime.Now;
                                                _dOrder.updated_by = _details.createdBy;

                                                _dbContext.Entry(_dOrderExt).CurrentValues.SetValues(_dOrder);
                                                Updated += _dbContext.SaveChanges();

                                            }
                                            else
                                            {
                                                string msg = "";
                                                if (_dOrder.StatusId != convert.ToInt(Status.OPEN))
                                                {
                                                    msg += "Delivery Order status is not Open" + Environment.NewLine;
                                                }
                                                if (_dOrder.CompanyId != _details.shipment_Info.companyid)
                                                {
                                                    msg += "Delivery Order company does not match with Shipment" + Environment.NewLine;
                                                }
                                                if (_dOrder.EndCustomerId != _shipment.ReceiverId)
                                                {
                                                    msg += "Delivery Order Customer does not match with Shipment Customer" + Environment.NewLine;
                                                }
                                                throw new Exception(msg);
                                            }
                                        }
                                    }

                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipment;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Shipment with order no : " + ShipmentNo + " created successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + ShipmentNo + " created successfully.", "", "", "", "");

                                    }
                                }
                                catch (Exception ex)
                                {
                                    dbContextTransaction.Rollback();
                                    setlog("Error while pushing Shipment : " + ex.Message);
                                    throw ex;
                                }
                            }
                        });
                    }
                    else
                    {
                        throw new Exception("Unable to get Customer details.");
                    }
                }
                else
                {
                    throw new Exception("Unable to get Customer details.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while creating Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while creating Shipment: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object UpdateOutboundShipment(UpdateShipmentOrderModal _details)
        {
            responseMessage _response = new responseMessage();
            int isAuto = -1;
            bool isUnassignStatus = false;
            try
            {
                if (_details.shipment_Info != null)
                {
                    int Updated = 0;
                    setlog("UpdateOutboundShipment DATA : " + getSerializeData(_details));
                    if (convert.ToInt(_details.shipment_Info.companyid) == 0)
                    {
                        throw new Exception("Company not found");
                    }
                    if (convert.ToInt(_details.shipment_Info.receiverid) == 0)
                    {
                        throw new Exception("ReceiverId not found");
                    }
                    les_Customers lesCustomer = _dbContext.les_customers.Find(_details.shipment_Info.receiverid);
                    if (lesCustomer != null)
                    {
                        var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                        executionStrategy.Execute(() =>
                        {
                            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                            {
                                try
                                {
                                    Shipment _shipmentExt = _dbContext.shipment.Find(_details.shipment_Info.shipmentid);
                                    Shipment _shipment = _shipmentExt;
                                    List<Delivery_Orders> _delOrders = _dbContext.delivery_orders.Where(x => x.ShipmentId == _details.shipment_Info.shipmentid).ToList();
                                    if (_shipment != null)
                                    {
                                        _shipment.ShipmentNotes = _details.shipment_Info.shipment_notes;
                                        if (!(convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.NEW) || convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.DRAFT) || convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.CANCELLED) || convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.READYTOSHIP)))
                                        {
                                            throw new Exception("Invalid Status");
                                        }
                                        if (!(convert.ToInt(_shipmentExt.ShipmentStatusId) == convert.ToInt(Status.NEW) || convert.ToInt(_shipmentExt.ShipmentStatusId) == convert.ToInt(Status.DRAFT) || convert.ToInt(_shipmentExt.ShipmentStatusId) == convert.ToInt(Status.OPEN) || convert.ToInt(_shipmentExt.ShipmentStatusId) == convert.ToInt(Status.READYTOSHIP)))
                                        {
                                            throw new Exception("Unable to Update as Shipment is not in Valid Status");
                                        }
                                        if (_shipment.CompanyId != _details.shipment_Info.companyid)
                                        {
                                            throw new Exception("Invalid Company provided");
                                        }
                                        if (convert.ToInt(_details.shipment_Info.receiverid) > 0 && _shipment.ReceiverId != _details.shipment_Info.receiverid)
                                        {
                                            if (convert.ToInt(_delOrders.Count) == 0)
                                            {
                                                _shipment.ReceiverId = _details.shipment_Info.receiverid;
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to update Customer details as DO already assigned.");
                                            }
                                        }
                                        if (_shipment.ShipmentStatusId == convert.ToInt(Status.READYTOSHIP) && convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.DRAFT))
                                        {
                                            isUnassignStatus = true;
                                        }
                                        _shipment.CompanyId = _details.shipment_Info.companyid;
                                        _shipment.IsAuto = isAuto;
                                        if (_details.shipment_Info.jobno == "" || _details.shipment_Info.jobno == null)
                                        {
                                            throw new Exception("Please enter Job no.");
                                        }
                                        _shipment.JobNo = _details.shipment_Info.jobno.Trim() == string.Empty ? throw new Exception("Please enter Job no.") : _details.shipment_Info.jobno.Trim();
                                        _shipment.ShipmentStatusId = _details.shipment_Info.shipment_statusid; // Draft
                                        _shipment.UpdatedDate = DateTime.Now;
                                        _shipment.UpdatedBy = _details.updatedBy;
                                        _shipment.PlannedDeliveryDate = convert.ToDateTime(_details.shipment_Info.planned_delivery_date, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.planned_delivery_date, "dd/MM/yyyy HH:mm");
                                        _shipment.PlannedShipDate = convert.ToDateTime(_details.shipment_Info.planned_ship_date, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.planned_ship_date, "dd/MM/yyyy HH:mm");

                                        _shipment.UpdatedDate = DateTime.Now;

                                        _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                        Updated += _dbContext.SaveChanges();
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get Shipment details");
                                    }

                                    Shipment_Vessel_Info _shipmentVslInfoExt = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == _details.shipment_Info.shipmentid);
                                    Shipment_Vessel_Info _shipmentVslInfo = _shipmentVslInfoExt;
                                    if (_shipmentVslInfo != null)
                                    {
                                        _shipmentVslInfo.ShipmentId = _shipment.ShipmentId;
                                        _shipmentVslInfo.Agent = _details.shipment_Info.agent;
                                        _shipmentVslInfo.AgentContactPerson = _details.shipment_Info.agent_contact_person;
                                        _shipmentVslInfo.AgentContactNo = _details.shipment_Info.agent_contact_no;
                                        _shipmentVslInfo.AnchorageId = _details.shipment_Info.anchorage_id;
                                        _shipmentVslInfo.UpdatedDate = DateTime.Now;
                                        _shipmentVslInfo.UpdatedBy = _details.updatedBy;
                                        _shipmentVslInfo.CoParty = _details.shipment_Info.co_party;
                                        _shipmentVslInfo.VesselId = convert.ToInt(_details.shipment_Info.vessel_id) == 0 ? throw new Exception("Please enter Vessel Name.") : convert.ToInt(_details.shipment_Info.vessel_id);
                                        _shipmentVslInfo.DeliveryDate = convert.ToDateTime(_details.shipment_Info.delivery_date, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? throw new Exception("Please enter Delivery Date.") : convert.ToDateTime(_details.shipment_Info.delivery_date, "dd/MM/yyyy HH:mm");
                                        _shipmentVslInfo.SupplyBoat = _details.shipment_Info.supply_boat;
                                        _shipmentVslInfo.SupplyBoatContactNo = _details.shipment_Info.supply_boat_contact_no;
                                        _shipmentVslInfo.SupplyBoatContactPerson = _details.shipment_Info.supply_boat_contact_person;
                                        _shipmentVslInfo.VesselAta = convert.ToDateTime(_details.shipment_Info.vessel_ata, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.vessel_ata, "dd/MM/yyyy HH:mm");
                                        _shipmentVslInfo.VesselEta = convert.ToDateTime(_details.shipment_Info.vessel_eta, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? throw new Exception("Please enter Vessel ETA Date.") : convert.ToDateTime(_details.shipment_Info.vessel_eta, "dd/MM/yyyy HH:mm");
                                        _shipmentVslInfo.LoadingPoint = _details.shipment_Info.loading_point;
                                        _shipmentVslInfo.LoadingTime = convert.ToDateTime(_details.shipment_Info.loading_time, "dd/MM/yyyy HH:mm") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_Info.loading_time, "dd/MM/yyyy HH:mm");

                                        _shipmentVslInfo.UpdatedDate = DateTime.Now;
                                        _dbContext.Entry(_shipmentVslInfoExt).CurrentValues.SetValues(_shipmentVslInfo);
                                        Updated += _dbContext.SaveChanges();
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get Shipment_Vessel_Info details");
                                    }

                                    Driver_Allocation _driver_allocationsExt = _dbContext.driver_allocation.FirstOrDefault(x => x.shipmentid == _details.shipment_Info.shipmentid);
                                    Driver_Allocation _driver_allocations = _driver_allocationsExt;
                                    if (_driver_allocations != null)
                                    {
                                        _driver_allocations.driver_name = convert.ToString(_details.shipment_trip_plan.driver_name).Trim() == string.Empty ? null : _details.shipment_trip_plan.driver_name.Trim();
                                        _driver_allocations.driver_code = convert.ToString(_details.shipment_trip_plan.driver_code).Trim() == string.Empty ? null : _details.shipment_trip_plan.driver_code.Trim();
                                        _driver_allocations.vehicle_no = convert.ToString(_details.shipment_trip_plan.vehicle_no).Trim() == string.Empty ? null : _details.shipment_trip_plan.vehicle_no.Trim(); ;
                                        _driver_allocations.driver_contact_no = _details.shipment_trip_plan.driver_contact_no;
                                        _driver_allocations.planned_from = convert.ToDateTime(_details.shipment_trip_plan.planned_from, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.planned_from, "dd/MM/yyyy");
                                        _driver_allocations.planned_to = convert.ToDateTime(_details.shipment_trip_plan.planned_to, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.planned_to, "dd/MM/yyyy");
                                        _driver_allocations.outsourced_contact_no = _details.shipment_trip_plan.outsourced_contact_no;
                                        _driver_allocations.outsourced_contact_person = _details.shipment_trip_plan.outsourced_contact_person;
                                        _driver_allocations.outsourced_vehicle_no = _details.shipment_trip_plan.outsourced_vehicle_no;
                                        _driver_allocations.allowance_amt = _details.shipment_trip_plan.allowance_amt;
                                        _driver_allocations.allowance_amt = _details.shipment_trip_plan.allowance_amt;
                                        _driver_allocations.shipmentid = _shipment.ShipmentId;
                                        _driver_allocations.updated_date = DateTime.Now;

                                        if (_details.shipment_Info.shipment_statusid == convert.ToInt(Status.READYTOSHIP))
                                        {
                                            if (convert.ToString(_driver_allocations.driver_name).Trim() == string.Empty) throw new Exception("Please enter Driver Name.");
                                            if (convert.ToString(_driver_allocations.driver_code).Trim() == string.Empty) throw new Exception("Please enter Driver Code.");
                                            if (convert.ToString(_driver_allocations.vehicle_no).Trim() == string.Empty) throw new Exception("Please enter Truck/vehicle no.");

                                        }

                                        _dbContext.Entry(_driver_allocationsExt).CurrentValues.SetValues(_driver_allocations);
                                        Updated += _dbContext.SaveChanges();
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get Driver_Allocation details");
                                    }

                                    Vehicle_Trip_Planning vehicle_Trip_PlanningEXT = _dbContext.Vehicle_Trip_Planning.FirstOrDefault(x => x.shipmentid == _details.shipment_Info.shipmentid);
                                    Vehicle_Trip_Planning vehicle_Trip_Planning = vehicle_Trip_PlanningEXT;
                                    if (vehicle_Trip_Planning != null)
                                    {
                                        vehicle_Trip_Planning.statusid = convert.ToInt(_shipmentExt.ShipmentStatusId);
                                        vehicle_Trip_Planning.updated_date = DateTime.Now;
                                        _dbContext.Entry(vehicle_Trip_PlanningEXT).CurrentValues.SetValues(vehicle_Trip_Planning);
                                        Updated += _dbContext.SaveChanges();

                                        Vehicle_Trip_Details vehicle_Trip_DetailsExt = _dbContext.Vehicle_Trip_Details.FirstOrDefault(x => x.tripid == vehicle_Trip_Planning.tripid);
                                        Vehicle_Trip_Details vehicle_Trip_Details = vehicle_Trip_DetailsExt;
                                        if (vehicle_Trip_Details != null)
                                        {
                                            vehicle_Trip_Details.estimate_packaging_unit = _details.shipment_trip_plan.estimate_packaging_unit;
                                            vehicle_Trip_Details.location_from = _details.shipment_trip_plan.location_from;
                                            vehicle_Trip_Details.location_to = _details.shipment_trip_plan.location_to;
                                            vehicle_Trip_Details.actual_delivery_start = convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_start, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_start, "dd/MM/yyyy");
                                            vehicle_Trip_Details.actual_delivery_end = convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_end, "dd/MM/yyyy") == DateTime.MinValue ? null : convert.ToDateTime(_details.shipment_trip_plan.actual_delivery_end, "dd/MM/yyyy");
                                            vehicle_Trip_Details.boarding_officer_name = _details.shipment_trip_plan.boarding_officer_name.Trim() == string.Empty ? null : _details.shipment_trip_plan.boarding_officer_name.Trim();
                                            vehicle_Trip_Details.transport_company = _details.shipment_trip_plan.transport_company;
                                            vehicle_Trip_Details.ctm = _details.shipment_trip_plan.ctm;
                                            vehicle_Trip_Details.transport_type_id = convert.ToInt(_details.shipment_trip_plan.transport_type_id) == 0 ? null : convert.ToInt(_details.shipment_trip_plan.transport_type_id);
                                            vehicle_Trip_Details.updated_date = DateTime.Now;
                                            vehicle_Trip_Details.statusid = convert.ToInt(_shipmentExt.ShipmentStatusId);

                                            if (_details.shipment_Info.shipment_statusid == convert.ToInt(Status.READYTOSHIP))
                                            {
                                                if (convert.ToString(vehicle_Trip_Details.boarding_officer_name).Trim() == string.Empty) throw new Exception("Please enter Boarding Officer name.");
                                                if (convert.ToInt(vehicle_Trip_Details.transport_type_id) == 0) throw new Exception("Please enter Transport type.");
                                            }

                                            _dbContext.Entry(vehicle_Trip_DetailsExt).CurrentValues.SetValues(vehicle_Trip_Details);
                                            Updated += _dbContext.SaveChanges();
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Vehicle_Trip_Details details");
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to get Vehicle_Trip_Planning details");
                                    }

                                    if (convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.CANCELLED))
                                    {
                                        if (_delOrders.Count > 0)
                                        {
                                            foreach (Delivery_Orders _orders in _delOrders)
                                            {
                                                Delivery_Orders _ordersExt = _orders;
                                                _orders.ShipmentId = null;
                                                _orders.StatusId = convert.ToInt(Status.OPEN);
                                                _orders.UpdateDate = DateTime.Now;
                                                _orders.updated_by = _details.updatedBy;
                                                _dbContext.Entry(_ordersExt).CurrentValues.SetValues(_orders);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                        }
                                    }

                                    if (convert.ToInt(_details.shipment_Info.shipment_statusid) == convert.ToInt(Status.READYTOSHIP))
                                    {
                                        if (_delOrders.Count > 0)
                                        {
                                            foreach (Delivery_Orders _orders in _delOrders)
                                            {
                                                Delivery_Orders _ordersExt = _orders;
                                                _orders.StatusId = convert.ToInt(Status.RELEASED);
                                                _orders.UpdateDate = DateTime.Now;
                                                _orders.updated_by = _details.updatedBy;
                                                _dbContext.Entry(_ordersExt).CurrentValues.SetValues(_orders);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Atleast one delivery order is required.");
                                        }
                                    }
                                    if (isUnassignStatus)
                                    {
                                        if (_delOrders.Count > 0)
                                        {
                                            foreach (Delivery_Orders _orders in _delOrders)
                                            {
                                                Delivery_Orders _ordersExt = _orders;
                                                _orders.StatusId = convert.ToInt(Status.CONFIRMED);
                                                _orders.UpdateDate = DateTime.Now;
                                                _orders.updated_by = _details.updatedBy;
                                                _dbContext.Entry(_ordersExt).CurrentValues.SetValues(_orders);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Atleast one delivery order is required.");
                                        }
                                    }

                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipment;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Shipment with order no : " + _shipment.OrderNo + " Updated successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Updated successfully.", "", "", "", "");
                                    }
                                }
                                catch (Exception ex)
                                {
                                    dbContextTransaction.Rollback();
                                    setlog("Error while Update Shipment : " + ex.Message);
                                    throw ex;
                                }
                            }
                        });
                    }
                    else
                    {
                        throw new Exception("Unable to get Customer details.");
                    }
                }
                else
                {
                    throw new Exception("Unable to get Customer details.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while Update Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on Update Outbound Shipment : " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected string GenerateQRCode(QRModal contentValue)
        {
            string jsondata = getSerializeData(contentValue);
            setlog("GenerateQRCode DATA : " + jsondata);
            return QrCode.QRCodeProgram.GenerateQRCode(jsondata);
        }

        private string GetLatestShipmentOrderNo(int nCompanyId)
        {
            string NewOrderNo = string.Empty, LastOrderNo = "", cSeqMask = ""; int nLastAutoNumber = 0;
            try
            {
                if (nCompanyId == 0) { throw new Exception("Company not found."); }

                var cMaskedDet = GetMaskedData(convert.ToInt(nCompanyId), 1, out cSeqMask);
                var LastUpdatedCustOrder = _dbContext.shipment.Where(x => x.IsAuto == 1 && x.CompanyId == nCompanyId).OrderByDescending(x => x.ShipmentId).FirstOrDefault();//
                if (LastUpdatedCustOrder != null)
                {

                    LastOrderNo = LastUpdatedCustOrder.OrderNo;
                    var _currentRunningNo = LastOrderNo.Replace(cMaskedDet, "");
                    nLastAutoNumber = convert.ToInt(_currentRunningNo);
                    NewOrderNo = SetLatestAutoNumber(convert.ToInt(nCompanyId), 1, nLastAutoNumber);
                }
                else
                {
                    NewOrderNo = SetLatestAutoNumber(convert.ToInt(nCompanyId), 1, 0);
                }

                var _existingCustOrder = _dbContext.shipment.Where(x => x.OrderNo.Trim() == NewOrderNo).FirstOrDefault(); // todo add condition for Companyid
                bool AlreadyExists = _existingCustOrder != null;
                while (AlreadyExists)
                {
                    {
                        LeSDM.AddLog(LastOrderNo + " already exists.");
                        NewOrderNo = SetLatestAutoNumber(convert.ToInt(nCompanyId), 1, nLastAutoNumber + 1);
                        _existingCustOrder = _dbContext.shipment.Where(x => x.OrderNo.Trim() == NewOrderNo).FirstOrDefault(); // todo add condition for Companyid
                        AlreadyExists = _existingCustOrder != null;
                        nLastAutoNumber++;
                    }
                }
                return NewOrderNo;
            }
            catch (Exception ex)
            {
                LeSDM.AddLog("Exception in Getting Auto Order Number for Customer Order - " + ex.Message);
                LeSDM.AddLog("Stacktrace - " + ex.StackTrace);
                return "";
            }
        }

        protected object UpdateAssignShipmenttoDeliveryOrder(AssignDeliverOrder _detailsObj)
        {
            responseMessage _response = new responseMessage();
            int Updated = 0;
            setlog("UpdateAssignShipmenttoDeliveryOrder DATA : " + getSerializeData(_detailsObj));
            try
            {
                V_Shipment_Info _shipmentDetails = _dbContext.v_shipment_info.Find(_detailsObj.ShipmentId);
                if (_shipmentDetails != null && _detailsObj.DeliveryOrderIds.Count() > 0)
                {

                    if (_shipmentDetails.shipment_statusid == convert.ToInt(Status.DRAFT) || _shipmentDetails.shipment_statusid == convert.ToInt(Status.NEW))  // Draft & NEW status only
                    {
                        List<Delivery_Orders> lst_delivery_Orders = new List<Delivery_Orders>();
                        foreach (int deliveryorderid in _detailsObj.DeliveryOrderIds)
                        {
                            Delivery_Orders _dOrderExt = _dbContext.delivery_orders.FirstOrDefault(x => x.DeliveryOrderId == deliveryorderid && x.EndCustomerId == _shipmentDetails.receiverid && x.CompanyId == _shipmentDetails.companyid && x.StatusId == convert.ToInt(Status.OPEN) /*Open status*/);
                            if (_dOrderExt != null)
                            {
                                lst_delivery_Orders.Add(_dOrderExt);
                            }
                            else
                            {

                                string msg = "";
                                Delivery_Orders _dOrder = _dbContext.delivery_orders.Find(deliveryorderid);
                                if (_dOrder.StatusId != convert.ToInt(Status.OPEN))
                                {
                                    msg += "Delivery Order status is not Open" + Environment.NewLine;
                                }
                                if (_dOrder.CompanyId != _shipmentDetails.companyid)
                                {
                                    msg += "Delivery Order company does not match with Shipment" + Environment.NewLine;
                                }
                                if (_dOrder.EndCustomerId != _shipmentDetails.receiverid)
                                {
                                    msg += "Delivery Order Customer does not match with Shipment Customer" + Environment.NewLine;
                                }
                                throw new Exception(msg);
                            }
                        }
                        Shipment _shipmentExt = _dbContext.shipment.Find(_shipmentDetails.shipmentid);
                        Shipment _shipment = _shipmentExt;
                        if (_shipment != null)
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        if (lst_delivery_Orders.Count() > 0)
                                        {
                                            _shipment.ShipmentStatusId = convert.ToInt(Status.DRAFT);
                                            _shipment.UpdatedDate = DateTime.Now;
                                            _shipment.UpdatedBy = _detailsObj.UpdatedBy;
                                            _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                            Updated += _dbContext.SaveChanges();

                                            for (int i = 0; i < lst_delivery_Orders.Count(); i++)
                                            {
                                                Delivery_Orders _delOrderDataExt = lst_delivery_Orders[i];
                                                Delivery_Orders _delOrderData = _delOrderDataExt;
                                                _delOrderData.ShipmentId = _shipmentDetails.shipmentid;
                                                _delOrderData.StatusId = convert.ToInt(Status.CONFIRMED); // setting release status 
                                                _delOrderData.UpdateDate = DateTime.Now;
                                                _delOrderData.updated_by = _detailsObj.UpdatedBy;

                                                _dbContext.Entry(_delOrderDataExt).CurrentValues.SetValues(_delOrderData);
                                                Updated += _dbContext.SaveChanges();

                                            }
                                            if (Updated > 0)
                                            {
                                                dbContextTransaction.Commit();
                                                _response.data = _shipmentDetails;
                                                _response.status = "SUCCESS";
                                                _response.isSuccess = true;
                                                _response.message = "Delivery Order assigned to Outbound Shipment no " + _shipmentDetails.order_no + " successfully.";
                                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order assigned to Outbound Shipment no " + _shipmentDetails.order_no + " successfully.", "", "", "", "");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Delivery Orders.");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        setlog("Error while assigning Shipment to Delivery Order : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Unable to get Shipment details.");
                        }
                    }
                    else
                    {
                        throw new Exception("Shipment status is invalid");
                    }
                }
                else
                {
                    throw new Exception("Invalid Shipment and Delivery Order details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while assigning Shipment to Delivery Order : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on Update Assign Shipment to DeliveryOrder: " + ex.Message, "", "", "", "");
            }
            return _response;
        }



        protected object UpdateUnAssignShipmenttoDeliveryOrder(AssignDeliverOrder _detailsObj)
        {
            responseMessage _response = new responseMessage();
            int Updated = 0;
            setlog("UpdateUnAssignShipmenttoDeliveryOrder DATA : " + getSerializeData(_detailsObj));
            try
            {
                V_Shipment_Info _shipmentDetails = _dbContext.v_shipment_info.Find(_detailsObj.ShipmentId);
                if (_shipmentDetails != null && _detailsObj.DeliveryOrderIds.Count() > 0)
                {

                    if (_shipmentDetails.shipment_statusid == convert.ToInt(Status.DRAFT) || _shipmentDetails.shipment_statusid == convert.ToInt(Status.NEW))  // Draft && NEW status only
                    {
                        List<Delivery_Orders> lst_delivery_Orders = new List<Delivery_Orders>();
                        foreach (int deliveryorderid in _detailsObj.DeliveryOrderIds)
                        {
                            Delivery_Orders _dOrder = _dbContext.delivery_orders.FirstOrDefault(x => x.DeliveryOrderId == deliveryorderid && x.EndCustomerId == _shipmentDetails.receiverid && x.CompanyId == _shipmentDetails.companyid && x.StatusId == convert.ToInt(Status.CONFIRMED) /*Open status*/);
                            if (_dOrder != null)
                            {
                                lst_delivery_Orders.Add(_dOrder);
                            }
                            else
                            {
                                throw new Exception("Please check the selected delivery orders");
                            }
                        }
                        Shipment _shipmentExt = _dbContext.shipment.Find(_shipmentDetails.shipmentid);
                        Shipment _shipment = _shipmentExt;
                        if (_shipment != null)
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        if (lst_delivery_Orders.Count() > 0)
                                        {
                                            _shipment.UpdatedDate = DateTime.Now;
                                            _shipment.UpdatedBy = _detailsObj.UpdatedBy;
                                            _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                            Updated += _dbContext.SaveChanges();

                                            for (int i = 0; i < lst_delivery_Orders.Count(); i++)
                                            {
                                                Delivery_Orders _delOrderDataExt = lst_delivery_Orders[i];
                                                Delivery_Orders _delOrderData = _delOrderDataExt;
                                                _delOrderData.ShipmentId = null;
                                                _delOrderData.StatusId = convert.ToInt(Status.OPEN); // setting Open status 
                                                _delOrderData.UpdateDate = DateTime.Now;
                                                _delOrderData.updated_by = _detailsObj.UpdatedBy;

                                                _dbContext.Entry(_delOrderDataExt).CurrentValues.SetValues(_delOrderData);
                                                Updated += _dbContext.SaveChanges();

                                            }
                                            if (Updated > 0)
                                            {
                                                dbContextTransaction.Commit();
                                                _response.data = _shipmentDetails;
                                                _response.status = "SUCCESS";
                                                _response.isSuccess = true;
                                                _response.message = "Delivery Order unassigned to Outbound Shipment no " + _shipmentDetails.order_no + " successfully";
                                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order unassigned to Outbound Shipment no " + _shipmentDetails.order_no + " successfully", "", "", "", "");

                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Delivery Orders.");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        setlog("Error while unassigned Shipment to Delivery Order : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Unable to get Shipment details.");
                        }
                    }
                    else
                    {
                        throw new Exception("Shipment status is invalid");
                    }
                }
                else
                {
                    throw new Exception("Invalid Shipment and Delivery Order details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while unassigned Shipment to Delivery Order : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on Update UnAssign Shipment to Delivery Order: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object UpdateEPODShipmentDetails(EPOD_ShipmentDetails _detailsObj)
        {
            responseMessage _response = new responseMessage();
            int Updated = 0;
            setlog("UpdateEPODShipmentDetails DATA : " + getSerializeData(_detailsObj));
            try
            {
                Shipment _shipmentDetailsExt = _dbContext.shipment.Find(_detailsObj.shipmentid);
                if (_shipmentDetailsExt != null)
                {
                    Shipment_Vessel_Info _shipmentInfoExt = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == _detailsObj.shipmentid);
                    Shipment_Vessel_Info _shipmentInfo = _shipmentInfoExt;
                    if (_shipmentDetailsExt.ShipmentStatusId == convert.ToInt(Status.READYTOSHIP) || _shipmentDetailsExt.ShipmentStatusId == convert.ToInt(Status.INITALRECEIPT))  // INITALRECEIPT status
                    {
                        Shipment _shipment = _shipmentDetailsExt;
                        if (_shipment != null)
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        _shipment.UpdatedDate = DateTime.Now;
                                        _shipment.UpdatedBy = _detailsObj.updateBy;
                                        _dbContext.Entry(_shipmentDetailsExt).CurrentValues.SetValues(_shipment);
                                        Updated += _dbContext.SaveChanges();

                                        _shipmentInfo.Epod_Shipment_Notes = _detailsObj.EPOD_Shipment_Remarks;
                                        _dbContext.Entry(_shipmentInfoExt).CurrentValues.SetValues(_shipmentInfo);
                                        Updated += _dbContext.SaveChanges();

                                        if (Updated > 0)
                                        {
                                            dbContextTransaction.Commit();
                                            _response.data = _shipmentInfo;
                                            _response.status = "SUCCESS";
                                            _response.isSuccess = true;
                                            _response.message = "EPOD Shipment no " + _shipment.OrderNo + " Updated successfully";
                                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "EPOD Shipment no " + _shipment.OrderNo + " Updated successfully", "", "", "", "");

                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        setlog("Error Update EPOD Shipment Details : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Unable to get Shipment details.");
                        }
                    }
                    else
                    {
                        throw new Exception("Shipment status is invalid");
                    }
                }
                else
                {
                    throw new Exception("Invalid Shipment Order details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while Update EPOD Shipment Details : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on update EPOD Shipment Details: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected List<Shipment_DropDown> Get_Shipment_DropDown_By_CompanyId(int? companyid)
        {
            List<Shipment_DropDown> obj = _dbContext.shipment.Where(x => x.CompanyId != null && x.CompanyId == convert.ToInt(companyid) && x.ShipmentStatusId != null && x.ShipmentStatusId == convert.ToInt(Status.DRAFT) && x.IsDelete == null).Select(x => new Shipment_DropDown
            {
                ShipmentId = x.ShipmentId,
                OrderNo = x.OrderNo
            }).ToList();
            return obj;
        }

        protected object GetNewShipmentWithDOList(deliveryOrderListModal _details)
        {
            CreateShipmentwithDOModal _obj = new CreateShipmentwithDOModal();
            responseMessage _response = new responseMessage();
            try
            {
                setlog("GetNewShipmentWithDOList DATA : " + getSerializeData(_details));
                int customerid = 0;
                string JobNo = "", VesselName = "", VesselETA = "";

                if (_details.lstdo.Count > 0)
                {
                    for (int i = 0; i < _details.lstdo.Count; i++)
                    {
                        V_Delivery_Orders_Info _dOrderInfo = _dbContext.v_delivery_orders_info.FirstOrDefault(x => x.delivery_order_id == _details.lstdo[i] && x.companyid == _details.companyid && x.shipmentid == null);
                        if (_dOrderInfo != null)
                        {
                            if (_dOrderInfo.statusid == convert.ToInt(Status.OPEN))
                            {
                                if (customerid == 0)
                                {
                                    customerid = convert.ToInt(_dOrderInfo.end_customerid);
                                    JobNo = convert.ToString(_dOrderInfo.do_job_no) != string.Empty ? convert.ToString(_dOrderInfo.do_job_no) : throw new Exception("Job no not found for Delivery Order no '" + _dOrderInfo.delivery_order_no + "'");
                                    VesselName = convert.ToString(_dOrderInfo.vessel_name) != string.Empty ? convert.ToString(_dOrderInfo.vessel_name) : throw new Exception("Vessel name not found for Delivery Order no '" + _dOrderInfo.delivery_order_no + "'");
                                    VesselETA = convert.ToDateTime(_dOrderInfo.vessel_eta) != DateTime.MinValue ? convert.ToDateTime(_dOrderInfo.vessel_eta).ToString("dd/MM/yyyy") : throw new Exception("Vessel ETA not found for Delivery Order no '" + _dOrderInfo.delivery_order_no + "'");

                                    _obj.customerid = _dOrderInfo.end_customerid;
                                    _obj.customername = _dOrderInfo.customer_name;
                                    _obj.jobno = _dOrderInfo.do_job_no;
                                    _obj.vesselid = _dOrderInfo.vessel_id;
                                    _obj.vesselname = _dOrderInfo.vessel_name;
                                    _obj.vesseleta = convert.ToDateTime(_dOrderInfo.vessel_eta).ToString("dd/MM/yyyy HH:mm");
                                }
                                if (customerid == _dOrderInfo.end_customerid)
                                {
                                    if (JobNo == _dOrderInfo.do_job_no)
                                    {
                                        if (VesselName == convert.ToString(_dOrderInfo.vessel_name))
                                        {
                                            if (VesselETA == convert.ToDateTime(_dOrderInfo.vessel_eta).ToString("dd/MM/yyyy"))
                                            {
                                                _obj.deliveryorders.Add(_dOrderInfo);
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to match same Vessel ETA from DO List");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to match same Vessel Name from DO List");
                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to match same Job No from DO List");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to match same customer from DO List");
                                }
                            }
                            else
                            {
                                throw new Exception("Delivery Order No '" + _dOrderInfo.delivery_order_no + "' is in Invalid status : " + _dOrderInfo.status_desc);
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get Delivery Order from the DO List");
                        }
                    }
                    if (_obj != null)
                    {
                        _response.data = _obj;
                        _response.status = "SUCCESS";
                        _response.isSuccess = true;
                        _response.message = _details.lstdo.Count + " Delivery Order assigned for New Outbound Shipment validated successfully.";
                    }
                }
                else
                {
                    throw new Exception("Unable to get Valid Delivery Orders");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while assigning Shipment to Delivery Order : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
            }
            return _response;
        }

        protected object GetShipmentByShipmentid(int shipmentid)
        {
            return _dbContext.shipment.FirstOrDefault(x => x.ShipmentId == shipmentid);
        }

        #endregion

        #region SM_ADDRESS

        protected List<SM_ADDRESS> GetAllSmAddress()
        {
            return _dbContext.Sm_Address.ToList();
        }

        protected SM_ADDRESS GetSmAddressById(int id)
        {
            SM_ADDRESS obj = _dbContext.Sm_Address.FirstOrDefault(x => x.addressid == id);
            return obj;
        }

        protected SM_ADDRESS GetSmAddressByCode(string code)
        {
            SM_ADDRESS obj = _dbContext.Sm_Address.FirstOrDefault(x => x.addr_code == code);
            return obj;
        }

        #endregion

        #region V_SHIPMENT_INFO
        protected List<V_Shipment_Info> GetAllVShipmentInfo()
        {
            return _dbContext.v_shipment_info.ToList();
        }

        protected List<V_Shipment_Info> Get_V_Shipment_Info_By_companyId(int companyid)
        {
            List<V_Shipment_Info> obj = _dbContext.v_shipment_info.Where(x => x.companyid == companyid && x.Is_Delete != 1).ToList();
            return obj;
        }

        //protected StandardAPIresponse Get_V_Shipment_Info_By_companyId_Filter(FilterShipmentList modal)
        //{
        //    StandardAPIresponse responsemodal = new StandardAPIresponse();

        //    List<V_Shipment_Info> obj = _dbContext.v_shipment_info.Where(x => x.companyid == modal.companyid && x.Is_Delete != 1)
        //    .Where(x => string.IsNullOrEmpty(modal.shipmentno) || x.order_no.Contains(modal.shipmentno))
        //    .Where(x => modal.statusid <= 0 || x.shipment_statusid == modal.statusid)
        //    .Where(x =>  modal.transTypeid<= 0 || x.transport_type_id == modal.transTypeid)
        //    .Where(x => string.IsNullOrEmpty(modal.jobno) || x.jobno.Contains(modal.jobno.Trim()))
        //    .Where(x => string.IsNullOrEmpty(modal.vesselName) || x.vessel_name.Contains(modal.vesselName.Trim())).ToList();

        //    if (convert.ToInt(modal.customerid) > 0)
        //    {
        //        obj = obj.Where(x => x.receiverid == convert.ToInt(modal.customerid)).ToList();
        //    }
        //    else
        //    {
        //        obj = obj.Where(x => string.IsNullOrEmpty(modal.custCode) || x.cust_code.Contains(modal.custCode) || x.cust_name.Contains(modal.custCode)).ToList();
        //        obj = obj.Where(x => string.IsNullOrEmpty(modal.custName) || x.cust_name == modal.custName).ToList();
        //    }
        //    if (convert.ToString(modal.dtFrom) != "" && convert.ToString(modal.dtTo) != "")
        //    {
        //        obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date >= convert.ToDateTime(modal.dtFrom, "dd/MM/yyyy").Date && convert.ToDateTime(x.delivery_date).Date <= convert.ToDateTime(modal.dtTo, "dd/MM/yyyy").Date).ToList();
        //    }
        //    if (modal.isDeliveryToday)
        //    {
        //        obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date == DateTime.Now.Date).ToList();
        //    }
        //    else if (modal.isDeliveryin3days)
        //    {
        //        obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date <= DateTime.Now.AddDays(3) && convert.ToDateTime(x.delivery_date).Date >= DateTime.Now.Date).ToList();
        //    }
        //    else if (modal.isDeliveryThisWeek)
        //    {
        //        obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date <= DateTime.Now.AddDays(7) && convert.ToDateTime(x.delivery_date).Date >= DateTime.Now.Date).ToList();
        //    }
        //    responsemodal.totalRecords = obj.Count;
        //    if (modal.pagesize != null && modal.pagesize> 0)
        //    {
        //        obj = obj.Skip(modal.skip).Take(modal.pagesize).ToList();
        //    }
        //    else
        //    {
        //        obj = obj.Skip(modal.skip).Take(1000).ToList(); // filter to get 1000 on all records request
        //    }

        //    responsemodal.data = obj;
        //    responsemodal.isSuccess = true;

        //    return responsemodal;
        //}

        protected StandardAPIresponse Get_V_Shipment_Info_By_companyId_Filter(FilterShipmentList modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            var UserCompany = _dbContextUserAdmin.les_company.Where(x => x.companyid == modal.companyid).FirstOrDefault();            // Initialize query
            var query = _dbContext.v_shipment_info.AsQueryable();

            // Apply filters
            //query = query.Where(x => x.companyid == modal.companyid && x.Is_Delete != 1);
            if (modal.companyid > 0)
            {

                var parameters = new[]
                {
                    new SqlParameter("@companyid", modal.companyid),
                    new SqlParameter("@shipmentno", string.IsNullOrEmpty(modal.shipmentno) ? (object)DBNull.Value : modal.shipmentno),
                    new SqlParameter("@statusid", modal.statusid),
                    new SqlParameter("@transTypeid", modal.transTypeid),
                    new SqlParameter("@jobno", string.IsNullOrEmpty(modal.jobno) ? (object)DBNull.Value : modal.jobno.Trim()),
                    new SqlParameter("@vesselName", string.IsNullOrEmpty(modal.vesselName) ? (object)DBNull.Value : modal.vesselName.Trim())
                };
                string sqlQuery = @"
                    SELECT *
                    FROM V_SHIPMENT_INFO
                    WHERE companyid = @companyid
                        AND (Is_Delete != 1 OR Is_Delete IS NULL)
                        AND (@shipmentno IS NULL OR @shipmentno = '' OR order_no LIKE '%' + @shipmentno + '%')
                        AND (@statusid <= 0 OR shipment_statusid = @statusid)
                        AND (@transTypeid <= 0 OR transport_type_id = @transTypeid)
                        AND (@jobno IS NULL OR @jobno = '' OR jobno LIKE '%' + LTRIM(RTRIM(@jobno)) + '%')
                        AND (@vesselName IS NULL OR @vesselName = '' OR vessel_name LIKE '%' + LTRIM(RTRIM(@vesselName)) + '%')
                ";

                query = _dbContext.v_shipment_info.FromSqlRaw(sqlQuery, parameters);
            }
            else
            {
                throw new Exception("Input data is invalid!");
            }

            // Quick search functionality
            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                var arrquery = query.ToArray();
                // Apply quick search logic
                arrquery = arrquery.Where(m =>
                {
                    string searchString = $"{m.order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.vessel_eta != null ? m.vessel_eta.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.delivery_date != null ? m.delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{m.jobno?.ToString().ToUpper() ?? ""} " +
                                          $"{m.anchorage_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.agent?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Boarding_Officer_Name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Vehicle_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.shipment_statusdesc?.ToString().ToUpper() ?? ""} " +
                                          $"{m.transport_type_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.driver_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.supply_boat?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.planned_ship_date != null ? m.planned_ship_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.planned_delivery_date != null ? m.planned_delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")}";

                    return searchString.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                }).ToArray();
                query = arrquery.AsQueryable(); ;
            }



            // Apply other filters
            if (!string.IsNullOrEmpty(modal.shipmentno))
            {
                query = query.Where(x => x.order_no.Contains(modal.shipmentno));
            }
            if (modal.statusid > 0)
            {
                query = query.Where(x => x.shipment_statusid == modal.statusid);
            }
            if (modal.transTypeid > 0)
            {
                query = query.Where(x => x.transport_type_id == modal.transTypeid);
            }
            if (!string.IsNullOrEmpty(modal.jobno))
            {
                query = query.Where(x => x.jobno.Contains(modal.jobno.Trim()));
            }
            if (!string.IsNullOrEmpty(modal.vesselName))
            {
                query = query.Where(x => x.vessel_name.Contains(modal.vesselName.Trim()));
            }

            if (convert.ToInt(modal.customerid) > 0)
            {
                query = query.Where(x => x.receiverid == convert.ToInt(modal.customerid));
            }
            if (!string.IsNullOrEmpty(modal.custCode))
            {
                query = query.Where(x => x.cust_code.Contains(modal.custCode) || x.cust_name.Contains(modal.custCode));
            }
            if (!string.IsNullOrEmpty(modal.custName))
            {
                query = query.Where(x => x.cust_name == modal.custName);
            }

            if (!string.IsNullOrEmpty(modal.dtFrom) && !string.IsNullOrEmpty(modal.dtTo))
            {
                DateTime dtFrom = convert.ToDateTime(modal.dtFrom, "dd/MM/yyyy").Date;
                DateTime dtTo = convert.ToDateTime(modal.dtTo, "dd/MM/yyyy").Date;
                query = query.Where(x => x.delivery_date >= dtFrom.Date && x.delivery_date <= dtTo.Date);
                //query = query.Where(x => convert.ToDateTime(x.delivery_date).Date >= dtFrom.Date && convert.ToDateTime(x.delivery_date).Date <= dtTo.Date);
            }

            if (modal.isDeliveryToday)
            {
                query = query.Where(x => convert.ToDateTime(x.delivery_date).Date == DateTime.Now.Date);
            }
            else if (modal.isDeliveryin3days)
            {
                DateTime now = DateTime.Now.Date;
                query = query.Where(x => convert.ToDateTime(x.delivery_date).Date >= now && convert.ToDateTime(x.delivery_date).Date <= now.AddDays(3));
            }
            else if (modal.isDeliveryThisWeek)
            {
                DateTime now = DateTime.Now.Date;
                query = query.Where(x => convert.ToDateTime(x.delivery_date).Date >= now && convert.ToDateTime(x.delivery_date).Date <= now.AddDays(7));
            }

            //Apply sorting 
            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                if (modal.sortingorder.ToLower() == "asc")
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": query = query.OrderBy(x => x.order_no); break;
                        case "cust_code": query = query.OrderBy(x => x.cust_code); break;
                        case "cust_name": query = query.OrderBy(x => x.cust_name); break;
                        case "jobno": query = query.OrderBy(x => x.jobno); break;
                        case "vessel_name": query = query.OrderBy(x => x.vessel_name); break;
                        case "vessel_eta": query = query.OrderBy(x => x.vessel_eta); break;
                        case "delivery_date": query = query.OrderBy(x => x.delivery_date); break;
                        case "anchorage_description": query = query.OrderBy(x => x.anchorage_description); break;
                        case "agent": query = query.OrderBy(x => x.agent); break;
                        case "transport_type_description": query = query.OrderBy(x => x.transport_type_description); break;
                        case "driver_name": query = query.OrderBy(x => x.driver_name); break;
                        case "shipment_statusdesc": query = query.OrderBy(x => x.shipment_statusdesc); break;
                        case "supply_boat": query = query.OrderBy(x => x.supply_boat); break;
                        case "boarding_Officer_Name": query = query.OrderBy(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": query = query.OrderBy(x => x.Vehicle_no); break;
                        default: query = query.OrderBy(x => x.shipmentid); break;
                    }
                }
                else
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": query = query.OrderByDescending(x => x.order_no); break;
                        case "delivery_date": query = query.OrderByDescending(x => x.delivery_date); break;
                        case "cust_code": query = query.OrderByDescending(x => x.cust_code); break;
                        case "cust_name": query = query.OrderByDescending(x => x.cust_name); break;
                        case "jobno": query = query.OrderByDescending(x => x.jobno); break;
                        case "vessel_name": query = query.OrderByDescending(x => x.vessel_name); break;
                        case "vessel_eta": query = query.OrderByDescending(x => x.vessel_eta); break;
                        case "anchorage_description": query = query.OrderByDescending(x => x.anchorage_description); break;
                        case "agent": query = query.OrderByDescending(x => x.agent); break;
                        case "transport_type_description": query = query.OrderByDescending(x => x.transport_type_description); break;
                        case "driver_name": query = query.OrderByDescending(x => x.driver_name); break;
                        case "shipment_statusdesc": query = query.OrderByDescending(x => x.shipment_statusdesc); break;
                        case "supply_boat": query = query.OrderByDescending(x => x.supply_boat); break;
                        case "boarding_Officer_Name": query = query.OrderByDescending(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": query = query.OrderByDescending(x => x.Vehicle_no); break;
                        default: query = query.OrderByDescending(x => x.shipmentid); break;
                    }
                }
            }


            // Get total count before pagination
            responsemodal.totalRecords = query.Count();

            // Apply pagination
            var lsData = new List<V_Shipment_Info>();
            if (modal.pagesize > 0)
            {
                lsData = query.Skip(modal.skip).Take(modal.pagesize).ToList();
            }
            else
            {
                lsData = query.ToList();
            }
            lsData.ForEach(x =>
            {
                x.CompanyCode = UserCompany.company_code;
                x.CompanyName = UserCompany.company_description;
            });
            responsemodal.data = lsData;
            responsemodal.isSuccess = true;
            return responsemodal;
        }

        protected StandardAPIresponse Get_V_Shipment_Info_By_customerid_Filter(FilterShipmentList modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            // Initialize query
            var query = _dbContext.v_shipment_info.AsQueryable();

            // Apply filters
            //query = query.Where(x => x.companyid == modal.companyid && x.Is_Delete != 1);
            if (modal.customerid > 0)
            {

                var parameters = new[]
                {
                    new SqlParameter("@companyid", modal.companyid),
                    new SqlParameter("@customerid", modal.customerid),
                    new SqlParameter("@shipmentno", string.IsNullOrEmpty(modal.shipmentno) ? (object)DBNull.Value : modal.shipmentno),
                    new SqlParameter("@statusid", modal.statusid),
                    new SqlParameter("@transTypeid", modal.transTypeid),
                    new SqlParameter("@jobno", string.IsNullOrEmpty(modal.jobno) ? (object)DBNull.Value : modal.jobno.Trim()),
                    new SqlParameter("@vesselName", string.IsNullOrEmpty(modal.vesselName) ? (object)DBNull.Value : modal.vesselName.Trim())
                };
                string sqlQuery = @"
                    SELECT *
                    FROM V_SHIPMENT_INFO
                    WHERE RECEIVERID = @customerid
                        AND (Is_Delete != 1 OR Is_Delete IS NULL)
                        AND (@shipmentno IS NULL OR @shipmentno = '' OR order_no LIKE '%' + @shipmentno + '%')
                        AND (@statusid <= 0 OR shipment_statusid = @statusid)
                        AND (@transTypeid <= 0 OR transport_type_id = @transTypeid)
                        AND (@jobno IS NULL OR @jobno = '' OR jobno LIKE '%' + LTRIM(RTRIM(@jobno)) + '%')
                        AND (@vesselName IS NULL OR @vesselName = '' OR vessel_name LIKE '%' + LTRIM(RTRIM(@vesselName)) + '%')
                ";

                query = _dbContext.v_shipment_info.FromSqlRaw(sqlQuery, parameters);
            }
            else
            {
                throw new Exception("Input data is invalid!");
            }

            // Quick search functionality
            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                var arrquery = query.ToArray();
                // Apply quick search logic
                arrquery = arrquery.Where(m =>
                {
                    string searchString = $"{m.order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.vessel_eta != null ? m.vessel_eta.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.delivery_date != null ? m.delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{m.jobno?.ToString().ToUpper() ?? ""} " +
                                          $"{m.anchorage_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.agent?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Boarding_Officer_Name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Vehicle_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.shipment_statusdesc?.ToString().ToUpper() ?? ""} " +
                                          $"{m.transport_type_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.driver_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.supply_boat?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.planned_ship_date != null ? m.planned_ship_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.planned_delivery_date != null ? m.planned_delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")}";

                    return searchString.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                }).ToArray();
                query = arrquery.AsQueryable(); ;
            }



            // Apply other filters
            if (!string.IsNullOrEmpty(modal.shipmentno))
            {
                query = query.Where(x => x.order_no.Contains(modal.shipmentno));
            }
            if (modal.statusid > 0)
            {
                query = query.Where(x => x.shipment_statusid == modal.statusid);
            }
            if (modal.transTypeid > 0)
            {
                query = query.Where(x => x.transport_type_id == modal.transTypeid);
            }
            if (!string.IsNullOrEmpty(modal.jobno))
            {
                query = query.Where(x => x.jobno.Contains(modal.jobno.Trim()));
            }
            if (!string.IsNullOrEmpty(modal.vesselName))
            {
                query = query.Where(x => x.vessel_name.Contains(modal.vesselName.Trim()));
            }

            if (convert.ToInt(modal.customerid) > 0)
            {
                query = query.Where(x => x.receiverid == convert.ToInt(modal.customerid));
            }
            if (!string.IsNullOrEmpty(modal.custCode))
            {
                query = query.Where(x => x.cust_code.Contains(modal.custCode) || x.cust_name.Contains(modal.custCode));
            }
            if (!string.IsNullOrEmpty(modal.custName))
            {
                query = query.Where(x => x.cust_name == modal.custName);
            }

            if (!string.IsNullOrEmpty(modal.dtFrom) && !string.IsNullOrEmpty(modal.dtTo))
            {
                DateTime dtFrom = convert.ToDateTime(modal.dtFrom, "dd/MM/yyyy").Date;
                DateTime dtTo = convert.ToDateTime(modal.dtTo, "dd/MM/yyyy").Date;
                query = query.Where(x => x.delivery_date >= dtFrom.Date && x.delivery_date <= dtTo.Date);
                //query = query.Where(x => convert.ToDateTime(x.delivery_date).Date >= dtFrom.Date && convert.ToDateTime(x.delivery_date).Date <= dtTo.Date);
            }

            if (modal.isDeliveryToday)
            {
                query = query.Where(x => convert.ToDateTime(x.delivery_date).Date == DateTime.Now.Date);
            }
            else if (modal.isDeliveryin3days)
            {
                DateTime now = DateTime.Now.Date;
                query = query.Where(x => convert.ToDateTime(x.delivery_date).Date >= now && convert.ToDateTime(x.delivery_date).Date <= now.AddDays(3));
            }
            else if (modal.isDeliveryThisWeek)
            {
                DateTime now = DateTime.Now.Date;
                query = query.Where(x => convert.ToDateTime(x.delivery_date).Date >= now && convert.ToDateTime(x.delivery_date).Date <= now.AddDays(7));
            }

            //Apply sorting 
            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                if (modal.sortingorder.ToLower() == "asc")
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": query = query.OrderBy(x => x.order_no); break;
                        case "cust_code": query = query.OrderBy(x => x.cust_code); break;
                        case "cust_name": query = query.OrderBy(x => x.cust_name); break;
                        case "jobno": query = query.OrderBy(x => x.jobno); break;
                        case "vessel_name": query = query.OrderBy(x => x.vessel_name); break;
                        case "vessel_eta": query = query.OrderBy(x => x.vessel_eta); break;
                        case "delivery_date": query = query.OrderBy(x => x.delivery_date); break;
                        case "anchorage_description": query = query.OrderBy(x => x.anchorage_description); break;
                        case "agent": query = query.OrderBy(x => x.agent); break;
                        case "transport_type_description": query = query.OrderBy(x => x.transport_type_description); break;
                        case "driver_name": query = query.OrderBy(x => x.driver_name); break;
                        case "shipment_statusdesc": query = query.OrderBy(x => x.shipment_statusdesc); break;
                        case "supply_boat": query = query.OrderBy(x => x.supply_boat); break;
                        case "boarding_Officer_Name": query = query.OrderBy(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": query = query.OrderBy(x => x.Vehicle_no); break;
                        default: query = query.OrderBy(x => x.shipmentid); break;
                    }
                }
                else
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": query = query.OrderByDescending(x => x.order_no); break;
                        case "delivery_date": query = query.OrderByDescending(x => x.delivery_date); break;
                        case "cust_code": query = query.OrderByDescending(x => x.cust_code); break;
                        case "cust_name": query = query.OrderByDescending(x => x.cust_name); break;
                        case "jobno": query = query.OrderByDescending(x => x.jobno); break;
                        case "vessel_name": query = query.OrderByDescending(x => x.vessel_name); break;
                        case "vessel_eta": query = query.OrderByDescending(x => x.vessel_eta); break;
                        case "anchorage_description": query = query.OrderByDescending(x => x.anchorage_description); break;
                        case "agent": query = query.OrderByDescending(x => x.agent); break;
                        case "transport_type_description": query = query.OrderByDescending(x => x.transport_type_description); break;
                        case "driver_name": query = query.OrderByDescending(x => x.driver_name); break;
                        case "shipment_statusdesc": query = query.OrderByDescending(x => x.shipment_statusdesc); break;
                        case "supply_boat": query = query.OrderByDescending(x => x.supply_boat); break;
                        case "boarding_Officer_Name": query = query.OrderByDescending(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": query = query.OrderByDescending(x => x.Vehicle_no); break;
                        default: query = query.OrderByDescending(x => x.shipmentid); break;
                    }
                }
            }


            // Get total count before pagination
            responsemodal.totalRecords = query.Count();

            // Apply pagination
            var lsData = new List<V_Shipment_Info>();
            if (modal.pagesize > 0)
            {
                lsData = query.Skip(modal.skip).Take(modal.pagesize).ToList();
            }
            else
            {
                lsData = query.ToList();
            }
            List<int?> CommonCompanies = lsData.Select(x => x.companyid).Distinct().ToList();
            var companies = _dbContextUserAdmin.les_company.Where(x => CommonCompanies.Contains(x.companyid)).ToList();
            lsData.ForEach(x =>
            {
                x.CompanyCode = companies.Where(y => y.companyid == x.companyid).FirstOrDefault().company_code ?? "";
                x.CompanyName = companies.Where(y => y.companyid == x.companyid).FirstOrDefault().company_description ?? "";
            });
            responsemodal.data = lsData;
            responsemodal.isSuccess = true;
            return responsemodal;
        }


        protected V_Shipment_Info Get_V_Shipment_Info_By_ShipmentId(int ShipmentId, int Companyid)
        {
            V_Shipment_Info obj = _dbContext.v_shipment_info.FirstOrDefault(x => x.shipmentid == ShipmentId && x.Is_Delete != 1);
            return obj;
        }

        #endregion

        #region V_INBOUND_SHIPMENT
        protected async Task<StandardAPIresponse> Get_InboundShipment_FilterByCompanyidAsync(FilterInboundShipment modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            try
            {
                var UserCompany = await _dbContextUserAdmin.les_company
                    .Where(x => x.companyid == modal.companyid)
                    .FirstOrDefaultAsync();

                var query = _dbContext.v_inbound_shipments.AsQueryable();
                var esupplierpos = await GetPOsfromEsupplierAsync(modal); // Run in parallel if possible

                if (modal.companyid > 0)
                {
                    var parameters = new[]
                    {
                new SqlParameter("@companyid", modal.companyid),
                new SqlParameter("@shipmentno", string.IsNullOrEmpty(modal.shipmentno) ? (object)DBNull.Value : modal.shipmentno),
                new SqlParameter("@statusid", modal.statusid),
                new SqlParameter("@transTypeid", modal.transTypeid),
                new SqlParameter("@jobno", string.IsNullOrEmpty(modal.jobno) ? (object)DBNull.Value : modal.jobno.Trim()),
                new SqlParameter("@vesselName", string.IsNullOrEmpty(modal.vesselName) ? (object)DBNull.Value : modal.vesselName.Trim())
            };

                    string sqlQuery = @"
                    SELECT *
                    FROM V_INBOUND_SHIPMENTS
                    WHERE companyid = @companyid";

                    query = _dbContext.v_inbound_shipments.FromSqlRaw(sqlQuery, parameters);
                }
                else
                {
                    throw new Exception("No company found to display inbound shipments!");
                }

                var bothls = await query.ToListAsync();

                // Add unique items from esupplierpos to bothls
                bothls.AddRange(esupplierpos.Where(item => !bothls.Any(existingItem =>
                    existingItem.shipmentno == item.shipmentno && existingItem.customerId == item.customerId)));

                // Quick search functionality
                if (!string.IsNullOrEmpty(modal.quicksearchvalue))
                {
                    string searchValue = modal.quicksearchvalue.Trim().ToUpper();

                    bothls = bothls.Where(m =>
                    {
                        string searchString = $"{m.shipmentno?.ToString().ToUpper() ?? ""} " +
                                              $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                              $"{m.vessel_code?.ToString().ToUpper() ?? ""} " +
                                              $"{m.cust_code?.ToString().ToUpper() ?? ""} " +
                                              $"{m.cust_name?.ToString().ToUpper() ?? ""} " +
                                              $"{(m.transactionDate != null ? m.transactionDate.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                              $"{m.jobOrderNo?.ToString().ToUpper() ?? ""} " +
                                              $"{m.remarks?.ToString().ToUpper() ?? ""} " +
                                              $"{m.CompanyCode?.ToString().ToUpper() ?? ""} " +
                                              $"{m.CompanyName?.ToString().ToUpper() ?? ""}";

                        return searchString.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                    }).ToList();
                }

                // Apply other filters
                var filters = new List<Func<V_INBOUND_SHIPMENTS, bool>>();

                if (!string.IsNullOrEmpty(modal.shipmentno))
                    filters.Add(x => x.shipmentno.Contains(modal.shipmentno));

                if (modal.statusid > 0)
                    filters.Add(x => x.statusId == modal.statusid);

                if (modal.pono > 0)
                    filters.Add(x => x.internal_order_no.Contains(Convert.ToString(modal.pono)));

                if (!string.IsNullOrEmpty(modal.jobno))
                    filters.Add(x => x.jobOrderNo.Contains(modal.jobno.Trim()));

                if (!string.IsNullOrEmpty(modal.vesselName))
                    filters.Add(x => x.vessel_name.Contains(modal.vesselName.Trim()));

                if (convert.ToInt(modal.customerid) > 0)
                    filters.Add(x => x.customerId == convert.ToInt(modal.customerid));

                if (!string.IsNullOrEmpty(modal.custCode))
                    filters.Add(x => x.cust_code.Contains(modal.custCode) || x.cust_name.Contains(modal.custCode));

                if (!string.IsNullOrEmpty(modal.custName))
                    filters.Add(x => x.cust_name == modal.custName);

                if (!string.IsNullOrEmpty(modal.dtFrom) && !string.IsNullOrEmpty(modal.dtTo))
                {
                    DateTime dtFrom = convert.ToDateTime(modal.dtFrom, "dd/MM/yyyy").Date;
                    DateTime dtTo = convert.ToDateTime(modal.dtTo, "dd/MM/yyyy").Date;
                    filters.Add(x => x.transactionDate >= dtFrom && x.transactionDate <= dtTo);
                }

                // Apply all filters
                foreach (var filter in filters)
                {
                    bothls = bothls.Where(filter).ToList();
                }

                // Apply sorting 
                if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
                {
                    if (modal.sortingorder.ToLower() == "asc")
                    {
                        bothls = modal.sortcolumn switch
                        {
                            "shipmentno" => bothls.OrderBy(x => x.shipmentno).ToList(),
                            "party" => bothls.OrderBy(x => x.cust_code).ToList(),
                            "jobOrderNo" => bothls.OrderBy(x => x.jobOrderNo).ToList(),
                            "vessel_name" => bothls.OrderBy(x => x.vessel_name).ToList(),
                            "remarks" => bothls.OrderBy(x => x.remarks).ToList(),
                            "transactionDate" => bothls.OrderBy(x => x.transactionDate).ToList(),
                            "vessel" => bothls.OrderBy(x => x.vessel_code).ToList(),
                            _ => bothls.OrderBy(x => x.inboundShipmentId).ToList(),
                        };
                    }
                    else
                    {
                        bothls = modal.sortcolumn switch
                        {
                            "shipmentno" => bothls.OrderByDescending(x => x.shipmentno).ToList(),
                            "party" => bothls.OrderByDescending(x => x.cust_code).ToList(),
                            "jobOrderNo" => bothls.OrderByDescending(x => x.jobOrderNo).ToList(),
                            "vessel_name" => bothls.OrderByDescending(x => x.vessel_name).ToList(),
                            "remarks" => bothls.OrderByDescending(x => x.remarks).ToList(),
                            "transactionDate" => bothls.OrderByDescending(x => x.transactionDate).ToList(),
                            "vessel" => bothls.OrderByDescending(x => x.vessel_code).ToList(),
                            _ => bothls.OrderByDescending(x => x.inboundShipmentId).ToList(),
                        };
                    }
                }

                // Get total count before pagination
                responsemodal.totalRecords = bothls.Count();

                // Apply pagination
                var lsData = new List<V_INBOUND_SHIPMENTS>();
                if (modal.pagesize > 0)
                {
                    lsData = bothls.Skip(modal.skip).Take(modal.pagesize).ToList();
                }
                else
                {
                    lsData = bothls.ToList();
                }

                responsemodal.data = lsData;
                responsemodal.isSuccess = true;
            }
            catch (Exception ex)
            {
                await Task.Run(() => LeSDM.AddLog("exception in Get_InboundShipment_FilterByCompanyid : " + ex.Message));
            }

            return responsemodal;
        }

        protected async Task<StandardAPIresponse> Get_InboundShipment_FilterByCustomeridAsync(FilterInboundShipment modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            var query = _dbContext.v_inbound_shipments.AsQueryable();
            var esupplierpos = await GetPOsfromEsupplierAsync(modal); // Ensure this method is async

            // Apply filters
            if (modal.customerid > 0)
            {
                var parameters = new[]
                {
            new SqlParameter("@customerid", modal.customerid),
            new SqlParameter("@shipmentno", string.IsNullOrEmpty(modal.shipmentno) ? (object)DBNull.Value : modal.shipmentno),
            new SqlParameter("@statusid", modal.statusid),
            new SqlParameter("@transTypeid", modal.transTypeid),
            new SqlParameter("@jobno", string.IsNullOrEmpty(modal.jobno) ? (object)DBNull.Value : modal.jobno.Trim()),
            new SqlParameter("@vesselName", string.IsNullOrEmpty(modal.vesselName) ? (object)DBNull.Value : modal.vesselName.Trim())
        };

                string sqlQuery = @"
            SELECT * 
            FROM V_INBOUND_SHIPMENTS 
            WHERE CustomerId = @customerid";

                query = _dbContext.v_inbound_shipments.FromSqlRaw(sqlQuery, parameters);
            }

            // Execute query asynchronously
            var bothls = await query.ToListAsync();

            // Merge esupplierpos records if not already present
            bothls.AddRange(esupplierpos.Where(item => !bothls.Any(existingItem => existingItem.shipmentno == item.shipmentno && existingItem.customerId == item.customerId)));

            // Quick search functionality
            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                bothls = bothls.Where(m =>
                {
                    string searchString = $"{m.shipmentno?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.transactionDate != null ? m.transactionDate.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{m.jobOrderNo?.ToString().ToUpper() ?? ""} " +
                                          $"{m.remarks?.ToString().ToUpper() ?? ""} " +
                                          $"{m.CompanyCode?.ToString().ToUpper() ?? ""} " +
                                          $"{m.CompanyName?.ToString().ToUpper() ?? ""} ";

                    return searchString.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                }).ToList();
            }

            // Apply sorting
            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                bool isAscending = modal.sortingorder.ToLower() == "asc";
                bothls = isAscending
                    ? bothls.OrderBy(x => GetSortValue(x, modal.sortcolumn)).ToList()
                    : bothls.OrderByDescending(x => GetSortValue(x, modal.sortcolumn)).ToList();
            }

            // Get total count before pagination
            responsemodal.totalRecords = bothls.Count;

            // Apply pagination
            var lsData = modal.pagesize > 0 ? bothls.Skip(modal.skip).Take(modal.pagesize).ToList() : bothls;

            // Fetch company details asynchronously
            List<int?> CommonCompanies = lsData.Where(x => x.companyid != null).Select(x => x.companyid).Distinct().ToList();
            var companies = await _dbContextUserAdmin.les_company.Where(x => CommonCompanies.Contains(x.companyid)).ToListAsync();

            // Assign company details
            lsData.ForEach(x =>
            {
                var company = companies.FirstOrDefault(y => y.companyid == x.companyid);
                x.CompanyCode = company?.company_code ?? "";
                x.CompanyName = company?.company_description ?? "";
            });

            responsemodal.data = lsData;
            responsemodal.isSuccess = true;
            return responsemodal;
        }

        // Helper method to sort dynamically
        private object GetSortValue(V_INBOUND_SHIPMENTS item, string sortColumn)
        {
            return sortColumn switch
            {
                "shipmentno" => item.shipmentno,
                "party" => item.cust_code,
                "jobOrderNo" => item.jobOrderNo,
                "vessel_name" => item.vessel_name,
                "remarks" => item.remarks,
                "transactionDate" => item.transactionDate,
                "vessel" => item.vessel_code,
                _ => item.inboundShipmentId
            };
        }

        private async Task<List<V_INBOUND_SHIPMENTS>> GetPOsfromEsupplierAsync(FilterInboundShipment Imodal)
        {
            List<V_INBOUND_SHIPMENTS> modal = new();
            Dictionary<int, int> customerAddressMap = new();
            List<lesv_Customers> linkedCustomers = new();
            bool isBuyer = false;

            try
            {
                if (Imodal.companyid > 0)
                {
                    isBuyer = true;
                    var company = await GetCompanyById(Imodal.companyid);
                    if (company == null) throw new Exception("Company details not found!");

                    var allPOs = await GetPOsByCompany(company.addressid, Imodal.skip, Imodal.pagesize);
                    if (allPOs.Count > 0)
                    {
                        linkedCustomers = await GetLinkedCustomers(allPOs.Select(x => x.Buyer_AddressId).Distinct().ToList());
                        FilterPOsByCustomers(allPOs, linkedCustomers, customerAddressMap);
                        modal = ConvertToV_InboundShipment(allPOs);
                    }
                }
                else if (Imodal.customerid > 0)
                {
                    var customer = await GetCustomerById(Imodal.customerid);
                    if (customer == null) throw new Exception("Customer details not found!");

                    linkedCustomers.Add(customer);
                    customerAddressMap[customer.customerid] = Convert.ToInt32(customer.addressid);

                    var allPOs = await GetPOsByCustomer(Convert.ToInt32(customer.addressid), Imodal.skip, Imodal.pagesize);
                    if (allPOs.Count > 0)
                    {
                        modal = ConvertToV_InboundShipment(allPOs);
                    }
                }
                else
                {
                    throw new Exception("No address ID found!");
                }

                EnrichPOsWithCustomerData(modal, linkedCustomers, customerAddressMap, isBuyer);
            }
            catch (Exception ex)
            {
                LeSDM.AddLog($"Exception in GetPOsfromEsupplierAsync: {ex.GetBaseException().Message}");
            }

            return modal;
        }

        private void FilterPOsByCustomers(
                List<SmQuotationsVendor> allPOs,
                List<lesv_Customers> linkedCustomers,
                Dictionary<int, int> customerAddressMap)
        {
            // Extract all customer address IDs
            var availableCustomerAddressIds = linkedCustomers.Select(c => c.addressid).ToList();

            // Filter POs to include only those linked to the available customer addresses
            allPOs.RemoveAll(po => !availableCustomerAddressIds.Contains(po.Buyer_AddressId));

            // Map customer IDs to their corresponding address IDs
            foreach (var customer in linkedCustomers)
            {
                if (!customerAddressMap.ContainsKey(customer.customerid))
                {
                    customerAddressMap.Add(customer.customerid, convert.ToInt(customer.addressid));
                }
            }
        }

        private async Task<LES_COMPANY> GetCompanyById(int companyId)
        {
            return _dbContextUserAdmin.les_company.FirstOrDefault(x => x.companyid == companyId);
        }

        private async Task<lesv_Customers> GetCustomerById(int customerId)
        {
            return _dbContext.lesv_customers.FirstOrDefault(x => x.customerid == customerId);
        }

        private async Task<List<SmQuotationsVendor>> GetPOsByCompany(int? addressId, int skip, int take)
        {
            string sqlQuery = @"
                SELECT * 
                FROM Sm_Quotations_Vendor
                WHERE Quote_AddressId = @CurrCompanyAddressId 
                AND VENDOR_STATUS != 7 
                AND Doc_Type = 'Order'
                ORDER BY QUOTATIONID
               ;";
            //if (take> 0)
            //{
            //    sqlQuery = @"
            //    SELECT * 
            //    FROM Sm_Quotations_Vendor
            //    WHERE Quote_AddressId = @CurrCompanyAddressId 
            //    AND VENDOR_STATUS != 7 
            //    AND Doc_Type = 'Order'
            //    ORDER BY QUOTATIONID
            //    OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY;";
            //}
            //else
            //{
            //    sqlQuery = @"
            //    SELECT * 
            //    FROM Sm_Quotations_Vendor
            //    WHERE Quote_AddressId = @CurrCompanyAddressId 
            //    AND VENDOR_STATUS != 7 
            //    AND Doc_Type = 'Order'
            //    ORDER BY QUOTATIONID
            //   ;";
            //}

            var parameters = new[]
             {
                new SqlParameter("@CurrCompanyAddressId", addressId),
                new SqlParameter("@Skip", skip),
                new SqlParameter("@Take", take)
            };

            _dbesuppliercontext.Database.SetCommandTimeout(150);
            return _dbesuppliercontext.Sm_Quotations_Vendor.FromSqlRaw(sqlQuery, parameters).ToList();
        }

        private async Task<List<SmQuotationsVendor>> GetPOsByCustomer(int addressId, int skip, int take)
        {
            var parameters = new[] {
                new SqlParameter("@CurrBuyerAddressId", addressId) ,
                new SqlParameter("@Skip",skip),
                new SqlParameter("@Take",take)
            };
            string sqlQuery = @"
                SELECT * 
                FROM Sm_Quotations_Vendor
                WHERE Buyer_AddressId = @CurrBuyerAddressId
                AND VENDOR_STATUS != 7
                AND Doc_Type = 'Order' 
                ORDER BY QUOTATIONID;";

            //if (take > 0)
            //{
            //    sqlQuery = @"
            //    SELECT * 
            //    FROM Sm_Quotations_Vendor
            //    WHERE Buyer_AddressId = @CurrBuyerAddressId
            //    AND VENDOR_STATUS != 7
            //    AND Doc_Type = 'Order' 
            //    ORDER BY QUOTATIONID
            //    OFFSET @Skip ROWS FETCH NEXT @Take ROWS ONLY;";
            //}
            //else
            //{
            //    sqlQuery = @"
            //    SELECT * 
            //    FROM Sm_Quotations_Vendor
            //    WHERE Buyer_AddressId = @CurrBuyerAddressId
            //    AND VENDOR_STATUS != 7
            //    AND Doc_Type = 'Order' 
            //    ORDER BY QUOTATIONID;";
            //}

            _dbesuppliercontext.Database.SetCommandTimeout(150);
            return _dbesuppliercontext.Sm_Quotations_Vendor.FromSqlRaw(sqlQuery, parameters).ToList();
        }

        private async Task< List<lesv_Customers>> GetLinkedCustomers(List<int?> addressIds)
        {
            return _dbContext.lesv_customers.Where(x => addressIds.Contains(x.addressid)).ToList();
        }

        private async void EnrichPOsWithCustomerData(
            List<V_INBOUND_SHIPMENTS> poList,
            List<lesv_Customers> customers,
            Dictionary<int, int> customerAddressMap,
            bool isBuyer)
        {
            foreach (var po in poList)
            {
                po.status_desc = "Open";
                var customer = customers.FirstOrDefault(c => customerAddressMap.ContainsKey(c.customerid) &&
                                                              customerAddressMap[c.customerid] == po.Buyer_AddressId);
                if (customer != null)
                {
                    po.cust_code = customer.cust_code;
                    po.cust_name = customer.cust_name;
                    po.cust_type = customer.cust_type;
                    po.customerId = customer.customerid;
                    po.companyid = customer.companyid;
                }
            }
        }

        //private List<V_INBOUND_SHIPMENTS> GetPOsfromEsupplier(FilterInboundShipment Imodal)
        //{
        //    LeSDM.AddLog("GetPOsfromEsupplier process started !");
        //    List<V_INBOUND_SHIPMENTS> modal = new List<V_INBOUND_SHIPMENTS>();
        //    Dictionary<int, int> customer_addressid = new Dictionary<int, int>();
        //    List<lesv_Customers> AllLinkedCustomers = new List<lesv_Customers>();
        //    bool userflag = false;//false==buyer true==supplier
        //    try
        //    {
        //        if (Imodal.companyid > 0)
        //        {
        //            userflag = true;
        //            var currcompany = _dbContextUserAdmin.les_company.Where(x => x.companyid == Imodal.companyid).FirstOrDefault();
        //            LeSDM.AddLog("les_company received!");
        //            if (currcompany != null)
        //            {
        //                var parameters = new[]
        //                {
        //                    new SqlParameter("@CurrCompanyAddressId", currcompany.addressid),
        //                };
        //                string sqlQuery = @"
        //                    SELECT * 
        //                    FROM Sm_Quotations_Vendor
        //                    WHERE Quote_AddressId = @CurrCompanyAddressId
        //                    AND VENDOR_STATUS != 7
        //                    AND Doc_Type = 'Order';";
        //                _dbesuppliercontext.Database.SetCommandTimeout(150);
        //                var allPOs = _dbesuppliercontext.Sm_Quotations_Vendor.FromSqlRaw(sqlQuery, parameters).ToList();
        //                LeSDM.AddLog("Sm_Quotations_Vendor received!");
        //                //var allPOs = _dbesuppliercontext.Sm_Quotations_Vendor.Where(x => x.Quote_AddressId == currcompany.addressid && x.Doc_Type == "Order").ToList();
        //                if (allPOs.Count > 0)
        //                {
        //                    var allAddressid = allPOs.Select(x => x.Buyer_AddressId).Distinct().ToList();
        //                    AllLinkedCustomers = _dbContext.lesv_customers.Where(x => allAddressid.Contains(x.addressid)).ToList();
        //                    LeSDM.AddLog("lesv_customers received!");
        //                    var availablecustomers = AllLinkedCustomers.Select(x => x.addressid).ToArray();
        //                    allPOs = allPOs.Where(x => availablecustomers.Contains(x.Buyer_AddressId)).ToList();
        //                    Dictionary<int, int> Mapping = new Dictionary<int, int>();
        //                    for (int i = 0; i < allAddressid.Count; i++)
        //                    {
        //                        Mapping = new Dictionary<int, int>();
        //                        var eachaddressid = allAddressid[i];
        //                        var currcustomer = AllLinkedCustomers.Where(x => x.addressid == eachaddressid).FirstOrDefault();
        //                        if (currcustomer != null)
        //                        {
        //                            customer_addressid.Add(currcustomer.customerid, convert.ToInt(eachaddressid));

        //                        }
        //                        else
        //                        {
        //                            LeSDM.AddLog("No customer found in logilink for given addressid = " + eachaddressid);
        //                        }


        //                    }
        //                    //var data = JsonConvert.SerializeObject(allPOs);
        //                    //modal = JsonConvert.DeserializeObject<List<V_INBOUND_SHIPMENTS>>(data).ToList();
        //                    modal = ConvertToV_InboundShipment(allPOs);
        //                }

        //            }
        //            else
        //            {
        //                throw new Exception("Company details not found while getting POs from eSupplier!");
        //            }
        //        }
        //        else if (Imodal.customerid > 0)
        //        {
        //            userflag = false;
        //            var customer = _dbContext.lesv_customers.Where(x => x.customerid == Imodal.customerid).FirstOrDefault();
        //            LeSDM.AddLog("lesv_customers received!");
        //            AllLinkedCustomers.Add(customer);
        //            if (customer != null)
        //            {
        //                Dictionary<int, int> mapping = new Dictionary<int, int>();
        //                customer_addressid.Add(customer.customerid, convert.ToInt(customer.addressid));

        //                _dbesuppliercontext.Database.SetCommandTimeout(150);
        //                var parameters = new[]
        //                {
        //                    new SqlParameter("@CurrBuyerAddressId", customer.addressid),
        //                };
        //                string sqlQuery = @"
        //                    SELECT * 
        //                    FROM Sm_Quotations_Vendor
        //                    WHERE Buyer_AddressId = @CurrBuyerAddressId
        //                    AND VENDOR_STATUS != 7
        //                    AND Doc_Type = 'Order';";

        //                var allPOs = _dbesuppliercontext.Sm_Quotations_Vendor.FromSqlRaw(sqlQuery, parameters).ToList();
        //                LeSDM.AddLog("Sm_Quotations_Vendor received!");
        //                var availablecustomers = AllLinkedCustomers.Select(x => x.addressid).ToArray();
        //                allPOs = allPOs.Where(x => availablecustomers.Contains(x.Buyer_AddressId)).ToList();
        //                //var allPOs = _dbesuppliercontext.Sm_Quotations_Vendor.Where(x => x.Buyer_AddressId == 5000197 && x.Doc_Type == "Order").ToList();
        //                if (allPOs.Count > 0)
        //                {
        //                    //var data = JsonConvert.SerializeObject(allPOs);
        //                    //modal = JsonConvert.DeserializeObject<List<V_INBOUND_SHIPMENTS>>(data).ToList();
        //                    modal = ConvertToV_InboundShipment(allPOs);
        //                }
        //            }
        //            else
        //            {
        //                throw new Exception("customer details not found while getting POs from eSupplier!");
        //            }
        //        }
        //        else
        //        {
        //            throw new Exception("No address id found !");
        //        }

        //        if (modal.Count > 0)
        //        {

        //            if (userflag)
        //            {
        //                if (customer_addressid.Count > 0)
        //                {
        //                    for (int i = 0; i < customer_addressid.Count; i++)
        //                    {
        //                        var dict = customer_addressid.ElementAt(i);
        //                        int customerid = dict.Key;
        //                        int addressid = dict.Value;
        //                        var currcustomer = AllLinkedCustomers.Where(x => x.customerid == customerid).FirstOrDefault();
        //                        for (int x = 0; x < modal.Count; x++)
        //                        {
        //                            var eachPo = modal[x];
        //                            modal[x].status_desc = "Open";
        //                            if (eachPo.Buyer_AddressId == addressid)
        //                            {
        //                                modal[x].cust_code = currcustomer.cust_code;
        //                                modal[x].cust_name = currcustomer.cust_name;
        //                                modal[x].cust_type = currcustomer.cust_type;
        //                                modal[x].customerId = currcustomer.customerid;
        //                                modal[x].companyid = currcustomer.companyid;
        //                            }

        //                        }

        //                    }

        //                }
        //            }
        //            else
        //            {
        //                if (customer_addressid.Count == 1)
        //                {

        //                    var dict = customer_addressid.ElementAt(0);
        //                    int customerid = dict.Key;
        //                    int addressid = dict.Value;

        //                    var currcustomer = AllLinkedCustomers.Where(x => x.customerid == customerid).FirstOrDefault();
        //                    modal.ForEach(x =>
        //                    {
        //                        x.status_desc = "Open";
        //                        x.customerId = currcustomer.customerid;
        //                        x.cust_code = currcustomer.cust_code;
        //                        x.cust_name = currcustomer.cust_name;
        //                        x.cust_type = currcustomer.cust_type;
        //                        x.companyid = currcustomer.companyid;
        //                    });


        //                }

        //            }
        //            //if (!string.IsNullOrEmpty(Imodal.shipmentno))
        //            //{
        //            //    modal = modal.Where(x => x.shipmentno.Contains(Imodal.shipmentno)).ToList();
        //            //}

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        LeSDM.AddLog("Exception in GetPOsfromEsupplier: " + ex.GetBaseException());
        //    }
        //    LeSDM.AddLog("GetPOsfromEsupplier process stopped !");
        //    return modal;
        //}
        private List<V_INBOUND_SHIPMENTS> ConvertToV_InboundShipment(List<SmQuotationsVendor> source)
        {
            List<V_INBOUND_SHIPMENTS> dest = new();
            V_INBOUND_SHIPMENTS eachdest = new V_INBOUND_SHIPMENTS();
            for (int i = 0; i < source.Count; i++)
            {
                eachdest = new V_INBOUND_SHIPMENTS();
                var eachsorce = source[i];
                if (eachsorce != null)
                {
                    eachdest.shipmentno = eachsorce.Vrno;
                    eachdest.Quote_AddressId = eachsorce.Quote_AddressId;
                    eachdest.Buyer_AddressId = eachsorce.Buyer_AddressId;
                    eachdest.transactionDate = eachsorce.Created_Date;
                    eachdest.vessel_name = eachsorce.Vessel_Name ?? "";
                    eachdest.jobOrderNo = eachsorce.Udf1;
                    eachdest.eta = eachsorce.Vessel_Eta;
                    eachdest.etd = eachsorce.Vessel_Etd;
                    eachdest.quotationid = eachsorce.QuotationId;

                    //eachdest.department = eachsorce.Department;

                    dest.Add(eachdest);
                }
            }
            return dest;
        }
        private INTERNAL_ORDERS ConvertToV_InboundShipmentDetails(SmQuotationsVendor eachsorce)
        {

            INTERNAL_ORDERS eachdest = new INTERNAL_ORDERS();

            var vendoraddr = _dbesuppliercontext.Sm_Quotations_Vendor_Address.Where(x => x.quotationid == eachsorce.QuotationId).FirstOrDefault();

            if (eachsorce != null && vendoraddr != null)
            {
                eachdest.FromServicePoint = vendoraddr.addr_city;
                eachdest.Internal_Order_Desc = eachsorce.Quote_Subject;
                eachdest.OrderDate = eachsorce.PoDate;
                eachdest.Delivery_Date = eachsorce.DeliveryTime;
                eachdest.FrieghtAmount = eachsorce.FreightAmt;
                eachdest.POAmount = eachsorce.Quote_Amount;
                eachdest.OtherCost = eachsorce.OtherCosts;
                eachdest.ItemTotal = eachsorce.Item_Total;
                eachdest.Currency = eachsorce.Curr_Code;
                eachdest.Internal_Order_No = eachsorce.Vrno;

            }

            return eachdest;
        }
        private int CreateOrGetVessel(string vesselname, string vesselimo)
        {
            if (vesselname != null && vesselname.Length > 0)
            {
                var vessel = _dbContext.mast_vessel
                    .Where(x => x.VesselCode.ToLower() == vesselname.ToLower() || x.VesselName.ToLower() == vesselname.ToLower())
                    .FirstOrDefault();
                if (vessel != null)
                {
                    return vessel.VesselId;
                }
                else
                {
                    Mast_Vessel modal = new Mast_Vessel();
                    modal.UpdatedDate = DateTime.Now;
                    modal.CreatedDate = DateTime.Now;
                    modal.VesselCode = vesselname;
                    //modal.ImoNo = vesselimo;
                    modal.VesselName = vesselname;
                    _dbContext.mast_vessel.Add(modal);
                    int tb = _dbContext.SaveChanges();
                    if (tb > 0)
                    {
                        return modal.VesselId;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            else
            {
                return 0;
            }
        }
        private string ConvertToLower(string? str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return "";

            return str.Trim().ToLower();
        }
        private InboundShipment ConvertQuotationToShipment(SmQuotationsVendor modal)
        {
            var customer = _dbContext.lesv_customers.Where(x => x.addressid == modal.Buyer_AddressId || x.addressid == modal.Quote_AddressId).FirstOrDefault();
            if (customer != null)
            {
                var ifalredyexist = _dbContext.v_inbound_shipments.Any(x => x.shipmentno.ToLower() == modal.Vrno.ToLower() && x.customerId == customer.customerid);
                if (ifalredyexist)
                {
                    throw new Exception("Given shipment is already exist in LogiLink unable to copy it!");
                }
                InboundShipment dest = new InboundShipment();
                dest.shipmentno = modal.Vrno;
                dest.transactionDate = modal.Created_Date;
                dest.vesselid = CreateOrGetVessel(modal.Vessel_Name, modal.Vessel_IdNo);
                dest.eta = modal.Vessel_Eta;
                dest.etd = modal.Vessel_Etd;
                dest.companyid = customer.companyid;
                dest.customerId = customer.customerid;
                dest.createdDate = DateTime.Now;
                dest.updatedDate = DateTime.Now;
                dest.jobOrderNo = modal.Udf1;
                dest.statusId = 1;//open
                dest.instRemarks = modal.Attention_Remark;
                _dbContext.inboundShipment.Add(dest);
                int changes = _dbContext.SaveChanges();
                if (changes > 0)
                {
                    return dest;

                }
                else
                {
                    throw new Exception("Something went wrong while assign DO!");
                }
            }
            else
            {
                throw new Exception("Customer details not found!");
            }


        }
        private INTERNAL_ORDERS ConvertQuotationToInternalOrder(SmQuotationsVendor modal, InboundShipment shipment)
        {
            var customer = _dbContext.lesv_customers.Where(x => x.addressid == modal.Buyer_AddressId || x.addressid == modal.Quote_AddressId).FirstOrDefault();
            INTERNAL_ORDERS dest = new INTERNAL_ORDERS();
            var vendoraddr = _dbesuppliercontext.Sm_Quotations_Vendor_Address.Where(x => x.quotationid == modal.QuotationId).FirstOrDefault();

            dest.FrieghtAmount = modal.FreightAmt;
            dest.Internal_Order_Desc = modal.Quote_Subject;
            dest.OrderDate = modal.PoDate;
            dest.Delivery_Date = modal.DeliveryTime;
            dest.POAmount = modal.Quote_Amount;
            dest.OtherCost = modal.OtherCosts;
            dest.ItemTotal = modal.Item_Total;
            dest.Currency = modal.Curr_Code;
            dest.Internal_Order_No = modal.Vrno;
            dest.quotationid = modal.QuotationId;
            if (vendoraddr != null)
            {
                dest.FromServicePoint = vendoraddr.addr_city;
            }
            dest.StatusId = 1;//Open
            dest.Inboundshipmentid = shipment.inboundShipmentId;
            _dbContext.internal_orders.Add(dest);
            int changes = _dbContext.SaveChanges();
            if (changes > 0)
            {
                return dest;
            }
            else
            {
                throw new Exception("Something went wrong while saving internal order!");
            }

        }
        private List<Internal_Order_Line> ConvertDetailvendorToInternalOrderLines(List<Sm_Quotationdetail_Vendor> source, int orderid = 0)
        {
            List<Internal_Order_Line> dest = new();
            Internal_Order_Line eachdest = new Internal_Order_Line();
            for (int i = 0; i < source.Count; i++)
            {
                eachdest = new Internal_Order_Line();
                var eachsorce = source[i];
                if (eachsorce != null)
                {
                    eachdest.qty = eachsorce.Qty_Ord;
                    //eachdest.qty_Rec = eachsorce.Qty_Req;
                    eachdest.part_Price = eachsorce.Quoted_Price;
                    //eachdest.receiptDate = eachsorce.Created_Date;
                    //eachdest.arrivalDate = eachsorce.DeliveryTime;
                    eachdest.partName = eachsorce.PartName;
                    eachdest.partNo = eachsorce.ExternalItemNumber;
                    eachdest.lineNo = eachsorce.ItemNo;
                    eachdest.specialInstructions = eachsorce.Equip_Remarks;
                    eachdest.remarks = eachsorce.Item_Remark;
                    if (orderid > 0)
                    {
                        eachdest.orderId = orderid;
                    }
                    dest.Add(eachdest);
                }
            }
            return dest;
        }
        protected StandardAPIresponse GetDeliveryOrderCount(int internalorderid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            responsemodal.status = "FAIL";
            responsemodal.isSuccess = false;
            var allDOs = _dbContext.v_delivery_orders_info.Where(x => x.internalOrderId == internalorderid).ToList();
            if (allDOs != null && allDOs.Count > -1)
            {
                responsemodal.data = allDOs.Count();
                responsemodal.totalRecords = allDOs.Count();
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            else
            {
                responsemodal.data = 0;
                responsemodal.totalRecords = 0;
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            return responsemodal;
        }
        protected StandardAPIresponse GetDeliveryOrderCountbyInboundId(int inboundshipmentid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            responsemodal.status = "FAIL";
            responsemodal.isSuccess = false;
            var internalOrders = _dbContext.internal_orders.Where(x => x.Inboundshipmentid == inboundshipmentid).FirstOrDefault();
            var allDOs = _dbContext.v_delivery_orders_info.Where(x => x.internalOrderId == internalOrders.InternalOrderId).ToList();
            if (allDOs != null && allDOs.Count > -1)
            {
                responsemodal.data = allDOs.Count();
                responsemodal.totalRecords = allDOs.Count();
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            else
            {
                responsemodal.data = 0;
                responsemodal.totalRecords = 0;
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            return responsemodal;
        }
        protected StandardAPIresponse GetRemainingPOlinesCount(int internalorderid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            responsemodal.status = "FAIL";
            responsemodal.isSuccess = false;
            var modal = _dbContext.VRemainingInternalOrderLines.Where(x => x.OrderId == internalorderid).ToList();
            var InternalOrder = _dbContext.internal_orders.Find(internalorderid);          
            if (modal != null&& modal.Count > -1&& InternalOrder!=null)
            {
                responsemodal.data = ""+modal.Count()+"|"+InternalOrder.StatusId ?? 0+"";
                responsemodal.totalRecords = modal.Count();
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;
               
            }
            else
            {
                responsemodal.data = 0;
                responsemodal.totalRecords = 0;
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            return responsemodal;
        }
        protected StandardAPIresponse GetRemainingPOlinesCountbyInboundId(int inboundshipmentid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            responsemodal.status = "FAIL";
            responsemodal.isSuccess = false;
            var internalorders = _dbContext.internal_orders.Where(x => x.Inboundshipmentid == inboundshipmentid).FirstOrDefault();
            var modal = _dbContext.VRemainingInternalOrderLines.Where(x => x.OrderId == internalorders.InternalOrderId).ToList();
            //var InternalOrder = _dbContext.internal_orders.Find(internalorderid);
            if (modal != null && modal.Count > -1 && internalorders != null)
            {
                responsemodal.data = "" + modal.Count() + "|" + internalorders.StatusId ?? 0 + "";
                responsemodal.totalRecords = modal.Count();
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            else
            {
                responsemodal.data = 0;
                responsemodal.totalRecords = 0;
                responsemodal.status = "SUCCESS";
                responsemodal.isSuccess = true;

            }
            return responsemodal;
        }
        protected StandardAPIresponse AssignDOtoPOInbound(AssignDoToPO_Inbound modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            LeSDM.AddLog("AssignDOtoPOInbound process started!");
            LeSDM.AddLog(JsonConvert.SerializeObject(modal));
            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
            executionStrategy.Execute(() =>
            {
                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                {

                    try
                    {
                        if ((modal.quotationid > 0 || modal.internalorderid > 0) && modal.inboundshipmentid > 0) { }
                        else
                        {
                            throw new Exception("Purchase order not found!");
                        }
                        if (modal.DeliveryOrderNo != null && modal.DeliveryOrderNo.Length > 0) { }
                        else
                        {
                            throw new Exception("Please fill valid deliver order number!");
                        }
                        var isduplicate = _dbContext.delivery_orders.Any(x => x.DeliveryOrderNo.Trim().ToLower() == modal.DeliveryOrderNo.Trim().ToLower());
                        if (isduplicate)
                        {
                            throw new Exception("Please enter unique delivery order number!");
                        }
                        if (modal.DeliveryOrderDate != null && modal.DeliveryOrderDate != DateTime.MinValue && modal.DeliveryOrderDate != DateTime.MaxValue) { }
                        else
                        {
                            throw new Exception("Please fill valid delivery order date!");
                        }
                        if (modal.Isfullorsplit == 0 || modal.Isfullorsplit == 1) { }
                        else
                        {
                            throw new Exception("Please check full delivery or split deliveries!");
                        }
                        if (modal.companyid > 0) { }
                        else
                        {
                            throw new Exception("Oops, Company not found!");

                        }
                        if (modal.customerid > 0) { }
                        else
                        {
                            throw new Exception("Oops, Customer not found!");

                        }

                        int deliveryOrderId = CreateDeliveryOrder(modal);
                        if (deliveryOrderId > 0)
                        {
                            if (CreateDeliveryOrderLines(modal, deliveryOrderId))
                            {
                                if (SaveDeliveryOrderDocuments(modal.Documents, deliveryOrderId, modal.companyid, modal.createdBy))
                                {
                                    dbContextTransaction.Commit();
                                    responsemodal.isSuccess = true;
                                    responsemodal.status = "SUCCESS";
                                    responsemodal.message = "Delivery order successfully created : " + modal.DeliveryOrderNo;
                                }
                                else
                                {
                                    throw new Exception("Unable to save delivery order attachments!");
                                }


                            }
                            else
                            {
                                dbContextTransaction.Rollback();
                            }
                        }
                        else
                        {
                            dbContextTransaction.Rollback();
                            throw new Exception("Unable to create delivery order details for given PO details!");
                        }

                    }
                    catch (Exception ex)
                    {
                        dbContextTransaction.Rollback();
                        responsemodal.isSuccess = false;
                        responsemodal.message = ex.Message;
                        LeSDM.AddLog("Exception in AssignDOtoPOInbound: " + ex.Message);
                    }
                }
            });
            return responsemodal;
        }
        private bool SaveDeliveryOrderDocuments(List<string> dodocuments, int deliveryorderid, int companyid, int createdby)
        {
            bool result = false;
            try
            {
                string esupplerAttachmentpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("ESUPPLIER_ATTACHMENT_PATH").Value);
                Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == companyid && x.moduleid == 13 && x.siteconfig_paramid == 1015);
                if (mast_SITE_CONFIG == null)
                {
                    throw new Exception("No configurations found for logged in company!");
                }
                string temppath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("TEMP_DOCUMENTS").Value);
                if (!Path.Exists(temppath))
                {
                    throw new Exception("No source path found for uploaded documents! Please contact site owner.");
                }
                //if (!Path.Exists(esupplerAttachmentpath))
                //{
                //    Directory.CreateDirectory(esupplerAttachmentpath);
                //}
                if (!Path.Exists(mast_SITE_CONFIG.param_value))
                {
                    Directory.CreateDirectory(mast_SITE_CONFIG.param_value);
                }
                Delivery_Orders _deliveryOrderExt = _dbContext.delivery_orders.Find(deliveryorderid);
                Delivery_Orders _deliveryOrder = _deliveryOrderExt;
                if (_deliveryOrder != null)
                {
                    if (convert.ToInt(_deliveryOrder.StatusId) > 0 && convert.ToInt(_deliveryOrder.StatusId) < 3)
                    {
                        //_deliveryOrder.StatusId = convert.ToInt(Status.DRAFT);
                        _deliveryOrder.UpdateDate = DateTime.Now;
                        _deliveryOrder.updated_by = createdby;
                        _dbContext.Entry(_deliveryOrderExt).CurrentValues.SetValues(_deliveryOrder);
                    }
                    else
                    {
                        throw new Exception("Invalid status of delivery order.");
                    }
                }
                else
                {
                    throw new Exception("Unable to get delivery order details");
                }

                if (dodocuments != null && dodocuments.Count > 0)
                {

                    for (int i = 0; i < dodocuments.Count; i++)
                    {
                        var eachdoc = dodocuments[i];
                        string destfilename = GetOriginalFileName(eachdoc);

                        string sourceFile = Path.Combine(temppath, eachdoc);
                        if (!Path.Exists(sourceFile))
                        {
                            throw new Exception("File not found : " + destfilename);
                        }
                        string Dbpath = Path.Combine(companyid.ToString(), deliveryorderid.ToString(), destfilename);
                        //string FinalDestination = Path.Combine(esupplerAttachmentpath, Dbpath);
                        string FinalDestination = Path.Combine(mast_SITE_CONFIG.param_value, Dbpath);
                        Directory.CreateDirectory(Path.GetDirectoryName(FinalDestination));
                        File.Copy(sourceFile, FinalDestination, true);
                        Delivery_Order_Documents DoDOC = new Delivery_Order_Documents();
                        DoDOC.DocumentTitle = "DO_Attachment";
                        DoDOC.DocumentPath = Dbpath;
                        DoDOC.created_by = createdby;
                        DoDOC.DocumentName = destfilename;
                        DoDOC.DeliveryOrderId = deliveryorderid;
                        DoDOC.CreatedDate = DateTime.Now;

                        DoDOC.DocumentType = "";
                        _dbContext.delivery_order_documents.Add(DoDOC);

                    }
                    int updates = _dbContext.SaveChanges();
                    if (updates > 0)
                    {
                        result = true;
                    }
                    else
                    {
                        throw new Exception("Unable to save attachments, Please contact support.");
                    }
                }

            }
            catch (Exception ex)
            {
                LeSDM.AddLog("Exception in SaveDeliveryOrderDocuments: " + ex.Message);
            }
            return result;
        }
        private string GetOriginalFileName(string sanitizedFileName)
        {
            string extension = Path.GetExtension(sanitizedFileName);
            string baseName = Path.GetFileNameWithoutExtension(sanitizedFileName);
            int underscoreIndex = baseName.LastIndexOf('_');
            if (underscoreIndex > 0)
            {
                return baseName.Substring(0, underscoreIndex) + extension;
            }
            return sanitizedFileName;
        }
        private int CreateDeliveryOrder(AssignDoToPO_Inbound modal)
        {
            int deliveryOrderId = 0;
            try
            {
                var customer = _dbContext.lesv_customers.Where(x => x.customerid == modal.customerid).FirstOrDefault();

                Delivery_Orders dest = new Delivery_Orders();
                dest.DeliveryDate = modal.DeliveryOrderDate;
                dest.DeliveryOrderNo = modal.DeliveryOrderNo;
                dest.CreatedDate = DateTime.Now;
                dest.created_by = modal.createdBy;
                dest.OrderId = modal.internalorderid;
                dest.CompanyId = modal.companyid;
                dest.CustomerId = modal.customerid;
                dest.EndCustomerId = modal.customerid;

                dest.StatusId = 1;//open
                dest.InternalOrderId = modal.internalorderid;
                //dest.ShipmentId = modal.inboundshipmentid;
                _dbContext.delivery_orders.Add(dest);
                int updates = _dbContext.SaveChanges();
                if (updates > 0)
                {
                    Delivery_Order_Info info = new Delivery_Order_Info();
                    info.delivery_order_id = dest.DeliveryOrderId;
                    info.customerid = modal.customerid;
                    info.vessel_id = CreateOrGetVessel(modal.VesselName, "");
                    info.requested_delivery_date = modal.DeliveryOrderDate;
                    info.planneddeliverydate = modal.DeliveryOrderDate;
                    info.customer_name = customer.cust_name;
                    info.customer_no = customer.cust_code;
                    info.do_job_no = modal.JobNo;
                    _dbContext.delivery_order_info.Add(info);
                    int updat = _dbContext.SaveChanges();

                    deliveryOrderId = dest.DeliveryOrderId;
                    LeSDM.AddLog("Delivery order successfully created!");
                }

            }
            catch (Exception ex)
            {

                LeSDM.AddLog("Exception in CreateDeliveryOrder: " + ex.Message);
            }
            return deliveryOrderId;
        }
        private bool CreateDeliveryOrderLines(AssignDoToPO_Inbound modal, int deliveryOrderID)
        {
            bool result = false;
            try
            {
                if (modal.POlines != null && modal.POlines.Count > 0)
                {

                    for (int i = 0; i < modal.POlines.Count; i++)
                    {
                        var eachLine = modal.POlines[i];
                        var SourceLine = _dbContext.Internal_Order_Line.Where(x => x.Internallineid == eachLine.internalOrderLineId).FirstOrDefault();
                        Delivery_Order_Lines line = new Delivery_Order_Lines();

                        if (SourceLine != null)
                        {
                            if (eachLine.qty > SourceLine.qty)
                            {
                                throw new Exception("Entered quantity found greater than original quantity for line :" + SourceLine.lineNo + " for Part : " + SourceLine.partName);
                            }
                            line.DeliveryOrderId = deliveryOrderID;

                            line.CreatedBy = modal.createdBy;
                            line.CreatedDate = DateTime.Now;
                            line.ItemRefNo = convert.ToString(SourceLine.lineNo);
                            line.ItemDescription = SourceLine.partName;
                            line.Quantity = eachLine.qty;
                            line.Uom = SourceLine.uom;

                            line.EPOD_LINE_REMARKS = SourceLine.specialInstructions;
                            line.InternalOrderLineId = eachLine.internalOrderLineId;
                            _dbContext.delivery_order_lines.Add(line);
                            int updates = _dbContext.SaveChanges();
                            if (updates > 0)
                            {
                                result = true;
                            }
                            else
                            {
                                throw new Exception("Unable to save delivery order lines !");
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to attach lines to DO!");
                        }
                    }

                    //int updates = _dbContext.SaveChanges();
                    //if (updates > 0)
                    //{
                    //    result = true;
                    //}
                    //else
                    //{
                    //    throw new Exception("Unable to save delivery order lines !");
                    //}
                }
                else
                {
                    throw new Exception("No lines found to be attached to DO!");
                }
            }
            catch (Exception ex)
            {
                LeSDM.AddLog("Exception in CreateDeliveryOrderLines: " + ex.Message);
            }
            return result;
        }
        protected StandardAPIresponse ImportPofromEsupplierToLogiLink(int quotationid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            try
            {
                if (quotationid > 0)
                {

                    var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                    executionStrategy.Execute(() =>
                    {
                        using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                        {
                            try
                            {
                                (bool result, int orderid, int inboundshipment) = InsertPOEsupplierToLogilink(quotationid); ;
                                if (result)
                                {
                                    dbContextTransaction.Commit();
                                    responsemodal.status = "SUCCESS";
                                    responsemodal.isSuccess = true;
                                    responsemodal.data = orderid + "|" + inboundshipment;


                                }
                                else
                                {
                                    responsemodal.status = "SUCCESS";
                                    responsemodal.isSuccess = true;
                                    dbContextTransaction.Rollback();
                                }
                            }
                            catch (Exception ex)
                            {
                                responsemodal.isSuccess = false;
                                responsemodal.message = ex.Message;
                                dbContextTransaction.Rollback();
                            }

                        }
                    });

                }
                else
                {
                    responsemodal.isSuccess = false;
                    responsemodal.message = "Something went wrong!";
                }
            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in ImportPofromEsupplierToLogiLink: " + ex.Message);
            }
            return responsemodal;
        }
        protected StandardAPIresponse LoadRemainingInternalOrderLines(int internalorderid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            try
            {
                var allremainingLines = _dbContext.VRemainingInternalOrderLines.Where(x => x.OrderId == internalorderid).ToList();
                if (allremainingLines != null)
                {
                    responsemodal.isSuccess = true;
                    responsemodal.status = "SUCCESS";
                    responsemodal.data = allremainingLines;
                }


            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in LoadRemainingInternalOrderLines: " + ex.Message);
            }
            return responsemodal;
        }
        protected StandardAPIresponse LoadDeliveryOrdersByInternalOrderLines(int internalorderid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            try
            {
                var allDOs = _dbContext.v_delivery_orders_info.Where(x => x.internalOrderId == internalorderid).ToList(); //&& x.statusid != 4
                if (allDOs != null)
                {
                    responsemodal.isSuccess = true;
                    responsemodal.status = "SUCCESS";
                    responsemodal.data = allDOs;
                }


            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in LoadRemainingInternalOrderLines: " + ex.Message);
            }
            return responsemodal;
        }
        protected object UpdateUnAssignDOtoDeliveryOrder(int deliveryOrderId)
        {
            responseMessage _response = new responseMessage();
            int Updated = 0;
            try
            {
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            Delivery_Orders _delOrderDataExt = _dbContext.delivery_orders.Find(deliveryOrderId);
                            if (_delOrderDataExt != null)
                            {
                                List<Delivery_Order_Lines> delivery_Order_LinesExt = _dbContext.delivery_order_lines.Where(x => x.DeliveryOrderId == _delOrderDataExt.DeliveryOrderId).ToList();

                                if (delivery_Order_LinesExt.Any())
                                {
                                    _dbContext.delivery_order_lines.RemoveRange(delivery_Order_LinesExt);
                                    //_dbContext.SaveChanges();
                                }

                                List<Delivery_Order_Info> _delOrderInfoExt = _dbContext.delivery_order_info.Where(x => x.delivery_order_id == _delOrderDataExt.DeliveryOrderId).ToList();

                                if (_delOrderInfoExt.Any())
                                {
                                    _dbContext.delivery_order_info.RemoveRange(_delOrderInfoExt);
                                    //_dbContext.SaveChanges();
                                }

                                List<Delivery_Order_Documents> _deliveryOrderDocuments = _dbContext.delivery_order_documents.Where(x => x.DeliveryOrderId == _delOrderDataExt.DeliveryOrderId).ToList();
                                if (_deliveryOrderDocuments.Any())
                                {
                                    _dbContext.delivery_order_documents.RemoveRange(_deliveryOrderDocuments);
                                    //_dbContext.SaveChanges();
                                }

                                var _deleteDOs = _dbContext.delivery_orders.Remove(_delOrderDataExt);

                                Updated += _dbContext.SaveChanges();

                                if (Updated > 0)
                                {
                                    dbContextTransaction.Commit();
                                    //_response.data = _delOrderData;
                                    _response.status = "SUCCESS";
                                    _response.isSuccess = true;
                                    _response.message = "Delivery Order successfully Removed : " + _delOrderDataExt.DeliveryOrderNo + "";
                                    LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order successfully Removed : " + _delOrderDataExt.DeliveryOrderNo + "", "", "", "", "");

                                }

                                //Delivery_Orders _delOrderData = _delOrderDataExt;
                                //_delOrderData.ShipmentId = null;
                                //_delOrderData.StatusId = convert.ToInt(Status.CANCELLED); // setting Open status 
                                //_delOrderData.UpdateDate = DateTime.Now;
                                //_delOrderData.updated_by = _detailsObj.UpdatedBy;

                                //_dbContext.Entry(_delOrderDataExt).CurrentValues.SetValues(_delOrderData);

                            }
                            else
                            {
                                throw new Exception("Unable to get Delivery Orders.");
                            }

                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while unassigned Shipment to Delivery Order : " + ex.Message);
                            throw ex;
                        }

                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while unassigned Purchase Order to Delivery Order : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on Update UnAssign Shipment to Delivery Order: " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        protected object UpdateReleaseDeliveryOrder(ReleasedData data)
        {
            responseMessage _response = new responseMessage();
            int Updated = 0;
            try
            {

                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var internalOrderExt = _dbContext.internal_orders.Find(data.internalOrderId);
                            if (internalOrderExt != null)
                            {
                                InboundShipment _inboundShipmentExt = _dbContext.inboundShipment.Find(internalOrderExt.Inboundshipmentid);

                                var allremainingLines = _dbContext.VRemainingInternalOrderLines.Where(x => x.OrderId == data.internalOrderId).ToList();

                                List<Delivery_Orders> _deliveryOrders = _dbContext.delivery_orders.Where(x => x.InternalOrderId == data.internalOrderId && x.StatusId != 3).ToList(); // dos are not released

                                if (_inboundShipmentExt != null)
                                {
                                    if (_inboundShipmentExt.statusId == 1 && _deliveryOrders.Count == 1 && allremainingLines.Count == 0)
                                    {
                                        InboundShipment _inboundShipment = _inboundShipmentExt;

                                        _inboundShipment.statusId = convert.ToInt(Status.RELEASED); // setting RELEASED status 
                                        _inboundShipment.updatedDate = DateTime.Now;
                                        _inboundShipment.updatedBy = data.createdBy;

                                        _dbContext.Entry(_inboundShipmentExt).CurrentValues.SetValues(_inboundShipment);

                                        Updated += _dbContext.SaveChanges();

                                        INTERNAL_ORDERS _internalOrder = internalOrderExt;

                                        _internalOrder.StatusId = convert.ToInt(Status.RELEASED); // setting RELEASED status 
                                        _internalOrder.Updated_Date = DateTime.Now;

                                        _dbContext.Entry(internalOrderExt).CurrentValues.SetValues(_internalOrder);

                                        Updated += _dbContext.SaveChanges();

                                    }
                                }
                                Delivery_Orders _delOrderDataExt = _dbContext.delivery_orders.Find(data.deliveryOrderid);
                                if (_delOrderDataExt != null)
                                {
                                    Delivery_Orders _delOrderData = _delOrderDataExt;
                                    _delOrderData.ShipmentId = null;
                                    _delOrderData.StatusId = convert.ToInt(Status.RELEASED); // setting Open status 
                                    _delOrderData.UpdateDate = DateTime.Now;
                                    _delOrderData.updated_by = data.createdBy;

                                    _dbContext.Entry(_delOrderDataExt).CurrentValues.SetValues(_delOrderData);

                                    Updated += _dbContext.SaveChanges();

                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _delOrderData;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Delivery Order successfully Released : " + _delOrderDataExt.DeliveryOrderNo + "";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Delivery Order successfully Released : " + _delOrderDataExt.DeliveryOrderNo + "", "", "", "", "");

                                    }

                                }
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while released Delivery Order : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while Release Delivery Order : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on Update Release Delivery Order: " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        protected object CallReleasePODO(AssignDoToPO_Inbound data)
        {
            responseMessage _response = new responseMessage();
            int Updated = 0;
            try
            {
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            var allremainingLines = _dbContext.VRemainingInternalOrderLines.Where(x => x.OrderId == data.internalorderid).ToList();
                            InboundShipment inboundShipmentExt = _dbContext.inboundShipment.Find(data.inboundshipmentid);
                            if (allremainingLines.Count == 0)
                            {
                                
                                if (inboundShipmentExt != null)
                                {
                                    InboundShipment _inboundShipment = inboundShipmentExt;

                                    _inboundShipment.statusId = convert.ToInt(Status.RELEASED); // setting RELEASED status 
                                    _inboundShipment.updatedDate = DateTime.Now;
                                    _inboundShipment.updatedBy = data.updatedBy;

                                    _dbContext.Entry(inboundShipmentExt).CurrentValues.SetValues(_inboundShipment);

                                    Updated += _dbContext.SaveChanges();


                                }

                                INTERNAL_ORDERS internalOrderExt = _dbContext.internal_orders.Where(x => x.Inboundshipmentid == data.inboundshipmentid).FirstOrDefault();
                                if (internalOrderExt != null)
                                {
                                    INTERNAL_ORDERS _internalOrder = internalOrderExt;

                                    _internalOrder.StatusId = convert.ToInt(Status.RELEASED); // setting RELEASED status 
                                    _internalOrder.Updated_Date = DateTime.Now;

                                    _dbContext.Entry(internalOrderExt).CurrentValues.SetValues(_internalOrder);

                                    Updated += _dbContext.SaveChanges();


                                }

                                List<Delivery_Orders> _delOrderDataExt = _dbContext.delivery_orders.Where(x => x.InternalOrderId == data.internalorderid).ToList();
                                if (_delOrderDataExt.Count > 0)
                                {
                                    for (int i = 0; i < _delOrderDataExt.Count; i++)
                                    {
                                        Delivery_Orders _delOrderData = _delOrderDataExt[i];
                                        _delOrderData.ShipmentId = null;
                                        _delOrderData.StatusId = convert.ToInt(Status.RELEASED); // setting RELEASED status 
                                        _delOrderData.UpdateDate = DateTime.Now;
                                        _delOrderData.updated_by = data.updatedBy;

                                        _dbContext.Entry(_delOrderDataExt[i]).CurrentValues.SetValues(_delOrderData);
                                    }
                                    Updated += _dbContext.SaveChanges();

                                }
                            }
                            if (Updated > 0)
                            {
                                dbContextTransaction.Commit();
                                //_response.data = _delOrderData;
                                _response.status = "SUCCESS";
                                _response.isSuccess = true;
                                _response.message = "Inbound Shipment successfully Released : " + inboundShipmentExt.shipmentno + "";
                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Inbound Shipment successfully Released : " + inboundShipmentExt.shipmentno + "", "", "", "", "");

                            }
                            else
                            {
                                _response.status = "FAIL";
                                _response.isSuccess = false;
                                _response.message = "Internal order lines remains present for : " + inboundShipmentExt.shipmentno + "";
                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "FAIL", "", "Internal order lines remains present for : " + inboundShipmentExt.shipmentno + "", "", "", "", "");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while released Delivery Order : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while Release Delivery Order : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on Update Release Delivery Order: " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        protected StandardAPIresponse GetInboundShipmentFromQuotation(int quotationid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            try
            {
                if (quotationid > 0)
                {
                    var Order = _dbContext.internal_orders.Where(x => x.quotationid == quotationid).FirstOrDefault();

                    if (Order != null && Order.Inboundshipmentid > 0)
                    {
                        responsemodal.message = "SUCCESSS";
                        responsemodal.data = Order.Inboundshipmentid;
                        responsemodal.isSuccess = true;
                    }
                    else
                    {
                        var quotation = _dbesuppliercontext.Sm_Quotations_Vendor.Where(x => x.QuotationId == quotationid).FirstOrDefault();
                        var shipment = _dbContext.inboundShipment.Where(x => x.shipmentno.ToLower() == quotation.Vrno.ToLower()).FirstOrDefault();
                        if (shipment != null)
                        {
                            responsemodal.message = "SUCCESSS";
                            responsemodal.data = shipment.inboundShipmentId;
                            responsemodal.isSuccess = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                LeSDM.AddLog("Exception in GetInboundShipmentFromQuotation: " + ex.Message);
            }
            return responsemodal;
        }
        private (bool, int, int) InsertPOEsupplierToLogilink(int quotationid)
        {
            bool result = false;
            int internalorderid = 0;
            int inboundOrderId = 0;

            try
            {
                var Currquoation = _dbesuppliercontext.Sm_Quotations_Vendor.Where(x => x.QuotationId == quotationid).FirstOrDefault();
                var allquotationLines = _dbesuppliercontext.Sm_Quotationdetail_Vendor.Where(x => x.QuotationId == quotationid).ToList();
                if (Currquoation != null)
                {
                    if (allquotationLines != null && allquotationLines.Count > 0)
                    {

                        var inboundshipment = ConvertQuotationToShipment(Currquoation);
                        if (inboundshipment != null)
                        {
                            var internalOrder = ConvertQuotationToInternalOrder(Currquoation, inboundshipment);
                            var AllLines = _dbesuppliercontext.Sm_Quotationdetail_Vendor.Where(x => x.QuotationId == Currquoation.QuotationId).ToList();
                            if (AllLines != null && AllLines.Count > 0 && internalOrder != null)
                            {
                                var convLines = ConvertDetailvendorToInternalOrderLines(AllLines, internalOrder.InternalOrderId);
                                _dbContext.Internal_Order_Line.AddRange(convLines);
                                var changes = _dbContext.SaveChanges();
                                if (changes > 0)
                                {
                                    internalorderid = internalOrder.InternalOrderId;
                                    inboundOrderId = inboundshipment.inboundShipmentId;
                                    result = true;
                                }
                                else
                                {
                                    throw new Exception("Something went wrong while saving internal order lines !");

                                }
                            }

                        }
                        else
                        {
                            throw new Exception("Something went wrong while saving inbound shipment!");
                        }

                    }
                    else
                    {
                        throw new Exception("No purchase order lines found !");
                    }
                }
                else
                {
                    throw new Exception("Purchase order not found !");
                }
            }
            catch (Exception ex)
            {
                result = false;
                LeSDM.AddLog("Exception in checkEsupplierToLogilinkPOtransfer: " + ex.Message);
            }
            return (result, internalorderid, inboundOrderId);
        }
        protected StandardAPIresponse GetVInboundShipmentDetails(int shipmentid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            try
            {

                var inboundshipment = _dbContext.v_inbound_shipments.Where(x => x.inboundShipmentId == shipmentid).FirstOrDefault();
                if (inboundshipment != null)
                {
                    var UserCompany = _dbContextUserAdmin.les_company.Where(x => x.companyid == inboundshipment.companyid).FirstOrDefault();
                    inboundshipment.CompanyCode = UserCompany.company_code ?? "";
                    inboundshipment.CompanyName = UserCompany.company_description ?? "";
                    responsemodal.totalRecords = 1;
                    responsemodal.data = inboundshipment;
                    responsemodal.isSuccess = true;
                }
                else
                {
                    responsemodal.isSuccess = false;
                    responsemodal.message = "No shipment found!";
                }
            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in GetVInboundShipmentDetails: " + ex.Message);
            }
            return responsemodal;
        }
        protected StandardAPIresponse GetVInboundShipmentDetailsFromesupplier(int quotationid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            V_INBOUND_SHIPMENTS obj = new V_INBOUND_SHIPMENTS();
            try
            {
                List<SmQuotationsVendor> ls = new List<SmQuotationsVendor>();
                var quotation = _dbesuppliercontext.Sm_Quotations_Vendor.Where(x => x.QuotationId == quotationid).FirstOrDefault();
                if (quotation != null)
                {
                    ls.Add(quotation);
                    var company = _dbContextUserAdmin.les_company.Where(x => quotation.Buyer_AddressId == x.addressid || quotation.Quote_AddressId == x.addressid).FirstOrDefault();
                    var customer = _dbContext.lesv_customers.Where(x => quotation.Buyer_AddressId == x.addressid || quotation.Quote_AddressId == x.addressid).FirstOrDefault();
                    if (customer != null)
                    {
                        var UserCompany = _dbContextUserAdmin.les_company.Where(x => x.companyid == customer.companyid).FirstOrDefault();
                        var inbound = ConvertToV_InboundShipment(ls);
                        obj = inbound[0];
                        obj.companyid = customer.companyid;
                        obj.customerId = customer.customerid;
                        obj.cust_code = customer.cust_code;
                        obj.cust_name = customer.cust_name;
                        obj.cust_type = customer.cust_type;
                        obj.CompanyCode = UserCompany.company_code;
                        obj.CompanyName = UserCompany.company_description;
                        obj.status_desc = "Open";
                        responsemodal.data = obj;
                        responsemodal.isSuccess = true;
                        responsemodal.status = "SUCCESS";

                    }
                    else
                    {
                        responsemodal.isSuccess = false;
                        responsemodal.message = "No customer found in logilink for : " + quotation.Vrno;
                    }
                }
                else
                {
                    responsemodal.isSuccess = false;
                    responsemodal.message = "No shipment found!";
                }
            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in GetVInboundShipmentDetails: " + ex.Message);
            }
            return responsemodal;
        }
        protected StandardAPIresponse GetLinkedpurchaseOrderByEsupplier(int quotationid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            try
            {
                var allLines = _dbesuppliercontext.Sm_Quotationdetail_Vendor.Where(x => x.QuotationId == quotationid).ToList();
                if (allLines != null && allLines.Count > 0)
                {
                    var lines = ConvertDetailvendorToInternalOrderLines(allLines);
                    responsemodal.data = lines;
                    responsemodal.message = "SUCCESS";
                    responsemodal.isSuccess = true;
                }
                else
                {
                    responsemodal.isSuccess = false;
                    responsemodal.message = "No lines found!";
                }
            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in GetLinkedpurchaseOrderByEsupplier: " + ex.Message);
            }
            return responsemodal;
        }
        protected StandardAPIresponse GetLinkedInternalOrderLinesbyPOId(int internalorderid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            try
            {
                var internalorderLines = _dbContext.Internal_Order_Line.Where(x => x.orderId == internalorderid).ToArray();
                if (internalorderLines != null && internalorderLines.Length > 0)
                {
                    responsemodal.totalRecords = internalorderLines.Length;
                    responsemodal.data = internalorderLines;
                    responsemodal.isSuccess = true;
                }
                else
                {
                    responsemodal.isSuccess = false;
                    responsemodal.message = "No purchase order lines found!";
                }
            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in GetLinkedPurchaseOrdersbyShipId: " + ex.Message);
            }
            return responsemodal;
        }

        protected StandardAPIresponse GetLinkedPurchaseOrdersbyShipId(int inboundhshipmentid)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            try
            {
                var internalorder = _dbContext.internal_orders.Where(x => x.Inboundshipmentid == inboundhshipmentid).FirstOrDefault();
                if (internalorder != null)
                {
                    responsemodal.totalRecords = 1;
                    responsemodal.data = internalorder;
                    responsemodal.isSuccess = true;
                }
                else
                {
                    responsemodal.isSuccess = false;
                    responsemodal.message = "No purchase order found!";
                }
            }
            catch (Exception ex)
            {
                responsemodal.isSuccess = false;
                responsemodal.message = ex.Message;
                LeSDM.AddLog("Exception in GetLinkedPurchaseOrdersbyShipId: " + ex.Message);
            }
            return responsemodal;
        }
        protected StandardAPIresponse GetlinkedpurchaseorderdetailsEsupplier(int quotationid)
        {
            StandardAPIresponse modal = new StandardAPIresponse();

            try
            {
                var quotation = _dbesuppliercontext.Sm_Quotations_Vendor.Where(x => x.QuotationId == quotationid).FirstOrDefault();
                if (quotation != null)
                {
                    var convdata = ConvertToV_InboundShipmentDetails(quotation);
                    modal.isSuccess = true;
                    modal.message = "SUCCESS";
                    modal.data = convdata;

                }
                else
                {
                    modal.isSuccess = false;
                    modal.message = "No purchase order found!";
                }
            }
            catch (Exception ex)
            {
                modal.isSuccess = false;
                modal.message = ex.Message;
                LeSDM.AddLog("Exception in Getlinkedpurchaseorderdetails: " + ex.Message);
            }
            return modal;
        }
        #endregion V_INBOUND_SHIPMENT

        #region V_SHIPMENT_TRIP_PLAN
        protected List<V_SHIPMENT_TRIP_PLAN> GetAllVShipmentTripPlan()
        {
            return _dbContext.v_shipment_trip_plan.ToList();
        }

        protected V_SHIPMENT_TRIP_PLAN GetVShipmentTripPlanByShipmentId(int id)
        {
            V_SHIPMENT_TRIP_PLAN obj = _dbContext.v_shipment_trip_plan.Find(id);
            return obj;
        }

        #endregion

        #region SHIPMENT_DOCUMENTS
        protected List<Shipment_Documents> GetAllShipmentDocument()
        {
            return _dbContext.shipment_documents.ToList();
        }

        protected Shipment_Documents GetShipmentDocumentById(int id)
        {
            Shipment_Documents obj = _dbContext.shipment_documents.FirstOrDefault(x => x.ShipmentDocumentId == id);

            return obj;
        }


        protected List<Shipment_Documents> GetShipmentDocumentByShipmentId(int? ShipmentId)
        {
            List<Shipment_Documents> obj = _dbContext.shipment_documents.Where(x => x.ShipmentId == ShipmentId && x.IsDelete != 1 && x.DocumentTitle != "GRN_DOCUMENT").ToList();
            return obj;
        }
        protected List<Shipment_Documents> GetShipmentDODocumentByShipmentId(int? ShipmentId)
        {
            List<Shipment_Documents> obj = _dbContext.shipment_documents.Where(x => x.ShipmentId == ShipmentId && x.IsDelete != 1 && x.DocumentTitle == "InternalOrderDO").ToList();
            return obj;
        }
        protected List<Shipment_Documents> GetInternalOrderDocuments(int Orderid)
        {
            List<Shipment_Documents> obj = _dbContext.shipment_documents.Where(x => x.ShipmentId == Orderid && x.IsDelete != 1 && x.DocumentTitle == "InternalOrderDO").ToList();
            return obj;
        }
        protected int AddShipmentDocument(Shipment_Documents obj)
        {
            obj.CreatedDate = DateTime.Now;
            obj.UpdatedDate = DateTime.Now;
            _dbContext.shipment_documents.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateShipmentDocument(Shipment_Documents obj)
        {
            Shipment_Documents _upData = _dbContext.shipment_documents.Find(obj.ShipmentDocumentId);
            Shipment_Documents _newData = _dbContext.shipment_documents.Find(obj.ShipmentDocumentId);
            _newData.UpdatedDate = DateTime.Now;
            _newData.ShipmentId = obj.ShipmentId;
            _newData.DocumentName = obj.DocumentName;
            _newData.DocumentNo = obj.DocumentNo;
            _newData.DocumentPath = obj.DocumentPath;
            _newData.DocumentTitle = obj.DocumentTitle;
            _newData.UpdatedBy = obj.UpdatedBy;
            _newData.CreatedDate = DateTime.Now;
            _newData.UpdatedDate = DateTime.Now;
            _newData.DocumentType = obj.DocumentType;
            _dbContext.Entry(_upData).CurrentValues.SetValues(_newData);
            return _dbContext.SaveChanges();
        }

        protected int DeleteShipmentDocument(int id)
        {
            Shipment_Documents module = _dbContext.shipment_documents.Find(id);
            _dbContext.shipment_documents.Remove(module);
            return _dbContext.SaveChanges();
        }

        protected int RemoveShipmentDocument(int id, int updateby)
        {
            int val = -1;
            Shipment_Documents _upData = _dbContext.shipment_documents.Find(id);
            Shipment_Documents module = _dbContext.shipment_documents.Find(id);
            if (module != null)
            {
                module.IsDelete = 1;
                module.UpdatedDate = DateTime.Now;
                module.UpdatedBy = updateby;
                _dbContext.Entry(_upData).CurrentValues.SetValues(module);
                val = _dbContext.SaveChanges();
            }
            return val;
        }

        protected object AddShipmentAttachment(Shipment_Documents _shipDoc)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                setlog("AddShipmentAttachment DATA : " + getSerializeData(_shipDoc));
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            Shipment _shipmentExt = _dbContext.shipment.Find(_shipDoc.ShipmentId);
                            Shipment _shipment = _shipmentExt;
                            if (_shipment != null)
                            {
                                if (convert.ToInt(_shipment.ShipmentStatusId) > 0 && convert.ToInt(_shipment.ShipmentStatusId) < 3)
                                {
                                    _shipment.ShipmentStatusId = convert.ToInt(Status.DRAFT);
                                    _shipment.UpdatedBy = _shipDoc.CreatedBy;
                                    _shipment.UpdatedDate = DateTime.Now;
                                    _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Shipment is in Invalid status");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment details");
                            }

                            Shipment_Documents _shipmentDocument = new Shipment_Documents();
                            _shipmentDocument.ShipmentId = _shipDoc.ShipmentId;
                            _shipmentDocument.DocumentName = _shipDoc.DocumentName;
                            _shipmentDocument.DocumentNo = _shipDoc.DocumentNo;
                            _shipmentDocument.DocumentPath = _shipDoc.DocumentPath;
                            _shipmentDocument.DocumentTitle = _shipDoc.DocumentTitle;
                            _shipmentDocument.CreatedBy = _shipDoc.CreatedBy;
                            _shipmentDocument.UpdatedBy = _shipDoc.CreatedBy;
                            _shipmentDocument.CreatedDate = DateTime.Now;
                            _shipmentDocument.UpdatedDate = DateTime.Now;
                            _shipmentDocument.DocumentType = _shipDoc.DocumentType;

                            _dbContext.shipment_documents.Add(_shipmentDocument);
                            Updated += _dbContext.SaveChanges();
                            if (Updated > 0)
                            {
                                dbContextTransaction.Commit();
                                _response.data = _shipmentDocument;
                                _response.status = "SUCCESS";
                                _response.isSuccess = true;
                                _response.message = "Shipment Document : " + _shipDoc.DocumentName + " created successfully.";
                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment Document : " + _shipDoc.DocumentName + " created successfully.", "", "", "", "");

                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while pushing Shipment Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while creating Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on creating Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object RemoveShipmentAttachment(Remove_Shipment_Documents _shipDoc)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                setlog("RemoveShipmentAttachment DATA : " + getSerializeData(_shipDoc));
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            Shipment _shipmentExt = _dbContext.shipment.Find(_shipDoc.ShipmentId);
                            Shipment _shipment = _shipmentExt;
                            if (_shipment != null)
                            {
                                if (_shipment.ShipmentStatusId == convert.ToInt(Status.NEW) || _shipment.ShipmentStatusId == convert.ToInt(Status.DRAFT) || _shipment.ShipmentStatusId == convert.ToInt(Status.READYTOSHIP) || _shipment.ShipmentStatusId == convert.ToInt(Status.SHIPPED) || _shipment.ShipmentStatusId == convert.ToInt(Status.VERIFICATION))
                                {
                                    _shipment.UpdatedBy = _shipDoc.UpdatedBy;
                                    _shipment.UpdatedDate = DateTime.Now;
                                    _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Shipment is in Invalid status");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment details");
                            }

                            Shipment_Documents _shipmentDocumentExt = _dbContext.shipment_documents.Find(_shipDoc.ShipmentDocumentId);
                            Shipment_Documents _shipmentDocument = _shipmentDocumentExt;
                            _shipmentDocument.ShipmentId = _shipDoc.ShipmentId;
                            _shipmentDocument.UpdatedBy = _shipDoc.UpdatedBy;
                            _shipmentDocument.UpdatedDate = DateTime.Now;
                            _shipmentDocument.IsDelete = 1;

                            _dbContext.Entry(_shipmentDocumentExt).CurrentValues.SetValues(_shipmentDocument);
                            Updated += _dbContext.SaveChanges();
                            if (Updated > 0)
                            {
                                dbContextTransaction.Commit();
                                _response.data = _shipmentDocument;
                                _response.status = "SUCCESS";
                                _response.isSuccess = true;
                                _response.message = "Shipment Document : " + _shipDoc.ShipmentDocumentId + " remove successfully.";
                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment Document : " + _shipDoc.ShipmentDocumentId + " remove successfully.", "", "", "", "");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while remove Shipment Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while removing Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on removing Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        protected object CreateInternalOrderDeliveryOrderDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
                string esupplerAttachmentpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("ESUPPLIER_ATTACHMENT_PATH").Value);
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            bool isUploaded = false;
                            InboundShipment ship = new InboundShipment();
                            INTERNAL_ORDERS _Order = _dbContext.internal_orders.FirstOrDefault(x => x.InternalOrderId == _data.DocRefId);
                            INTERNAL_ORDERS ordercopy = _Order;
                            if (ordercopy != null)
                            {
                                ship = _dbContext.inboundShipment.Where(X => X.inboundShipmentId == _Order.Inboundshipmentid).FirstOrDefault();

                                if (ordercopy.StatusId == convert.ToInt(Status.NEW) || ordercopy.StatusId == convert.ToInt(Status.DRAFT) || ordercopy.StatusId == convert.ToInt(Status.READYTOSHIP) || ordercopy.StatusId == convert.ToInt(Status.SHIPPED) || ordercopy.StatusId == convert.ToInt(Status.VERIFICATION) || ordercopy.StatusId == convert.ToInt(Status.OPEN))
                                {
                                    //_shipment.up = _data.UpdatedBy;
                                    ordercopy.Updated_Date = DateTime.Now;
                                    _dbContext.Entry(_Order).CurrentValues.SetValues(ordercopy);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Internal Order is in Invalid status");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Internal Order details");
                            }

                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == ship.companyid && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value + "\\" + ship.companyid + "\\" + ordercopy.InternalOrderId;
                                string _docPath = "\\" + ship.companyid + "\\" + ordercopy.InternalOrderId;

                                Shipment_Documents _shipmentDocument = new Shipment_Documents();
                                _shipmentDocument.ShipmentId = _data.DocRefId;
                                _shipmentDocument.DocumentName = _data.Document_Name;
                                _shipmentDocument.DocumentNo = _data.DocRefId;
                                _shipmentDocument.DocumentPath = _docPath + "\\" + _data.Document_Name;
                                _shipmentDocument.DocumentTitle = "InternalOrderDO";
                                _shipmentDocument.CreatedBy = _data.UpdatedBy;
                                _shipmentDocument.UpdatedBy = _data.UpdatedBy;
                                _shipmentDocument.CreatedDate = DateTime.Now;
                                _shipmentDocument.UpdatedDate = DateTime.Now;
                                _shipmentDocument.DocumentType = GetMimeType(Path.GetExtension(_data.Document_Name));
                                if (_data.Base64Data != null)
                                {
                                    byte[] _sbytes = Convert.FromBase64String(_data.Base64Data);
                                    if (!Directory.Exists(_savePath)) Directory.CreateDirectory(_savePath);
                                    System.IO.File.WriteAllBytes(_savePath + "\\" + _data.Document_Name, _sbytes);
                                    Directory.CreateDirectory(esupplerAttachmentpath);
                                    System.IO.File.WriteAllBytes(esupplerAttachmentpath + "\\" + _data.Document_Name, _sbytes);
                                    if (System.IO.File.Exists(_savePath + "\\" + _data.Document_Name))
                                    {
                                        isUploaded = true;
                                        setlog("File " + _docPath + "\\" + _data.Document_Name + " created successfully");
                                    }
                                }
                                if (isUploaded)
                                {
                                    _dbContext.shipment_documents.Add(_shipmentDocument);
                                    Updated += _dbContext.SaveChanges();
                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipmentDocument;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "DO Document : " + _data.Document_Name + " created successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Internal Order delivery order document : " + _data.Document_Name + " created successfully.", "", "", "", "");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get Upload File Data.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Upload File Data.");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while pushing internal Order DO Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while creating Internal Order DO Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on creating Internal Order DO Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object CreateShipmentAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            try
            {
                int Updated = 0;
                setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
                string esupplerAttachmentpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("ESUPPLIER_ATTACHMENT_PATH").Value);
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            bool isUploaded = false;
                            Shipment _shipmentExt = _dbContext.shipment.FirstOrDefault(x => x.ShipmentId == _data.DocRefId);
                            Shipment _shipment = _shipmentExt;
                            if (_shipment != null)
                            {
                                if (_shipment.ShipmentStatusId == convert.ToInt(Status.NEW) || _shipment.ShipmentStatusId == convert.ToInt(Status.DRAFT) || _shipment.ShipmentStatusId == convert.ToInt(Status.READYTOSHIP) || _shipment.ShipmentStatusId == convert.ToInt(Status.SHIPPED) || _shipment.ShipmentStatusId == convert.ToInt(Status.VERIFICATION))
                                {
                                    _shipment.UpdatedBy = _data.UpdatedBy;
                                    _shipment.UpdatedDate = DateTime.Now;
                                    _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Shipment is in Invalid status");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment details");
                            }

                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _shipment.CompanyId && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value + "\\" + _shipment.CompanyId + "\\" + _shipment.ShipmentId;
                                string _docPath = "\\" + _shipment.CompanyId + "\\" + _shipment.ShipmentId;

                                Shipment_Documents _shipmentDocument = new Shipment_Documents();
                                _shipmentDocument.ShipmentId = _data.DocRefId;
                                _shipmentDocument.DocumentName = _data.Document_Name;
                                _shipmentDocument.DocumentNo = _data.DocRefId;
                                _shipmentDocument.DocumentPath = _docPath + "\\" + _data.Document_Name;
                                _shipmentDocument.DocumentTitle = "SHIPMENT_DOCUMENTS";
                                _shipmentDocument.CreatedBy = _data.UpdatedBy;
                                _shipmentDocument.UpdatedBy = _data.UpdatedBy;
                                _shipmentDocument.CreatedDate = DateTime.Now;
                                _shipmentDocument.UpdatedDate = DateTime.Now;
                                _shipmentDocument.DocumentType = GetMimeType(Path.GetExtension(_data.Document_Name));
                                if (_data.Base64Data != null)
                                {
                                    byte[] _sbytes = Convert.FromBase64String(_data.Base64Data);
                                    if (!Directory.Exists(_savePath)) Directory.CreateDirectory(_savePath);
                                    System.IO.File.WriteAllBytes(_savePath + "\\" + _data.Document_Name, _sbytes);
                                    Directory.CreateDirectory(esupplerAttachmentpath);
                                    System.IO.File.WriteAllBytes(esupplerAttachmentpath + "\\" + _data.Document_Name, _sbytes);
                                    if (System.IO.File.Exists(_savePath + "\\" + _data.Document_Name))
                                    {
                                        isUploaded = true;
                                        setlog("File " + _docPath + "\\" + _data.Document_Name + " created successfully");
                                    }
                                }
                                if (isUploaded)
                                {
                                    _dbContext.shipment_documents.Add(_shipmentDocument);
                                    Updated += _dbContext.SaveChanges();
                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipmentDocument;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Shipment Document : " + _data.Document_Name + " created successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment Document : " + _data.Document_Name + " created successfully.", "", "", "", "");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get Upload File Data.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Upload File Data.");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while pushing Shipment Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while creating Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on creating Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object DownloadShipmentAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
            try
            {
                Shipment _shipment = _dbContext.shipment.Find(_data.DocRefId);
                if (_shipment != null)
                {
                    Shipment_Documents _shipmentDocument = _dbContext.shipment_documents.FirstOrDefault(x => x.ShipmentDocumentId == _data.Docid && x.ShipmentId == _data.DocRefId);
                    if (_shipmentDocument != null)
                    {
                        if (_shipmentDocument.DocumentPath != "")
                        {
                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _shipment.CompanyId && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value;
                                if (File.Exists(_savePath + "\\" + _shipmentDocument.DocumentPath))
                                {
                                    Byte[] bytes = File.ReadAllBytes(_savePath + "\\" + _shipmentDocument.DocumentPath);
                                    string Base64file = Convert.ToBase64String(bytes);
                                    _data.Document_Name = Path.GetFileName(_savePath + "\\" + _shipmentDocument.DocumentPath);
                                    _data.Base64Data = Base64file;
                                    _data.Companyid = _shipment.CompanyId;
                                    _data.FileType = GetMimeType(Path.GetExtension(_shipmentDocument.DocumentName));
                                    _response.data = _data;
                                    _response.status = "SUCCESS";
                                    _response.isSuccess = true;
                                    _response.message = "Attachment downloaded successfully";
                                    setlog("Attachment downloaded successfully by Userid : " + _data.UpdatedBy);
                                }
                                else
                                {
                                    throw new Exception("Unable to found Shipment Attachment : '" + _shipmentDocument.DocumentName + "'");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment Attachment path");
                            }
                        }
                        else
                        {
                            throw new Exception("Shipment Document path is empty.");
                        }
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipment details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while downloading Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on downloading Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        protected object DownloadShipmentDOAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
            try
            {
                InboundShipment _shipment = _dbContext.inboundShipment.Find(_data.DocRefId);
                if (_shipment != null)
                {
                    Shipment_Documents _shipmentDocument = _dbContext.shipment_documents.FirstOrDefault(x => x.ShipmentDocumentId == _data.Docid && x.ShipmentId == _data.DocRefId);
                    if (_shipmentDocument != null)
                    {
                        if (_shipmentDocument.DocumentPath != "")
                        {
                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _shipment.companyid && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value;
                                if (File.Exists(_savePath + "\\" + _shipmentDocument.DocumentPath))
                                {
                                    Byte[] bytes = File.ReadAllBytes(_savePath + "\\" + _shipmentDocument.DocumentPath);
                                    string Base64file = Convert.ToBase64String(bytes);
                                    _data.Document_Name = Path.GetFileName(_savePath + "\\" + _shipmentDocument.DocumentPath);
                                    _data.Base64Data = Base64file;
                                    _data.Companyid = _shipment.companyid;
                                    _data.FileType = GetMimeType(Path.GetExtension(_shipmentDocument.DocumentName));
                                    _response.data = _data;
                                    _response.status = "SUCCESS";
                                    _response.isSuccess = true;
                                    _response.message = "Attachment downloaded successfully";
                                    setlog("Attachment downloaded successfully by Userid : " + _data.UpdatedBy);
                                }
                                else
                                {
                                    throw new Exception("Unable to found Shipment Attachment : '" + _shipmentDocument.DocumentName + "'");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment Attachment path");
                            }
                        }
                        else
                        {
                            throw new Exception("Shipment Document path is empty.");
                        }
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipment details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while downloading Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on downloading Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }
        protected object DownloadGRNShipmentAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
            try
            {
                Shipment _shipment = _dbContext.shipment.Find(_data.DocRefId);
                if (_shipment != null)
                {
                    Shipment_Documents _shipmentDocument = _dbContext.shipment_documents.FirstOrDefault(x => x.ShipmentId == _data.DocRefId && x.DocumentTitle == "GRN_DOCUMENTS");
                    if (_shipmentDocument != null)
                    {
                        if (_shipmentDocument.DocumentPath != "")
                        {
                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _shipment.CompanyId && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value;
                                if (File.Exists(_savePath + "\\" + _shipmentDocument.DocumentPath))
                                {
                                    Byte[] bytes = File.ReadAllBytes(_savePath + "\\" + _shipmentDocument.DocumentPath);
                                    string Base64file = Convert.ToBase64String(bytes);
                                    _data.Document_Name = Path.GetFileName(_savePath + "\\" + _shipmentDocument.DocumentPath);
                                    _data.Base64Data = Base64file;
                                    _data.Companyid = _shipment.CompanyId;
                                    _data.FileType = GetMimeType(Path.GetExtension(_shipmentDocument.DocumentName));
                                    _response.data = _data;
                                    _response.status = "SUCCESS";
                                    _response.isSuccess = true;
                                    _response.message = "Attachment downloaded successfully";
                                    setlog("Attachment downloaded successfully by Userid : " + _data.UpdatedBy);
                                }
                                else
                                {
                                    throw new Exception("Unable to found Shipment Attachment : '" + _shipmentDocument.DocumentName + "'");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment Attachment path");
                            }
                        }
                        else
                        {
                            throw new Exception("Shipment Document path is empty.");
                        }
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipment details");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while downloading Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on downloading Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object UpdateShipmentGRNAttachmentDetails(AttachDocumentsDataModal _data)
        {
            responseMessage _response = new responseMessage();
            bool isNew = false;
            try
            {
                int Updated = 0;
                setlog("AttachDocumentsDataModal DATA : " + getSerializeData(_data));
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        try
                        {
                            bool isUploaded = false;
                            Shipment_Documents _shipmentDocumentExt = _dbContext.shipment_documents.FirstOrDefault(x => x.ShipmentId == _data.DocRefId && x.DocumentTitle == "GRN_DOCUMENTS");
                            Shipment_Documents _shipmentDocument = _shipmentDocumentExt;
                            Shipment _shipmentExt = _dbContext.shipment.FirstOrDefault(x => x.ShipmentId == _data.DocRefId && x.CompanyId == _data.Companyid);
                            Shipment _shipment = _shipmentExt;
                            if (_shipment != null)
                            {
                                if (_shipment.ShipmentStatusId == convert.ToInt(Status.NEW) || _shipment.ShipmentStatusId == convert.ToInt(Status.DRAFT) || _shipment.ShipmentStatusId == convert.ToInt(Status.READYTOSHIP) || _shipment.ShipmentStatusId == convert.ToInt(Status.SHIPPED))
                                {
                                    _shipment.UpdatedDate = DateTime.Now;
                                    _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                    Updated += _dbContext.SaveChanges();
                                }
                                else
                                {
                                    throw new Exception("Shipment is in Invalid status");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Shipment details");
                            }

                            Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _shipment.CompanyId && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                            if (mast_SITE_CONFIG != null)
                            {
                                string _savePath = mast_SITE_CONFIG.param_value + "\\" + _shipment.CompanyId + "\\" + _shipment.ShipmentId;
                                string _docPath = "\\" + _shipment.CompanyId + "\\" + _shipment.ShipmentId;

                                if (_shipmentDocument == null)
                                {
                                    _shipmentDocument = new Shipment_Documents();
                                    _shipmentDocument.CreatedDate = DateTime.Now;
                                    isNew = true;
                                }
                                _shipmentDocument.ShipmentId = _data.DocRefId;
                                _shipmentDocument.DocumentName = _data.Document_Name;
                                _shipmentDocument.DocumentNo = _data.DocRefId;
                                _shipmentDocument.DocumentPath = _docPath + "\\" + _data.Document_Name;
                                _shipmentDocument.DocumentTitle = "GRN_DOCUMENTS";
                                _shipmentDocument.CreatedBy = _data.UpdatedBy;
                                _shipmentDocument.UpdatedBy = _data.UpdatedBy;
                                _shipmentDocument.UpdatedDate = DateTime.Now;
                                _shipmentDocument.DocumentType = GetMimeType(Path.GetExtension(_data.Document_Name));
                                if (_data.Base64Data != null)
                                {
                                    byte[] _sbytes = Convert.FromBase64String(_data.Base64Data);
                                    if (!Directory.Exists(_savePath)) Directory.CreateDirectory(_savePath);
                                    System.IO.File.WriteAllBytes(_savePath + "\\" + _data.Document_Name, _sbytes);
                                    if (System.IO.File.Exists(_savePath + "\\" + _data.Document_Name))
                                    {
                                        isUploaded = true;
                                        setlog("File " + _docPath + "\\" + _data.Document_Name + " GRN created successfully");
                                    }
                                }
                                if (isUploaded)
                                {
                                    if (isNew)
                                    {
                                        _dbContext.shipment_documents.Add(_shipmentDocument);
                                    }
                                    else
                                    {
                                        _dbContext.Entry(_shipmentDocumentExt).CurrentValues.SetValues(_shipmentDocument);
                                    }
                                    Updated += _dbContext.SaveChanges();
                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipmentDocument;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Shipment GRN Document : " + _data.Document_Name + " created successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment GRN Document : " + _data.Document_Name + " created successfully.", "", "", "", "");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get Upload File Data.");
                                }
                            }
                            else
                            {
                                throw new Exception("Unable to get Upload File Data.");
                            }
                        }
                        catch (Exception ex)
                        {
                            dbContextTransaction.Rollback();
                            setlog("Error while pushing Shipment Document : " + ex.Message);
                            throw ex;
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while creating Shipment Document : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "ERROR on creating Shipment Document: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        #endregion

        #region DeliveryOrderDocuments

        protected object UploadDeliveryOrderDocuments(IFormFileCollection _documents)
        {
            StandardAPIresponse response = new StandardAPIresponse();
            try
            {
                string temppath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("TEMP_DOCUMENTS").Value);
                if (temppath != null && temppath.Length > 0)
                {
                    List<string> files = new List<string>();
                    foreach (var file in _documents)
                    {
                        if (file.Length > 0)
                        {
                            string sanitizedFileName = Path.GetFileNameWithoutExtension(file.FileName) +
                                                       "_" + Guid.NewGuid() +
                                                       Path.GetExtension(file.FileName);

                            string filePath = Path.Combine(temppath, sanitizedFileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                file.CopyTo(stream);
                            }
                            files.Add(sanitizedFileName);
                        }
                    }
                    response.isSuccess = true;
                    response.message = "Files successfully uploaded!";
                    response.status = "SUCCESS";
                    response.data = files;
                }
                else
                {
                    response.status = "FAIL";
                    response.isSuccess = false;
                    response.message = "TEMP_DOCUMENTS path not found!";
                }

            }
            catch (Exception ex)
            {
                response.status = "FAIL";
                response.isSuccess = false;
                response.message = ex.Message;
            }
            return response;
        }
        #endregion DeliveryOrderDocuments
        protected object Logistic_ExportData()
        {
            ExportDataModal exportDataModal = new ExportDataModal();
            List<V_Shipment_Info> objInitialReceipt = _dbContext.v_shipment_info.Where(x => x.InitialReceiptExported == 1 && x.Is_Delete != 1).ToList();
            if (objInitialReceipt.Count > 0)
            {
                exportDataModal.InitialReceiptExportList = objInitialReceipt;
            }
            else
            {
                exportDataModal.InitialReceiptExportList = null;

            }
            List<V_Shipment_Info> objFinalReceipt = _dbContext.v_shipment_info.Where(x => x.FinalReceiptExported == 1 && x.Is_Delete != 1).ToList();
            if (objFinalReceipt.Count > 0)
            {
                exportDataModal.FinalReceiptExportList = objFinalReceipt;
            }
            else
            {
                exportDataModal.FinalReceiptExportList = null;
            }
            return exportDataModal;
        }

        protected PrintGoodsReturnReportModal PrintGoodsReturnReport(int shipmentid, int companyid)
        {
            PrintGoodsReturnReportModal _obj = new PrintGoodsReturnReportModal();
            try
            {
                object _pobj = Get_Print_Shipment_Info_By_ShipmentId(shipmentid, companyid);
                if (_pobj != null && _pobj.GetType() == typeof(Print_Shipment_Info))
                {
                    Print_Shipment_Info printData = (Print_Shipment_Info)_pobj;
                    PrintGoodsReturnHeaderInfo _headerInfo = new PrintGoodsReturnHeaderInfo();
                    _headerInfo.drivername = printData.driver_name;
                    _headerInfo.shipmentid = printData.shipmentid;
                    _headerInfo.jobno = printData.jobno;
                    _headerInfo.bordingofficer = printData.Boarding_Officer_Name;
                    _headerInfo.deliverydate = (printData.delivery_date == null || convert.ToDateTime(printData.delivery_date) == DateTime.MinValue) ? null : convert.ToDateTime(printData.delivery_date).ToString("dd/MM/yyyy HH:mm");
                    _headerInfo.loadinglocation = printData.loading_point;
                    _headerInfo.loadingtime = (printData.loading_time == null || convert.ToDateTime(printData.loading_time) == DateTime.MinValue) ? null : convert.ToDateTime(printData.loading_time).ToString("dd/MM/yyyy HH:mm");
                    _headerInfo.shipmentno = printData.order_no;
                    _headerInfo.vesselname = printData.vessel_name;
                    _headerInfo.packedby = "";
                    _headerInfo.purchaser_tech = "";
                    _headerInfo.purchaser_tech = "";
                    _obj.goodsreturnheaderinfo = _headerInfo;
                }
                else
                {
                    throw new Exception("Unable to get Shipment details");
                }
                List<PrintGoodsReturnItemInfo> _ItemInfolst = new List<PrintGoodsReturnItemInfo>();
                List<V_SHIPMENT_DELIVERY_ORDERS> DO_list = GetVShipmentDeliveryOrdersByShipmentId(shipmentid);
                if (DO_list != null && DO_list.Count > 0)
                {
                    foreach (V_SHIPMENT_DELIVERY_ORDERS DO_Details in DO_list)
                    {
                        List<V_DELIVERY_ORDER_LINES> DO_Lines = GetVDeliveryOrderLinesByDeliveryOrderId(DO_Details.delivery_order_id);
                        if (DO_Lines.Count > 0)
                        {
                            for (int i = 0; i < DO_Lines.Count; i++)
                            {
                                V_DELIVERY_ORDER_LINES DOitem = DO_Lines[i];
                                if (DOitem != null)
                                {

                                    var rou_quantity = RoundToTwoDecimals(DOitem.quantity);
                                    var rou_quantity_invoiced = RoundToTwoDecimals(DOitem.quantity_invoiced);
                                    double returnVal = rou_quantity - rou_quantity_invoiced;
                                    if (returnVal > 0)
                                    {
                                        PrintGoodsReturnItemInfo _itemInfo = new PrintGoodsReturnItemInfo();
                                        _itemInfo.shipmentid = DO_Details.shipmentid;
                                        _itemInfo.deliveryorderid = DOitem.delivery_order_id;
                                        _itemInfo.deliveryorderno = DO_Details.delivery_order_no;
                                        _itemInfo.itemdesc = DOitem.item_description;
                                        _itemInfo.itemno = convert.ToString(DOitem.item_no);
                                        _itemInfo.cust_itemno = DOitem.item_ref_no;
                                        _itemInfo.deliveredQty = rou_quantity;
                                        _itemInfo.recvQty = rou_quantity_invoiced;
                                        _itemInfo.returnQty = convert.ToFloat(returnVal);
                                        _itemInfo.remarks = DOitem.epod_line_remarks;
                                        _itemInfo.reasoncodeid = DOitem.grn_reason_id;
                                        _itemInfo.reasoncode = DOitem.grn_reason_code + " " + DOitem.grn_reason_description;
                                        _itemInfo.cust_dept = DOitem.dept_code;
                                        _itemInfo.uom = DOitem.uom;
                                        _itemInfo.delivery_order_lines_id = DOitem.delivery_order_lines_id;
                                        _ItemInfolst.Add(_itemInfo);
                                    }
                                }
                            }
                        }
                    }
                }
                if (_ItemInfolst.Count() > 0)
                {
                    _obj.goodsreturniteminfo = _ItemInfolst;
                }
                else
                {
                    _obj.goodsreturniteminfo = null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _obj;
        }

        public static double RoundToTwoDecimals(object value)
        {
            double doubleValue = Convert.ToDouble(value);
            return Math.Round(doubleValue, 2);
        }
        protected object Epod_Update_Shipped_Status(int shipmentid, int userid, string lat, string lon, string emailid = "", string username = "", string vesselimo = "", string role = "")
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            try
            {
                if (convert.ToInt(shipmentid) != 0)
                {
                    Shipment _shipmentExt = _dbContext.shipment.Find(shipmentid);
                    Shipment _shipment = _shipmentExt;
                    if (_shipment != null)
                    {
                        if (_shipment.ShipmentStatusId == convert.ToInt(Status.READYTOSHIP))
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        _shipment.ShipmentStatusId = convert.ToInt(Status.SHIPPED);
                                        _shipment.UpdatedBy = userid;
                                        _shipment.UpdatedDate = DateTime.Now;
                                        _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                        Updated += _dbContext.SaveChanges();

                                        Shipment_Vessel_Info _shipmentInfoExt = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == shipmentid);
                                        Shipment_Vessel_Info _shipmentInfo = _shipmentInfoExt;
                                        if (_shipmentInfo != null)
                                        {
                                            _shipmentInfo.shipped_date = DateTime.Now;
                                            _shipmentInfo.InitialReceiptExported = 1;
                                            _dbContext.Entry(_shipmentInfoExt).CurrentValues.SetValues(_shipmentInfo);
                                            Updated += _dbContext.SaveChanges();
                                            List<Delivery_Orders> _lstDeliveryOrder = _dbContext.delivery_orders.Where(x => x.ShipmentId == shipmentid).ToList();
                                            for (int i = 0; i < _lstDeliveryOrder.Count; i++)
                                            {
                                                Delivery_Orders _dOrderExt = _lstDeliveryOrder[i];
                                                Delivery_Orders _dOrder = _lstDeliveryOrder[i];
                                                _dOrder.StatusId = convert.ToInt(Status.SHIPPED);
                                                _dOrder.UpdateDate = DateTime.Now;
                                                _dbContext.Entry(_dOrderExt).CurrentValues.SetValues(_dOrder);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                            if (emailid != "" && username != "" && role != "")
                                            {
                                                Epod_Access_Log _AccessLog = new Epod_Access_Log();
                                                _AccessLog.userid = userid;
                                                _AccessLog.shipmentid = shipmentid;
                                                _AccessLog.location_lat = lat;
                                                _AccessLog.location_long = lon;
                                                _AccessLog.emailid = emailid;
                                                _AccessLog.user_name = username;
                                                _AccessLog.vesselimo = vesselimo;
                                                _AccessLog.role = role;
                                                _AccessLog.created_date = DateTime.Now;
                                                _AccessLog.shipped_date = DateTime.Now;

                                                _dbContext.Epod_Access_Log.Add(_AccessLog);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to get crew details");
                                            }
                                            if (Updated > 0)
                                            {
                                                dbContextTransaction.Commit();
                                                _response.data = _shipment;
                                                _response.status = "SUCCESS";
                                                _response.isSuccess = true;
                                                _response.message = "Shipment with order no : " + _shipment.OrderNo + " Shipped successfully.";
                                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Shipped successfully.", "", "", "", "");

                                            }
                                            else
                                            {
                                                throw new Exception("Unable to Save Shipment details.");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Shipment Info details.");
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        setlog("Error while pushing Shipment : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Shipment is in Invalid status.");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get Shipment details.");
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipmentid.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while Updating Shipping Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while Updating Shipping Shipment: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object Epod_Update_Verification_Status(int shipmentid, int userid, string lat, string lon, string emailid = "", string username = "", string vesselimo = "", string role = "")
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            try
            {
                if (convert.ToInt(shipmentid) != 0)
                {
                    Shipment _shipmentExt = _dbContext.shipment.Find(shipmentid);
                    Shipment _shipment = _shipmentExt;
                    if (_shipment != null)
                    {
                        if (_shipment.ShipmentStatusId == convert.ToInt(Status.SHIPPED))
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        _shipment.ShipmentStatusId = convert.ToInt(Status.VERIFICATION);
                                        _shipment.UpdatedBy = userid;
                                        _shipment.UpdatedDate = DateTime.Now;
                                        _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                        Updated += _dbContext.SaveChanges();

                                        Shipment_Vessel_Info _shipmentInfoExt = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == shipmentid);
                                        Shipment_Vessel_Info _shipmentInfo = _shipmentInfoExt;
                                        if (_shipmentInfo != null)
                                        {
                                            _shipmentInfo.verified_date = DateTime.Now;
                                            _dbContext.Entry(_shipmentInfoExt).CurrentValues.SetValues(_shipmentInfo);
                                            Updated += _dbContext.SaveChanges();
                                            if (emailid != "" && username != "" && role != "")
                                            {
                                                Epod_Access_Log _AccessLog = new Epod_Access_Log();
                                                _AccessLog.userid = userid;
                                                _AccessLog.shipmentid = shipmentid;
                                                _AccessLog.location_lat = lat;
                                                _AccessLog.location_long = lon;
                                                _AccessLog.emailid = emailid;
                                                _AccessLog.user_name = username;
                                                _AccessLog.vesselimo = vesselimo;
                                                _AccessLog.role = role;
                                                _AccessLog.created_date = DateTime.Now;
                                                _AccessLog.verified_date = DateTime.Now;

                                                _dbContext.Epod_Access_Log.Add(_AccessLog);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to get crew details");
                                            }
                                            if (Updated > 0)
                                            {
                                                dbContextTransaction.Commit();
                                                _response.data = _shipment;
                                                _response.status = "SUCCESS";
                                                _response.isSuccess = true;
                                                _response.message = "Shipment with order no : " + _shipment.OrderNo + " Verified successfully.";
                                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Verified successfully.", "", "", "", "");
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to Save Shipment details.");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Shipment Info details.");
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        setlog("Error while pushing Shipment : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Shipment is in Invalid status.");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get Shipment details.");
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipmentid.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while Updating Verified Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while Updating Verified Shipment: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object Epod_Update_Confirmed_Status(int shipmentid, int userid, string lat, string lon, string emailid = "", string username = "", string vesselimo = "", string role = "")
        {
            responseMessage _response = new responseMessage();
            int Updated = -1;
            try
            {
                if (convert.ToInt(shipmentid) != 0)
                {
                    Shipment _shipmentExt = _dbContext.shipment.Where(x => x.ShipmentId == shipmentid).FirstOrDefault();
                    Shipment _shipment = _shipmentExt;
                    if (_shipment != null)
                    {
                        if (_shipment.ShipmentStatusId == convert.ToInt(Status.VERIFICATION))
                        {
                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {
                                    try
                                    {
                                        _shipment.ShipmentStatusId = convert.ToInt(Status.COMPLETED);
                                        _shipment.UpdatedBy = userid;
                                        _shipment.UpdatedDate = DateTime.Now;
                                        _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                        Updated += _dbContext.SaveChanges();

                                        List<Delivery_Orders> _lstDeliveryOrder = _dbContext.delivery_orders.Where(x => x.ShipmentId == shipmentid).ToList();
                                        for (int i = 0; i < _lstDeliveryOrder.Count; i++)
                                        {
                                            Delivery_Orders _dOrderExt = _lstDeliveryOrder[i];
                                            Delivery_Orders _dOrder = _lstDeliveryOrder[i];
                                            _dOrder.StatusId = convert.ToInt(Status.RECEIVED);
                                            _dOrder.UpdateDate = DateTime.Now;
                                            _dbContext.Entry(_dOrderExt).CurrentValues.SetValues(_dOrder);
                                            Updated += _dbContext.SaveChanges();
                                        }
                                        PrintGoodsReturnReportModal _printdata = PrintGoodsReturnReport(_shipment.ShipmentId, convert.ToInt(_shipment.CompanyId));
                                        Shipment_Vessel_Info _shipmentInfoExt = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == shipmentid);
                                        Shipment_Vessel_Info _shipmentInfo = _shipmentInfoExt;
                                        if (_shipmentInfo != null)
                                        {
                                            _shipmentInfo.confirm_date = DateTime.Now;
                                            if (_printdata.goodsreturniteminfo != null && _printdata.goodsreturniteminfo.Count() > 0)
                                            {
                                                _shipmentInfo.FinalReceiptExported = 1;
                                            }
                                            else
                                            {
                                                _shipmentInfo.FinalReceiptExported = 3;
                                            }
                                            _dbContext.Entry(_shipmentInfoExt).CurrentValues.SetValues(_shipmentInfo);
                                            Updated += _dbContext.SaveChanges();

                                            if (emailid != "" && username != "" && role != "")
                                            {
                                                Epod_Access_Log _AccessLog = new Epod_Access_Log();
                                                _AccessLog.userid = userid;
                                                _AccessLog.shipmentid = shipmentid;
                                                _AccessLog.location_lat = lat;
                                                _AccessLog.location_long = lon;
                                                _AccessLog.emailid = emailid;
                                                _AccessLog.user_name = username;
                                                _AccessLog.vesselimo = vesselimo;
                                                _AccessLog.role = role;
                                                _AccessLog.created_date = DateTime.Now;
                                                _AccessLog.confirm_date = DateTime.Now;

                                                _dbContext.Epod_Access_Log.Add(_AccessLog);
                                                Updated += _dbContext.SaveChanges();
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to get crew details");
                                            }

                                            if (Updated > 0)
                                            {
                                                dbContextTransaction.Commit();
                                                _response.data = _shipment;
                                                _response.status = "SUCCESS";
                                                _response.isSuccess = true;
                                                _response.message = "Shipment with order no : " + _shipment.OrderNo + " Final receipt successfully.";
                                                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Final receipt successfully.", "", "", "", "");
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to Save Shipment details.");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Shipment Info details.");
                                        }

                                    }
                                    catch (Exception ex)
                                    {
                                        dbContextTransaction.Rollback();
                                        setlog("Error while pushing Shipment : " + ex.Message);
                                        throw ex;
                                    }
                                }
                            });
                        }
                        else
                        {
                            throw new Exception("Shipment is in Invalid status.");
                        }
                    }
                    else
                    {
                        throw new Exception("Unable to get Shipment details.");
                    }
                }
                else
                {
                    throw new Exception("Unable to get Shipmentid.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error while Updating Final receipt Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while Updating Final receipt Shipment: " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected bool Check_Epod_Access_Logs(int shipmentid, string emailid)
        {
            bool result = false;
            List<Epod_Access_Log> _AccessLogLst = _dbContext.Epod_Access_Log.Where(x => x.shipmentid == shipmentid && x.emailid == emailid).ToList();
            if (_AccessLogLst.Count > 0)
            {
                result = true;
            }
            return result;
        }

        protected bool AddEpod_Access_Logs(int shipmentid, int userid, string emailid, string lat, string lon, string crueName = "", string VesselIMO = "", string Role = "")
        {
            bool result = false;
            try
            {
                int update = -1;
                Epod_Access_Log _AccessLog = new Epod_Access_Log();
                _AccessLog.userid = userid;
                _AccessLog.shipmentid = shipmentid;
                _AccessLog.emailid = emailid;
                _AccessLog.location_lat = lat;
                _AccessLog.location_long = lon;
                _AccessLog.created_date = DateTime.Now;
                _AccessLog.user_name = crueName;
                _AccessLog.vesselimo = VesselIMO;
                _AccessLog.role = Role;

                _dbContext.Epod_Access_Log.Add(_AccessLog);
                update = _dbContext.SaveChanges();
                if (update > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        protected object Get_Print_Shipment_Info_By_ShipmentId(int ShipmentId, int Companyid)
        {
            Print_Shipment_Info pobj = null;
            V_Shipment_Info obj = _dbContext.v_shipment_info.FirstOrDefault(x => x.shipmentid == ShipmentId && x.Is_Delete != 1);
            if (obj != null)
            {
                Epod_Access_Log objInitialReceipt = _dbContext.Epod_Access_Log.Where(x => x.shipmentid == ShipmentId && x.shipped_date != null).OrderByDescending(x => x.logid).FirstOrDefault();
                Epod_Access_Log objFinalReceipt = _dbContext.Epod_Access_Log.Where(x => x.shipmentid == ShipmentId && x.confirm_date != null).OrderByDescending(x => x.logid).FirstOrDefault();

                pobj = new Print_Shipment_Info();
                pobj.shipmentid = obj.shipmentid;

                pobj.order_no = obj.order_no;

                pobj.receiverid = obj.receiverid;

                pobj.planned_ship_date = obj.planned_ship_date;

                pobj.planned_delivery_date = obj.planned_delivery_date;

                pobj.shipment_notes = obj.shipment_notes;

                pobj.shipment_statusid = obj.shipment_statusid;

                pobj.jobno = obj.jobno;

                pobj.companyid = obj.companyid;

                pobj.vessel_id = obj.vessel_id;

                pobj.vessel_eta = obj.vessel_eta;

                pobj.vessel_ata = obj.vessel_ata;

                pobj.delivery_date = obj.delivery_date;

                pobj.anchorage_id = obj.anchorage_id;

                pobj.agent = obj.agent;

                pobj.agent_contact_person = obj.agent_contact_person;

                pobj.agent_contact_no = obj.agent_contact_no;

                pobj.supply_boat = obj.supply_boat;

                pobj.supply_boat_contact_person = obj.supply_boat_contact_person;

                pobj.supply_boat_contact_no = obj.supply_boat_contact_no;

                pobj.loading_point = obj.loading_point;

                pobj.loading_time = obj.loading_time;

                pobj.co_party = obj.co_party;

                pobj.vessel_code = obj.vessel_code;

                pobj.vessel_name = obj.vessel_name;

                pobj.imo_no = obj.imo_no;

                pobj.anchorage_code = obj.anchorage_code;

                pobj.anchorage_description = obj.anchorage_description;

                pobj.transport_type_code = obj.transport_type_code;

                pobj.transport_type_description = obj.transport_type_description;

                pobj.transport_type_id = obj.transport_type_id;

                pobj.driver_name = obj.driver_name;

                pobj.cust_code = obj.cust_code;

                pobj.cust_name = obj.cust_name;

                pobj.shipment_statusdesc = obj.shipment_statusdesc;

                pobj.Epod_Shipment_Notes = obj.Epod_Shipment_Notes;
                pobj.Is_Delete = obj.Is_Delete;
                pobj.Vehicle_no = obj.Vehicle_no;
                pobj.Boarding_Officer_Name = obj.Boarding_Officer_Name;

                if (objInitialReceipt != null)
                {
                    pobj.Initial_Receipt_Emailid = objInitialReceipt.emailid;
                    pobj.Initial_Receipt_Crew = objInitialReceipt.user_name;
                    pobj.Initial_Receipt_Role = objInitialReceipt.role;
                    pobj.Initial_Receipt_Date = objInitialReceipt.created_date;
                    pobj.Initial_Receipt_LoCode = objInitialReceipt.location_lat + "/" + objInitialReceipt.location_long;
                }
                if (objFinalReceipt != null)
                {
                    pobj.Final_Receipt_Emailid = objFinalReceipt.emailid;
                    pobj.Final_Receipt_Crew = objFinalReceipt.user_name;
                    pobj.Final_Receipt_Role = objFinalReceipt.role;
                    pobj.Final_Receipt_Date = objFinalReceipt.created_date;
                    pobj.Final_Receipt_LoCode = objFinalReceipt.location_lat + "/" + objFinalReceipt.location_long;
                }

            }
            return pobj;
        }

        protected object UpdateInitialReceiptMarker(UpdateInitialExportedMarker markerData)
        {
            int Updated = -1;
            responseMessage _response = new responseMessage();
            try
            {
                string mailpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("SEND_MAIL_PATH").Value);
                setlog("UpdateInitialExportedMarker DATA : " + getSerializeData(markerData));
                string sEmailID = "";
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        Print_Shipment_Info _printData = (Print_Shipment_Info)Get_Print_Shipment_Info_By_ShipmentId(markerData.shipmentid, markerData.companyid);
                        V_Shipment_Info _vShipment = _dbContext.v_shipment_info.FirstOrDefault(x => x.shipmentid == markerData.shipmentid && x.companyid == markerData.companyid);
                        Shipment _shipment = _dbContext.shipment.FirstOrDefault(x => x.ShipmentId == markerData.shipmentid && x.CompanyId == markerData.companyid);
                        Shipment _shipmentExt = _shipment;

                        if (_printData != null && convert.ToString(_printData.Initial_Receipt_Emailid) != "")
                        {
                            sEmailID = convert.ToString(_printData.Initial_Receipt_Emailid) + "," + markerData.emailids;
                        }
                        else
                        {
                            sEmailID = markerData.emailids;
                        }

                        if (_shipment != null)
                        {
                            try
                            {
                                _shipment.UpdatedDate = DateTime.Now;
                                _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                Updated += _dbContext.SaveChanges();

                                Shipment_Vessel_Info _shipmentInfo = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == markerData.shipmentid && x.InitialReceiptExported == 1);
                                Shipment_Vessel_Info _shipmentInfoExt = _shipmentInfo;
                                if (_shipmentInfo != null)
                                {
                                    _shipmentInfo.UpdatedDate = DateTime.Now;
                                    _shipmentInfo.InitialReceiptExported = 2;
                                    _dbContext.Entry(_shipmentInfoExt).CurrentValues.SetValues(_shipmentInfo);
                                    Updated += _dbContext.SaveChanges();

                                    if (Updated > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipment;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Shipment with order no : " + _shipment.OrderNo + " Initial receipt exported successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Initial receipt exported successfully.", "", "", "", "");
                                        if (sEmailID.Length > 0)
                                        {
                                            LeSDataMain.LeSDM.SendMailQueueFile("", "EPOD_INITAIL_RECEIEPT_EXPORT", _shipment.OrderNo, _vShipment.vessel_name, "Exported", sEmailID, "", "", "", markerData.company_desc, _vShipment.cust_name, "Shipment with order no : " + _shipment.OrderNo + " Initial receipt successfully", mailpath, "0", "Shipment for REF : " + _vShipment.order_no + " VESSEL : " + _vShipment.vessel_name + " Initial receipt successfully", markerData.attachmentfiles, "0");

                                        }
                                        else
                                        {
                                            LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "No Email found for : " + _shipment.OrderNo + " Initial receipt .", "", "", "", "");

                                        }
                                    }
                                    else
                                    {
                                        throw new Exception("Unable to Save Shipment details.");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Given Shipment is invalid !");
                                }
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                setlog("Error while pushing Shipment : " + ex.Message);
                                throw ex;
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get Shipment Info details.");
                        }
                    }
                });
            }
            catch (Exception ex)
            {
                setlog("Error while Update Initial receipt Export Marker for Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while Update Initial receipt Export Marker for Shipment : " + ex.Message, "", "", "", "");
            }
            return _response;
        }

        protected object UpdateFinalReceiptMarker(UpdateFinalExportedMarker markerData)
        {
            int Updated = -1;
            bool isNew = false, isUploaded = false;
            responseMessage _response = new responseMessage();
            try
            {
                string mailpath = convert.ToString(LogisticDbContext.configuration.GetSection("AppSettings").GetSection("SEND_MAIL_PATH").Value);
                setlog("UpdateFinalExportedMarker DATA : " + getSerializeData(markerData));
                string sEmailID = "";
                var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                executionStrategy.Execute(() =>
                {
                    using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                    {
                        Print_Shipment_Info _printData = (Print_Shipment_Info)Get_Print_Shipment_Info_By_ShipmentId(markerData.shipmentid, markerData.companyid);
                        V_Shipment_Info _vShipment = _dbContext.v_shipment_info.FirstOrDefault(x => x.shipmentid == markerData.shipmentid && x.companyid == markerData.companyid);
                        Shipment _shipment = _dbContext.shipment.FirstOrDefault(x => x.ShipmentId == markerData.shipmentid && x.CompanyId == markerData.companyid);
                        Shipment _shipmentExt = _shipment;
                        if (_shipment != null)
                        {
                            try
                            {
                                if (_printData != null && convert.ToString(_printData.Final_Receipt_Emailid) != "")
                                {
                                    sEmailID = convert.ToString(_printData.Final_Receipt_Emailid) + "," + markerData.emailids;
                                }
                                else
                                {
                                    sEmailID = markerData.emailids;
                                }
                                _shipment.UpdatedDate = DateTime.Now;
                                _dbContext.Entry(_shipmentExt).CurrentValues.SetValues(_shipment);
                                Updated += _dbContext.SaveChanges();

                                Shipment_Vessel_Info _shipmentInfo = _dbContext.shipment_vessel_info.FirstOrDefault(x => x.ShipmentId == markerData.shipmentid && x.FinalReceiptExported == 1);
                                Shipment_Vessel_Info _shipmentInfoExt = _shipmentInfo;
                                if (_shipmentInfo != null)
                                {
                                    _shipmentInfo.UpdatedDate = DateTime.Now;
                                    _shipmentInfo.FinalReceiptExported = 2;
                                    _dbContext.Entry(_shipmentInfoExt).CurrentValues.SetValues(_shipmentInfo);
                                    Updated += _dbContext.SaveChanges();

                                    PrintGoodsReturnReportModal _printdata = PrintGoodsReturnReport(_shipment.ShipmentId, convert.ToInt(_shipment.CompanyId));

                                    if (_printdata != null && _printdata.goodsreturniteminfo.Count() > 0)
                                    {
                                        Shipment_Documents _shipmentDocumentExt = _dbContext.shipment_documents.FirstOrDefault(x => x.ShipmentId == markerData.shipmentid && x.DocumentTitle == "GRN_DOCUMENTS");
                                        Shipment_Documents _shipmentDocument = _shipmentDocumentExt;

                                        Mast_SITE_CONFIG mast_SITE_CONFIG = _dbContext.mast_site_config.FirstOrDefault(x => x.companyid == _shipment.CompanyId && x.moduleid == 1 && x.siteconfig_paramid == 1015);
                                        if (mast_SITE_CONFIG != null)
                                        {
                                            string _savePath = mast_SITE_CONFIG.param_value + "\\" + _shipment.CompanyId + "\\" + _shipment.ShipmentId;
                                            string _docPath = "\\" + _shipment.CompanyId + "\\" + _shipment.ShipmentId;

                                            if (_shipmentDocument == null)
                                            {
                                                _shipmentDocument = new Shipment_Documents();
                                                _shipmentDocument.CreatedDate = DateTime.Now;
                                                isNew = true;
                                            }
                                            _shipmentDocument.ShipmentId = markerData.shipmentid;
                                            _shipmentDocument.DocumentName = markerData.GRNReportName;
                                            _shipmentDocument.DocumentNo = markerData.shipmentid;
                                            _shipmentDocument.DocumentPath = _docPath + "\\" + markerData.GRNReportName;
                                            _shipmentDocument.DocumentTitle = "GRN_DOCUMENTS";

                                            _shipmentDocument.UpdatedDate = DateTime.Now;
                                            _shipmentDocument.DocumentType = GetMimeType(Path.GetExtension(markerData.GRNReportName));
                                            if (markerData.Base64GRNReport != null)
                                            {
                                                byte[] _sbytes = Convert.FromBase64String(markerData.Base64GRNReport);
                                                if (!Directory.Exists(_savePath)) Directory.CreateDirectory(_savePath);
                                                System.IO.File.WriteAllBytes(_savePath + "\\" + markerData.GRNReportName, _sbytes);
                                                if (System.IO.File.Exists(_savePath + "\\" + markerData.GRNReportName))
                                                {
                                                    isUploaded = true;
                                                    setlog("File " + _docPath + "\\" + markerData.GRNReportName + " GRN created successfully");
                                                }
                                            }
                                            if (isUploaded)
                                            {
                                                if (isNew)
                                                {
                                                    _dbContext.shipment_documents.Add(_shipmentDocument);
                                                }
                                                else
                                                {
                                                    _dbContext.Entry(_shipmentDocumentExt).CurrentValues.SetValues(_shipmentDocument);
                                                }
                                                Updated += _dbContext.SaveChanges();
                                                if (Updated > 0)
                                                {
                                                    dbContextTransaction.Commit();
                                                    _response.data = _shipment;
                                                    _response.status = "SUCCESS";
                                                    _response.isSuccess = true;
                                                    _response.message = "Shipment with order no : " + _shipment.OrderNo + " Final receipt with Goods return exported successfully.";
                                                    LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Final receipt with Goods return exported successfully.", "", "", "", "");
                                                    if (sEmailID.Length > 0)
                                                    {
                                                        LeSDataMain.LeSDM.SendMailQueueFile("", "EPOD_FINAL_RECEIEPT_EXPORT", _shipment.OrderNo, _vShipment.vessel_name, "Exported", sEmailID, "", "", "", markerData.company_desc, _vShipment.cust_name, "Goods Return Report for Shipment Order Number : " + _shipment.OrderNo + " VESSEL : " + _vShipment.vessel_name + ".", mailpath, "0", "Goods Return Report for Shipment Order Number : " + _shipment.OrderNo + " VESSEL : " + _vShipment.vessel_name + ".", markerData.attachmentfiles, "0");

                                                    }
                                                    else
                                                    {
                                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "No Email found for : " + _shipment.OrderNo + " Final receipt .", "", "", "", "");

                                                    }

                                                }
                                            }
                                            else
                                            {
                                                throw new Exception("Unable to get Upload File Data.");
                                            }
                                        }
                                        else
                                        {
                                            throw new Exception("Unable to get Upload File Data.");
                                        }
                                    }
                                    else
                                    {
                                        dbContextTransaction.Commit();
                                        _response.data = _shipment;
                                        _response.status = "SUCCESS";
                                        _response.isSuccess = true;
                                        _response.message = "Shipment with order no : " + _shipment.OrderNo + " Final receipt exported successfully.";
                                        LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "SUCCESS", "", "Shipment with order no : " + _shipment.OrderNo + " Final receipt exported successfully.", "", "", "", "");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Unable to get Shipment Info details for Export.");
                                }
                            }
                            catch (Exception ex)
                            {
                                dbContextTransaction.Rollback();
                                setlog("Error while pushing Shipment : " + ex.Message);
                                throw ex;
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to get Shipment Info details.");
                        }
                    }
                });

            }
            catch (Exception ex)
            {
                setlog("Error while Update Final receipt Export Marker for Shipment : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, "ERROR", "", "Error while Update Final receipt Export Marker for Shipment : " + ex.Message, "", "", "", "");
            }
            return _response;
        }


        protected StandardAPIresponse Get_EPOD_Shipment_Info_By_companyId_Filter(FilterShipmentList modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();
            var userCompany = _dbContextUserAdmin.les_company.Where(x => x.companyid == modal.companyid).FirstOrDefault();

            var shipmentInfoList = _dbContext.v_shipment_info.AsQueryable();
            string sqlQuery = @"
                SELECT *
                FROM V_SHIPMENT_INFO
                WHERE companyid = @companyid
                    AND (Is_Delete != 1 OR Is_Delete IS NULL)
                    AND (shipment_statusid = @readyToShipStatus
                         OR shipment_statusid = @shippedStatus
                         OR shipment_statusid = @verificationStatus
                         OR shipment_statusid = @completedStatus)
                    AND (@shipmentNo IS NULL OR @shipmentNo = '' OR order_no LIKE '%' + @shipmentNo + '%')
                    AND (@statusid <= 0 OR shipment_statusid = @statusid)
                    AND (@transType <= 0 OR transport_type_id = @transType)
                    AND (@jobno IS NULL OR @jobno = '' OR jobno LIKE '%' + LTRIM(RTRIM(@jobno)) + '%')
                    AND (@vesselName IS NULL OR @vesselName = '' OR vessel_name LIKE '%' + LTRIM(RTRIM(@vesselName)) + '%')
            ";


            var parameters = new[]
            {
                new SqlParameter("@companyid", modal.companyid),
                new SqlParameter("@readyToShipStatus", Convert.ToInt32(Status.READYTOSHIP)),
                new SqlParameter("@shippedStatus", Convert.ToInt32(Status.SHIPPED)),
                new SqlParameter("@verificationStatus", Convert.ToInt32(Status.VERIFICATION)),
                new SqlParameter("@completedStatus", Convert.ToInt32(Status.COMPLETED)),
                new SqlParameter("@shipmentNo", string.IsNullOrEmpty(modal.shipmentno) ? (object)DBNull.Value : modal.shipmentno),
                new SqlParameter("@statusid", modal.statusid),
                new SqlParameter("@transType", modal.transTypeid),
                new SqlParameter("@jobno", string.IsNullOrEmpty(modal.jobno) ? (object)DBNull.Value : modal.jobno.Trim()),
                new SqlParameter("@vesselName", string.IsNullOrEmpty(modal.vesselName) ? (object)DBNull.Value : modal.vesselName.Trim())
            };
            shipmentInfoList = _dbContext.v_shipment_info.FromSqlRaw(sqlQuery, parameters);
            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                var arrquery = shipmentInfoList.ToArray();
                // Apply quick search logic
                arrquery = arrquery.Where(m =>
                {
                    string searchString = $"{m.order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.vessel_eta != null ? m.vessel_eta.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.delivery_date != null ? m.delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{m.jobno?.ToString().ToUpper() ?? ""} " +
                                          $"{m.anchorage_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.agent?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Boarding_Officer_Name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Vehicle_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.shipment_statusdesc?.ToString().ToUpper() ?? ""} " +
                                          $"{m.transport_type_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.driver_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.supply_boat?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.planned_ship_date != null ? m.planned_ship_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.planned_delivery_date != null ? m.planned_delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")}";

                    return searchString.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                }).ToArray();
                shipmentInfoList = arrquery.AsQueryable(); ;
            }

            // Apply additional filters using LINQ if needed
            if (!string.IsNullOrEmpty(modal.custCode))
            {
                shipmentInfoList = shipmentInfoList.Where(x => x.cust_code.Contains(modal.custCode) || x.cust_name.Contains(modal.custCode));
            }

            if (!string.IsNullOrEmpty(modal.custName))
            {
                shipmentInfoList = shipmentInfoList.Where(x => x.cust_name == modal.custName);
            }

            if (!string.IsNullOrEmpty(modal.dtFrom) && !string.IsNullOrEmpty(modal.dtTo))
            {
                DateTime dtFrom = DateTime.ParseExact(modal.dtFrom, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dtTo = DateTime.ParseExact(modal.dtTo, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date >= dtFrom.Date && x.delivery_date.Value.Date <= dtTo.Date);
            }

            // Check delivery date conditions
            if (modal.isDeliveryToday)
            {
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date == DateTime.Now.Date);
            }
            else if (modal.isDeliveryin3days)
            {
                DateTime now = DateTime.Now.Date;
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date >= now && x.delivery_date.Value.Date <= now.AddDays(3));
            }
            else if (modal.isDeliveryThisWeek)
            {
                DateTime now = DateTime.Now.Date;
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date >= now && x.delivery_date.Value.Date <= now.AddDays(7));
            }

            //Apply sorting 

            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                if (modal.sortingorder.ToLower() == "asc")
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": shipmentInfoList = shipmentInfoList.OrderBy(x => x.order_no); break;
                        case "cust_code": shipmentInfoList = shipmentInfoList.OrderBy(x => x.cust_code); break;
                        case "cust_name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.cust_name); break;
                        case "jobno": shipmentInfoList = shipmentInfoList.OrderBy(x => x.jobno); break;
                        case "vessel_name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.vessel_name); break;
                        case "vessel_eta": shipmentInfoList = shipmentInfoList.OrderBy(x => x.vessel_eta); break;
                        case "delivery_date": shipmentInfoList = shipmentInfoList.OrderBy(x => x.delivery_date); break;
                        case "anchorage_description": shipmentInfoList = shipmentInfoList.OrderBy(x => x.anchorage_description); break;
                        case "agent": shipmentInfoList = shipmentInfoList.OrderBy(x => x.agent); break;
                        case "transport_type_description": shipmentInfoList = shipmentInfoList.OrderBy(x => x.transport_type_description); break;
                        case "driver_name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.driver_name); break;
                        case "shipment_statusdesc": shipmentInfoList = shipmentInfoList.OrderBy(x => x.shipment_statusdesc); break;
                        case "supply_boat": shipmentInfoList = shipmentInfoList.OrderBy(x => x.supply_boat); break;
                        case "boarding_Officer_Name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": shipmentInfoList = shipmentInfoList.OrderBy(x => x.Vehicle_no); break;
                        default: shipmentInfoList = shipmentInfoList.OrderBy(x => x.shipmentid); break;
                    }
                }
                else
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.order_no); break;
                        case "delivery_date": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.delivery_date); break;
                        case "cust_code": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.cust_code); break;
                        case "cust_name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.cust_name); break;
                        case "jobno": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.jobno); break;
                        case "vessel_name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.vessel_name); break;
                        case "vessel_eta": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.vessel_eta); break;
                        case "anchorage_description": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.anchorage_description); break;
                        case "agent": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.agent); break;
                        case "transport_type_description": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.transport_type_description); break;
                        case "driver_name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.driver_name); break;
                        case "shipment_statusdesc": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.shipment_statusdesc); break;
                        case "supply_boat": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.supply_boat); break;
                        case "boarding_Officer_Name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.Vehicle_no); break;
                        default: shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.shipmentid); break;
                    }
                }
            }
            // Apply pagination
            responsemodal.totalRecords = shipmentInfoList.Count();
            var lsData = new List<V_Shipment_Info>();
            if (modal.pagesize > 0)
            {
                lsData = shipmentInfoList.Skip(modal.skip).Take(modal.pagesize).ToList();
            }
            else
            {
                lsData = shipmentInfoList.ToList();
            }
            lsData.ForEach(x =>
            {
                x.CompanyCode = userCompany.company_code;
                x.CompanyName = userCompany.company_description;
            });
            responsemodal.data = lsData;
            responsemodal.isSuccess = true;
            return responsemodal;

        }
        protected StandardAPIresponse Get_EPOD_Shipment_Info_By_customerId_Filter(FilterShipmentList modal)
        {
            StandardAPIresponse responsemodal = new StandardAPIresponse();

            var shipmentInfoList = _dbContext.v_shipment_info.AsQueryable();
            string sqlQuery = @"
                SELECT *
                FROM V_SHIPMENT_INFO
                WHERE  RECEIVERID = @customerid
                    AND (Is_Delete != 1 OR Is_Delete IS NULL)
                    AND (shipment_statusid = @readyToShipStatus
                         OR shipment_statusid = @shippedStatus
                         OR shipment_statusid = @verificationStatus
                         OR shipment_statusid = @completedStatus)
                    AND (@shipmentNo IS NULL OR @shipmentNo = '' OR order_no LIKE '%' + @shipmentNo + '%')
                    AND (@statusid <= 0 OR shipment_statusid = @statusid)
                    AND (@transType <= 0 OR transport_type_id = @transType)
                    AND (@jobno IS NULL OR @jobno = '' OR jobno LIKE '%' + LTRIM(RTRIM(@jobno)) + '%')
                    AND (@vesselName IS NULL OR @vesselName = '' OR vessel_name LIKE '%' + LTRIM(RTRIM(@vesselName)) + '%')
            ";


            var parameters = new[]
            {
                new SqlParameter("@companyid", modal.companyid),
                new SqlParameter("@customerid", modal.customerid),
                new SqlParameter("@readyToShipStatus", Convert.ToInt32(Status.READYTOSHIP)),
                new SqlParameter("@shippedStatus", Convert.ToInt32(Status.SHIPPED)),
                new SqlParameter("@verificationStatus", Convert.ToInt32(Status.VERIFICATION)),
                new SqlParameter("@completedStatus", Convert.ToInt32(Status.COMPLETED)),
                new SqlParameter("@shipmentNo", string.IsNullOrEmpty(modal.shipmentno) ? (object)DBNull.Value : modal.shipmentno),
                new SqlParameter("@statusid", modal.statusid),
                new SqlParameter("@transType", modal.transTypeid),
                new SqlParameter("@jobno", string.IsNullOrEmpty(modal.jobno) ? (object)DBNull.Value : modal.jobno.Trim()),
                new SqlParameter("@vesselName", string.IsNullOrEmpty(modal.vesselName) ? (object)DBNull.Value : modal.vesselName.Trim())
            };
            shipmentInfoList = _dbContext.v_shipment_info.FromSqlRaw(sqlQuery, parameters);
            if (!string.IsNullOrEmpty(modal.quicksearchvalue))
            {
                string searchValue = modal.quicksearchvalue.Trim().ToUpper();
                var arrquery = shipmentInfoList.ToArray();
                // Apply quick search logic
                arrquery = arrquery.Where(m =>
                {
                    string searchString = $"{m.order_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.vessel_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_code?.ToString().ToUpper() ?? ""} " +
                                          $"{m.cust_name?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.vessel_eta != null ? m.vessel_eta.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.delivery_date != null ? m.delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{m.jobno?.ToString().ToUpper() ?? ""} " +
                                          $"{m.anchorage_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.agent?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Boarding_Officer_Name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.Vehicle_no?.ToString().ToUpper() ?? ""} " +
                                          $"{m.shipment_statusdesc?.ToString().ToUpper() ?? ""} " +
                                          $"{m.transport_type_description?.ToString().ToUpper() ?? ""} " +
                                          $"{m.driver_name?.ToString().ToUpper() ?? ""} " +
                                          $"{m.supply_boat?.ToString().ToUpper() ?? ""} " +
                                          $"{(m.planned_ship_date != null ? m.planned_ship_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")} " +
                                          $"{(m.planned_delivery_date != null ? m.planned_delivery_date.Value.ToString("dd/MM/yyyy").ToUpper() : "")}";

                    return searchString.Contains(searchValue, StringComparison.OrdinalIgnoreCase);
                }).ToArray();
                shipmentInfoList = arrquery.AsQueryable(); ;
            }

            // Apply additional filters using LINQ if needed
            if (!string.IsNullOrEmpty(modal.custCode))
            {
                shipmentInfoList = shipmentInfoList.Where(x => x.cust_code.Contains(modal.custCode) || x.cust_name.Contains(modal.custCode));
            }

            if (!string.IsNullOrEmpty(modal.custName))
            {
                shipmentInfoList = shipmentInfoList.Where(x => x.cust_name == modal.custName);
            }

            if (!string.IsNullOrEmpty(modal.dtFrom) && !string.IsNullOrEmpty(modal.dtTo))
            {
                DateTime dtFrom = DateTime.ParseExact(modal.dtFrom, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateTime dtTo = DateTime.ParseExact(modal.dtTo, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date >= dtFrom.Date && x.delivery_date.Value.Date <= dtTo.Date);
            }

            // Check delivery date conditions
            if (modal.isDeliveryToday)
            {
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date == DateTime.Now.Date);
            }
            else if (modal.isDeliveryin3days)
            {
                DateTime now = DateTime.Now.Date;
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date >= now && x.delivery_date.Value.Date <= now.AddDays(3));
            }
            else if (modal.isDeliveryThisWeek)
            {
                DateTime now = DateTime.Now.Date;
                shipmentInfoList = shipmentInfoList.Where(x => x.delivery_date.HasValue && x.delivery_date.Value.Date >= now && x.delivery_date.Value.Date <= now.AddDays(7));
            }

            //Apply sorting 

            if (!string.IsNullOrEmpty(modal.sortcolumn) && !string.IsNullOrEmpty(modal.sortingorder))
            {
                if (modal.sortingorder.ToLower() == "asc")
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": shipmentInfoList = shipmentInfoList.OrderBy(x => x.order_no); break;
                        case "cust_code": shipmentInfoList = shipmentInfoList.OrderBy(x => x.cust_code); break;
                        case "cust_name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.cust_name); break;
                        case "jobno": shipmentInfoList = shipmentInfoList.OrderBy(x => x.jobno); break;
                        case "vessel_name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.vessel_name); break;
                        case "vessel_eta": shipmentInfoList = shipmentInfoList.OrderBy(x => x.vessel_eta); break;
                        case "delivery_date": shipmentInfoList = shipmentInfoList.OrderBy(x => x.delivery_date); break;
                        case "anchorage_description": shipmentInfoList = shipmentInfoList.OrderBy(x => x.anchorage_description); break;
                        case "agent": shipmentInfoList = shipmentInfoList.OrderBy(x => x.agent); break;
                        case "transport_type_description": shipmentInfoList = shipmentInfoList.OrderBy(x => x.transport_type_description); break;
                        case "driver_name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.driver_name); break;
                        case "shipment_statusdesc": shipmentInfoList = shipmentInfoList.OrderBy(x => x.shipment_statusdesc); break;
                        case "supply_boat": shipmentInfoList = shipmentInfoList.OrderBy(x => x.supply_boat); break;
                        case "boarding_Officer_Name": shipmentInfoList = shipmentInfoList.OrderBy(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": shipmentInfoList = shipmentInfoList.OrderBy(x => x.Vehicle_no); break;
                        default: shipmentInfoList = shipmentInfoList.OrderBy(x => x.shipmentid); break;
                    }
                }
                else
                {
                    switch (modal.sortcolumn)
                    {
                        case "order_no": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.order_no); break;
                        case "delivery_date": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.delivery_date); break;
                        case "cust_code": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.cust_code); break;
                        case "cust_name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.cust_name); break;
                        case "jobno": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.jobno); break;
                        case "vessel_name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.vessel_name); break;
                        case "vessel_eta": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.vessel_eta); break;
                        case "anchorage_description": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.anchorage_description); break;
                        case "agent": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.agent); break;
                        case "transport_type_description": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.transport_type_description); break;
                        case "driver_name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.driver_name); break;
                        case "shipment_statusdesc": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.shipment_statusdesc); break;
                        case "supply_boat": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.supply_boat); break;
                        case "boarding_Officer_Name": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.Boarding_Officer_Name); break;
                        case "vehicle_no": shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.Vehicle_no); break;
                        default: shipmentInfoList = shipmentInfoList.OrderByDescending(x => x.shipmentid); break;
                    }
                }
            }
            // Apply pagination
            responsemodal.totalRecords = shipmentInfoList.Count();
            var lsData = new List<V_Shipment_Info>();
            if (modal.pagesize > 0)
            {
                lsData = shipmentInfoList.Skip(modal.skip).Take(modal.pagesize).ToList();
            }
            else
            {
                lsData = shipmentInfoList.ToList();
            }
            List<int?> CommonCompanies = lsData.Select(x => x.companyid).Distinct().ToList();
            var companies = _dbContextUserAdmin.les_company.Where(x => CommonCompanies.Contains(x.companyid)).ToList();
            lsData.ForEach(x =>
            {
                x.CompanyCode = companies.Where(y => y.companyid == x.companyid).FirstOrDefault().company_code ?? "";
                x.CompanyName = companies.Where(y => y.companyid == x.companyid).FirstOrDefault().company_description ?? "";
            });
            responsemodal.data = lsData;
            responsemodal.isSuccess = true;
            return responsemodal;

        }

        //    protected List<V_Shipment_Info> Get_EPOD_Shipment_Info_By_companyId_Filter(int companyid, string shipmentNo, int statusid,int customerid, string custCode, string custName, int transType, string jobno, string vesselName, string dtFrom, string dtTo, bool isDeliveryToday = false, bool isDeliveryin3days = false, bool isDeliveryThisWeek = false)
        //    {
        //        StandardAPIresponse modal = new StandardAPIresponse();

        //        var query = _dbContext.v_shipment_info.AsQueryable();

        //        List<V_Shipment_Info> obj = _dbContext.v_shipment_info.Where(x => x.companyid == companyid && x.Is_Delete != 1 && (x.shipment_statusid == convert.ToInt(Status.READYTOSHIP) || x.shipment_statusid == convert.ToInt(Status.SHIPPED) || x.shipment_statusid == convert.ToInt(Status.VERIFICATION) || x.shipment_statusid == convert.ToInt(Status.COMPLETED)))

        //.Where(x => string.IsNullOrEmpty(shipmentNo) || x.order_no.Contains(shipmentNo))
        //.Where(x => statusid <= 0 || x.shipment_statusid == statusid)
        //.Where(x => transType <= 0 || x.transport_type_id == transType)
        //.Where(x => string.IsNullOrEmpty(jobno) || x.jobno.Contains(jobno.Trim()))
        //.Where(x => string.IsNullOrEmpty(vesselName) || x.vessel_name.Contains(vesselName.Trim())).ToList();
        //        if (convert.ToInt(customerid) > 0)
        //        {
        //            obj = obj.Where(x => x.receiverid == convert.ToInt(customerid)).ToList();
        //        }
        //        else
        //        {
        //            obj = obj.Where(x => string.IsNullOrEmpty(custCode) || x.cust_code.Contains(custCode) || x.cust_name.Contains(custCode)).ToList();
        //            obj = obj.Where(x => string.IsNullOrEmpty(custName) || x.cust_name == custName).ToList();
        //        }
        //        if (convert.ToString(dtFrom) != "" && convert.ToString(dtTo) != "")
        //        {
        //            obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date >= convert.ToDateTime(dtFrom, "dd/MM/yyyy").Date && convert.ToDateTime(x.delivery_date).Date <= convert.ToDateTime(dtTo, "dd/MM/yyyy").Date).ToList();
        //        }
        //        if (isDeliveryToday)
        //        {
        //            obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date == DateTime.Now.Date).ToList();
        //        }
        //        else if (isDeliveryin3days)
        //        {
        //            obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date <= DateTime.Now.AddDays(3) && convert.ToDateTime(x.delivery_date).Date >= DateTime.Now.Date).ToList();
        //        }
        //        else if (isDeliveryThisWeek)
        //        {
        //            obj = obj.Where(x => convert.ToDateTime(x.delivery_date).Date <= DateTime.Now.AddDays(7) && convert.ToDateTime(x.delivery_date).Date >= DateTime.Now.Date).ToList();
        //        }
        //        return obj;
        //    }

        //protected string GetQueryData(string sqlQuery)
        //{
        //    DataAccess _service = new DataAccess("LogisticConnectionString");
        //    DataTable _dataTable = _service.ExecuteSqlQuery(sqlQuery);
        //    string json = JsonConvert.SerializeObject(_dataTable);
        //    return json;
        //}

        //protected string GetSqlQueryDataParameters(string sqlQuery, List<string> lstParameters)
        //{
        //    DataAccess _service = new DataAccess("LogisticConnectionString");
        //    _service.CreateSQLCommand(sqlQuery);
        //    if (lstParameters.Count() > 0)
        //    {
        //        foreach (string _parma in lstParameters)
        //        {
        //            string[] _parameters = _parma.Split('~');
        //            _service.AddParameter(_parameters[0], _parameters[1], ParameterDirection.Input);
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("Parameters are empty");
        //    }
        //    DataSet _ds = _service.ExecuteDataSet();
        //    string json = JsonConvert.SerializeObject(_ds.Tables[0]);
        //    return json;
        //}

        private string SetLatestAutoNumber(int companyid, int ModuleId, int ModuleLastNumber)
        {
            string cResult = "";
            bool IsAuto = false;
            var _NumTypeObj = _dbContext.mast_site_config.Where(x => x.companyid == companyid && x.moduleid == ModuleId && x.siteconfig_paramid == 1004).FirstOrDefault();
            if (_NumTypeObj != null)
            {
                IsAuto = (_NumTypeObj.param_value.ToUpper() == "MANUAL") ? false : true;
            }
            if (IsAuto)
            {
                string cSeqMask = "";
                var cMaskedDet = GetMaskedData(companyid, ModuleId, out cSeqMask);
                cResult = cMaskedDet + string.Format("{0:" + cSeqMask + "}", ModuleLastNumber + 1);
            }
            return cResult;
        }

        private string GetMaskedData(int companyid, int ModuleId, out string cSeqMask)
        {
            string cResult = ""; cSeqMask = "";
            var _NumberFormatObj = _dbContext.mast_site_config.Where(x => x.companyid == companyid && x.moduleid == ModuleId && x.siteconfig_paramid == 1001).FirstOrDefault();
            if (_NumberFormatObj != null)
            {
                string[] _arrNumFormat = _NumberFormatObj.param_value.Split('|');
                string cPrefix = _arrNumFormat[0].Trim(); string cFormat = _arrNumFormat[1].Trim(); cSeqMask = _arrNumFormat[2].Trim();

                string tempstr = "";
                if (cFormat.Contains("YYYY"))
                {
                    tempstr = cFormat.Replace("YYYY", "yyyy");
                }
                else if (cFormat.Contains("YY"))
                {
                    tempstr = cFormat.Replace("YY", "yy");
                }
                if (cFormat.Contains("DD"))
                {
                    tempstr = cFormat.Replace("DD", "dd");
                }
                if (cFormat.Contains("mmm"))
                {
                    tempstr = cFormat.Replace("mmm", "MMM");
                }
                if (cFormat.Contains("mm"))
                {
                    tempstr = cFormat.Replace("mm", "MM");
                }
                if (tempstr == "") tempstr = cFormat;
                string cFinStr = "";
                for (int k = 0; k < tempstr.Length; k++)
                {
                    if (!char.IsLetter(tempstr[k]))
                    {
                        cFinStr += "'" + tempstr[k] + "'";
                    }
                    else { cFinStr += tempstr[k]; }

                }
                string finalStr = DateTime.Now.ToString(cFinStr);
                cResult = cPrefix + finalStr;
            }
            return cResult;
        }

        private string getSerializeData(object data)
        {
            string _Data = "";
            try
            {
                _Data = JsonConvert.SerializeObject(data);
            }
            catch (Exception ex)
            {
                setlog("Error on getSerializeData : " + ex.Message + " Stack Trace : " + ex.StackTrace);
            }
            return _Data;
        }

        private string GetMimeType(string ext)
        {
            string str = "";
            switch (ext.ToUpper())
            {
                case ".PNG":
                    str = "image/png";
                    break;
                case ".JPEG":
                    str = "image/jpeg";
                    break;
                case ".XML":
                    str = "application/xml";
                    break;
                case ".PDF":
                    str = "application/pdf";
                    break;
                case ".DOCX":
                    str = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                    break;
                case ".XLSX":
                    str = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                    break;
                case ".TXT":
                    str = "text/plain";
                    break;
                case ".DOC":
                    str = "application/msword";
                    break;
                case ".ICO":
                    str = "image/vnd.microsoft.icon";
                    break;
                case ".JPG":
                    str = "image/jpeg";
                    break;
                case ".XLS":
                    str = "application/vnd.ms-excel";
                    break;
            }
            return str;
        }

        public static void SetAuditLogFile(string ModuleName, string Action, string FileName, string LogMsg, string KeyID, string BuyerRefNo, string BuyerID, string SuppID)
        {
            try
            {
                DateTime now = DateTime.Now;
                string Auditpath = ConfigurationSettings.AppSettings["ESUPPLIER_AUDIT"]!.ToString();
                string text2 = "";
                string text3 = "";
                if (ConfigurationSettings.AppSettings["SERVER_NAME"] != null)
                {
                    text2 = ConfigurationSettings.AppSettings["SERVER_NAME"];
                }

                if (ConfigurationSettings.AppSettings["PROCESSOR_NAME"] != null)
                {
                    text3 = ConfigurationSettings.AppSettings["PROCESSOR_NAME"];
                }

                if (!Directory.Exists(Auditpath))
                {
                    Directory.CreateDirectory(Auditpath);
                }

                string path = Auditpath + "\\LesAudit_" + convert.ToFileName(ModuleName + "_" + DateTime.Now.ToString("ddMMyy_HHmmssfff") + ".TXT");
                string value = "";
                ModuleName = ModuleName.Replace("|", " ");
                FileName = FileName.Replace("|", " ");
                BuyerRefNo = BuyerRefNo.Replace("|", " ");
                Action = Action.Replace("|", " ");
                LogMsg = LogMsg.Replace("|", " ");
                if (LogMsg != string.Empty)
                {
                    value = BuyerID + "|" + SuppID + "|" + ModuleName + "|" + FileName + "|" + BuyerRefNo + "|" + Action + "|" + DateTime.Now.ToString("yy-MM-dd HH:mm") + " : " + LogMsg + "||" + text2 + "|||" + text3;
                }

                DirectoryInfo directoryInfo = new DirectoryInfo(Auditpath);
                if (!directoryInfo.Exists)
                {
                    Directory.CreateDirectory(Auditpath);
                }

                if (Directory.Exists(Auditpath))
                {
                    StreamWriter streamWriter = new StreamWriter(path, append: true);
                    streamWriter.WriteLine(value);
                    streamWriter.Flush();
                    streamWriter.Close();
                    streamWriter.Dispose();
                }
            }
            catch
            {
            }
        }

        public static void setlog(string msg)
        {
            try
            {
                LeSDataMain.LeSDM.AddConsoleLog(msg);
            }
            catch
            {
                //
            }
        }


    }

    public class AttachDocumentsDataModal
    {
        public int? DocRefId { get; set; }
        public int? UpdatedBy { get; set; }
        public string? Document_Name { get; set; } = "";
        public string? FileType { get; set; } = "";
        public string? Base64Data { get; set; } = "";
        public int? Docid { get; set; } = 0;
        public int? Companyid { get; set; } = 0;
    }

    public class CreateDeliveryOrderModal
    {
        public string companycode { get; set; }
        public V_Delivery_Orders_Info DeliveryOrderInfo { get; set; }
        public List<V_DELIVERY_ORDER_LINES> DeliveryOrderLines { get; set; }

    }

    public class CreateShipmentOrderModal
    {
        public CURD_Shipment_Info shipment_Info { get; set; }
        public CURD_SHIPMENT_TRIP_PLAN shipment_trip_plan { get; set; }
        public List<Shipment_Documents> shipment_document { get; set; }
        public List<int> deliveryOrderIds { get; set; }
        public int createdBy { get; set; }
    }

    public class UpdateShipmentOrderModal
    {
        public CURD_Shipment_Info shipment_Info { get; set; }
        public CURD_SHIPMENT_TRIP_PLAN shipment_trip_plan { get; set; }
        public int updatedBy { get; set; }
    }

    public class LesCustomerDropdown
    {
        public int customerid { get; set; }

        public string? cust_code { get; set; }

        public string? cust_name { get; set; }

        public string? cust_type { get; set; }
        public int? companyid { get; set; }
    }

    public class responseMessage
    {
        public object data { get; set; }
        public string status { get; set; }
        public bool isSuccess { get; set; }
        public string message { get; set; }
    }

    public partial class GlobalTools
    {
        public static string cPWDecrypted = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890@#$%^&*()[]-_~!+:,'{}";
        public static string cPWEncrypted = @".-,+*)(~&%$#}!@?>=<;:98765^]\[ZYXWV_ABCDEFGHIJKLMNOPQRSTU";

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

        public static bool HasAccess(string UserAccessDetails, string ModuleID, string AccessLevel = "")
        {
            if (UserAccessDetails != null)
            {
                Dictionary<string, string> UserAccess = JsonConvert.DeserializeObject<Dictionary<string, string>>(UserAccessDetails);
                if (!UserAccess.ContainsKey(ModuleID) || (UserAccess.ContainsKey(ModuleID) && UserAccess[ModuleID] == "0" || (AccessLevel != "" && UserAccess.ContainsKey(ModuleID) && UserAccess[ModuleID] != AccessLevel))) return false;
                else return true;
            }
            else return false;
        }

    }

    public class Update_EPOD_DeliveryOrderItems
    {
        public int DeliveryOrderId { get; set; }
        public int? ShipmentId { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? GoodsReturnRemarks { get; set; }
        public List<EPODItemListField> EPOD_ItemDetails { get; set; }
    }

    public class EPODItemListField
    {
        public int DeliveryOrderLinesId { get; set; }
        public double? Quantity { get; set; }
        public double? QuantityInvoiced { get; set; }
        public int? GrnReasonId { get; set; }
        public string? Epod_line_remarks { get; set; }
    }

    public class AssignDeliverOrder
    {
        public List<int> DeliveryOrderIds { get; set; }
        public int ShipmentId { get; set; }
        public int UpdatedBy { get; set; }

    }

    public class EPOD_ShipmentDetails
    {
        public int? shipmentid { get; set; }
        public string? EPOD_Shipment_Remarks { get; set; }
        public int? updateBy { get; set; }
    }

    public class QRModal
    {
        public int ShipmentId { get; set; }
        public string ShipmentNo { get; set; }
        public string VesselName { get; set; }
        public string CustomerName { get; set; }
        public string JobNo { get; set; }
    }

    public class EPODDeliveryOrderInfoLinesModal
    {
        public V_Delivery_Orders_Info _DOInfo { get; set; }
        public List<V_DELIVERY_ORDER_LINES> _DOLines { get; set; }
    }

    public class CreateShipmentwithDOModal
    {
        public int? customerid { get; set; }
        public string? customername { get; set; }
        public string? jobno { get; set; }
        public int? vesselid { get; set; }
        public string? vesselname { get; set; }
        public string? vesseleta { get; set; }
        public List<V_Delivery_Orders_Info> deliveryorders { get; set; } = new List<V_Delivery_Orders_Info>();
    }

    public class deliveryOrderListModal
    {
        public int? companyid { get; set; }
        public List<int> lstdo { get; set; }
    }

    public class UpdateEpodStatusModal
    {
        public int shipmentid { get; set; }
        public int userid { get; set; } = 0;
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string emailid { get; set; } = string.Empty;
        public string username { get; set; } = string.Empty;
        public string vesselimo { get; set; } = string.Empty;
        public string role { get; set; } = string.Empty;

    }

    public class PrintGoodsReturnReportModal
    {
        public Companyinfodata companydata { get; set; } = new Companyinfodata();
        public PrintGoodsReturnHeaderInfo goodsreturnheaderinfo { get; set; } = new PrintGoodsReturnHeaderInfo();
        public List<PrintGoodsReturnItemInfo> goodsreturniteminfo { get; set; } = new List<PrintGoodsReturnItemInfo>();
    }

    public class PrintGoodsReturnHeaderInfo
    {
        public int shipmentid { get; set; }
        public string? shipmentno { get; set; }
        public string? vesselname { get; set; }
        public string? drivername { get; set; }
        public string? jobno { get; set; }
        public string? bordingofficer { get; set; }
        public string? deliverydate { get; set; }
        public string? loadingtime { get; set; }
        public string? loadinglocation { get; set; }
        public string? packedby { get; set; }
        public string? purchaser_tech { get; set; }
        public string? purchaser_prov { get; set; }

    }

    public class PrintGoodsReturnItemInfo
    {
        public int shipmentid { get; set; }
        public int deliveryorderid { get; set; }
        public int delivery_order_lines_id { get; set; }
        public string? deliveryorderno { get; set; }
        public string? cust_dept { get; set; }
        public string? cust_itemno { get; set; }
        public string? itemno { get; set; }
        public string? itemdesc { get; set; }
        public double? deliveredQty { get; set; }
        public double? recvQty { get; set; }
        public double? returnQty { get; set; }
        public string? uom { get; set; }
        public string? remarks { get; set; }
        public int? reasoncodeid { get; set; }
        public string? reasoncode { get; set; }
    }
    public class ReleasedData
    {
        public int deliveryOrderid { get; set; }
        public int internalOrderId { get; set; }
        public int inboundShipmentId { get; set; }
        public int createdBy { get; set; }
    }
    public class Companyinfodata
    {
        public int? CompanyId { get; set; }
        public string? Company_Code { get; set; }
        public string? Company_Description { get; set; }
        public int? AddressId { get; set; }

        public string? base64Logo { get; set; }
        public string? base64LogoName { get; set; }
        public string? base64LogoType { get; set; }

        public string? base64minLogo { get; set; }
        public string? base64minLogoName { get; set; }
        public string? base64minLogoType { get; set; }

        public string? base64printLogo { get; set; }
        public string? base64printLogoName { get; set; }
        public string? base64printLogoType { get; set; }

        public string? addr_code { get; set; }
        public string? addr_name { get; set; }
        public string? contact_person { get; set; }
        public string? address1 { get; set; }
        public string? address2 { get; set; }
        public string? address3 { get; set; }
        public string? address4 { get; set; }
        public string? addr_city { get; set; }
        public string? addr_country { get; set; }
        public string? addr_zipcode { get; set; }
        public string? addr_phone1 { get; set; }
        public string? addr_phone2 { get; set; }
        public string? addr_fax { get; set; }
        public string? addr_telex { get; set; }
        public string? addr_email { get; set; }
        public string? addr_mobilephone { get; set; }
        public string? addr_type { get; set; }

    }

    public class ExportDataModal
    {
        public List<V_Shipment_Info> InitialReceiptExportList { get; set; }
        public List<V_Shipment_Info> FinalReceiptExportList { get; set; }
    }

    public class UpdateInitialExportedMarker
    {
        public int shipmentid { get; set; } = 0;
        public int companyid { get; set; } = 0;
        public int receiptmarker { get; set; } = -1;
        public string attachmentfiles { get; set; } = string.Empty;
        public string emailids { get; set; } = string.Empty;
        public string company_desc { get; set; } = string.Empty;
    }

    public class UpdateFinalExportedMarker
    {
        public int shipmentid { get; set; } = 0;
        public int companyid { get; set; } = 0;
        public int receiptmarker { get; set; } = -1;
        public string Base64GRNReport { get; set; } = string.Empty;
        public string GRNReportName { get; set; } = string.Empty;
        public string attachmentfiles { get; set; } = string.Empty;
        public string emailids { get; set; } = string.Empty;
        public string company_desc { get; set; } = string.Empty;

    }

    public class VesselAuthenticationParameter
    {
        public int shipmentid { get; set; }
        public string? useremailid { get; set; }
        public int? userid { get; set; } = null;
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string? password { get; set; } = string.Empty;
        public string? vesselimo { get; set; } = null;
        public string? crewname { get; set; } = null;
        public string? role { get; set; } = null;
    }
    public class VesselAuthenticationUrlParameter
    {
        public string EncryptData { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }

    }

    public class FilterDeliveryOrdersList
    {
        public int companyid { get; set; }
        public int customerid { get; set; } = 0;
        public string doNo { get; set; } = "";
        public string custCode { get; set; } = "";
        public string custName { get; set; } = "";
        public int statusid { get; set; }
        public string shipmentno { get; set; } = "";
        public string shipmentdate { get; set; } = "";
        public string dtFrom { get; set; } = "";
        public string dtTo { get; set; } = "";
        public bool unassignDO { get; set; } = false;
        public bool shipment14days { get; set; } = false;
        public string quicksearchvalue { get; set; } = "";
        public int skip { get; set; }
        public int pagesize { get; set; }
        public string? sortcolumn { get; set; }
        public string? sortingorder { get; set; }
    }

    public class FilterShipmentList
    {
        public int companyid { get; set; }
        public string quicksearchvalue { get; set; }
        public string shipmentno { get; set; }
        public int statusid { get; set; }
        public int customerid { get; set; } = 0;
        public string custCode { get; set; }
        public string custName { get; set; }
        public int transTypeid { get; set; }
        public string jobno { get; set; }
        public string vesselName { get; set; }
        public string dtFrom { get; set; } = string.Empty;
        public string dtTo { get; set; } = string.Empty;
        public int skip { get; set; }
        public int pagesize { get; set; }
        public string? sortcolumn { get; set; }
        public string? sortingorder { get; set; }
        public bool isDeliveryToday { get; set; } = false;
        public bool isDeliveryin3days { get; set; } = false;
        public bool isDeliveryThisWeek { get; set; } = false;
    }
    public class ShipmentData
    {
        public int shipmentid { get; set; }
        public int companyid { get; set; }
    }

    public class DeliveryOrdersDropDownVerification
    {
        public int companyid { get; set; }
        public int customerid { get; set; }
        public string Jobno { get; set; }
        public string VesselName { get; set; }
        public string VesselETA { get; set; }
    }

    public enum Status
    {
        OPEN = 1,
        DRAFT = 2,
        RELEASED = 3,
        CANCELLED = 4,
        READYTOSHIP = 5,
        CONFIRMED = 6,
        INITALRECEIPT = 7,
        SHIPPED = 8,
        RECEIVED = 9,
        COMPLETED = 10,
        NEW = 11,
        VERIFICATION = 12,
    }
    public class StandardAPIresponse
    {
        public object data { get; set; }
        public string status { get; set; }
        public bool isSuccess { get; set; }
        public int totalRecords { get; set; }
        public string message { get; set; }
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
    public class AssignDoToPO_Inbound
    {
        public int quotationid { get; set; } = 0;
        public int inboundshipmentid { get; set; } = 0;
        public int internalorderid { get; set; } = 0;
        public string? VesselName { get; set; }
        public string? DeliveryOrderNo { get; set; }
        public DateTime? DeliveryOrderDate { get; set; }
        public string? JobNo { get; set; }
        public int Isfullorsplit { get; set; } //0 means full 1 means split
        public int createdBy { get; set; }
        public int updatedBy { get; set; }
        public int companyid { get; set; }
        public int customerid { get; set; }
        public List<POlinesMin> POlines { get; set; }
        public List<string> Documents { get; set; }

    }
    public class POlinesMin
    {
        public int internalOrderLineId { get; set; }
        public double qty { get; set; }
    }
}