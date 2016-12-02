using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AsyncController.Startup))]
namespace AsyncController
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
