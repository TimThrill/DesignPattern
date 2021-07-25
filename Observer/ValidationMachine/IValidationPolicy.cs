using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ValidationMachine
{
    public interface IValidationPolicy
    {
        ValidationResult Validate();
    }

    public class ValidationPolicy : IValidationPolicy
    {
        public ValidationPolicy(IValidationMachine validationMachine)
        {
            validationMachine.AddValidationPolicy(this);
        }

        public ValidationResult Validate()
        {
            return new ValidationResult();
        }
    }
}
