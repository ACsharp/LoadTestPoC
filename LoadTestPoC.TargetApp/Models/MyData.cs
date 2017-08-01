namespace LoadTestPoC.TargetApp.Models
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class MyData : DbContext
    {
        // Your context has been configured to use a 'MyData' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'LoadTestPoC.TargetApp.Models.MyData' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MyData' 
        // connection string in the application configuration file.
        public MyData()
            : base("name=MyData")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MyTargetEntity> TargetEntities { get; set; }
        public virtual DbSet<MySourceEntity> SourceEntities { get; set; }
    }

    public class MySourceEntity
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }

    public class MyTargetEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}