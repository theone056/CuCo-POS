using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class SupplierList
    {
        [Key]
        public string SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierOwner { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhoneNumber { get; set; }
        public bool isActive { get; set; }

        [ForeignKey("ItemID")]
        public ICollection<ItemInventory> ItemInventory { get; set; }
    }
}
