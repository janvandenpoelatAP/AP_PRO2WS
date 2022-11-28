using Microsoft.EntityFrameworkCore;
using OefeningContractEF.Models;

namespace OefeningContractEF.Entities;

public class ContractDbContext : DbContext
{
	public ContractDbContext(DbContextOptions options) : base(options)
	{
	}
    public DbSet<Contract> Contracts { get; set; }  
}
