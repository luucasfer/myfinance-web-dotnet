using Microsoft.EntityFrameworkCore;
using myfinance_web_netcore_domain;                                                                                                                                                          

namespace myfinance_web_netcore_infra;

public class MyFinanceDbContext : DbContext
{
    public DbSet<PlanoConta> PlanoConta { get; set; }
    public DbSet<Transacao> Transacao { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=; Database=; Trusted_Connection=True")
    }
}
