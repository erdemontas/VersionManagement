using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.DTOs
{
    public class LiteCustomerProductDTO : SharedEntitiesDTO
    {
        public Guid? CustomerId { get; set; }
        public Guid? ProductId { get; set; }
        public Guid? LastVersionId { get; set; }
    }
    public class CustomerProductDTO : LiteCustomerProductDTO
    {
        public CustomerDTO Customer { get; set; }
        public ProductDTO Product { get; set; }
        public VersionDTO LastVersion { get; set; }
    }
}
