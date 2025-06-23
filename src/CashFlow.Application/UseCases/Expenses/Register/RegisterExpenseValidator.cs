using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseValidator : AbstractValidator<RequestExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage("the title is required");
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage("the Amount must be greater then zero.");
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("expenses cannot be the future");
        RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage("Payment type is not valid.");

    }
}
