using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(logisticTracker.Web.Startup))]
namespace logisticTracker.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
