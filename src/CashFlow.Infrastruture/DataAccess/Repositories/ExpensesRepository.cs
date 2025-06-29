using CashFlow.Domain.Entities;
using CashFlow.Domain.Repositories.Expenses;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastruture.DataAccess.Repositories;
internal class ExpensesRepository : IExpensesReadOnlyRepository, IExpensesWriteOnlyRepository
{
    private readonly CashFlowDbContext _dbContext;
    public ExpensesRepository(CashFlowDbContext dbContext)
    {
        _dbContext = dbContext;
        
    }
    public async Task Add(Expense expense)
    {
      await _dbContext.expenses.AddAsync(expense);
    }

    public async Task<List<Expense>> GetAll()
    {
        return await _dbContext.expenses.AsNoTracking().ToListAsync(); //AsNoTracking Performace
    }

    public async Task<Expense?> GetById(long id)
    {
        return await _dbContext.expenses.AsNoTracking().FirstOrDefaultAsync(expense => expense.Id == id);
    }
}
