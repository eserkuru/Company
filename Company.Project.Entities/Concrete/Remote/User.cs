using Company.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.Remote
{
    public class User : BaseEntity
    {
        public Account Account { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string OldPassword { get; set; }
        public DateTime LastChangedDate { get; set; }
    }
}
