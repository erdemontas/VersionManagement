using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Models
{
    public class ChangeLog : SharedEntities
    {
        public string Title { get; set; }
        public Version Version { get; set; }      //Foreign Key   
        public string Description { get; set; }
        public Guid TypeId { get; set; }
        public ChangeLogType ChangeLogType { get; set; }    //Foreign Key
    }
}
