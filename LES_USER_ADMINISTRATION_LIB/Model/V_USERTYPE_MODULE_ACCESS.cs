using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class V_USERTYPE_MODULE_ACCESS
    {
        [Key]
        public long RowNumber { get; set; }
        public int? MODULEACCESSID { get; set; }
        public int? USERTYPEID { get; set; }
        public int? MODULEID { get; set; }
        public int? ACCESS_LEVEL { get; set; }
        public string? USERTYPEDESCR { get; set; }
        public string? Module_Desc { get; set; }
        public string? ACCESS_VALUE_TEXT { get; set; }
    }
}
