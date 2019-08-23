﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class Component : SharedEntities
    {
        public string Name { get; set; }
        public Product Product { get; set; }    //Foreign Key
        public Guid? ProductId { get; set; }
        public string Type { get; set; }
        public List<Version> Versions { get; set; }
    }
}
