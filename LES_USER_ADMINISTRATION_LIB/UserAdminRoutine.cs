
using Microsoft.EntityFrameworkCore;
using System;
using LES_USER_ADMINISTRATION_LIB.DAL;
using LES_USER_ADMINISTRATION_LIB.Model;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using System.Data;
using Newtonsoft.Json;
using LeSDataMain;
using Microsoft.AspNetCore.Http;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.Design;
using System.Security.Authentication.ExtendedProtection;
using System.Text.RegularExpressions;
using Logistic_Management_Lib.DAL;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.Extensions.Options;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static LeSEncryptionHelper.LeSEncryption;
using LeSEncryptionHelper;


namespace LES_USER_ADMINISTRATION_LIB
{
    public class UserAdminRoutine
    {
        private readonly UserAdminDbContext _dbContext;
        private readonly LogisticDbContext _dbContextLogistics;
        public string ModuleName { get; set; }
        public UserAdminRoutine(UserAdminDbContext dbContext)
        {
            _dbContext = dbContext;
            
            var configBuilder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            UserAdminDbContext.configuration = configBuilder.Build();
            ModuleName = UserAdminDbContext.configuration.GetSection("AppSettings").GetSection("ADMIN_MODULE").Value;
        }
        public UserAdminRoutine(UserAdminDbContext dbContext, LogisticDbContext dbContextLogistics)
        {
            
            _dbContext = dbContext;
            _dbContextLogistics = dbContextLogistics;
            var configBuilder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
            UserAdminDbContext.configuration = configBuilder.Build();
            ModuleName = UserAdminDbContext.configuration.GetSection("AppSettings").GetSection("ADMIN_MODULE").Value;
        }

        #region LES_APPLICATIONS
        protected object GetAllApplication()
        {
            //object data = _dbContext.Set<LES_COMPANY_DETAILS>().FromSqlRaw("select COMPANYID,COMPANY_CODE,COMPANY_DESCRIPTION from LES_COMPANY").ToList();
            return _dbContext.les_applications.ToList();
            //return data;
        }

        protected LES_APPLICATIONS GetApplicationById(int ApplicationId)
        {
            LES_APPLICATIONS Application = _dbContext.les_applications.FirstOrDefault(x => x.applicationid == ApplicationId);
            return Application;
        }

        protected int AddApplication(LES_APPLICATIONS Application)
        {
            _dbContext.les_applications.Add(Application);
            return _dbContext.SaveChanges();
        }

        protected int UpdateApplication(LES_APPLICATIONS Application)
        {
            _dbContext.Entry(Application).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteApplication(int ApplicationId)
        {
            LES_APPLICATIONS Application = _dbContext.les_applications.FirstOrDefault(x => x.applicationid == ApplicationId);
            _dbContext.les_applications.Remove(Application);
            return _dbContext.SaveChanges();
        }
        #endregion

        #region LES_COMPANY
        protected List<LES_COMPANY> GetAllCompany()
        {
            return _dbContext.les_company.ToList();
        }

        protected LES_COMPANY GetcompanyById(int companyId)
        {
            LES_COMPANY company = _dbContext.les_company.FirstOrDefault(x => x.companyid == companyId);
            return company;
        }

        protected List<V_COMPANY_DETAILS_DATA> GetusercompanylinkByCompanyid(int companyid)
        {
            List<V_COMPANY_DETAILS_DATA> lstcompanyDetails = _dbContext.v_company_details.Where(x => x.CompanyId == companyid).Select(x => new V_COMPANY_DETAILS_DATA
            {
                User_Company_Link_Id = convert.ToInt(x.User_Company_Link_Id),
                CompanyId = x.CompanyId,
                Company_Code = x.Company_Code,
                Company_Description = x.Company_Description,
                //LogoPath = x.LogoPath,
                //min_LogoPath = x.min_LogoPath,
                AddressId = x.AddressId,
                Ex_UserId = x.Ex_UserId,
                UserTypeId = x.UserTypeId,
                Usertypedescr = x.Usertypedescr,
                mail_notification = x.mail_notification,

                base64Logo = Base64DataObject(x.LogoPath),
                base64LogoName = Path.GetFileName(x.LogoPath),
                base64LogoType = GetMimeType(Path.GetExtension(x.LogoPath)),

                base64minLogo = Base64DataObject(x.min_LogoPath),
                base64minLogoName = Path.GetFileName(x.min_LogoPath),
                base64minLogoType = GetMimeType(Path.GetExtension(x.min_LogoPath)),

                base64printLogo = Base64DataObject(x.print_logo_path),
                base64printLogoName = Path.GetFileName(x.print_logo_path),
                base64printLogoType = GetMimeType(Path.GetExtension(x.print_logo_path)),

                ex_emailid = x.ex_emailid, //Updated by sayak 11.07.2024

            }).ToList();
            return lstcompanyDetails;
        }
        protected List<V_COMPANY_DETAILS_DATA> GetDefaultVesselusercompanylinkByCompanyid(int companyid)
        {
            List<V_COMPANY_DETAILS_DATA> lstcompanyDetails = _dbContext.v_company_details.Where(x => x.CompanyId == companyid && x.UserTypeId == 10).Select(x => new V_COMPANY_DETAILS_DATA
            {
                // x.UserTypeId ==10 == Vessel User
                User_Company_Link_Id = convert.ToInt(x.User_Company_Link_Id),
                CompanyId = x.CompanyId,
                Company_Code = x.Company_Code,
                Company_Description = x.Company_Description,
                //LogoPath = x.LogoPath,
                //min_LogoPath = x.min_LogoPath,
                AddressId = x.AddressId,
                Ex_UserId = x.Ex_UserId,
                UserTypeId = x.UserTypeId,
                Usertypedescr = x.Usertypedescr,

                base64Logo = Base64DataObject(x.LogoPath),
                base64LogoName = Path.GetFileName(x.LogoPath),
                base64LogoType = GetMimeType(Path.GetExtension(x.LogoPath)),

                base64minLogo = Base64DataObject(x.min_LogoPath),
                base64minLogoName = Path.GetFileName(x.min_LogoPath),
                base64minLogoType = GetMimeType(Path.GetExtension(x.min_LogoPath)),

                base64printLogo = Base64DataObject(x.print_logo_path),
                base64printLogoName = Path.GetFileName(x.print_logo_path),
                base64printLogoType = GetMimeType(Path.GetExtension(x.print_logo_path)),

                ex_emailid = x.ex_emailid, //Updated by sayak 11.07.2024
                poweredby_flag = x.poweredby_flag,

            }).ToList();
            return lstcompanyDetails;
        }
        protected List<V_COMPANY_DETAILS_DATA> GetusercompanylinkByUserId(int companyid, int userid)
        {
            List<V_COMPANY_DETAILS_DATA> lstcompanylink = _dbContext.v_company_details.Where(x => x.CompanyId == companyid && x.Ex_UserId == userid).Select(x => new V_COMPANY_DETAILS_DATA
            {
                User_Company_Link_Id = convert.ToInt(x.User_Company_Link_Id),
                CompanyId = x.CompanyId,
                Company_Code = x.Company_Code,
                Company_Description = x.Company_Description,
                //LogoPath = x.LogoPath,
                //min_LogoPath = x.min_LogoPath,
                AddressId = x.AddressId,
                Ex_UserId = x.Ex_UserId,
                UserTypeId = x.UserTypeId,
                Usertypedescr = x.Usertypedescr,
                base64Logo = Base64DataObject(x.LogoPath),
                base64LogoName = convert.ToString(Path.GetFileName(x.LogoPath)),
                base64LogoType = GetMimeType(Path.GetExtension(x.LogoPath)),

                base64minLogo = Base64DataObject(x.min_LogoPath),
                base64minLogoName = convert.ToString(Path.GetFileName(x.min_LogoPath)),
                base64minLogoType = GetMimeType(Path.GetExtension(x.min_LogoPath)),

                base64printLogo = Base64DataObject(x.print_logo_path),
                base64printLogoName = Path.GetFileName(x.print_logo_path),
                base64printLogoType = GetMimeType(Path.GetExtension(x.print_logo_path)),

                ex_emailid = x.ex_emailid,  //Updated by sayak 11.07.2024
                poweredby_flag = x.poweredby_flag

            }).ToList();
            return lstcompanylink;
        }

        protected LES_COMPANY GetCompanyByAddressID(int AddressID)
        {
            LES_COMPANY company = _dbContext.les_company.FirstOrDefault(x => x.addressid == AddressID);
            return company;
        }

        protected int Addcompany(LES_COMPANY company)
        {
            company.updated_date = DateTime.Now;
            company.created_date = DateTime.Now;
            _dbContext.les_company.Add(company);
            return _dbContext.SaveChanges();
        }

        protected int Updatecompany(LES_COMPANY company)
        {
            company.updated_date = DateTime.Now;
            _dbContext.Entry(company).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteCompany(int companyId)
        {
            LES_COMPANY company = _dbContext.les_company.FirstOrDefault(x => x.companyid == companyId);
            _dbContext.les_company.Remove(company);
            return _dbContext.SaveChanges();
        }
        #endregion

        #region LES_MODULE
        protected List<LES_MODULE> GetAllModule()
        {
            return _dbContext.les_module.ToList();
        }

        protected List<LES_USERTYPE> GetRoles()
        {
            return _dbContext.les_usertype.ToList();
        }

        protected LES_MODULE GetModuleById(int moduleId)
        {
            LES_MODULE module = _dbContext.les_module.FirstOrDefault(x => x.moduleid == moduleId);
            return module;
        }

        protected int AddModule(LES_MODULE module)
        {

            _dbContext.les_module.Add(module);
            return _dbContext.SaveChanges();
        }

        protected int UpdateModule(LES_MODULE module)
        {

            _dbContext.Entry(module).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteModule(int moduleId)
        {
            LES_MODULE module = _dbContext.les_module.FirstOrDefault(x => x.moduleid == moduleId);
            _dbContext.les_module.Remove(module);
            return _dbContext.SaveChanges();
        }
        #endregion

        #region LES_USER_COMPANY_LINK
        protected List<LES_USER_COMPANY_LINK> GetAllUserCompanyLink()
        {
            return _dbContext.les_user_company_link.ToList();
        }

        protected LES_USER_COMPANY_LINK GetUserCompanyLinkById(int id)
        {
            LES_USER_COMPANY_LINK obj = _dbContext.les_user_company_link.FirstOrDefault(x => x.user_company_link_id == id);
            return obj;
        }

        protected List<LES_USER_COMPANY_LINK> GetUserCompanyLinkBycompanyid(int id)
        {
            List<LES_USER_COMPANY_LINK> obj = _dbContext.les_user_company_link.Where(x => x.companyid == id).ToList();
            return obj;
        }

        protected int AddUserCompanyLink(LES_USER_COMPANY_LINK obj)
        {

            _dbContext.les_user_company_link.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateUserCompanyLink(LES_USER_COMPANY_LINK obj)
        {
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteUserCompanyLink(int id)
        {
            LES_USER_COMPANY_LINK module = _dbContext.les_user_company_link.FirstOrDefault(x => x.user_company_link_id == id);
            _dbContext.les_user_company_link.Remove(module);
            return _dbContext.SaveChanges();
        }
        #endregion

        #region LES_USERTYPE
        protected List<LES_USERTYPE> GetAllUserType()
        {
            return _dbContext.les_usertype.ToList();
        }

        protected LES_USERTYPE GetUserTypeById(int id)
        {
            LES_USERTYPE obj = _dbContext.les_usertype.FirstOrDefault(x => x.usertypeid == id);
            return obj;
        }

        protected int AddUserCompanyLink(LES_USERTYPE obj)
        {
            _dbContext.les_usertype.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateUserCompanyLink(LES_USERTYPE obj)
        {
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteUserType(int id)
        {
            LES_USERTYPE module = _dbContext.les_usertype.FirstOrDefault(x => x.usertypeid == id);
            _dbContext.les_usertype.Remove(module);
            return _dbContext.SaveChanges();
        }



        #endregion

        #region LES_USERTYPE_MODULE_ACCESS
        protected List<LES_USERTYPE_MODULE_ACCESS> GetAll_Usertype_Module_Access()
        {
            return _dbContext.les_usertype_module_access.ToList();
        }

        protected LES_USERTYPE_MODULE_ACCESS GetUsertypeModuleAccessById(int id)
        {
            LES_USERTYPE_MODULE_ACCESS obj = _dbContext.les_usertype_module_access.FirstOrDefault(x => x.moduleaccessid == id);
            return obj;
        }

        protected List<LES_USERTYPE_MODULE_ACCESS> GetUsertypeModuleAccessByusertypeId(int usertypeid)
        {
            List<LES_USERTYPE_MODULE_ACCESS> obj = _dbContext.les_usertype_module_access.Where(x => x.usertypeid == usertypeid).ToList();
            return obj;
        }

        protected int AddUsertypeModuleAccess(LES_USERTYPE_MODULE_ACCESS obj)
        {
            _dbContext.les_usertype_module_access.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateUsertypeModuleAccess(LES_USERTYPE_MODULE_ACCESS obj)
        {
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteUsertypeModuleAccess(int id)
        {
            LES_USERTYPE_MODULE_ACCESS module = _dbContext.les_usertype_module_access.FirstOrDefault(x => x.moduleaccessid == id);
            _dbContext.les_usertype_module_access.Remove(module);
            return _dbContext.SaveChanges();
        }



        #endregion

        #region SM_EXTERNAL_USERS
        protected List<SM_EXTERNAL_USERS> GetAllSmExternalUsers()
        {
            return _dbContext.sm_external_users.ToList();
        }

        protected SM_EXTERNAL_USERS GetSmExternalUsersById(int id)
        {
            SM_EXTERNAL_USERS obj = _dbContext.sm_external_users.FirstOrDefault(x => x.ex_userid == id);
            return obj;
        }

        protected SM_EXTERNAL_USERS GetSmExternalUsersByEmail(string id)
        {
            SM_EXTERNAL_USERS obj = _dbContext.sm_external_users.FirstOrDefault(x => x.ex_emailid == id);
            return obj;
        }

        protected int AddSmExternalUsers(SM_EXTERNAL_USERS obj)
        {
            _dbContext.sm_external_users.Add(obj);
            return _dbContext.SaveChanges();
        }

        protected int UpdateSmExternalUsers(SM_EXTERNAL_USERS obj)
        {
            _dbContext.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return _dbContext.SaveChanges();
        }

        protected int DeleteSmExternalUsers(int id)
        {
            SM_EXTERNAL_USERS module = _dbContext.sm_external_users.FirstOrDefault(x => x.ex_userid == id);
            _dbContext.sm_external_users.Remove(module);
            return _dbContext.SaveChanges();
        }



        #endregion

        #region V_APPLICATION_MODULE_ACCESS
        protected List<V_APPLICATION_MODULE_ACCESS> GetAllVApplicationModuleAccess()
        {
            return _dbContext.v_application_module_access.ToList();
        }

        protected V_APPLICATION_MODULE_ACCESS GetVApplicationModuleAccessById(int id)
        {
            V_APPLICATION_MODULE_ACCESS obj = _dbContext.v_application_module_access.FirstOrDefault(x => x.ModuleAccessId == id);
            return obj;
        }

        protected List<V_APPLICATION_MODULE_ACCESS> GetVApplicationModuleAccessByModuleid(int moduleid)
        {
            List<V_APPLICATION_MODULE_ACCESS> obj = _dbContext.v_application_module_access.Where(x => x.ModuleId == moduleid).ToList();
            return obj;
        }

        protected List<V_APPLICATION_MODULE_ACCESS> GetVApplicationModuleAccessByUsertypeid(int Usertypeid)
        {
            List<V_APPLICATION_MODULE_ACCESS> obj = _dbContext.v_application_module_access.Where(x => x.UserTypeId == Usertypeid).ToList();
            return obj;
        }

        protected List<V_APPLICATION_MODULE_ACCESS> GetVApplicationModuleAccessBycompanyandUsertypeid(int companyid, int Usertypeid)
        {
            List<V_APPLICATION_MODULE_ACCESS> obj = _dbContext.v_application_module_access.Where(x => x.CompanyId == companyid && x.UserTypeId == Usertypeid).ToList();
            return obj;
        }

        protected List<V_APPLICATION_MODULE_ACCESS> GetVApplicationModuleAccessBycompanyandUsertypeidandUserid(int companyid, int Usertypeid, int Userid)
        {
            List<V_APPLICATION_MODULE_ACCESS> obj = _dbContext.v_application_module_access.Where(x => x.CompanyId == companyid && x.UserTypeId == Usertypeid && x.Ex_UserId == Userid).ToList();
            return obj;
        }
        protected List<V_APPLICATION_MODULE_ACCESS> GetVApplicationModuleAccessBycompanyandUsertypeidandUseridForEpod(int companyid, int Usertypeid, int Userid)
        {
            List<V_APPLICATION_MODULE_ACCESS> obj = _dbContext.v_application_module_access.Where(x => x.CompanyId == companyid && x.UserTypeId == Usertypeid && x.Ex_UserId == Userid && x.ModuleId == 3).ToList();
            return obj;
        }
        protected V_APPLICATION_MODULE_ACCESS GetDefaultVApplicationModuleAccessForEpod(int companyid, int Usertypeid)
        {
            V_APPLICATION_MODULE_ACCESS obj = _dbContext.v_application_module_access.Where(x => x.CompanyId == companyid && x.UserTypeId == Usertypeid && x.ModuleId == 3).FirstOrDefault();
            return obj;
        }

        protected List<V_APPLICATION_MODULE_ACCESS> GetVApplicationModuleAccessBycompanyandUseridForEpod(int companyid, int Userid)
        {
            List<V_APPLICATION_MODULE_ACCESS> obj = _dbContext.v_application_module_access.Where(x => x.CompanyId == companyid && x.Ex_UserId == Userid && x.ModuleId == 3).ToList();
            return obj;
        }

        #endregion

        #region V_COMPANY_DETAILS
        protected List<V_COMPANY_DETAILS> GetAllVCompanyDetails()
        {
            return _dbContext.v_company_details.ToList();
        }

        protected V_COMPANY_DETAILS GetVCompanyDetailsById(int id)
        {
            V_COMPANY_DETAILS obj = _dbContext.v_company_details.FirstOrDefault(x => x.CompanyId == id);
            return obj;
        }

        protected List<V_COMPANY_DETAILS> GetVCompanyDetailsByUserId(int userid)
        {
            List<V_COMPANY_DETAILS> obj = _dbContext.v_company_details.Where(x => x.Ex_UserId == userid).ToList();
            return obj;
        }

        protected List<V_COMPANY_DETAILS> GetVCompanyDetailsByIds(int companyid, int userid)
        {
            List<V_COMPANY_DETAILS> obj = _dbContext.v_company_details.Where(x => x.CompanyId == companyid && x.Ex_UserId == userid).ToList();
            return obj;
        }



        #endregion

        #region User Admin
        //User list -->
        protected adminresponseMessage GetUsersList(int UserId)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(UserId, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    var UserData = _dbContext.v_user_list.ToList();
                    if (UserData != null && UserData.Count > 0)
                    {
                        _response.data = UserData;

                    }
                    else
                    {
                        _response.status = "FAIL";
                        _response.isSuccess = false;
                        _response.message = "Oops,no users found! please contact to support for assistace!";
                    }
                }

            }
            catch (Exception ex)
            {
                setlog("Error in GetUsersList - " + ex.Message);
                setlog("Error Stack in GetUsersList - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage checkAccessForModule(int UserId, int ModuleId, int AccessLevel)
        {


            adminresponseMessage _response = new adminresponseMessage();
            try
            {

                SM_EXTERNAL_USERS objUser = _dbContext.sm_external_users.Where(u => u.ex_userid == UserId).FirstOrDefault();
                if (objUser != null)
                {
                    if (objUser.isactive == 1)
                    {
                        List<V_APPLICATION_MODULE_ACCESS> slUserAccess = null;
                        slUserAccess = (from s in _dbContext.v_application_module_access.ToList()
                                        where s.Ex_UserId == UserId && s.ApplicationId == 1
                                        select s)
                                       .ToList();
                        if (slUserAccess != null)
                        {
                            var Access = slUserAccess.Any(x => x.Access_Level >= AccessLevel && x.Ex_UserId == UserId && x.ModuleId == ModuleId);
                            if (Access)
                            {

                                _response.status = "SUCCESS";
                                _response.isSuccess = true;
                                _response.message = "Access Granted !";
                            }
                            else
                            {
                                throw new Exception("It looks like you do not have valid permission. Please check your permissions or contact support for assistance.");

                            }
                        }
                        else
                        {
                            throw new Exception("You do not have access to proceed. Please verify your permissions or contact support for assistance.");
                        }
                    }
                    else
                    {
                        throw new Exception("It seems you're not currently active. Please check your account status or contact support for help.");

                    }
                }
                else
                {
                    throw new Exception("Sorry, it looks like you're not a recognized user");
                }

            }
            catch (Exception ex)
            {
                setlog("Error in Content - " + ex.Message);

                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;

            }

            return _response;
        }

        //Create and update User -->
        private adminresponseMessage ValidateNewUser(CreateUpdateUserModal Modal)
        {
            adminresponseMessage Model = new();
            Model.isSuccess = true;
            try
            {

                if (Modal == null)
                {
                    throw new Exception("It's not you, it's us. Something went wrong on our side. Please try again later.");
                }
                else
                {
                    if (Modal.userdetails != null)
                    {
                        if (Modal.IsNewUser == 1)
                        {
                            Modal.userdetails.ex_userid = 0;
                        }
                        else
                        {
                            if (Modal.IsNewUser == 0)//Update user validation
                            {
                                throw new Exception("It's not you, it's us. Something went wrong on our side.");

                            }
                        }
                        if (string.IsNullOrEmpty(Modal.userdetails.ex_usercode) || string.IsNullOrWhiteSpace(Modal.userdetails.ex_usercode))
                        {
                            throw new Exception("Please enter valid Username!");
                        }
                        var NotUniqueCode = _dbContext.sm_external_users.Any(X => (X.ex_usercode == Modal.userdetails.ex_usercode && X.ex_userid != Modal.userdetails.ex_userid));
                        if (NotUniqueCode)
                        {
                            throw new Exception("Oops! That username is taken. Try another one!");
                        }
                        if (string.IsNullOrEmpty(Modal.userdetails.ex_username) || string.IsNullOrWhiteSpace(Modal.userdetails.ex_username))
                        {
                            throw new Exception("Please enter valid Name!");
                        }
                        if (string.IsNullOrEmpty(Modal.userdetails.ex_emailid) || string.IsNullOrWhiteSpace(Modal.userdetails.ex_emailid) || !IsValidEmail(Modal.userdetails.ex_emailid))
                        {
                            throw new Exception("Please enter valid Email!");
                        }
                        if (!string.IsNullOrEmpty(Modal.userdetails.companyid) && !string.IsNullOrWhiteSpace(Modal.userdetails.companyid))
                        {
                            int companyId = convert.ToInt(Modal.userdetails.companyid);
                            if (companyId > 0) { }
                            else
                            {
                                throw new Exception("Please select a valid company to continue!");
                            }
                        }
                        else
                        {
                            throw new Exception("Please select a company to continue!");
                        }
                        if (Modal.userdetails.usertype == null || Modal.userdetails.usertype < 1)
                        {
                            throw new Exception("Please select User role!");
                        }
                        if (Modal.password == null || Modal.password.Length == 0 || string.IsNullOrEmpty(Modal.password) || string.IsNullOrWhiteSpace(Modal.password))
                        {
                            throw new Exception("Please enter a valid password!");
                        }
                        if (Modal.confirmpassword == null || Modal.confirmpassword.Length == 0 || string.IsNullOrEmpty(Modal.confirmpassword) || string.IsNullOrWhiteSpace(Modal.confirmpassword))
                        {
                            throw new Exception("Please enter a valid confirm password!");
                        }
                        else
                        {
                            if (Modal.password != Modal.confirmpassword)
                            {
                                throw new Exception("Oops! Your password and confirm password don't match. Let's give it another shot!");
                            }
                        }

                        Model.data = Modal;
                    }
                    else
                    {
                        throw new Exception("Uh-oh! Something went wrong. Please contact support for assistance!");
                    }



                }
            }
            catch (Exception ex)
            {

                Model.status = "fail";
                Model.isSuccess = false;
                Model.message = ex.Message;

            }


            return Model;
        }
        private adminresponseMessage ValidateUpdateUser(CreateUpdateUserModal Modal)
        {
            adminresponseMessage Model = new();
            Model.isSuccess = true;
            try
            {
                if (Modal == null)
                {
                    throw new Exception("It's not you, it's us. Something went wrong on our side. Please try again later.");
                }
                else
                {
                    if (Modal.userdetails != null)
                    {
                        if (Modal.IsNewUser == 1)
                        {
                            throw new Exception("It's not you, it's us. Something went wrong on our side.");

                        }
                        else
                        {
                            if (Modal.IsNewUser == 0)//Update user validation
                            {
                                if (Modal.userdetails.ex_userid < 1)
                                {
                                    throw new Exception("Sorry, we couldn't find such user.");
                                }
                                bool isuserexist = _dbContext.sm_external_users.Any(x => x.ex_userid == Modal.userdetails.ex_userid);
                                if (!isuserexist)
                                {
                                    throw new Exception("Sorry, we couldn't find such user.");
                                }
                            }
                        }
                        if (string.IsNullOrEmpty(Modal.userdetails.ex_usercode) || string.IsNullOrWhiteSpace(Modal.userdetails.ex_usercode))
                        {
                            throw new Exception("Please enter valid Username!");
                        }
                        var NotUniqueCode = _dbContext.sm_external_users.Any(X => (X.ex_usercode == Modal.userdetails.ex_usercode && X.ex_userid != Modal.userdetails.ex_userid));
                        if (NotUniqueCode)
                        {
                            throw new Exception("Oops! That username is taken. Try another one!");
                        }
                        if (string.IsNullOrEmpty(Modal.userdetails.ex_username) || string.IsNullOrWhiteSpace(Modal.userdetails.ex_username))
                        {
                            throw new Exception("Please enter valid Name!");
                        }
                        if (string.IsNullOrEmpty(Modal.userdetails.ex_emailid) || string.IsNullOrWhiteSpace(Modal.userdetails.ex_emailid) || !IsValidEmail(Modal.userdetails.ex_emailid))
                        {
                            throw new Exception("Please enter valid Email!");
                        }
                        if (!string.IsNullOrEmpty(Modal.userdetails.companyid) && !string.IsNullOrWhiteSpace(Modal.userdetails.companyid))
                        {
                            int companyId = convert.ToInt(Modal.userdetails.companyid);
                            if (companyId > 0) { }
                            else
                            {
                                throw new Exception("Please select a valid company to continue!");
                            }
                        }
                        else
                        {
                            throw new Exception("Please select a company to continue!");
                        }
                        if (Modal.userdetails.usertype == null || Modal.userdetails.usertype < 1)
                        {
                            throw new Exception("Please select User role!");
                        }
                        if (Modal.password == null || Modal.password.Length == 0 || string.IsNullOrEmpty(Modal.password) || string.IsNullOrWhiteSpace(Modal.password))
                        {
                            throw new Exception("Please enter a valid password!");
                        }
                        else
                        {
                            if (Modal.confirmpassword == null || Modal.confirmpassword.Length == 0 || string.IsNullOrEmpty(Modal.confirmpassword) || string.IsNullOrWhiteSpace(Modal.confirmpassword))
                            {

                            }
                            else
                            {
                                if (Modal.password != Modal.confirmpassword)
                                {
                                    throw new Exception("Oops! Your password and confirm password don't match. Let's give it another shot!");
                                }
                            }

                        }


                        Model.data = Modal;
                    }
                    else
                    {
                        throw new Exception("Uh-oh! Something went wrong. Please contact support for assistance!");
                    }



                }
            }
            catch (Exception ex)
            {

                Model.status = "fail";
                Model.isSuccess = false;
                Model.message = ex.Message;
            }

            return Model;

        }
        public bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                string DomainMapper(Match match)
                {
                    var idn = new System.Globalization.IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
        public int GetCompanyAddressid(int companyid)
        {
            int addressid = 0;
            try
            {
                var Company = _dbContext.les_company.Where(x => x.companyid == companyid).FirstOrDefault();
                if (Company != null)
                {
                    addressid = convert.ToInt(Company.addressid);
                }
            }
            catch (Exception ex)
            {
                setlog("Error in GetCompanyAddressid - " + ex.Message);
                setlog("Error Stack in GetCompanyAddressid - " + ex.GetBaseException());
            }
            return addressid;
        }
        protected adminresponseMessage CreateOrUpdateUser(CreateUpdateUserModal Modal)
        {
            adminresponseMessage Model = new();
            Model.message = "Something went wrong!";
            Model.isSuccess = false;
            Model.status = "FAIL";

            try
            {

                if (Modal.IsNewUser == 1)
                {
                    //User creation 
                    var Result = ValidateNewUser(Modal);
                    if (Result.isSuccess)
                    {
                        var UserDetails = Modal.userdetails;
                        UserDetails.ex_password = Modal.password;
                        SM_EXTERNAL_USERS DATA = new SM_EXTERNAL_USERS();
                        DATA.isactive = 1;
                        DATA.addressid = GetCompanyAddressid(convert.ToInt(UserDetails.companyid));
                        DATA.ex_usercode = UserDetails.ex_usercode;
                        DATA.ex_username = UserDetails.ex_username;
                        DATA.ex_password = GlobalTools.EncodePWD(Modal.password);
                        DATA.ex_emailid = UserDetails.ex_emailid;
                        DATA.usertype = UserDetails.usertype;
                        DATA.inv_usertype = UserDetails.usertype;
                        DATA.created_date = DateTime.Now;
                        DATA.exported = 0;
                        DATA.dashboard_access = 1;
                        DATA.isactive = 1;//User will now be active here
                        DATA.mail_notification = 1;
                        DATA.pwd_expired = 0;

                        DATA.companyid = UserDetails.companyid;
                        var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                        executionStrategy.Execute(() =>
                        {
                            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                            {
                                _dbContext.sm_external_users.Add(DATA);
                                int Update = _dbContext.SaveChanges();
                                if (Update > 0)
                                {
                                    LES_USER_COMPANY_LINK link = new();
                                    link.created_date = DateTime.Now;
                                    link.ex_userid = DATA.ex_userid;
                                    link.companyid = convert.ToInt(DATA.companyid);
                                    link.usertypeid = DATA.usertype;

                                    _dbContext.les_user_company_link.Add(link);
                                    int update = _dbContext.SaveChanges();
                                    if (update > 0)
                                    {
                                        dbContextTransaction.Commit();
                                        Result.data = Modal.userdetails = DATA;
                                        Result.message = "User successfully created!";
                                        Result.status = "SUCCESS";
                                        Result.isSuccess = true;
                                    }
                                    else
                                    {
                                        dbContextTransaction.Rollback();
                                        Result.message = "Unable to create new users! Please contact support for assistance.";
                                        Result.status = "FAIL";
                                        Result.isSuccess = false;
                                    }
                                }
                                else
                                {
                                    dbContextTransaction.Rollback();
                                    Result.status = "FAIL";
                                    Result.message = "Unable to create new user!";
                                    Result.isSuccess = false;

                                }
                            }
                        });


                    }
                    else
                    {
                        return Result;
                    }
                    Model = Result;

                }
                else
                {
                    //User Update
                    var res = ValidateUpdateUser(Modal);
                    if (res.isSuccess)
                    {
                        var UserDetails = Modal.userdetails;
                        var ExistingUser = _dbContext.sm_external_users.Where(x => x.ex_userid == UserDetails.ex_userid).FirstOrDefault();
                        var ExistingUsercopy = _dbContext.sm_external_users.Where(x => x.ex_userid == UserDetails.ex_userid).FirstOrDefault();
                        var ExitingUserCompany = _dbContext.les_user_company_link.Where(x => x.companyid == convert.ToInt(ExistingUser.companyid) && x.ex_userid == ExistingUser.ex_userid).FirstOrDefault();
                        if (ExistingUsercopy != null && ExistingUser != null && UserDetails != null)
                        {
                            if (string.IsNullOrEmpty(Modal.confirmpassword) || string.IsNullOrWhiteSpace(Modal.confirmpassword))
                            {
                                UserDetails.ex_password = Modal.password;

                            }
                            else
                            {
                                UserDetails.ex_password = GlobalTools.EncodePWD(Modal.password);

                            }


                            //ExistingUser.isactive = 1;
                            ExistingUser.addressid = GetCompanyAddressid(convert.ToInt(UserDetails.companyid));
                            //ExistingUser.ex_usercode = UserDetails.ex_usercode;
                            ExistingUser.ex_username = UserDetails.ex_username;
                            ExistingUser.ex_password = UserDetails.ex_password;
                            ExistingUser.ex_emailid = UserDetails.ex_emailid;
                            ExistingUser.usertype = UserDetails.usertype;
                            ExistingUser.inv_usertype = UserDetails.usertype;
                            //ExistingUser.created_date = UserDetails.created_date;
                            ExistingUser.update_date = DateTime.Now;
                            //ExistingUser.pwd_expired = UserDetails.pwd_expired;
                            //ExistingUser.exported = UserDetails.exported;
                            ExistingUser.isactive = UserDetails.isactive;
                            ExistingUser.mail_notification = UserDetails.mail_notification;
                            ExistingUser.companyid = UserDetails.companyid;

                            var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                            executionStrategy.Execute(() =>
                            {
                                using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                                {

                                    _dbContext.sm_external_users.Update(ExistingUser);
                                    int Update = _dbContext.SaveChanges();
                                    if (Update > 0)
                                    {
                                        if (convert.ToInt(UserDetails.companyid) != ExitingUserCompany.companyid || UserDetails.usertype != ExitingUserCompany.usertypeid)
                                        {
                                            if (ExitingUserCompany != null)
                                            {
                                                var NewusercompLink = _dbContext.les_user_company_link.Where(x => x.ex_userid == ExistingUsercopy.ex_userid && x.companyid == convert.ToInt(UserDetails.companyid)).FirstOrDefault();

                                                if (NewusercompLink != null)
                                                {
                                                    NewusercompLink.usertypeid = UserDetails.usertype;
                                                    NewusercompLink.companyid = convert.ToInt(UserDetails.companyid);

                                                    _dbContext.les_user_company_link.Update(NewusercompLink);
                                                    int update = _dbContext.SaveChanges();
                                                    if (update > 0)
                                                    {
                                                        dbContextTransaction.Commit();
                                                        res.message = "User successfully updated!";
                                                        res.status = "SUCCESS";
                                                        res.isSuccess = true;
                                                    }
                                                    else
                                                    {
                                                        dbContextTransaction.Rollback();
                                                        res.status = "FAIL";
                                                        res.message = "Unable to update user!";
                                                        res.isSuccess = false;
                                                    }
                                                }
                                                else
                                                {
                                                    ExitingUserCompany.usertypeid = UserDetails.usertype;
                                                    ExitingUserCompany.companyid = convert.ToInt(UserDetails.companyid);

                                                    _dbContext.les_user_company_link.Update(ExitingUserCompany);
                                                    int update = _dbContext.SaveChanges();
                                                    if (update > 0)
                                                    {
                                                        dbContextTransaction.Commit();
                                                        res.message = "User successfully updated!";
                                                        res.status = "SUCCESS";
                                                        res.isSuccess = true;
                                                    }
                                                    else
                                                    {
                                                        dbContextTransaction.Rollback();
                                                        res.status = "FAIL";
                                                        res.message = "Unable to update user!";
                                                        res.isSuccess = false;
                                                    }
                                                }

                                            }
                                            else
                                            {
                                                dbContextTransaction.Rollback();
                                                res.status = "FAIL";
                                                res.message = "Unable to update user!";
                                                res.isSuccess = false;

                                            }

                                        }
                                        else
                                        {
                                            dbContextTransaction.Commit();
                                            res.message = "User successfully updated!";
                                            res.status = "SUCCESS";
                                            res.isSuccess = true;
                                        }


                                    }
                                    else
                                    {
                                        dbContextTransaction.Rollback();
                                        res.status = "FAIL";
                                        res.message = "Unable to update user!";
                                        res.isSuccess = false;

                                    }
                                }
                            });

                        }
                        else
                        {
                            res.status = "FAIL";
                            res.message = "Unable to get user details!";
                            res.isSuccess = false;
                        }
                    }
                    else
                    {
                        return res;
                    }

                    Model = res;
                }


            }
            catch (Exception ex)
            {

                Model.message = "Something went wrong!";
                Model.isSuccess = false;
                Model.status = "FAIL";
                setlog("Error in CreateNewUser - " + ex.Message);
                setlog("Error Stack in CreateNewUser - " + ex.GetBaseException());
            }




            return Model;
        }

        //User Details -->
        protected adminresponseMessage GetUserDetails(int AccessUserId, int ForUserId)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(AccessUserId, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    var UserDetails = _dbContext.v_user_list.Where(x => x.ex_userid == ForUserId).FirstOrDefault();
                    if (UserDetails != null)
                    {
                        UserDetailsModal Modal = new();
                        List<V_USERLINKED_COMPANIES> LinkedCompanies = new();
                        LinkedCompanies = _dbContext.v_userlinked_companies.Where(x => x.ex_userid == UserDetails.ex_userid).ToList();
                        if (LinkedCompanies == null)
                        {
                            LinkedCompanies = new();
                        }
                        Modal.userdetails = UserDetails;
                        Modal.linkedcompanies = LinkedCompanies;
                        _response.data = Modal;

                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "User not found! please contact support for assitance.";
                        _response.status = "FAIL";

                    }
                }
            }
            catch (Exception ex)
            {
                setlog("Error in GetUsersList - " + ex.Message);
                setlog("Error Stack in GetUsersList - " + ex.GetBaseException());
            }
            return _response;
        }
        //Get All Companies
        protected adminresponseMessage GetAllCompanies(int AccessUserId)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(AccessUserId, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    var companies = _dbContext.les_company.Select(x => new { x.companyid, x.company_code, x.company_description }).ToList();
                    if (companies != null)
                    {

                        _response.data = companies;

                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "Companies not found! please contact support for assitance.";
                        _response.status = "FAIL";

                    }
                }
            }
            catch (Exception ex)
            {
                setlog("Error in GetAllCompanies - " + ex.Message);
                setlog("Error Stack in GetAllCompanies - " + ex.GetBaseException());
            }
            return _response;
        }

        protected adminresponseMessage AllCompanyList(int UserId)
        {
            adminresponseMessage ResponseMsg = new();
            //List<CompanyList> companyLists = new List<CompanyList>();
            try
            {
                ResponseMsg = checkAccessForModule(UserId, 7, 1);

                if (ResponseMsg.isSuccess)
                {

                    var companyList = _dbContext.les_company.Select(companies =>
                        new CompanyList
                        {
                            companyid = companies.companyid,
                            company_code = companies.company_code,
                            company_description = companies.company_description,
                            addressId = companies.addressid

                        }).ToList();
                    List<AddressType> addressList = _dbContextLogistics.Sm_Address.Select(x => new AddressType { addressId = x.addressid, addr_type = x.addr_type, Country = x.addr_country }).ToList();
                    var joinedList = (from company in companyList
                                      join address in addressList
                                      on company.addressId equals address.addressId
                                      select new CompanyList
                                      {
                                          companyid = company.companyid,
                                          company_code = company.company_code,
                                          company_description = company.company_description,
                                          addressId = company.addressId,
                                          Country = address.Country,
                                          addr_type = address.addr_type // Assign address type
                                      }).ToList();

                    ResponseMsg.data = joinedList;
                }
                else
                {
                    ResponseMsg.isSuccess = false;
                    ResponseMsg.message = "No Companies Found, Please contact support.";
                    ResponseMsg.status = "FAIL";
                }
            }
            catch (Exception ex)
            {
                setlog("Error in AllCompanyList - " + ex.Message);
                setlog("Error Stack in AllCompanyList - " + ex.GetBaseException());
            }
            return ResponseMsg;
        }
        protected adminresponseMessage GetAllSmAddresses(int AccessUserId)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(AccessUserId, 7, 1);
                if (_response.isSuccess)
                {    
                    var SMAddess = _dbContextLogistics.Sm_Address
                        .Where(a => new[] { "buyer", "supplier" }.Contains(a.addr_type.ToLower()))
                        .Select(x => new { x.addr_name, x.addr_code, x.addressid, x.addr_type })
                        .ToArray();
                    if (SMAddess != null && SMAddess.Length > 0)
                    {
                        _response.data = SMAddess;

                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "Sm Addresses not found! please contact support for assistance.";
                        _response.status = "FAIL";
                    }
                }

            }
            catch (Exception ex)
            {
                setlog("Error in GetAllCompanies - " + ex.Message);
                setlog("Error Stack in GetAllCompanies - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage GetSMAddressDetails(int AccessUserId, int Addressid)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(AccessUserId, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    var SmAddress = _dbContextLogistics.Sm_Address.Where(x => x.addressid == Addressid).FirstOrDefault();

                    if (SmAddress != null)
                    {
                        _response.data = SmAddress;
                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "Address Details not found! please contact support for assitance.";
                        _response.status = "FAIL";

                    }
                }
            }
            catch (Exception ex)
            {
                setlog("Error in GetSMAddressDetails - " + ex.Message);
                setlog("Error Stack in GetSMAddressDetails - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage UpdateCompanyDetails(CompanyUpdateModal modal)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(modal.accessuserid, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    if (modal.companydetails != null && modal.companydetails.companyid > 0)
                    {
                        var ExistingCompany = _dbContext.les_company.Where(x => x.companyid == modal.companydetails.companyid).FirstOrDefault();
                        var ExistingCompanyModal = ExistingCompany;
                        if (ExistingCompanyModal == null)
                        {
                            _response.isSuccess = false;
                            _response.message = "Unable to find Company Details! please contact support for assitance.";
                            _response.status = "FAIL";
                        }
                        else
                        {

                            var NotUniqueCode = _dbContext.les_company.Any(X => (X.company_code == modal.companydetails.companycode && X.companyid != modal.companydetails.companyid));
                            if (NotUniqueCode)
                            {
                                _response.isSuccess = false;
                                _response.message = "Unable to save company details! Company Code is already taken.";
                                _response.status = "FAIL";
                                throw new Exception(_response.message);
                            }
                            if (modal.companydetails.mainlogofilename != null && modal.companydetails.mainlogofilename.Length > 0 && modal.companydetails.mainlogo != null && modal.companydetails.mainlogo.Length > 0)
                            {//assuming main logo changed!
                                (bool result, string filepath) = SaveCompanylogo(modal.companydetails.companyid, modal.companydetails.mainlogo, modal.companydetails.mainlogofilename);
                                if (result)
                                {
                                    ExistingCompanyModal.logopath = filepath;
                                }
                                else
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Unable to save Company logo!";
                                    _response.status = "FAIL";
                                    throw new Exception(_response.message);
                                }
                            }
                            if (modal.companydetails.printlogofilename != null && modal.companydetails.printlogofilename.Length > 0 && modal.companydetails.printlogo != null && modal.companydetails.printlogo.Length > 0)
                            {//assuming print logo changes!
                                (bool result, string filepath) = SaveCompanylogo(modal.companydetails.companyid, modal.companydetails.printlogo, modal.companydetails.printlogofilename);
                                if (result)
                                {
                                    ExistingCompanyModal.print_logo_path = filepath;
                                }
                                else
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Unable to save print logo!";
                                    _response.status = "FAIL";
                                    throw new Exception(_response.message);
                                }
                            }
                            if (modal.companydetails.faviconlogofilename != null && modal.companydetails.faviconlogofilename.Length > 0 && modal.companydetails.faviconlogo != null && modal.companydetails.faviconlogo.Length > 0)
                            {//assuming favicon logo changed!
                                (bool result, string filepath) = SaveCompanylogo(modal.companydetails.companyid, modal.companydetails.faviconlogo, modal.companydetails.faviconlogofilename);
                                if (result)
                                {
                                    ExistingCompanyModal.min_logopath = filepath;
                                }
                                else
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Unable to save favicon logo!";
                                    _response.status = "FAIL";
                                    throw new Exception(_response.message);
                                }
                            }
                            if (modal.companydetails.addressid != ExistingCompanyModal.addressid)
                            {
                                var address = _dbContext.les_company.Any(x => x.addressid == modal.companydetails.addressid);
                                if (address)
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Company address is already linked to another company!";
                                    _response.status = "FAIL";
                                    throw new Exception(_response.message);
                                }
                                else
                                {
                                    ExistingCompanyModal.addressid = modal.companydetails.addressid;
                                }
                            }
                            
                            ExistingCompanyModal.updated_date = DateTime.Now;
                            ExistingCompanyModal.company_description = modal.companydetails.companydescription;
                            ExistingCompanyModal.company_code = modal.companydetails.companycode;
                            _dbContext.les_company.Update(ExistingCompanyModal);
                            var res = _dbContext.SaveChanges();
                            if (res > 0)
                            {
                                _response.isSuccess = true;
                                _response.message = "Company details saved successfully!";
                                _response.status = "SUCCESS";
                            }
                            else
                            {
                                _response.isSuccess = false;
                                _response.message = "Something went wrong while saving company details!";
                                _response.status = "FAIL";
                            }

                        }
                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "Company Details not found! please contact support for assitance.";
                        _response.status = "FAIL";
                    }
                }
            }
            catch (Exception ex)
            {
                setlog("Error in UpdateCompanyDetails - " + ex.Message);
                setlog("Error Stack in UpdateCompanyDetails - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage CreateNewCompanyDetails(LES_COMPANY_UPDATE modal, int accessuserid)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(accessuserid, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    if (modal.addressid > 0 && !string.IsNullOrEmpty(modal.companycode) && modal.companycode.Length > 0 && !string.IsNullOrEmpty(modal.companydescription) && modal.companydescription.Length > 0)
                    {
                        var executionStrategy = _dbContext.Database.CreateExecutionStrategy();
                        executionStrategy.Execute(() =>
                        {
                            using (var dbContextTransaction = _dbContext.Database.BeginTransaction())
                            {

                                modal.companyid = 0;
                                var address = _dbContextLogistics.Sm_Address.Any(x => x.addressid == modal.addressid);
                                var NotUniqueCode = _dbContext.les_company.Any(X => (X.company_code == modal.companycode && X.companyid != modal.companyid));

                                var isaddresslinked = _dbContext.les_company.Any(x => x.addressid == modal.addressid);
                                if (isaddresslinked)
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Company address is already linked to another company!";
                                    _response.status = "FAIL";
                                    dbContextTransaction.Rollback();
                                    throw new Exception(_response.message);
                                }
                                if (NotUniqueCode)
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Unable to save company details! Company Code is already taken.";
                                    _response.status = "FAIL";
                                    dbContextTransaction.Rollback();
                                    throw new Exception(_response.message);
                                }
                                if (address)
                                {
                                    LES_COMPANY CompModal = new LES_COMPANY();
                                    var Rec = _dbContext.les_company.OrderByDescending(x => x.companyid).FirstOrDefault();
                                    int companyId = 0;
                                    if (Rec != null)
                                    {
                                        companyId = Rec.companyid + 1;
                                    }

                                    if (companyId != 0 && companyId > 0) { }
                                    else
                                    {
                                        _response.isSuccess = false;
                                        _response.message = "Oops, Unable to generate company id!";
                                        _response.status = "FAIL";
                                        dbContextTransaction.Rollback();
                                        throw new Exception(_response.message);
                                    }
                                    CompModal.companyid = companyId;
                                    CompModal.addressid = modal.addressid;
                                    CompModal.updated_date = DateTime.Now;
                                    CompModal.created_date = DateTime.Now;
                                    CompModal.company_description = modal.companydescription;
                                    CompModal.company_code = modal.companycode;
                                    CompModal.poweredby_flag = 0;
                                    _dbContext.les_company.Add(CompModal);
                                    var result = _dbContext.SaveChanges();
                                    if (result > 0)
                                    {
                                        _response.data = CompModal.companyid;
                                        dbContextTransaction.Commit();
                                        _response.isSuccess = true;
                                        _response.message = "Congratulations! company '" + CompModal.company_description + "' successfully created!";
                                        _response.status = "SUCCESS";
                                    }
                                    else
                                    {
                                        dbContextTransaction.Rollback();
                                        _response.isSuccess = false;
                                        _response.message = "Oops, Something went wrong at our side.";
                                        _response.status = "FAIL";
                                    }
                                }

                            }
                        });


                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "Company Details not found! please ensure all details entered.";
                        _response.status = "FAIL";
                    }
                }
            }
            catch (Exception ex)
            {
                setlog("Error in UpdateCompanyDetails - " + ex.Message);
                setlog("Error Stack in UpdateCompanyDetails - " + ex.GetBaseException());
            }
            return _response;
        }
        protected int GetLatestCompanyId()
        {
            int CompanyId = 0;
            try
            {
                var Rec = _dbContext.les_company.OrderByDescending(x => x.companyid).FirstOrDefault();
                if (Rec != null)
                {
                    CompanyId = Rec.companyid + 1;
                }
                else
                {
                    CompanyId = 0;
                }

            }
            catch (Exception ex)
            {
                setlog("Error in GetLatestCompanyId - " + ex.Message);
            }
            return CompanyId;
        }
        protected (bool, string) SaveCompanylogo(int companyid, string logoimagedata, string filename)
        {
            bool result = false;
            string savedpath = "";
            try
            {
                string CompanyAttachpath = convert.ToString(UserAdminDbContext.configuration.GetSection("AppSettings").GetSection("Company_Document_Path").Value);
                if (!Directory.Exists(CompanyAttachpath)) { Directory.CreateDirectory(CompanyAttachpath); }
                if (companyid > 0 && logoimagedata != null && logoimagedata.Length > 0 && filename.Length > 0)
                {
                    string NewDirpath = CompanyAttachpath + "\\" + companyid.ToString();
                    if (!Directory.Exists(NewDirpath)) { Directory.CreateDirectory(NewDirpath); }
                    string CompanyLogoPath = NewDirpath + "\\" + filename;
                    byte[] _sbytes = Convert.FromBase64String(logoimagedata);
                    if (!File.Exists(CompanyLogoPath))
                    {
                        System.IO.File.WriteAllBytes(CompanyLogoPath, _sbytes);
                        result = true;
                        savedpath = CompanyLogoPath;
                    }
                    else
                    {
                        File.Delete(CompanyLogoPath);
                        System.IO.File.WriteAllBytes(CompanyLogoPath, _sbytes);
                        result = true;
                        savedpath = CompanyLogoPath;
                    }

                }
                else
                {
                    result = false;
                }

            }
            catch (Exception ex)
            {
                setlog("Error in SaveCompanylogo - " + ex.Message);
                setlog("Error Stack in SaveCompanylogo - " + ex.GetBaseException());
            }

            return (result, savedpath);
        }
        protected adminresponseMessage AddCompanyUserLink(int companyid, int foruserid, int usertypeid, int accessuserid)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(accessuserid, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    bool iflinkexist = _dbContext.les_user_company_link.Where(x => x.companyid == companyid && x.ex_userid == foruserid).Any();
                    if (!iflinkexist)
                    {
                        bool isuserexist = _dbContext.sm_external_users.Any(x => x.ex_userid == foruserid);
                        bool iscompanyexist = _dbContext.les_company.Any(x => x.companyid == companyid);
                        if (iscompanyexist && isuserexist)
                        {
                            var Link = new LES_USER_COMPANY_LINK();
                            Link.created_date = DateTime.Now;
                            Link.ex_userid = foruserid;
                            Link.usertypeid = usertypeid;
                            Link.companyid = companyid;
                            Link.created_by = accessuserid;
                            _dbContext.les_user_company_link.Add(Link);
                            var res = _dbContext.SaveChanges();
                            if (res > 0)
                            {
                                _response.isSuccess = true;
                                _response.message = "User is successfully linked !";
                                _response.status = "SUCCESS";
                            }
                            else
                            {
                                _response.isSuccess = false;
                                _response.message = "Oops, Something went wrong at our side.";
                                _response.status = "FAIL";
                            }
                        }
                        else
                        {
                            _response.isSuccess = false;
                            _response.message = "Oops, given user or company dose not exist!";
                            _response.status = "FAIL";
                        }

                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "User is already linked !";
                        _response.status = "FAIL";
                    }

                }
            }
            catch (Exception ex)
            {
                setlog("Error in AddCompanyUserLink - " + ex.Message);
                setlog("Error Stack in AddCompanyUserLink - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage RemoveCompanyUserLink(int companyid, int foruserid, int accessuserid)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(accessuserid, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    var link = _dbContext.les_user_company_link.Where(x => x.companyid == companyid && x.ex_userid == foruserid).FirstOrDefault();
                    if (link != null)
                    {
                        _dbContext.les_user_company_link.Remove(link);
                        var res = _dbContext.SaveChanges();
                        if (res > 0)
                        {
                            _response.isSuccess = true;
                            _response.message = "Company successfully delinked from user !";
                            _response.status = "SUCCESS";
                        }
                        else
                        {
                            _response.isSuccess = false;
                            _response.message = "Oops, Something went wrong at our side.";
                            _response.status = "FAIL";
                        }
                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "User is not linked given company !";
                        _response.status = "FAIL";
                    }

                }
            }
            catch (Exception ex)
            {
                setlog("Error in RemoveCompanyUserLink - " + ex.Message);
                setlog("Error Stack in RemoveCompanyUserLink - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage GetUserTypeModuleAccess(int accessuserid, int UsertypeId)
        {
            adminresponseMessage _response = new adminresponseMessage();
            try
            {
                _response = checkAccessForModule(accessuserid, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    var ifusertypeexist = _dbContext.les_usertype.Any(x => x.usertypeid == UsertypeId);
                    if (ifusertypeexist)
                    {
                        var AccessLevels = _dbContext.v_usertype_module_access.Where(x => x.USERTYPEID == UsertypeId).ToList();

                        if (AccessLevels != null)
                        {
                            _response.data = AccessLevels;
                        }
                        else
                        {
                            _response.isSuccess = false;
                            _response.message = "User access level not found! please contact support for assitance.";
                            _response.status = "FAIL";

                        }
                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "No such user type exist! please contact support for assitance.";
                        _response.status = "FAIL";
                    }

                }
            }
            catch (Exception ex)
            {
                setlog("Error in GetUserTypeModuleAccess - " + ex.Message);
                setlog("Error Stack in GetUserTypeModuleAccess - " + ex.GetBaseException());
            }
            return _response;
        }
        protected adminresponseMessage UpdateUserAccessRights(int accessuserid, int Usertypesid, string Options)
        {
            adminresponseMessage _response = new adminresponseMessage();
            int Updatedrec = 0;

            try
            {
                _response = checkAccessForModule(accessuserid, 7, 1);//7=User Admin 1 =Greater than read only 
                if (_response.isSuccess)
                {
                    if (Usertypesid > 0 && Options != null && Options.Length > 0)
                    {

                        var dsrlzData = JsonConvert.DeserializeObject<List<USERTYPE>>(Options);
                        var AllModuleLinks = _dbContext.les_usertype_module_access.Any(x => x.usertypeid == Usertypesid);
                        if (AllModuleLinks)
                        {
                            if (dsrlzData != null && dsrlzData.Count > 0)
                            {
                                for (int i = 0; i < dsrlzData.Count; i++)
                                {
                                    var eachModuleAccess = dsrlzData[i];
                                    int _selectedvalue = convert.ToInt(eachModuleAccess.SelectedValue);
                                    int _moduleid = convert.ToInt(eachModuleAccess.moduleId);
                                    var existingRecord = _dbContext.les_usertype_module_access.Where(x => x.moduleid == _moduleid && x.usertypeid == Usertypesid).FirstOrDefault();
                                    if (existingRecord != null)
                                    {
                                        existingRecord.update_date = DateTime.Now;
                                        existingRecord.access_level = _selectedvalue;
                                        _dbContext.Update(existingRecord);
                                    }
                                    else
                                    {
                                        LES_USERTYPE_MODULE_ACCESS newRecord = new LES_USERTYPE_MODULE_ACCESS();
                                        newRecord.access_level = _selectedvalue;
                                        newRecord.usertypeid = Usertypesid;
                                        newRecord.moduleid = _moduleid;
                                        newRecord.created_date = DateTime.Now;
                                        newRecord.update_date = DateTime.Now;
                                        _dbContext.les_usertype_module_access.Add(newRecord);

                                    }


                                }
                                Updatedrec = _dbContext.SaveChanges();
                                if (Updatedrec > 0)
                                {
                                    _response.isSuccess = true;
                                    _response.message = "User type details successfully saved!";
                                    _response.status = "SUCCESS";
                                }
                                else
                                {
                                    _response.isSuccess = false;
                                    _response.message = "Oops, something went wrong! please contact support for assitance.";
                                    _response.status = "FAIL";
                                }

                            }
                            else
                            {
                                _response.isSuccess = false;
                                _response.message = "Oops, No selected access levels found! please contact support for assitance.";
                                _response.status = "FAIL";
                            }

                        }
                        else
                        {
                            _response.isSuccess = false;
                            _response.message = "Oops, No such user type exist! please contact support for assitance.";
                            _response.status = "FAIL";
                        }
                    }
                    else
                    {
                        _response.isSuccess = false;
                        _response.message = "Oops, Something went wrong! please contact support for assitance.";
                        _response.status = "FAIL";
                    }
                }
            }
            catch (Exception ex)
            {
                setlog("Error in GetUserTypeModuleAccess - " + ex.Message);
                setlog("Error Stack in GetUserTypeModuleAccess - " + ex.GetBaseException());
            }
            return _response;
        }

        #endregion User Admin
        //protected string GetQueryData(string sqlQuery)
        //{
        //    LES_USER_ADMINISTRATION_LIB.DAL.DataAccess _service = new LES_USER_ADMINISTRATION_LIB.DAL.DataAccess("UserAdminConnectionString");
        //    DataTable _dataTable = _service.ExecuteSqlQuery(sqlQuery);
        //    string json = JsonConvert.SerializeObject(_dataTable);
        //    return json;
        //}

        //protected string GetSqlQueryDataParamerters(string sqlQuery , List<string> lstParamenters)
        //{
        //    LES_USER_ADMINISTRATION_LIB.DAL.DataAccess _service = new LES_USER_ADMINISTRATION_LIB.DAL.DataAccess("UserAdminConnectionString");
        //    _service.CreateSQLCommand(sqlQuery);
        //    if (lstParamenters.Count() > 0)
        //    {
        //        foreach (string _parma in lstParamenters)
        //        {
        //            string[] _parameters = _parma.Split('~');
        //            _service.AddParameter(_parameters[0], _parameters[1], ParameterDirection.Input);
        //        }
        //    }
        //    else
        //    {
        //        throw new Exception("Paramerters are empty");
        //    }
        //    DataSet _ds = _service.ExecuteDataSet();
        //    string json = JsonConvert.SerializeObject(_ds.Tables[0]);
        //    return json;
        //}

        protected object LoginInByCredentials(string ex_username, string ex_password)
        {
            object _obj = null;
            adminresponseMessage _response = new adminresponseMessage();
            LoginModalViews _loginData = new LoginModalViews();
            try
            {
                if (!string.IsNullOrWhiteSpace(ex_username) && !string.IsNullOrWhiteSpace(ex_password))
                {
                    // Check USER by usercode //
                    SM_EXTERNAL_USERS objUser = _dbContext.sm_external_users.FirstOrDefault(u => u.ex_usercode.ToUpper().Trim() == ex_username.ToUpper().Trim());
                    if (objUser != null)
                    {
                        // Check Password Expiry Date //
                        if (objUser.pwd_expired == null && (convert.ToDateTime(objUser.update_date).Date - DateTime.Now.Date).TotalDays > objUser.pwd_expired)
                        {
                            throw new Exception("Your password is expired.");
                        }
                        else
                        {
                            if (objUser.isactive == 1)
                            {
                                string sPassword = GlobalTools.EncodePassword(ex_password);
                                string cInput = "UserCode=" + ex_username + "&" + "Password=" + ex_password;

                                IEnumerable<SM_EXTERNAL_USERS> slUsers = null;
                                slUsers = _dbContext.sm_external_users.Where(s => s.isactive == 1
                                  && s.ex_usercode.ToUpper() == objUser.ex_usercode.ToUpper().Trim()
                                  && s.ex_password.ToUpper().Trim() == sPassword.ToUpper().Trim()).ToList();

                                if (slUsers.Count() > 0)
                                {
                                    if (slUsers.First().dashboard_access == 1)
                                    {

                                        SM_EXTERNAL_USERS _user = slUsers.First();

                                        string cUserName = convert.ToString(_user.ex_username).Trim(),
                                            cEmailId = convert.ToString(_user.ex_emailid).Trim(),
                                            UserCode = _user.ex_usercode.ToUpper();

                                        if (cUserName.Trim().Length == 0)
                                        {
                                            cUserName = _user.ex_usercode.ToUpper();
                                        }

                                        List<V_COMPANY_DETAILS_DATA> lstUserCompanyData = _dbContext.v_company_details.Where(x => x.Ex_UserId == _user.ex_userid).Select(x => new V_COMPANY_DETAILS_DATA
                                        {
                                            User_Company_Link_Id = convert.ToInt(x.User_Company_Link_Id),
                                            CompanyId = x.CompanyId,
                                            Company_Code = x.Company_Code,
                                            CustomerId  = GetCustomerIdFromCompanyId(convert.ToInt(x.CompanyId),_dbContext,_dbContextLogistics),
                                            Company_Description = x.Company_Description,
                                            //LogoPath = x.LogoPath,
                                            //min_LogoPath = x.min_LogoPath,
                                            AddressId = x.AddressId,
                                            AddressType = GetAddressType(_dbContextLogistics, x.AddressId),
                                            Ex_UserId = x.Ex_UserId,
                                            UserTypeId = x.UserTypeId,
                                            Usertypedescr = x.Usertypedescr,
                                            base64Logo = Base64DataObject(x.LogoPath),
                                            base64minLogo = Base64DataObject(x.min_LogoPath),
                                            base64printLogo = Base64DataObject(x.print_logo_path),
                                            poweredby_flag = x.poweredby_flag

                                        }).ToList();

                                        List<V_APPLICATION_MODULE_ACCESS> slUserAccess = null;
                                        slUserAccess = (from s in _dbContext.v_application_module_access.ToList()
                                                        where s.Ex_UserId == convert.ToInt(_user.ex_userid) && s.ApplicationId == 1
                                                        select s)
                                                       .ToList();

                                        _loginData.Userid = convert.ToInt(_user.ex_userid);
                                        _loginData.UserName = convert.ToString(cUserName);
                                        _loginData.UserCode = convert.ToString(UserCode);
                                        _loginData.UserEmail = convert.ToString(cEmailId);
                                        _loginData.DefaultCompanyID = convert.ToString(_user.companyid);
                                        _loginData.list_company_details = lstUserCompanyData;
                                        _loginData.list_Application_Module_Access = slUserAccess;

                                        _obj = _loginData;

                                    }
                                    else
                                    {
                                        throw new Exception("You do not have the necessary permissions to view this content.");
                                    }
                                }
                                else
                                {
                                    throw new Exception("Wrong password entered");
                                }
                            }
                            else
                            {
                                throw new Exception("Your account is inactive");
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("No user found");
                    }
                }
                else
                {
                    throw new Exception("Please enter valid username and password");
                }
            }
            catch (Exception ex)
            {
                setlog("Error in Content - " + ex.Message);
                _response.data = null;
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                _obj = _response;
            }
            return _obj;
        }

       
        protected object LoginByMicrosoftEmail(MicrosoftUserModal modal)
        {
            object _obj = null;
            adminresponseMessage _response = new adminresponseMessage();
            LoginModalViews _loginData = new LoginModalViews();
            try
            {
                if (modal != null && !string.IsNullOrWhiteSpace(modal.sigmakey) && !string.IsNullOrWhiteSpace(modal.emailid) && !string.IsNullOrEmpty(modal.uti) && !string.IsNullOrEmpty(modal.rh) && !string.IsNullOrEmpty(modal.aio) && !string.IsNullOrEmpty(modal.nucleus))
                {
                    // Check USER by usercode //
                    SM_EXTERNAL_USERS objUser = _dbContext.sm_external_users.FirstOrDefault(u => u.ex_emailid.ToLower().Trim() == modal.emailid.ToLower().Trim());
                    if (objUser != null)
                    {
                        if (ValidateEncryption(modal))
                        {
                            // Check Password Expiry Date //
                            if (objUser.pwd_expired == null && (convert.ToDateTime(objUser.update_date).Date - DateTime.Now.Date).TotalDays > objUser.pwd_expired)
                            {
                                throw new Exception("Your password is expired.");
                            }
                            else
                            {
                                if (objUser.isactive == 1)
                                {

                                    if (objUser.dashboard_access == 1)
                                    {

                                        SM_EXTERNAL_USERS _user = objUser;

                                        string cUserName = convert.ToString(_user.ex_username).Trim(),
                                            cEmailId = convert.ToString(_user.ex_emailid).Trim(),
                                            UserCode = _user.ex_usercode.ToUpper();

                                        if (cUserName.Trim().Length == 0)
                                        {
                                            cUserName = _user.ex_usercode.ToUpper();
                                        }
                                        List<V_COMPANY_DETAILS_DATA> lstUserCompanyData = _dbContext.v_company_details.Where(x => x.Ex_UserId == _user.ex_userid).Select(x => new V_COMPANY_DETAILS_DATA
                                        {
                                            User_Company_Link_Id = convert.ToInt(x.User_Company_Link_Id),
                                            CompanyId = x.CompanyId,
                                            CustomerId = GetCustomerIdFromCompanyId(convert.ToInt(x.CompanyId),_dbContext,_dbContextLogistics),
                                            Company_Code = x.Company_Code,
                                            Company_Description = x.Company_Description,
                                            AddressType = GetAddressType(_dbContextLogistics, x.AddressId),
                                            //LogoPath = x.LogoPath,
                                            //min_LogoPath = x.min_LogoPath,
                                            AddressId = x.AddressId,
                                            Ex_UserId = x.Ex_UserId,
                                            UserTypeId = x.UserTypeId,
                                            Usertypedescr = x.Usertypedescr,
                                            base64Logo = Base64DataObject(x.LogoPath),
                                            base64minLogo = Base64DataObject(x.min_LogoPath),
                                            base64printLogo = Base64DataObject(x.print_logo_path),
                                            poweredby_flag = x.poweredby_flag,
                                        }).ToList();

                                        List<V_APPLICATION_MODULE_ACCESS> slUserAccess = null;
                                        slUserAccess = (from s in _dbContext.v_application_module_access.ToList()
                                                        where s.Ex_UserId == convert.ToInt(_user.ex_userid) && s.ApplicationId == 1
                                                        select s)
                                                        .ToList();

                                        _loginData.Userid = convert.ToInt(_user.ex_userid);
                                        _loginData.UserName = convert.ToString(cUserName);
                                        _loginData.UserCode = convert.ToString(UserCode);
                                        _loginData.UserEmail = convert.ToString(cEmailId);
                                        _loginData.DefaultCompanyID = convert.ToString(_user.companyid);
                                        _loginData.list_company_details = lstUserCompanyData;
                                        _loginData.list_Application_Module_Access = slUserAccess;

                                        _obj = _loginData;

                                    }
                                    else
                                    {
                                        throw new Exception("You do not have the necessary permissions to view this content.");
                                    }

                                }
                                else
                                {
                                    throw new Exception("Your account is inactive");
                                }
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to validate user details!");
                        }
                    }
                    else
                    {
                        throw new Exception("User is authenticated but not registered in the system.");
                    }
                }
                else
                {
                    throw new Exception("Oops! Something went wrong on our end. Please contact support.");
                }
            }
            catch (Exception ex)
            {
                setlog("Error in Content - " + ex.Message);
                _response.data = null;
                _response.status = "FAIL";
                _response.isSuccess = false;
                _response.message = "ERROR : " + ex.Message;
                _obj = _response;
            }
            return _obj;
        }
        private static int GetCustomerIdFromCompanyId(int companyid,UserAdminDbContext _dbContext,LogisticDbContext _dbContextLogistics)
        {
            int CustId = 0;
            var lesCompany = _dbContext.les_company.Where(x => x.companyid == companyid).FirstOrDefault();
            if (lesCompany != null && lesCompany.addressid > 0)
            {
                var customer = _dbContextLogistics.les_customers.Where(x => x.addressid == lesCompany.addressid).FirstOrDefault();
                if (customer != null && customer.customerid > 0)
                {
                    CustId = customer.customerid;
                }
            }
            return CustId;
        }
        private bool ValidateEncryption(MicrosoftUserModal modal)
        {
            bool result = false;
            try
            {
                if (modal != null)
                {
                    if ((modal.uti != null || modal.uti != "") && (modal.rh != null || modal.rh != "") && (modal.aio != null || modal.aio != "") && (modal.sigmakey != null || modal.sigmakey != "") && (modal.nucleus != null || modal.nucleus != ""))
                    {
                        string DeSigmakey = LeSEncryption.Decrypt(modal.sigmakey);
                        string Timestamp = LeSEncryption.Decrypt(modal.nucleus);
                        DateTime Dtm = convert.ToDateTime(Timestamp, "dd-MM-yyyy HH:mm:ss:ff");
                        DateTime current = DateTime.Now;
                        TimeSpan difference = current - Dtm;

                        string[] DeKeys = DeSigmakey.Split("&|&");
                        string deaio = LeSEncryption.Decrypt(DeKeys[0]);
                        string derh = LeSEncryption.Decrypt(DeKeys[1]);
                        string deuti = LeSEncryption.Decrypt(DeKeys[2]);
                        if (deaio == modal.aio && derh == modal.rh && deuti == modal.uti && current > Dtm && difference.Hours < 1)
                        {
                            result = true;

                        }
                        else
                        {
                            result = false;
                        }

                    }
                    else
                    {
                        throw new Exception("Oops! Keys are missing !");
                    }
                }
                else
                {

                    throw new Exception("Oops! Modal found null");
                }
            }
            catch (Exception ex)
            {
                setlog("Error in ValidateEncryption - " + ex.Message);
                return result = false;
            }
            return result;

        }
        private static string Base64DataObject(string _filepath)
        {
            string strReturn = string.Empty;
            try
            {
                if (_filepath != null && _filepath.Trim() != string.Empty)
                {
                    if (File.Exists(_filepath))
                    {
                        Byte[] bytes = File.ReadAllBytes(_filepath);
                        strReturn = Convert.ToBase64String(bytes);
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return strReturn;
        }

        private static string GetMimeType(string ext)
        {
            string str = "";
            if (ext != null)
            {
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
                    case ".SVG":
                        str = "image/svg+xml";
                        break;
                }
            }
            return str;
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
        private static string? GetAddressType(LogisticDbContext _dblogisticContext, int? addressid)
        {
            var addr_type = _dblogisticContext.Sm_Address.Where(x => x.addressid == addressid).Select(a => a.addr_type).FirstOrDefault();
            return addr_type;
        }
    }
    

    public class adminresponseMessage
    {
        public object data { get; set; }
        public string status { get; set; }
        public bool isSuccess { get; set; }
        public string message { get; set; }
    }
    public class MicrosoftUserModal
    {
        public string? sigmakey { get; set; }
        public string? emailid { get; set; }
        public string? nucleus { get; set; }
        public string? aio { get; set; }
        public string? rh { get; set; }
        public string? uti { get; set; }

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
                setlog("Error in EncryptID() : " + ex.Message);
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
                setlog("Error in DecryptID() : " + ex.Message);
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
    public class USERTYPE
    {
        public string? moduleId { get; set; }
        public string? SelectedValue { get; set; }
    }
}