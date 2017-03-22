using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OpenStore.Startup))]
namespace OpenStore
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
