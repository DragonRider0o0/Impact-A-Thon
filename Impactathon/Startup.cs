using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Impactathon.Startup))]
namespace Impactathon
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
