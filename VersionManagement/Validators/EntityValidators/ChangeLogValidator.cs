using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.Validators.EntityValidators
{
    public class ChangeLogValidator : AbstractValidator<ChangeLog>
    {
        public ChangeLogValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Title).Length(1, 40);
            RuleFor(x => x.Description).Length(1, 40);
        }
    }
}
