using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Epod_Access_Log
    {
        #region Instance Properties
        [Key]
        public int logid { get; set; }

        public int? userid { get; set; }

        public int? shipmentid { get; set; }

        public string? emailid { get; set; }

        public DateTime? created_date { get; set; }

        public string? location_lat { get; set; }

        public string? location_long { get; set; }
        public DateTime? shipped_date { get; set; }
		public DateTime? verified_date { get; set; }
		public DateTime? confirm_date { get; set; }
		public string? vesselimo { get; set; }
		public string? role { get; set; }
		public string? user_name { get; set; }


		#endregion Instance Properties
	}

}
