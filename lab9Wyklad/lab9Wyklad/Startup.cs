using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab9Wyklad.Startup))]
namespace lab9Wyklad
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
