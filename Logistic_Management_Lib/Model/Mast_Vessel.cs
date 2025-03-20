using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic_Management_Lib.Model
{
    public class Mast_Vessel
    {
        [Key]
        [Column("VESSEL_ID")]
        public int VesselId { get; set; }

        [Column("VESSEL_CODE")]
        [MaxLength(50)]
        public string? VesselCode { get; set; }

        [Column("VESSEL_NAME")]
        [MaxLength(250)]
        public string? VesselName { get; set; }

        [Column("CREATED_DATE")]
        public DateTime? CreatedDate { get; set; }

        [Column("UPDATED_DATE")]
        public DateTime? UpdatedDate { get; set; }

        [Column("CREATED_BY")]
        public int? CreatedBy { get; set; }

        [Column("UPDATED_BY")]
        public int? UpdatedBy { get; set; }

        [Column("IMO_NO")]
        public string? ImoNo { get; set; }

    }

    public class VesselDetails
    {
        public int VesselId { get; set; }

        public string? VesselCode { get; set; }

        public string? VesselName { get; set; }

        public string? ImoNo { get; set; }
    }


    public class Update_Vessels
    {
        #region Instance Properties

        public int VesselId { get; set; }

        public string? VesselCode { get; set; }

        public string? VesselName { get; set; }
        public string? ImoNo { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public int? UpdatedBy { get; set; }

        #endregion Instance Properties

    }
}
