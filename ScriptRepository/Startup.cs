using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ScriptRepository.Startup))]
namespace ScriptRepository
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
