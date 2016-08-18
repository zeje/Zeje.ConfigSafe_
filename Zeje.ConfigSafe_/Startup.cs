using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Zeje.ConfigSafe_.Startup))]
namespace Zeje.ConfigSafe_
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
