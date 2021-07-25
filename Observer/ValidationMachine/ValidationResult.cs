using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ValidationMachine
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> ErrorMessages { get; set; } = new List<string>();
    }
}
