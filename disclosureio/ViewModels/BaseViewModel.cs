using disclosureio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio.ViewModels
{
    public class BaseViewModel
    {
        public UserPermissionEnum UserPermission { get; set; }
        public string UserName { get; set; }

        public string CurrentPage { get; set; }

        public bool DiagnosticsEnabled { get; set; }

        public BaseViewModel(string pageName)
        {
            CurrentPage = pageName;
            UserPermission = UserPermissionEnum.Anonymous;
            DiagnosticsEnabled = Properties.Settings.Default.DiagnosticsEnabled;
        }
    }
}
