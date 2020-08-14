using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(L01_AuthorizationAndAuthentication_HW1.Startup))]
namespace L01_AuthorizationAndAuthentication_HW1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
