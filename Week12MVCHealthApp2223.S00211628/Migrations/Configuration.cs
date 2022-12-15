namespace Week12MVCHealthApp2223.S00211628.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tracker.WebAPIClient;
    using Week12MVCHealthApp2223.S00211628.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Week12MVCHealthApp2223.S00211628.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week12MVCHealthApp2223.S00211628.Models.ApplicationDbContext context)
        {
            ActivityAPIClient.Track(StudentID: "S00211628", StudentName: "Martin Melody", activityName: "Rad301 2223 Week 12Lab", Task: "Testing Login MVC App");

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Admin" });

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "Doctor" });

            context.Roles.AddOrUpdate(r => r.Name,
                new IdentityRole { Name = "LabTech" });

            PasswordHasher ps = new PasswordHasher();

            context.Users.AddOrUpdate(u => u.UserName,
                new ApplicationUser
                {
                    EntityID = "Admin",
                    UserName = "admin@SUH.ie",
                    Email = "Admin@suh.ie",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    PasswordHash = ps.HashPassword("TheAdmin$1")
                });
        }
    }
}
