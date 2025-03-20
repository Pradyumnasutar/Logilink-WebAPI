using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class MAST_TRANSPORT_TYPE
    {
        #region Instance Properties
        [Key]
        public int transport_type_id { get; set; }

        public string? transport_type_code { get; set; }

        public string? transport_type_description { get; set; }

        public DateTime? created_date { get; set; }
        public DateTime? updated_date { get; set; }
        public int? created_by { get; set; }
        public int? updated_by { get; set; }

        #endregion Instance Properties

    }

    public class Update_Transport_Type
    {
        #region Instance Properties
        
        public int transport_type_id { get; set; }

        public string? transport_type_code { get; set; }

        public string? transport_type_description { get; set; }

        public DateTime? updated_date { get; set; }
       
        public int? updated_by { get; set; }

        #endregion Instance Properties

    }
}
