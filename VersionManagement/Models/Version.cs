using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class Version:SharedEntities
    {     
        public Component Component { get; set; }    //Foreign Key
        public string Comment { get; set; }
        public string ReleaseNumber { get; set; }
    }
}
