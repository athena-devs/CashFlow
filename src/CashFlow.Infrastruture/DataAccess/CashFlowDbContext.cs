using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastruture.DataAccess;
internal class CashFlowDbContext : DbContext
{
    public DbSet<Expense> expenses { get; set; } // nome da tabele em minusculo

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=cashflow_db;Uid=cash_user;Pwd=123456";

        var version = new Version(9, 3, 0);

        var serverVersion = new MySqlServerVersion(version);

        optionsBuilder.UseMySql(connectionString, serverVersion);
    }

}
