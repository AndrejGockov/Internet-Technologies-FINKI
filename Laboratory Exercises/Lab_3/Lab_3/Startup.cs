using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab_3.Startup))]
namespace Lab_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
