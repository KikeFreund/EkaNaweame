using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OfficialEkaNaweame.Startup))]
namespace OfficialEkaNaweame
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
