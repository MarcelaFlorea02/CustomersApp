using System.DirectoryServices.ActiveDirectory;
using System.Net.Mail;

namespace CustomersApp;

public class ValidationResult
{
    public bool IsValid { get; set; }
    public string Message { get; set; }
    public string FieldName { get; set; }

    public ValidationResult(bool isValid, string message = "", string fieldName = "")
    {
        IsValid = isValid;
        Message = message;
        FieldName = fieldName;
    }
}


public static class CustomerValidator
{
    public static ValidationResult Validate(string firstName, string lastName, string email, string phone)
    {
        if (string.IsNullOrWhiteSpace(firstName))
            return new ValidationResult(false, "FirstName is mandatory", "firstName");
        if (string.IsNullOrWhiteSpace(lastName))
            return new ValidationResult(false, "LastName is mandatory", "lastName");
        if (string.IsNullOrWhiteSpace(email))
            return new ValidationResult(false, "Email is mandatory", "email");

        try
        {
            var emailInput = new MailAddress(email);
        }
        catch
        {
            return new ValidationResult(false, "Email is not in a correct format.", "email");
        }

        if (!string.IsNullOrWhiteSpace(phone) && !phone.All(char.IsDigit))
            return new ValidationResult(false, "Phone must contain only digits", "phone");

        if (firstName.Length > 50)
            return new ValidationResult(false, "FirstName must be max. 50 chars.", "firstName");

        if (lastName.Length > 50)
            return new ValidationResult(false, "LastName must be max. 50 chars.", "lastName");

        if (email.Length > 100)
            return new ValidationResult(false, "Email must be max. 100 chars.", "email");

        if (!string.IsNullOrWhiteSpace(phone) && phone.Length > 20)
            return new ValidationResult(false, "Phone must be max. 20 chars.", "phone");

        return new ValidationResult(true);
    }
}
