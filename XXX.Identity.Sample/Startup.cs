using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(XXX.Identity.Sample.Startup))]
namespace XXX.Identity.Sample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
