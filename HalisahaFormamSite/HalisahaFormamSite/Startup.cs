using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HalisahaFormamSite.Startup))]
namespace HalisahaFormamSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
