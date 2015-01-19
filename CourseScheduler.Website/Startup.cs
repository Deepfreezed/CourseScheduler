using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CourseScheduler.Website.Startup))]
namespace CourseScheduler.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
