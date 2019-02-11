﻿using Company.Core.Entities;
using Company.Project.Entities.Concrete.ClientManagment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Company.Project.Entities.Concrete.HumanResources
{
    public class Unit : BaseEntity
    {
        public Organisation Organisation { get; set; }
        public Branch Branch { get; set; }

        public string Name { get; set; }
    }
}