using CashFlow.Communication.Requests;
using CashFlow.Exception;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpenseValidator : AbstractValidator<RequestExpenseJson>
{
    public RegisterExpenseValidator()
    {
        RuleFor(expense => expense.Title).NotEmpty().WithMessage(ResouceErrorMessages.TITLE_ERROR);
        RuleFor(expense => expense.Amount).GreaterThan(0).WithMessage(ResouceErrorMessages.AMOUNT_ERROR);
        RuleFor(expense => expense.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage(ResouceErrorMessages.DATE_ERROR);
        RuleFor(expense => expense.PaymentType).IsInEnum().WithMessage(ResouceErrorMessages.PAYMENT_ERROR);

    }
}
