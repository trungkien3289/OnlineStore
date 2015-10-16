using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStore.UI.Web.MVC.Startup))]
namespace OnlineStore.UI.Web.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
