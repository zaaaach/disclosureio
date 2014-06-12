using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(disclosureio.Startup))]
namespace disclosureio
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
