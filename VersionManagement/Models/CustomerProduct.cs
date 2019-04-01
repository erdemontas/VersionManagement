using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class CustomerProduct:SharedEntities
    {
        public Customer Customer { get; set; }  //Foreign Key
        public Product Product { get; set; }    //Foreign Key
        public Version LastVersion { get; set; }    //Foreign Key
    }   
}
