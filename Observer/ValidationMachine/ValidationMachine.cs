using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ValidationMachine
{
    public interface IValidationMachine
    {
        void AddValidationPolicy(IValidationPolicy validationPolicy);
        ValidationResult Validate(); 
    }
    public class ValidationMachine : IValidationMachine
    {
        private readonly List<IValidationPolicy> _validationPolicies = new List<IValidationPolicy>();

        public void AddValidationPolicy(IValidationPolicy validationPolicy)
        {
            _validationPolicies.Add(validationPolicy);
        }

        public ValidationResult Validate()
        {
            var validationResult = new ValidationResult
            {
                IsValid = true
            };
            foreach(var validationPolicy in _validationPolicies)
            {
                var res = validationPolicy.Validate();
                validationResult.IsValid = res.IsValid && validationResult.IsValid;
                validationResult.ErrorMessages.AddRange(res.ErrorMessages);
            }

            return validationResult;
        }
    }
}
