﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class ComponentType : SharedEntities
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
