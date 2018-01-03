namespace GCF.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GCF.Models.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GCF.Models.DatabaseContext";
        }

        protected override void Seed(GCF.Models.DatabaseContext context)
        {
            context.Members.AddOrUpdate(member => member.Name,
                new Models.MembersModel { Name = "Tibor", Email = "tibor.gencel@gcf-consulting.com", About = "Does some stuff", Telephone = "+42425242",  ImageUrl= "http://colepartners.net/wp-content/uploads/2014/10/Dollarphotoclub_69536992-2-1030x770.jpg" },
                new Models.MembersModel { Name = "Sven", Email = "tibor.gencel@gcf-consulting.com", About = "Does some stuff", Telephone = "+42425242", ImageUrl = "http://colepartners.net/wp-content/uploads/2014/10/Dollarphotoclub_69536992-2-1030x770.jpg" },
                new Models.MembersModel { Name = "Carl", Email = "tibor.gencel@gcf-consulting.com", About = "Does some stuff", Telephone = "+42425242", ImageUrl = "http://colepartners.net/wp-content/uploads/2014/10/Dollarphotoclub_69536992-2-1030x770.jpg" }
                



            );


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
        }
    }
}
