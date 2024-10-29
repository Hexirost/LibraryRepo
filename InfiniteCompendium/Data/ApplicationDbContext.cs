using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InfiniteCompendium.Models;

namespace InfiniteCompendium.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InfiniteCompendium.Models.Book> Books { get; set; } = default!;
        public DbSet<InfiniteCompendium.Models.Status> Statuses { get; set; } = default!;
        public DbSet<InfiniteCompendium.Models.Category> Categories { get; set; } = default!;

    }
}
