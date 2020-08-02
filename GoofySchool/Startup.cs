using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoofySchool.Startup))]
namespace GoofySchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
