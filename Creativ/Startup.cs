using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Creativ.Startup))]
namespace Creativ
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
