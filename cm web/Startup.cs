using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cm_web.Startup))]
namespace cm_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
