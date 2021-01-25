using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TeachingVidly.Startup))]
namespace TeachingVidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
