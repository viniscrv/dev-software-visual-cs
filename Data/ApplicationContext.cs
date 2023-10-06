using FolhaDePagamento.Models;
using Microsoft.EntityFrameworkCore;

namespace FolhaDePagamento.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Payroll> Payrolls{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
