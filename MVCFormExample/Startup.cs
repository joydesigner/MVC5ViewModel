using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFormExample.Startup))]
namespace MVCFormExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
