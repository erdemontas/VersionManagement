using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.Validators.EntityValidators
{
    public class ChangeLogTypeValidator : AbstractValidator<ChangeLogType>
    {
        public ChangeLogTypeValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Name).Length(1, 40);
            RuleFor(x => x.Description).Length(1, 600);
        }
    }
}
