using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyShop.WebUI.Tests1.Startup))]
namespace MyShop.WebUI.Tests1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
