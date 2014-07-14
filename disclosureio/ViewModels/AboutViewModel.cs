using disclosureio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public List<UserModel> Admins { get; set; }
        public List<UserModel> Moderators { get; set; }

        public AboutViewModel() : base("About")
        {
            Admins = new List<UserModel>();
            Moderators = new List<UserModel>();
        }
    }
}
