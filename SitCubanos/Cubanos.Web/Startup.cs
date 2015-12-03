using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cubanos.Web.Startup))]
namespace Cubanos.Web
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
