using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MarkArzilloSite.Startup))]
namespace MarkArzilloSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
