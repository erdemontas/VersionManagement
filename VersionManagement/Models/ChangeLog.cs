using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class ChangeLog : SharedEntities
    {
        public int VersionId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
    }
}
