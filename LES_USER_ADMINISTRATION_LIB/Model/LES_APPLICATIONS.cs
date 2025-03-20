using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LES_USER_ADMINISTRATION_LIB.Model
{
    public class LES_APPLICATIONS
    {
        [Key]
        public int applicationid { get; set; }
        public string? application_name { get; set; }
    }

   
}
