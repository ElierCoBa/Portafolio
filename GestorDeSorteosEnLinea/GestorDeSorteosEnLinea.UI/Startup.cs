using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestorDeSorteosEnLinea.UI.Startup))]
namespace GestorDeSorteosEnLinea.UI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
