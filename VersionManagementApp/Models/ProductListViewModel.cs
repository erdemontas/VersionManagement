using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.DTOs;

namespace VersionManagementApp.Models
{
    public class ProductListViewModel
    {
        IEnumerable<ProductDTO> Products { get; set; }
    }
}
