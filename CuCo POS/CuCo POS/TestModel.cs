using CuCo_POS.Entities;
using System;
using System.Data.Entity;
using System.Linq;

namespace CuCo_POS
{
    public class TestModel : DbContext
    {
        // Your context has been configured to use a 'TestModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CuCo_POS.TestModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'TestModel' 
        // connection string in the application configuration file.
        public TestModel()
            : base("name=CuCoPOS")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public DbSet<Discount> Discounts { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}