using EzyBuy.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EzyBuy.Infrastructure.Data;

internal class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
	internal DbSet<Product> Products { get; set; }
	internal DbSet<Brand> Brands { get; set; }
	internal DbSet<Category> Categories { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		base.OnConfiguring(optionsBuilder);
	}
	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
	}
}
