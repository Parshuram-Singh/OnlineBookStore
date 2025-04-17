namespace OnlineBookStore.Data;

using Microsoft.EntityFrameworkCore;
using OnlineBookStore.Models.Entities;

public class BookstoreDbContext : DbContext
{
    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options)
        : base(options)
    {
    }

    public DbSet<Books> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Books>(entity =>
        {
            entity.ToTable("Books");
            entity.HasKey(b => b.Id);
            entity.HasIndex(b => b.ISBN).IsUnique();
            entity.Property(b => b.Title).HasMaxLength(200).IsRequired();
            entity.Property(b => b.ISBN).HasMaxLength(17).IsRequired();
            entity.Property(b => b.Price).HasColumnType("numeric(18,2)").IsRequired();
            
        });
    }
}