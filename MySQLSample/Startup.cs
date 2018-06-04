using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySQLSample.Startup))]
namespace MySQLSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
