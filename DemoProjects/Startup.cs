using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoProjects.Startup))]
namespace DemoProjects
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
