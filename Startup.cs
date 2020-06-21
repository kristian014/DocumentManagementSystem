using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DocumentManagementSystem.Startup))]
namespace DocumentManagementSystem
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
