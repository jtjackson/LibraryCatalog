using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LibraryCatalogWebApp.Startup))]
namespace LibraryCatalogWebApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
