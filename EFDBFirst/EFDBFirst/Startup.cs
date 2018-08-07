using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EFDBFirst.Startup))]
namespace EFDBFirst
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
