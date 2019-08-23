using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.DTOs
{
    public class ComponentTypeDTO : SharedEntitiesDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
