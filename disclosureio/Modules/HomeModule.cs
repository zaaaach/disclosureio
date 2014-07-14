using disclosureio.ViewModels;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace disclosureio.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["Index", new BaseViewModel("Home")];
            };
            Get["/about"] = About;
        }

        private dynamic About(dynamic _)
        {
            return View["About", new AboutViewModel()];
        }
    }
}