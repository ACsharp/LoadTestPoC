namespace LoadTestPoC.TargetApp.Migrations
{
    using LoadTestPoC.TargetApp.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LoadTestPoC.TargetApp.Models.MyData>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LoadTestPoC.TargetApp.Models.MyData context)
        {

        }
    }
}
