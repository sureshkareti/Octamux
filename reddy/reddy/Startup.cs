using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(reddy.Startup))]
namespace reddy
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
