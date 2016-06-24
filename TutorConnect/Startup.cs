using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TutorConnect.Startup))]
namespace TutorConnect
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
