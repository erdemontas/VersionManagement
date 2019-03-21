using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class CustomerProduct:SharedEntities
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int LastVersionId { get; set; }
    }
}
