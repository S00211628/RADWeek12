namespace Week12HealthDomain2223.S00211628.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Tracker.WebAPIClient;
    using Week12HealthDomain2223.S00211628.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Week12HealthDomain2223.S00211628.Models.HealthContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Week12HealthDomain2223.S00211628.Models.HealthContext context)
        {
            ActivityAPIClient.Track(StudentID: "S00211628", StudentName: "Martin Melody", activityName: "Rad301 2223 Week 12Lab", Task: "Seeding Health Data Model");

            Seed_Doctors(context);
            Seed_Patients(context);


            var query = context.Patients.Where(p => p.Insurance == "VHI");

            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private void Seed_Patients(HealthContext context)
        {
            context.Patients.AddOrUpdate(p => p.FirstName,
                new Patient
                {
                    DSS = 2,
                    FirstName = "Elizabeth",
                    SecondName = "Andersen",
                    Insurance = "VHI",
                    DateAdmitted = new DateTime(2020, 04, 23),
                    DateCheckedOut = new DateTime(2020, 05, 23)
                },
                new Patient
                {
                    DSS = 1,
                    FirstName = "Catherine Autier",
                    SecondName = "Miconi",
                    Insurance = "VHI",
                    DateAdmitted = new DateTime(2020, 04, 25),
                    DateCheckedOut = new DateTime(2020, 04, 27)
                },
                new Patient
                {
                    DSS = 3,
                    FirstName = "Thomas",
                    SecondName = "Axen",
                    Insurance = "BURA",
                    DateAdmitted = new DateTime(2020, 09, 03),
                    DateCheckedOut = new DateTime(2020, 09, 23)
                },
                new Patient
                {
                    DSS = 2,
                    FirstName = "Jean Phillippe",
                    SecondName = "Bagel",
                    Insurance = "Public",
                    DateAdmitted = new DateTime(2020, 06, 30),
                    DateCheckedOut = new DateTime(2020, 07, 07)
                },
                new Patient
                {
                    DSS = 4,
                    FirstName = "Anna",
                    SecondName = "Bedecs",
                    Insurance = "BURA",
                    DateAdmitted = new DateTime(2020, 01, 29),
                    DateCheckedOut = new DateTime(2020, 02, 20)
                },
                new Patient
                {
                    DSS = 5,
                    FirstName = "John",
                    SecondName = "Edwards",
                    Insurance = "VHI",
                    DateAdmitted = new DateTime(2020, 01, 20),
                    DateCheckedOut = new DateTime(2020, 02, 15)
                },
                new Patient
                {
                    DSS = 6,
                    FirstName = "Alexander",
                    SecondName = "Eggerer",
                    Insurance = "Public",
                    DateAdmitted = new DateTime(2020, 01, 27),
                    DateCheckedOut = new DateTime(2020, 02, 20)
                }
                );
        }

        private void Seed_Doctors(HealthContext context)
        {
            context.Doctors.AddOrUpdate(d => d.FirstName,
                new Doctor
                {
                    Title = "Mr",
                    FirstName = "Martin",
                    SecondName = "O'Donnell",
                    Specilization = "Paediatrics",
                    Email = "modonnell@SUH.ie"
                },
                new Doctor
                {
                    Title = "Dr",
                    FirstName = "John",
                    SecondName = "Rodman",
                    Specilization = "Geriatrics",
                    Email = "jrodman@SUH.ie"
                },
                 new Doctor
                 {
                     Title = "Dr",
                     FirstName = "Bernard",
                     SecondName = "Tham",
                     Specilization = "Infectious Diseases",
                     Email = "btham@SUH.ie"
                 },
                  new Doctor
                  {
                      Title = "Dr",
                      FirstName = "Elizabeth",
                      SecondName = "Andersen",
                      Specilization = "Intensive Care",
                      Email = "eAndersen@SUH.ie"
                  },
                   new Doctor
                   {
                       Title = "Dr",
                       FirstName = "Madeleine",
                       SecondName = "Kelley",
                       Specilization = "Brain Trauma",
                       Email = "mkelley@SUH.ie"
                   },
                    new Doctor
                    {
                        Title = "Dr",
                        FirstName = "Mikael",
                        SecondName = "Sandberg",
                        Specilization = "Geriatrics",
                        Email = "msandberg@SUH.ie"
                    });
        }
    }
}
