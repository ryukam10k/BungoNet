using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BungoNet.Startup))]
namespace BungoNet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
