using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DemoPortal.Startup))]
namespace DemoPortal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
