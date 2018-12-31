﻿using Company.Core.Entities;
using System;

namespace Company.Project.Entities.Concrete.Remote
{
    public class Configuration : BaseEntity
    {
        public Account Account { get; set; }

        public string DomainServer { get; set; }
        public string DomainUsername { get; set; }
        public string DomainPassword { get; set; }
        public string DatabaseServer { get; set; }
        public string InitialName { get; set; }
        public string DatabaseUsername { get; set; }
        public string DatabasePassword { get; set; }
    }
}
