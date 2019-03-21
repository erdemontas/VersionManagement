using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class Version:SharedEntities
    {
        public int ComponentId { get; set; }
        public string Comment { get; set; }
        public string ReleaseNumber { get; set; }
    }
}
