using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutodijeloviAsp.Startup))]
namespace AutodijeloviAsp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
