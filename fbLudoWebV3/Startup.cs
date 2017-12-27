using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(fbLudoWebV3.Startup))]
namespace fbLudoWebV3
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
