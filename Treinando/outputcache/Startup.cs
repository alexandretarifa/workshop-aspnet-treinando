using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(outputcache.Startup))]
namespace outputcache
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
