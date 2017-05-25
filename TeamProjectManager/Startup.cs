using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeamProjectManager.Startup))]
namespace TeamProjectManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
