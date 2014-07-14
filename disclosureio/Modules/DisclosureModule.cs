using disclosureio.ViewModels;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio.Modules
{
    public class DisclosureModule : NancyModule
    {
        public DisclosureModule()
        {
            Get["/disclosures"] = Index;
            Get["/disclosures/submit"] = Submit;
            //Post["/discosures/submit2"] = Submit2;
            //Post["/discosures/submit3"] = Submit3;
        }

        public dynamic Index(dynamic _)
        {
            return View["Index", new DisclosureViewModel()];
        }

        public dynamic Submit(dynamic _)
        {
            return View["Submit", new BaseViewModel("Submit")];
        }
    }
}
