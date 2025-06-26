using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastruture.DataAccess;
internal class CashFlowDbContext : DbContext
{
    public CashFlowDbContext(DbContextOptions options) : base(options) 
    {
        
    }
    public DbSet<Expense> expenses { get; set; } // nome da tabele em minusculo

}
