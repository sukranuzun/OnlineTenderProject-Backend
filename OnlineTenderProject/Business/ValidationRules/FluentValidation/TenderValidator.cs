using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class TenderValidator : AbstractValidator<Tender>
    {
        public TenderValidator()
        {
            RuleFor(t => t.UnitPrice).GreaterThan(0);
        }
    }
}
