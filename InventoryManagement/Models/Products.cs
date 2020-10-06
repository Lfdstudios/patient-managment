using System;
using System.Collections.Generic;

namespace InventoryManagement.Models
{
    public partial class Products
    {
        public int ProductId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public string History { get; set; }

    }
}
