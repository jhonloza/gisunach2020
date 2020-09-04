using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(gisunachweb.Startup))]
namespace gisunachweb
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
