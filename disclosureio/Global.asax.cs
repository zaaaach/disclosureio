using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace disclosureio
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // https://stackoverflow.com/questions/16922952/system-nullreferenceexception-object-reference-not-set-to-an-instance-of-an-obj
            HttpEncoder.Current = HttpEncoder.Default;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
