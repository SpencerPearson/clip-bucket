using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClipBucket.UI.MVC.Startup))]
namespace ClipBucket.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
