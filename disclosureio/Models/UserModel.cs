using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disclosureio.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

    }

    public enum UserPermissionEnum
    {
        Anonymous,
        User,
        Admin
    }
}
