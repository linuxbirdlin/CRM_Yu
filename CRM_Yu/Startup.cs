using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CRM_Yu.Startup))]
namespace CRM_Yu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
