using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(tp2.Startup))]
namespace tp2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
