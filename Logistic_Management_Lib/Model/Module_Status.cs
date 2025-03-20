using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{

    public class Mast_STATUSES
    {
        #region Instance Properties
        [Key]
        public int statusid { get; set; }

        public string? status_desc { get; set; }

        #endregion Instance Properties
    }

    public class Module_Status
    {
        #region Instance Properties
        [Key]
        public int module_statusid { get; set; }

        public int? statusid { get; set; }

        public int? moduleid { get; set; }

        public int? status_level { get; set; }

        #endregion Instance Properties
    }

    public class V_MODULE_STATUSES
    {
        #region Instance Properties
        [Key]
        public int statusid { get; set; }

        public string? status_desc { get; set; }

        public int? moduleid { get; set; }

        public int? status_level { get; set; }

        #endregion Instance Properties
    }
}
