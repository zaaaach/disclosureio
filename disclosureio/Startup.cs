using Nancy.Hosting.Self;
using Fos;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio
{
    class Startup
    {
#if DEBUG
        public static void Main(string[] args)
        {
            var config = new HostConfiguration
            {
                UrlReservations =
                {
                    CreateAutomatically = true
                }
            };
            using (var host = new NancyHost(config, new Uri("http://localhost:8888")))
            {
               
                host.Start();
                Console.ReadLine();
            }
        }
#else
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
#endif
    }
}
