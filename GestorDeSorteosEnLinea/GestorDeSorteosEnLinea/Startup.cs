using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GestorDeSorteosEnLinea.Startup))]
namespace GestorDeSorteosEnLinea
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
