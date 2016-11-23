using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Curso_udemy.Startup))]
namespace Curso_udemy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
