using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PledDream.Startup))]
namespace PledDream
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
