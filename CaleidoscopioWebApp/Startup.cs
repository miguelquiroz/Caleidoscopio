using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CaleidoscopioWebApp.Startup))]
namespace CaleidoscopioWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
