using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.UseCases.Expenses.Register;
public class RegisterExpensesUseCase
{
    public ResponseExpenseJson Execute(RequestExpenseJson request)
    {
        Validate(request);

        return new ResponseExpenseJson();

    }


    private void Validate(RequestExpenseJson request)
    {

        var validator = new RegisterExpenseValidator();

        var expense = validator.Validate(request);

       if (expense.IsValid == false)
        {
            var errorMessages = expense.Errors.Select(f => f.ErrorMessage).ToList();

            throw new ArgumentException();
        }


    }

}