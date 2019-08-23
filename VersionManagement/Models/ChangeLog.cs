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
        public Guid? VersionId { get; set; }
        public string Description { get; set; }
        public ChangeLogType ChangeLogType { get; set; }    //Foreign Key
        public Guid? ChangeLogTypeId { get; set; }

    }
}
