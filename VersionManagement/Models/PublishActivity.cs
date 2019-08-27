using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class PublishActivity : SharedEntities
    {
        public virtual CustomerProduct CustomerProduct { get; set; }    //Foreign Key
        public Guid? CustomerProductId { get; set; }
        public virtual Version Version { get; set; }    //Foreign Key
        public Guid? VersionId { get; set; }
    }
}
