using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mobileweb.Startup))]
namespace mobileweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
