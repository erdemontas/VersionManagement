using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.DTOs
{
    public class LitePublishActivityDTO : SharedEntitiesDTO
    {
        public Guid? CustomerProductId { get; set; }
        public Guid? VersionId { get; set; }
    }
    public class PublishActivityDTO : LitePublishActivityDTO
    {
        public CustomerProductDTO CustomerProduct { get; set; }
        public VersionDTO Version { get; set; }
    }
}
