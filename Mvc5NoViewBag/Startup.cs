using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5NoViewBag.Startup))]
namespace Mvc5NoViewBag
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
