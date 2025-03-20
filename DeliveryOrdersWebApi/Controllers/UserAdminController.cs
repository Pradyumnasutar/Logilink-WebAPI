﻿using DeliveryOrdersWebApi.Model;
using LES_USER_ADMINISTRATION_LIB;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Imaging;
using System.Drawing;
using DeliveryOrdersWebApi.DAL;
using LES_USER_ADMINISTRATION_LIB.DAL;
using System.Configuration;
using LES_USER_ADMINISTRATION_LIB.Model;
using Microsoft.AspNetCore.Authorization;
using Logistic_Management_Lib.DAL;
using Microsoft.IdentityModel.Abstractions;
using System.ComponentModel.Design;

namespace DeliveryOrdersWebApi.Controllers
{
    [Route("api/V1/UserAdmin")]
    [ApiController]
    [Authorize]
    public class UserAdminController : Controller
    {
        IConfiguration configuration;
        private readonly UserAdminDbContext _dbContext;
        private readonly LogisticDbContext _dbContextLogistics;
        public UserAdminRoutine _routine { get; set; }
        
        public UserAdminController(UserAdminDbContext dbContext, LogisticDbContext dbContextLogistics)
        {
            CommonFunction.setLog("before - UserAdmin");
            _dbContext = dbContext;
            _dbContextLogistics = dbContextLogistics;
            _routine = new UserAdminRoutine(_dbContext, _dbContextLogistics);
            //_dbContextLogistics = dbContextLogistics;

            var configBuilder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            configuration = configBuilder.Build();
            CommonFunction.setLog("after - UserAdmin");
        }

        [HttpGet("GetApplicationList")]
        public IActionResult GetApplicationList()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetApplicationList Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
                object obj = _adminrtn.CallProtedtedMethod();
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UserAdmin GetApplicationList Error: " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetApplicationList function stopped successfully.");
            }
        }

        //[HttpPost]
        //[Route("GetSqlQueryData")]
        //public IActionResult GetSqlQueryData(string QueryData)
        //{
        //    try
        //    {
        //        CommonFunction.setLog("=====================================================");
        //        CommonFunction.setLog("GetSqlQueryData Process started");
        //        UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
        //        object obj = _adminrtn.CallSqlQueryDataMethod(QueryData);
        //        //object ListData = _routine.();
        //        return Ok(obj);
        //    }
        //    catch (Exception ex)
        //    {
        //        CommonFunction.setLog("Error on UserAdmin GetSqlQueryData Error: " + ex.Message);
        //        return BadRequest(ex.Message);
        //    }
        //    finally
        //    {
        //        CommonFunction.setLog("GetSqlQueryData function stopped successfully.");
        //    }
        //}

        //[HttpPost]
        //[Route("GetSqlQueryDataWithParameter")]
        //public IActionResult GetSqlQueryDataWithParameter(SqlDataParmerter QueryData)
        //{
        //    try
        //    {
        //        CommonFunction.setLog("=====================================================");
        //        CommonFunction.setLog("GetSqlQueryDataWithParameter Process started");
        //        UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
        //        object obj = _adminrtn.CallSqlQueryDataMethodWithParameter(QueryData);
        //        //object ListData = _routine.();
        //        return Ok(obj);
        //    }
        //    catch (Exception ex)
        //    {
        //        CommonFunction.setLog("Error on UserAdmin GetSqlQueryDataWithParameter Error: " + ex.Message);
        //        return BadRequest(ex.Message);
        //    }
        //    finally
        //    {
        //        CommonFunction.setLog("GetSqlQueryDataWithParameter function stopped successfully.");
        //    }
        //}

        [HttpPost]
        [Route("UserLogIn")]
        public IActionResult UserLogIn(UserDetails QueryData)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UserLogIn Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContext,_dbContextLogistics);
                object obj = _adminrtn.CallLoginInByCredentials(QueryData);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UserAdmin UserLogIn Error: " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UserLogIn function stopped successfully.");
            }
        }
        [HttpPost]
        [Route("UserLogInByMicrosoft")]
        public IActionResult UserLogInByMicrosoft(MicrosoftUserModal QueryData)
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UserLogInByMicrosoft Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
                object obj = _adminrtn.CallLoginInBymicrosoft(QueryData);
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UserAdmin UserLogInByMicrosoft Error: " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UserLogInByMicrosoft function stopped successfully.");
            }
        }

        [HttpPost]
        [Route("GetAllCompanies")]
        public IActionResult GetAllCompanies(int accessuserid)
        {

            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetAllCompanies Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (accessuserid > 0 )
                {
                    model = _adminrtn.CallGetAllCompanies(accessuserid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetAllCompanies Error: " + ex.Message);

            }

            return Ok(model);
        }

        [HttpGet]
        [Route("GetAllModuleDetails")]
        public IActionResult GetAllModuleDetails()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UserLogIn Process started");
                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
                object obj = _adminrtn.CallGetAllModule();
                //object ListData = _routine.();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UserAdmin GetAllModuleDetails Error: " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("UserLogIn function stopped successfully.");
            }
        }
        #region User Admin Module

        [HttpPost]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers(int Userid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetAllUsers Process started");
               
                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
                if (Userid > 0)
                {
                    model = _adminrtn.CallGetV_UserList(Userid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false ;
                }

                
            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetAllModuleDetails Error: " + ex.Message);
                
            }
            
            return Ok(model);
        }

        [HttpPost]
        [Route("GetAllCompanyList")]
        public IActionResult GetAllCompanyList(int userId)
        {
            adminresponseMessage adminResponse = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetAllCompaniesList Process started");
                UserAdminClass UserAdmin = new UserAdminClass(_dbContext, _dbContextLogistics);
                if (userId > 0)
                {
                    adminResponse = UserAdmin.CallGetCompanyList(userId);
                }
                else
                {
                    adminResponse.status = "FAIL";
                    adminResponse.message = "Oops something went wrong! Please contact Support!";
                    adminResponse.isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                adminResponse.status = "FAIL";
                adminResponse.message = "Oops something went wrong! Please contact Support!";
                adminResponse.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetAllCompanyList Error: " + ex.Message);
            }
            return Ok(adminResponse);
        }

        [HttpPost]
        [Route("CreateOrUpdateUserDetails")]
        public IActionResult CreateOrUpdateUserDetails(CreateUpdateUserModal UserDetails)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("CreateOrUpdateUserDetails Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (UserDetails!=null&&UserDetails!=null)
                {
                    model = _adminrtn.CallCreateOrUpdateUser(UserDetails);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin CreateOrUpdateUserDetails Error: " + ex.Message);

            }

            return Ok(model);
        }

        [HttpPost]
        [Route("GetUserDetails")]
        public IActionResult GetUserDetails(int accessUserid,int foruserid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetUserDetails Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (accessUserid>0 && foruserid>0)
                {
                    model = _adminrtn.CallGetUserDetails(accessUserid,foruserid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetAllModuleDetails Error: " + ex.Message);

            }

            return Ok(model);
        }

        [HttpGet]
        [Route("GetAllRoles")]
        public IActionResult GetAllRoles()
        {
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetUserDetails Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);
                object obj = _adminrtn.CallGetRoles();
                return Ok(obj);
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on UserAdmin GetAllRoles Error: " + ex.Message);
                return BadRequest(ex.Message);
            }
            finally
            {
                CommonFunction.setLog("GetAllRoles function stopped successfully.");
            }

        }

        [HttpGet]
        [Route("GetAllSMAddress")]
        public IActionResult GetAllSMAddress(int accessuserid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetAllSMAddress Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext, _dbContextLogistics);
                
                if (accessuserid > 0)
                {
                    model = _adminrtn.CallGetAllSMAddress(accessuserid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }
               
            }
            catch(Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetAllSMAddress Error: " + ex.Message);

            }
            return Ok(model);
          
        }

        [HttpPost]
        [Route("UpdateCompanyDetails")]
        public IActionResult UpdateCompanyDetails(CompanyUpdateModal modal)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateCompanyDetails Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext, _dbContextLogistics);
                if (modal != null && modal.accessuserid > 0&&modal.companydetails!=null&&modal.companydetails.companyid>0)
                {
                    model = _adminrtn.CallUpdateCompanyDetails(modal);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin UpdateCompanyDetails Error: " + ex.Message);

            }
            return Ok(model);
        }

        [HttpPost]
        [Route("CreateNewCompany")]
        public IActionResult CreateNewCompany(LES_COMPANY_UPDATE modal,int accessuserid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("CreateNewCompany Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext, _dbContextLogistics);
                if (modal != null )
                {
                    model = _adminrtn.CallCreateCompanyDetails(modal, accessuserid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin CreateNewCompany Error: " + ex.Message);

            }
            return Ok(model);
        }

        [HttpGet]
        [Route("GetSMaddressDetails")]
        public IActionResult GetSMaddressDetails(int accessuserid,int addressid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetSMaddressDetails Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext, _dbContextLogistics);

                if (accessuserid >0 && addressid>0)
                {
                    model = _adminrtn.CallGetSmAddressDetails(accessuserid, addressid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetSMaddressDetails Error: " + ex.Message);

            }
            return Ok(model);
        }

        [HttpPost]
        [Route("AddCompanyLink")]
        public IActionResult AddCompanyLink(int companyId,int foruserid,int UsertypeId, int accessUserid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("AddCompanyLink Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (accessUserid > 0 && foruserid >0&& companyId > 0&& UsertypeId>0)
                {
                    model = _adminrtn.CallAddCompanyLink(companyId, foruserid, UsertypeId, accessUserid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin AddCompanyLink Error: " + ex.Message);

            }
            return Ok(model);
        }
        
        [HttpPost]
        [Route("RemoveUserCompanyLink")]
        public IActionResult RemoveUserCompanyLink(int accessuserid,int companyid,int foruserid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("RemoveUserCompanyLink Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (accessuserid > 0 && foruserid > 0 && companyid > 0 )
                {
                    model = _adminrtn.CallRemoveCompanyLink(companyid ,foruserid, accessuserid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin RemoveUserCompanyLink Error: " + ex.Message);

            }
            return Ok(model);
        }
        
        [HttpGet]
        [Route("GetUserTypeModuleAccess")]
        public IActionResult GetUserTypeModuleAccess(int accessuserid,int usertypeid)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("GetUserTypeModuleAccess Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (accessuserid > 0 && usertypeid > 0)
                {
                    model = _adminrtn.CallGetUsertypeModuleAccess(accessuserid, usertypeid);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin GetUserTypeModuleAccess Error: " + ex.Message);

            }
            return Ok(model);
        }

        [HttpPost]
        [Route("UpdateUserTypeAccessLevelDetails")]
        public IActionResult UpdateUserTypeAccessLevelDetails(int accessuserid,int usertypeid,string Options)
        {
            adminresponseMessage model = new();
            try
            {
                CommonFunction.setLog("=====================================================");
                CommonFunction.setLog("UpdateUserTypeAccessLevelDetails Process started");

                UserAdminClass _adminrtn = new UserAdminClass(_dbContext);

                if (accessuserid > 0 && usertypeid > 0&& Options!=null&& Options.Length>0)
                {
                    model = _adminrtn.CallUpdateUserTypeDetails(accessuserid, usertypeid,Options);
                }
                else
                {
                    model.status = "FAIL";
                    model.message = "Oops something went wrong! Please contact Support!";
                    model.isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                model.status = "FAIL";
                model.message = "Oops something went wrong! Please contact Support!";
                model.isSuccess = false;
                CommonFunction.setLog("Error on UserAdmin UpdateUserTypeAccessLevelDetails Error: " + ex.Message);

            }
            return Ok(model);
        }

        #endregion User Admin Module 
    }

    public class SqlDataParmerter
    {
        public string SqlQuery { get; set; }
        public List<string> Parmerter { get; set; }
    }

    public class UserDetails
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class UserAdminClass : LES_USER_ADMINISTRATION_LIB.UserAdminRoutine
    {
        private readonly UserAdminDbContext _dbContext;

        public UserAdminRoutine _routine { get; set; }
        public UserAdminClass(UserAdminDbContext dbContext) : base(dbContext)
        {

        }

        public UserAdminClass(UserAdminDbContext dbContext, LogisticDbContext dbContextLogistics) : base(dbContext, dbContextLogistics)
        {

        }

        public object CallProtedtedMethod()
        {
            return GetAllApplication();
        }

        //public object CallSqlQueryDataMethod(string Querydata)
        //{
        //    return GetQueryData(Querydata);
        //}

        //public object CallSqlQueryDataMethodWithParameter(SqlDataParmerter Querydata)
        //{
        //    return GetSqlQueryDataParamerters(Querydata.SqlQuery, Querydata.Parmerter);
        //}

        public object CallLoginInByCredentials(UserDetails Querydata)
        {
            return LoginInByCredentials(Querydata.username, Querydata.password);
        }
        public object CallLoginInBymicrosoft(MicrosoftUserModal modal)
        {
            return LoginByMicrosoftEmail(modal);
        }

        public object CallSmExternalUsersByEmail(string Emailid)
        {
            return GetSmExternalUsersByEmail(Emailid);
        }

        public object CallGetusercompanylinkByUserId(int companyid, int userid)
        {
            return GetusercompanylinkByUserId(companyid, userid);
        }

        public object CallGetusercompanylinkByCompanyid(int companyid)
        {
            return GetusercompanylinkByCompanyid(companyid);
        }

        public object CallDefaultVesselusercompanylinkByCompanyid(int companyid)
        {
            return GetDefaultVesselusercompanylinkByCompanyid(companyid);
        }


        public object CallGetUsertypeModuleAccessByusertypeId(int usertypid)
        {
            return GetUsertypeModuleAccessByusertypeId(usertypid);
        }

        public object CallGetVApplicationModuleAccessBycompanyandUsertypeid(int companyid, int usertypeid)
        {
            return GetVApplicationModuleAccessBycompanyandUsertypeid(companyid, usertypeid);
        }

        public object CallGetVCompanyDetailsByUserId(int userid)
        {
            return GetVCompanyDetailsByUserId(userid);
        }

        public object CallGetVCompanyDetailsByIds(int companyid, int userid)
        {
            return GetVCompanyDetailsByIds(companyid, userid);
        }

        public object CallGetAllModule()
        {
            return GetAllModule();
        }

        public object CallGetRoles()
        {
            return GetRoles();
        }
        public object CallGetVApplicationModuleAccessBycompanyandUsertypeidandUserid(int companyid, int userTypeid, int userid)
        {
            return GetVApplicationModuleAccessBycompanyandUsertypeidandUserid(companyid, userTypeid, userid);
        }
        public object CallGetVApplicationModuleAccessBycompanyandUsertypeidandUseridForEpod(int companyid, int userTypeid, int userid)
        {
            return GetVApplicationModuleAccessBycompanyandUsertypeidandUseridForEpod(companyid, userTypeid, userid);
        }
        public object CallGetDefaultVApplicationModuleAccessBycompanyandUsertypeidandUseridForEpod(int companyid, int userTypeid)
        {
            return GetDefaultVApplicationModuleAccessForEpod(companyid, userTypeid);
        }
        public object CallGetVApplicationModuleAccessBycompanyandUseridForEpod(int companyid, int userid)
        {
            return GetVApplicationModuleAccessBycompanyandUseridForEpod(companyid, userid);
        }

        public adminresponseMessage CallGetCompanyList(int userId)
        {
            return AllCompanyList(userId);
        }
        public LES_COMPANY CallGetCompanyByAddressID(int addressid)
        {
            return GetCompanyByAddressID(addressid);

        }
        #region User Admin
        public adminresponseMessage CallGetV_UserList(int userid)
        {
            return GetUsersList(userid);
        }
        public adminresponseMessage CallCreateOrUpdateUser(CreateUpdateUserModal ModalData)
        {
            return CreateOrUpdateUser(ModalData);
        }
        public adminresponseMessage CallGetUserDetails(int accessuserid, int foruserid)
        {
            return GetUserDetails(accessuserid, foruserid);
        }
        public adminresponseMessage CallGetAllCompanies(int accessuserid)
        {
            return GetAllCompanies(accessuserid);
        }
        public adminresponseMessage CallGetAllSMAddress(int accessuserid)
        {
            return GetAllSmAddresses(accessuserid);
        }
        public adminresponseMessage CallGetSmAddressDetails(int accessuserid, int Addressid)
        {
            return GetSMAddressDetails(accessuserid, Addressid);
        }
        public adminresponseMessage CallUpdateCompanyDetails(CompanyUpdateModal modal)
        {
            return UpdateCompanyDetails(modal);
        }
        public adminresponseMessage CallCreateCompanyDetails(LES_COMPANY_UPDATE modal, int Accessuserid)
        {
            return CreateNewCompanyDetails(modal, Accessuserid);
        }
        public adminresponseMessage CallAddCompanyLink(int companyid,int ForuserId,int UsertypeId, int Accessuserid)
        {
            return AddCompanyUserLink(companyid, ForuserId, UsertypeId, Accessuserid);
        }
        public adminresponseMessage CallRemoveCompanyLink(int companyid,int ForuserId,int accessuserid )
        {
            return RemoveCompanyUserLink(companyid, ForuserId, accessuserid);
        }
        public adminresponseMessage CallGetUsertypeModuleAccess(int accessuserid,int UsertypeId)
        {
            return GetUserTypeModuleAccess(accessuserid, UsertypeId);
        }
        public adminresponseMessage CallUpdateUserTypeDetails(int accessuserid,int UsertypeId,string Options)
        {
            return UpdateUserAccessRights(accessuserid, UsertypeId, Options);
        }
        #endregion User Admin
    }


}
