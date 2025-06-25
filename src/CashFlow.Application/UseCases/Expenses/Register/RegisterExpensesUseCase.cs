using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Domain.Entities;
using CashFlow.Exception.ExceptionsBase;
using CashFlow.Infrastruture.DataAccess;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpensesUseCase
{
    public ResponseExpenseJson Execute(RequestExpenseJson request)
    {
        Validate(request);

        

        var entity = new Expense
        {
            Amount = request.Amount,
            Date = request.Date,
            Description = request.Description,
            Title = request.Title,
            PaymentType = (Domain.Enums.PaymentType)request.PaymentType,
        };

        

        return new ResponseExpenseJson();

    }


    private void Validate(RequestExpenseJson request)
    {

        var validator = new RegisterExpenseValidator();

        var expense = validator.Validate(request);

       if (expense.IsValid == false)
        {
            var errorMessages = expense.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ErrorOnValidationException(errorMessages);
        }


    }

}