using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;
using CommonTestUtilities.Requests;

namespace Validatiors.Tests.Expenses.Register;
public class RegisterExpenseValidatorTests
{
    [Fact]
    public void Success()
    {
        //Arrange
        var validator = new RegisterExpenseValidator();
        var request =  RequestExpenseJsonBuilder.Build();

        //Act
        var result = validator.Validate(request);

        //Assert
        Assert.True(result.IsValid);


    }
}
