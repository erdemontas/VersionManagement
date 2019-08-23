using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class CustomerProduct:SharedEntities
    {
        public Customer Customer { get; set; }  //Foreign Key
        public Guid? CustomerId { get; set; }
        public Product Product { get; set; }    //Foreign Key
        public Guid? ProductId { get; set; }
        public Version LastVersion { get; set; }    //Foreign Key
        public Guid? LastVersionId { get; set; }
    }   
}
