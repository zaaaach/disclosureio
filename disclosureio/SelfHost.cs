using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio
{
    class SelfHost
    {
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
    }
}
