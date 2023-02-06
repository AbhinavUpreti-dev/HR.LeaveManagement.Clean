using FluentValidation.Results;

namespace Hr.LeaveManagement.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        private readonly List<string>? ValidationErrors;
        public BadRequestException(string message) : base(message)
        {
                
        }

        public BadRequestException(string message, ValidationResult validationResult) : base(message)
        {
            ValidationErrors = new List<string>();
            ValidationErrors.AddRange(validationResult.Errors.Select(i => i.ErrorMessage));
        }


    }
}
