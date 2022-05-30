using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1911062483_phamvanhoailoc.Startup))]
namespace _1911062483_phamvanhoailoc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
