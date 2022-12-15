namespace Week12MVCHealthApp2223.S00211628.Migrations
{
    using Microsoft.Ajax.Utilities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tracker.WebAPIClient;
    using Week12HealthDomain2223.S00211628.Models;
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

            var manager =
               new UserManager<ApplicationUser>(
                   new UserStore<ApplicationUser>(context));

            var roleManager =
                new RoleManager<IdentityRole>(
                    new RoleStore<IdentityRole>(context));

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

            seed_doctors_roles(manager, context);
        }

        private void seed_doctors_roles(UserManager<ApplicationUser> manager, ApplicationDbContext context)
        {


            using(HealthContext db = new HealthContext())
            {

            }

          using (HealthContext db = new HealthContext())
            {

                db.Doctors.ForEach(d =>
                {
                    IdentityResult result = manager.Create(new ApplicationUser
                    {
                        EntityID = "Doctor",
                        Email = d.Email,
                        UserName = d.Email,
                        EmailConfirmed = true,
                        SecurityStamp = Guid.NewGuid().ToString(),
                    }, d.FirstName + "$1"); ;
                    if (result.Succeeded)
                    {
                        ApplicationUser doctor = manager.FindByEmail(d.Email);
                        if (doctor != null)
                        {
                            manager.AddToRoles(doctor.Id, new string[] { "Doctor" });
                        }
                    }
                });

            }
        }
    }
}
