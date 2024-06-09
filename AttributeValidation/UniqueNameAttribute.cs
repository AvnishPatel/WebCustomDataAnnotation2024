using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebCustomDataAnnotation2024.AttributeValidation
{
    public class UniqueNameAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            // Here "allen" is hardcoded, but we can use Database call to check Name is exists
            if (value != null)
            {
                if (value.ToString().ToLower() == "allen")
                {
                    var errorMessage = FormatErrorMessage(validationContext.DisplayName);
                    return new ValidationResult(errorMessage);
                }
                return ValidationResult.Success;
            }

            return ValidationResult.Success;
        }
    }
}