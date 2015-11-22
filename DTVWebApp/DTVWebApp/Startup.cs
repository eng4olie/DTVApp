using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DTVWebApp.Startup))]
namespace DTVWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
