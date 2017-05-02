using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DoriVLN.Startup))]
namespace DoriVLN
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
