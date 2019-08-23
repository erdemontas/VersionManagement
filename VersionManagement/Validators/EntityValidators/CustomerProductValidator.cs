using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.Validators.EntityValidators
{
    public class CustomerProductValidator : AbstractValidator<CustomerProduct>
    {
        public CustomerProductValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
        }
        
    }
}
