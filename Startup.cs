using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mod04_01.Startup))]
namespace Mod04_01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
