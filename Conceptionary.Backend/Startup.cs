using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Conceptionary.Backend.Startup))]
namespace Conceptionary.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
