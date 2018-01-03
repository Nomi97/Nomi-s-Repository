using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GCF.Startup))]
namespace GCF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
