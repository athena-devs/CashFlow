using CashFlow.Domain.Repositories.Expenses;
using CashFlow.Infrastruture.DataAccess.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CashFlow.Infrastruture;
public static class DependencyInjectionExtension
{
    public static void AddInfrastructure(this IServiceCollection services)
    {
        services.AddScoped<IExpensesRepository, ExpensesRepository>(); // injeção de dependência

    }
}
