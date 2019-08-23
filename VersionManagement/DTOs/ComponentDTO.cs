using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.DTOs
{
    public class LiteComponentDTO : SharedEntitiesDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public Guid? ProductId { get; set; }
    }
    public class ComponentDTO : LiteComponentDTO
    {
        public ProductDTO Product { get; set; }
    }
    public class DetailedComponentDTO : ComponentDTO
    {
        public List<Version> Versions { get; set; }
    }
}
