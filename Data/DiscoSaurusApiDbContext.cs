namespace DiscoSaurusApi.Data
{
  using Microsoft.EntityFrameworkCore;
  using DiscosaurusApi.Models;

  public class DiscoSaurusApiDbContext : DbContext
  {
    public DiscoSaurusApiDbContext(DbContextOptions<DiscoSaurusApiDbContext> options) : base(options) 
    {
      
    }
    public DbSet<Album> Albums { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      if (modelBuilder is null)
      {
        throw new ArgumentNullException(nameof(modelBuilder));
      }

      modelBuilder.Entity<Genre>().HasData(
        new Genre { Id = 1, Name = "Rock" },
        new Genre { Id = 2, Name = "Jazz" },
        new Genre { Id = 3, Name = "Metal" }
      );

      modelBuilder.Entity<Artist>().HasData(
        new Artist { Id = 1, Name = "AC/DC" },
        new Artist { Id = 2, Name = "Accept" },
        new Artist { Id = 3, Name = "Iron Maiden" },
        new Artist { Id = 4, Name = "Snarky Puppy" },
        new Artist { Id = 5, Name = "Valley Of The Sun" }
      );

      modelBuilder.Entity<Album>().HasData(
        new Album { Id = 1, ArtistId = 1, GenreId = 1, Title = "Thunderstruck", Duration = 507 },
        new Album { Id = 2, ArtistId = 2, GenreId = 2, Title = "Balls to the Wall", Duration = 731 },
        new Album { Id = 3, ArtistId = 3, GenreId = 3, Title = "The Number of the Beast", Duration = 441 },
        new Album { Id = 4, ArtistId = 4, GenreId = 1, Title = "We Like It Here", Duration = 955 },
        new Album { Id = 5, ArtistId = 5, GenreId = 3, Title = "Volume Rock", Duration = 456 }
      );
    }
  }
}