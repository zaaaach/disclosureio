using disclosureio.ViewModels;
using Nancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio.Modules
{
    public class UserModule : NancyModule
    {
        public UserModule()
        {
            Get["/login"] = Login;
            Post["/login"] = LoginPost;
        }

        private dynamic Login(dynamic _)
        {
            return View["Login", new LoginViewModel()];
        }

        private dynamic LoginPost(dynamic _)
        {
            return View["Login", new LoginViewModel()];
        }
    }
}
