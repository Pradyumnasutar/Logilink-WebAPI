using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_USERTYPE
    {
        [Key]
        public int usertypeid { get; set; }
        public string? usertypedescr { get; set; }
        public int? usertype_level { get; set; }
        public DateTime? update_date { get; set; }
        public DateTime? created_date { get; set; }
    }
}
