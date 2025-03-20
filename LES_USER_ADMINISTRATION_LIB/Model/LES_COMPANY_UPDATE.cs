using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_COMPANY_UPDATE
    {
        public int companyid { get; set; }
        public string? companydescription { get; set; }
        public string? companycode { get; set; }
        public int? addressid { get; set; }
        public string? mainlogo { get; set; }
        public string? mainlogofilename {  get; set; }
        public string? printlogo { get; set; }
        public string? printlogofilename { get; set; }
        public string? faviconlogo { get; set; }
        public string? faviconlogofilename { get; set; }

    }
}
