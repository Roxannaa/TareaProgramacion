using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TareaProg4.Startup))]
namespace TareaProg4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
