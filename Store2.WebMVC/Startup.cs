using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Store2.WebMVC.Startup))]
namespace Store2.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
