using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShotgeneratorProject.Web.Startup))]
namespace ShotgeneratorProject.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
