using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class CustomerProduct:SharedEntities
    {
        public virtual Customer Customer { get; set; }  //Foreign Key
        public Guid? CustomerId { get; set; }
        public virtual Product Product { get; set; }    //Foreign Key
        public Guid? ProductId { get; set; }
        public virtual Version LastVersion { get; set; }    //Foreign Key
        public Guid? LastVersionId { get; set; }
    }   
}
