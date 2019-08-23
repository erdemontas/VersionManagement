﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Interfaces;
using VersionManagement.Models;

namespace VersionManagement.Repositories
{
    public class ProductRepository : RepositoryBase<Product> , IProductRepository
    {
        public ProductRepository(VManagementContext vmContext) : base(vmContext)
        {

        }
    }
}
