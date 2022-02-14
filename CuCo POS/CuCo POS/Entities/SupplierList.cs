using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class SupplierList
    {
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierOwner { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public bool isActive { get; set; }

        public ICollection<ItemInventory> ItemInventory { get; set; }
    }
}
