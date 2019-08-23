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
        public Customer Customer { get; set; }
        public Product Product { get; set; }
        public Models.Version LastVersion { get; set; }
    }
}
