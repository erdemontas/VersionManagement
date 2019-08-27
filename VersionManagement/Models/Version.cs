using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class Version:SharedEntities
    {
        public virtual Component Component { get; set; }    //Foreign Key
        public Guid? ComponentId { get; set; }
        public string Comment { get; set; }
        public string ReleaseNumber { get; set; }
    }
}
