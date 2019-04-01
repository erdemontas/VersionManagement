using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class PublishActivity : SharedEntities
    {
        
        public CustomerProduct CustomerProduct { get; set; }    //Foreign Key
        public Version Version { get; set; }    //Foreign Key
    }
}
