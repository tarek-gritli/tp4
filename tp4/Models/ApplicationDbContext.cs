using System.Text.Json;
using Microsoft.EntityFrameworkCore;
using tp4.Models;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Genre> Genres { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<MembershipType> Membershiptypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Movie>()
            .HasOne(m => m.Genre)
            .WithMany(g => g.Movies)
            .HasForeignKey(m => m.GenreId);

        modelBuilder.Entity<Customer>()
            .HasOne(c => c.MembershipType)
            .WithMany(m => m.Customers)
            .HasForeignKey(c => c.MembershipTypeId);

        modelBuilder.Entity<Customer>()
            .HasMany(c => c.Movies)
            .WithMany(m => m.Customers);
    }
}