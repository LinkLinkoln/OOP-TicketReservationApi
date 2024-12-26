using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api.Models;

namespace TicketBookingApplication.Api
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Session> Sessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                 .HasMany(c => c.Tickets)
                 .WithOne(t => t.Client)
                 .HasForeignKey(t => t.ClientId)
                 .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Session>()
                .HasMany(s => s.Tickets)
                .WithOne(t => t.Session)
                .HasForeignKey(t => t.SessionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Movie>()
                .HasMany(m => m.Sessions)
                .WithOne(s => s.Movie)
                .HasForeignKey(s => s.MovieId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Genre>()
                .HasMany<Movie>()
                .WithOne(m => m.Genre)
                .HasForeignKey(m => m.GenreId)
                .OnDelete(DeleteBehavior.Cascade);
            
            var genres = new List<Genre>
            {
                new Genre { Id = Guid.Parse("d3f1f8b0-19e6-4db6-8e91-a6fdee8a7611"), Name = "Action" },
                new Genre { Id = Guid.Parse("a2c6f1b3-7520-4a90-baba-5cb0c00f8935"), Name = "Comedy" },
                new Genre { Id = Guid.Parse("b341cf42-64c5-4dfb-b0b6-4bb5d4b1f451"), Name = "Drama" },
                new Genre { Id = Guid.Parse("29f7804a-54f8-4a72-aadb-cf4f3f6060a4"), Name = "Horror" },
                new Genre { Id = Guid.Parse("ef9a4a02-b59e-497e-82be-20d19f62e785"), Name = "Fantasy" },
                new Genre { Id = Guid.Parse("fde9f3a4-3558-4ddf-9349-b6e75fd8e92e"), Name = "Sci-Fi" },
                new Genre { Id = Guid.Parse("e0e4d9e2-d2b1-4c50-b4a7-ef3a8b21cde3"), Name = "Romance" }
            };
            modelBuilder.Entity<Genre>().HasData(genres);

            var movies = new List<Movie>
            {
                new Movie { Id = Guid.Parse("de91c5e3-dab1-4d23-9f36-947f785b20b3"), Name = "Action Movie 1", Description = "An exciting action movie.", GenreId = genres[0].Id },
                new Movie { Id = Guid.Parse("ae61e5f1-4517-48e3-960e-812f7235c8fc"), Name = "Comedy Movie 1", Description = "A hilarious comedy movie.", GenreId = genres[1].Id },
                new Movie { Id = Guid.Parse("bf35e5a2-3abf-4e2b-b0d4-31d84324e674"), Name = "Drama Movie 1", Description = "An emotional drama movie.", GenreId = genres[2].Id },
                new Movie { Id = Guid.Parse("af47c5a9-0921-463e-b1a8-4c59b24b8f0e"), Name = "Horror Movie 1", Description = "A scary horror movie.", GenreId = genres[3].Id },
                new Movie { Id = Guid.Parse("cfe1b5d9-0f2b-4a24-b749-2e8bcb14a241"), Name = "Fantasy Movie 1", Description = "A magical fantasy movie.", GenreId = genres[4].Id },
                new Movie { Id = Guid.Parse("d921a4e3-7f2a-467e-b93a-08fcb57b8e4e"), Name = "Sci-Fi Movie 1", Description = "A futuristic sci-fi movie.", GenreId = genres[5].Id },
                new Movie { Id = Guid.Parse("fb12a8d2-1721-4c48-bd8b-4c7a12b1c1f3"), Name = "Romance Movie 1", Description = "A heartwarming romance movie.", GenreId = genres[6].Id }
            };
            modelBuilder.Entity<Movie>().HasData(movies);

            var sessions = new List<Session>
            {
                new Session { Id = Guid.Parse("22b9d7b1-4c32-459a-bf71-1e9bcd16a7d5"), StartAt = DateTime.UtcNow.AddHours(1), Price = 10.99m, AvailableQuantity = 50, MovieId = movies[0].Id },
                new Session { Id = Guid.Parse("4a3bc7d5-53f6-4e2b-b4d6-94a81c2f574d"), StartAt = DateTime.UtcNow.AddHours(2), Price = 9.99m, AvailableQuantity = 30, MovieId = movies[1].Id },
                new Session { Id = Guid.Parse("34a5c9f4-6123-48e6-b2c4-5db7c9a5a54e"), StartAt = DateTime.UtcNow.AddHours(3), Price = 12.99m, AvailableQuantity = 20, MovieId = movies[2].Id },
                new Session { Id = Guid.Parse("89f7b5d3-4128-489b-9487-ef21c4b8e5f3"), StartAt = DateTime.UtcNow.AddHours(4), Price = 8.99m, AvailableQuantity = 40, MovieId = movies[3].Id },
                new Session { Id = Guid.Parse("8f1c9b42-0f1d-44f2-b14b-812c9b8c5d7f"), StartAt = DateTime.UtcNow.AddHours(5), Price = 11.99m, AvailableQuantity = 25, MovieId = movies[4].Id },
                new Session { Id = Guid.Parse("5d7e4b32-1f8a-482f-b7f1-1e3c9b8f0a8b"), StartAt = DateTime.UtcNow.AddHours(6), Price = 13.99m, AvailableQuantity = 15, MovieId = movies[5].Id },
                new Session { Id = Guid.Parse("1e9b7f32-4d2a-42b1-9723-8f4b9c7a8d5c"), StartAt = DateTime.UtcNow.AddHours(7), Price = 14.99m, AvailableQuantity = 10, MovieId = movies[6].Id }
            };
            modelBuilder.Entity<Session>().HasData(sessions);

            var clients = new List<Client>
            {
                new Client { Id = Guid.Parse("12b7e4a5-93f6-4b82-b721-4c5a8d9f1c32"), FirstName = "John", LastName = "Doe", Email = "john.doe1@example.com", PhoneNumber = "+1234567890" },
                new Client { Id = Guid.Parse("29f7c5a8-41d3-44f2-b9f4-2c8d7a1b5f12"), FirstName = "Jane", LastName = "Smith", Email = "jane.smith2@example.com", PhoneNumber = "+1234567891" },
                new Client { Id = Guid.Parse("8f2c9b7a-14d6-4a5b-b93e-7f2a4d8b5c7f"), FirstName = "Alice", LastName = "Brown", Email = "alice.brown3@example.com", PhoneNumber = "+1234567892" },
                new Client { Id = Guid.Parse("3b9f4a5d-7f2c-4d1b-b921-8c5f7a2b4d1c"), FirstName = "Bob", LastName = "Taylor", Email = "bob.taylor4@example.com", PhoneNumber = "+1234567893" },
                new Client { Id = Guid.Parse("7f2c8d9a-41b5-4d7f-b12e-4a9f5c7a8d32"), FirstName = "Charlie", LastName = "Davis", Email = "charlie.davis5@example.com", PhoneNumber = "+1234567894" },
                new Client { Id = Guid.Parse("1e7b4c5a-9f21-4a8f-b2d3-5c7a8f4d9b1f"), FirstName = "Emily", LastName = "Clark", Email = "emily.clark6@example.com", PhoneNumber = "+1234567895" },
                new Client { Id = Guid.Parse("5c7a9f4b-2d7e-4b1f-b93a-7a8f5c4d9b3e"), FirstName = "Frank", LastName = "White", Email = "frank.white7@example.com", PhoneNumber = "+1234567896" }
            };
            modelBuilder.Entity<Client>().HasData(clients);

            var tickets = new List<Ticket>
            {
                new Ticket { Id = Guid.Parse("8d5f7a4c-92b7-4a1d-b5f2-7a8d9c4b1e32"), ClientId = clients[0].Id, SessionId = sessions[0].Id },
                new Ticket { Id = Guid.Parse("3a9f4b7e-1c2b-4d5a-b93e-7f4d9c1a8b52"), ClientId = clients[1].Id, SessionId = sessions[1].Id },
                new Ticket { Id = Guid.Parse("7a8f5c4d-2b9f-4b1e-b7d3-8c4a9f1b5e32"), ClientId = clients[2].Id, SessionId = sessions[2].Id },
                new Ticket { Id = Guid.Parse("1e7a9f4c-3d5b-4f8a-b92e-7f4d1b5c8a32"), ClientId = clients[3].Id, SessionId = sessions[3].Id },
                new Ticket { Id = Guid.Parse("5c7f8d4a-92b1-4e7f-b9d2-7a1b5f4d8a32"), ClientId = clients[4].Id, SessionId = sessions[4].Id },
                new Ticket { Id = Guid.Parse("2d3f7b8e-4c1a-5d9f-b72e-8a4c9f1d3b52"), ClientId = clients[5].Id, SessionId = sessions[5].Id },
                new Ticket { Id = Guid.Parse("4b9f2a7c-8d1f-3e5b-b74a-9f3c2d8a7e52"), ClientId = clients[6].Id, SessionId = sessions[6].Id }
            };
            modelBuilder.Entity<Ticket>().HasData(tickets);
        }
    }
}
