using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EjemploRoles2.Startup))]
namespace EjemploRoles2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);   
        }
    }
}
