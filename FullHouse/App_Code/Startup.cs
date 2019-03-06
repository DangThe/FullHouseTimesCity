using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullHouse.Startup))]
namespace FullHouse
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
