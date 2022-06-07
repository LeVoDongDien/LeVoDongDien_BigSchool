using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LeVoDongDien_BigSchool.Startup))]
namespace LeVoDongDien_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
