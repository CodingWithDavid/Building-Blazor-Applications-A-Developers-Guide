using System.ComponentModel.DataAnnotations;

namespace Chapter3.Attributes
{
    public class CustomValidatorAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if (value!.ToString() == "Test")
                {
                    return ValidationResult.Success!;
                }
            }
            return new ValidationResult("Value is not Test");
        }
    }
}
