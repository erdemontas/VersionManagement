using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VersionManagement.Validators.EntityValidators
{
    public class VersionValidator : AbstractValidator<Models.Version>
    {
        public VersionValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
            RuleFor(x => x.Comment).Length(1, 600);
            RuleFor(x => x.ReleaseNumber).Length(1, 40);
        }
    }
}
