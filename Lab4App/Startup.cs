using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab4App.Startup))]
namespace Lab4App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
