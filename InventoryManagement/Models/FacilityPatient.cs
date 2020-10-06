using System;
using System.Collections.Generic;

namespace InventoryManagement.Models
{
    public partial class FacilityPatient
    {
        public int Id { get; set; }
        public int FacilityID { get; set; }
        public int PatientId { get; set; }
    }
}
