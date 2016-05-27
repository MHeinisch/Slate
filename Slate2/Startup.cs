using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Slate2.Startup))]
namespace Slate2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
