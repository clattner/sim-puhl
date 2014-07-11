using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(simpuhl2.Startup))]
namespace simpuhl2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
