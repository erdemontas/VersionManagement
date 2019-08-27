using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.DTOs
{
    public class ProductDTO : SharedEntitiesDTO
    {
        public string Name { get; set; }
        public List<ComponentDTO> Components { get; set; }
    }
}