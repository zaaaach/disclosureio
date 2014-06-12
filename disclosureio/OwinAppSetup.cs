using Fos;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio.Startup
{
    public static class OwinAppSetup
    {
        private static void ConfigureOwin(IAppBuilder builder)
        {
            builder.UseNancy();
        }

        public static void Main(string[] args)
        {
            using (var fosServer = new FosSelfHost(ConfigureOwin))
            {
                fosServer.Bind(System.Net.IPAddress.Loopback, 9000);
                //fosServer.Bind("/tmp/disclosureiofcgi.sock");
                fosServer.Start(false);
            }
        }
    }
}
