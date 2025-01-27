using Microsoft.EntityFrameworkCore;
using Sistema_Pizzaria.Models;


namespace Sistema_Pizzaria.Infra
{
    public class PizzariaContext : DbContext
    {
        public PizzariaContext(DbContextOptions<PizzariaContext> options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; } // Tabela de pizzas

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().ToTable("Pizzas");
        }
    }
}
