namespace KendoUILearn.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using KendoUILearn.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<KendoUILearn.Models.CustomDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(KendoUILearn.Models.CustomDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var studentList = new StudentModel[]{
                new StudentModel{Name = "libin",Sex="m",Age=22,Address="schuan",Tel="123123"},
                new StudentModel{Name = "zhaoxiao",Sex="m",Age=21,Address="schuan",Tel="667"},
                new StudentModel{Name = "zhangfei",Sex="f",Age=24,Address="schuan",Tel="12223123"},
                new StudentModel{Name = "liubei",Sex="m",Age=21,Address="schuan",Tel="12312234323"},
                new StudentModel{Name = "libai",Sex="f",Age=23,Address="schuan",Tel="2234"}
            };

            foreach(var o in studentList)
            {
                context.Students.AddOrUpdate(
                    s => s.Id,
                    new StudentModel { Name=o.Name,Sex=o.Sex,Age=o.Age,Address=o.Address,Tel=o.Tel}
                    );
            }
        }
    
    }
}
