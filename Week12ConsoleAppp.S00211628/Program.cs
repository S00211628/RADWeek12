using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tracker.WebAPIClient;
using Week12HealthDomain2223.S00211628.Models;

namespace Week12ConsoleAppp.S00211628
{
    public class Program
    {
        static void Main(string[] args)
        {

            ActivityAPIClient.Track(StudentID: "S00211628", StudentName: "Martin Melody", activityName: "Rad301 2223 Week 12 Lab", Task: "RunningConsole App Queries");


            HealthContext db = new HealthContext();

            var query = db.Patients
                .Where(p => p.Insurance == "VHI");

            foreach (var item in query)
            {
                Console.WriteLine(item.ToString());
            }


            var doctors = db.Doctors.ToList();


            foreach (var item in doctors)
            {
                var patients = db.Patients.Where(s => s.DSS == item.DSS);
                Console.WriteLine("Doctor");
                Console.WriteLine("First Name : {0}, Second Name{1}",item.FirstName, item.SecondName);
                Console.WriteLine("=========================================================");
                Console.WriteLine("Patients");
                foreach (var pat in patients)
                {
                    Console.WriteLine("First Name {0}, SecondName {1}", pat.FirstName, pat.SecondName);
                }
                Console.WriteLine("=========================================================");

            }



            var patOver7 = db.Patients.Where(s => s.DateAdmitted.AddDays(7) < s.DateCheckedOut);

            foreach(var item in patOver7)
            {
                Console.WriteLine("Patient First Name : {0}", item.FirstName);
            }

            Console.ReadKey();

        }
    }
}
