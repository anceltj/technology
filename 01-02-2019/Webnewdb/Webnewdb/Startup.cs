using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Webnewdb.Startup))]
namespace Webnewdb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
