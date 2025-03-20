using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_MODULE
    {
        [Key]
        public int moduleid { get; set; }
        public int? applicationid { get; set; }
        public string? module_code { get; set; }
        public string? module_desc { get; set; }

    }
}
