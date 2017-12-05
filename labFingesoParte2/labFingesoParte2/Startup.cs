using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(labFingesoParte2.Startup))]
namespace labFingesoParte2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
