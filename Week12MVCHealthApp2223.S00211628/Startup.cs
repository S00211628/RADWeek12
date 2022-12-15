using Microsoft.Owin;
using Owin;
using Tracker.WebAPIClient;

[assembly: OwinStartupAttribute(typeof(Week12MVCHealthApp2223.S00211628.Startup))]
namespace Week12MVCHealthApp2223.S00211628
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            ActivityAPIClient.Track(StudentID: "S00211628", StudentName: "Martin Melody", activityName: "Rad301 2223 Week 12Lab", Task: "Implementing Doctor Patient Controller");


        }
    }
}
