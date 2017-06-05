using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DOAN_WEB2.Startup))]
namespace DOAN_WEB2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
