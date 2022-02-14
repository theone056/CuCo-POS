using CuCo_POS.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuCo_POS.DBContext
{
    public class POSContext: DbContext
    {
        public POSContext()
        {

        }

        public DbSet<MenuList> MenuLists { get; set; }
        public DbSet<SupplierList> SupplierLists { get; set; }
        public DbSet<ItemInventory> ItemInventories { get; set; }
        public DbSet<EmployeeList> employeeLists { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<ItemUnit> ItemUnits { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Discount> Discounts { get; set; }
    }
}
