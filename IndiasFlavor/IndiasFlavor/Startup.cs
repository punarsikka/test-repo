using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndiasFlavor.Startup))]
namespace IndiasFlavor
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
