using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FullCalenderIO.Startup))]
namespace FullCalenderIO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
