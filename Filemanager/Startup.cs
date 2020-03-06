using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Filemanager.Startup))]
namespace Filemanager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
