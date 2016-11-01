using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WoWCharMgr.Startup))]
namespace WoWCharMgr
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
