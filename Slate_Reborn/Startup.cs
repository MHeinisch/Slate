using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Slate_Reborn.Startup))]
namespace Slate_Reborn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
