using System.ComponentModel.DataAnnotations;

namespace UTB.Restauracia.Domain.Validations
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter)]
    public class ReservationTableValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is DateTime reservationDateTime)
            {
                if (reservationDateTime > DateTime.Now.AddHours(2))
                {
                    return ValidationResult.Success;
                }
                else
                {

                    return new ValidationResult($"The {validationContext.MemberName} needs to be 2+ hours.");

                }
            }
            return new ValidationResult($"The {validationContext.MemberName} is not a valid date and time.");
        }
    }
}
