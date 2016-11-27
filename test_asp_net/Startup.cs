using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(test_asp_net.Startup))]
namespace test_asp_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
