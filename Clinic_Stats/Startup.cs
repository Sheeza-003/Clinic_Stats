using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Clinic_Stats.Startup))]
namespace Clinic_Stats
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
