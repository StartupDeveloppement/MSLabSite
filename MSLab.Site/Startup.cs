using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MSLab.Startup))]
namespace MSLab
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
