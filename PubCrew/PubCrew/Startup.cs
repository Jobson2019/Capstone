using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PubCrew.Startup))]
namespace PubCrew
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
