using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuraProject.Startup))]
namespace AuraProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
