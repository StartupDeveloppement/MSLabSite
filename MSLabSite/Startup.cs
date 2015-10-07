using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSLabSite.Startup))]
namespace MSLabSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
