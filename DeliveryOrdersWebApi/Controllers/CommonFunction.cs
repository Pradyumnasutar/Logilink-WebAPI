using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Text;
using DeliveryOrdersWebApi.DAL;
using LeSDataMain;
using Newtonsoft.Json;

namespace DeliveryOrdersWebApi.Controllers
{
    public class CommonFunction
    {
        public IConfiguration configuration;
        public static void setLog(string msg)
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

        public static void SetAudit(string ModuleName,string Action,string FileName,string Log_msg,string refNo)
        {
            try
            {
                    LeSDataMain.LeSDM.SetAuditLogFile(ModuleName, Action, FileName, Log_msg, "", refNo, "", "");
            }
            catch(Exception ex)
            {
                CommonFunction.setLog("Error on SetAudit : " + ex.Message + " Stack Trace : " + ex.StackTrace);
            }

        }

        public static bool Check_AUTHENTICATION_KEY(string authkey)
        {
            bool result = false;
            try
            {
                var configBuilder = new ConfigurationBuilder()
   .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
                var configuration = configBuilder.Build();

                string hkey = configuration.GetSection("AppSettings").GetSection("AUTHENTICATION_KEY_SECRET_WORD").Value;
               
                byte[] bytearr = Convert.FromBase64String(authkey);
                string encptData = Encoding.UTF8.GetString(bytearr);
                string dycriptData = GlobalTools.DecodePassword(encptData);

                if (hkey != "")
                {
                    string dt = DateTime.Now.ToString("d-M-yyyy");
                    string dtyester = DateTime.Now.AddDays(-1).ToString("d-M-yyyy");
                    string dttomm = DateTime.Now.AddDays(1).ToString("d-M-yyyy");
                    if (dycriptData.ToUpper().StartsWith(dt + "#" + hkey.ToUpper() + "#"))
                    {
                        result = true;
                        return result;
                    }
                    else if (dycriptData.ToUpper().StartsWith(dtyester + "#" + hkey.ToUpper() + "#"))
                    {
                        result = true;
                        return result;
                    }
                    else if (dycriptData.ToUpper().StartsWith(dttomm + "#" + hkey.ToUpper() + "#"))
                    {
                        result = true;
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                CommonFunction.setLog("Error on Check_AUTHENTICATION_KEY : " + ex.Message + " Stack Trace : " + ex.StackTrace);
                throw ex;
            }
            return result;
        }

        public static void Set_Client_Data_on_Log(object _data)
        {
            try
            {
                var configBuilder = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
                var configuration = configBuilder.Build();
                string clientVal = convert.ToString(configuration.GetSection("AppSettings").GetSection("SHOW_CLIENT_POST_DATA").Value).ToUpper();
                if (clientVal == "YES")
                {
                    string _dataValueStr = JsonConvert.SerializeObject(_data);
                    CommonFunction.setLog("Data : " + _dataValueStr);
                }
            }
            catch (Exception ex)
            {
                setLog("Error on Set_Client_Data_on_Log : " + ex.Message);
            }
        }

        public static void Set_Client_Data_on_Log_Authentication(object _data, string AUTHENTICATION_KEY ="")
        {
            try
            {
                var configBuilder = new ConfigurationBuilder()
       .SetBasePath(Directory.GetCurrentDirectory())
       .AddJsonFile("AppSettings.json", optional: true, reloadOnChange: true);
                var configuration = configBuilder.Build();
                string clientVal = convert.ToString(configuration.GetSection("AppSettings").GetSection("SHOW_CLIENT_POST_DATA").Value).ToUpper();
                if (clientVal == "YES")
                {
                    if (AUTHENTICATION_KEY != "")
                    {
                        CommonFunction.setLog("AUTHENTICATION_KEY : " + AUTHENTICATION_KEY);
                    }
                    string _dataValueStr = JsonConvert.SerializeObject(_data);
                    CommonFunction.setLog("Data : " + _dataValueStr);
                }
            }
            catch (Exception ex)
            {
                setLog("Error on Set_Client_Data_on_Log : " + ex.Message);
            }
        }
    }
}
