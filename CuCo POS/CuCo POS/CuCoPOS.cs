using CuCo_POS.Entities;
using MySql.Data.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace CuCo_POS
{
    // Code-Based Configuration and Dependency resolution  
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CuCoPOS : DbContext
    {
        // Your context has been configured to use a 'CuCoPOS' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CuCo_POS.CuCoPOS' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CuCoPOS' 
        // connection string in the application configuration file.
        public CuCoPOS()
            : base("CuCoPOS")
        {
        }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<MenuList> MenuLists { get; set; }
        public DbSet<SupplierList> SupplierLists { get; set; }
        public DbSet<ItemInventory> ItemInventories { get; set; }
        public DbSet<EmployeeList> employeeLists { get; set; }
        public DbSet<UserList> UserLists { get; set; }
        public DbSet<MenuType> MenuTypes { get; set; }
        public DbSet<ItemUnit> ItemUnits { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}