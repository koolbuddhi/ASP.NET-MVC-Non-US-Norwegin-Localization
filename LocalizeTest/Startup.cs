using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LocalizeTest.Startup))]
namespace LocalizeTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
