using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class Component : SharedEntities
    {
        public string Name { get; set; }
        public Product Product { get; set; }    //Foreign Key
        public string Type { get; set; }



    }
}
