using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Mast_SITE_CONFIG
    {
        #region Instance Properties
        [Key]
        public int siteconfigid { get; set; }

        public int? moduleid { get; set; }

        public int? siteid { get; set; }

        public int? companyid { get; set; }

        public int? siteconfig_paramid { get; set; }

        public string siteconfig_param_code { get; set; }

        public string param_value { get; set; }

        public DateTime? created_date { get; set; }

        public DateTime? update_date { get; set; }

        #endregion Instance Properties
    }
}
