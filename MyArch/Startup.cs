using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyArch.Startup))]
namespace MyArch
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
