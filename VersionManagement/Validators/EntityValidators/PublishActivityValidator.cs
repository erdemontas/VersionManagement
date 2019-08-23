using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VersionManagement.Models;

namespace VersionManagement.Validators.EntityValidators
{
    public class PublishActivityValidator : AbstractValidator<PublishActivity>
    {
        public PublishActivityValidator()
        {
            RuleFor(x => x.ModifiedDate).GreaterThanOrEqualTo(x => x.CreatedDate);
        }
    }
}
