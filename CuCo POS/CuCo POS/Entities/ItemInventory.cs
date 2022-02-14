using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.Entities
{
    public class ItemInventory
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public int ItemQty { get; set; }
        public int UnitID { get; set; }
        public double ItemCost { get; set; }
        public SupplierList SupplierID { get; set; }
        public bool inStock { get; set; }
    }
}
