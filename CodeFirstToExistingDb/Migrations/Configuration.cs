using System.Collections.ObjectModel;

namespace CodeFirstToExistingDb.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstToExistingDb.PlutoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstToExistingDb.PlutoContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Authors.AddOrUpdate(a => a.Name,
                new Authors
                {
                    Name = "Author 1",
                    Courses = new Collection<Course>()
                    {
                        new Course() { Name = "Course for Author 1", Description="Description"}
                    }
                });
        }
    }
}
