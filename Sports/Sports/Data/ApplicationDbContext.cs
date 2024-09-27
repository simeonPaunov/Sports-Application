using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sports.Models;

namespace Sports.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Sports.Models.Sport> Sport { get; set; } = default!;
        public DbSet<Sports.Models.Competition> Competition { get; set; } = default!;
        public DbSet<Sports.Models.Team> Team { get; set; } = default!;
        public DbSet<Sports.Models.Statistic> Statistic { get; set; } = default!;
        public DbSet<Sports.Models.Statistic_Type> Statistic_Type { get; set; } = default!;
        public DbSet<Sports.Models.Result> Result { get; set; } = default!;
    }
}
