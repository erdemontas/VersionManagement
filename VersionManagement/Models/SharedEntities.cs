using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class SharedEntities
    {
        public long Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
