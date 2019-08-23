using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.DTOs
{
    public class LiteVersionDTO : SharedEntitiesDTO
    {
        public string Comment { get; set; }
        public string ReleaseNumber { get; set; }
        public Guid? ComponentId { get; set; }
    }
    public class VersionDTO : LiteVersionDTO
    {
        public ComponentDTO Component { get; set; }
    }
}
