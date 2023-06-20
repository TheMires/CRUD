using Microsoft.EntityFrameworkCore;

namespace crud.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=crud;Integrated Security=True");
        }
    }
}
