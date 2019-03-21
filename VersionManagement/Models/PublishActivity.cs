using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class PublishActivity : SharedEntities
    {
        public int CustomerProductId { get; set; }
        public int VersionId { get; set; }
    }
}
