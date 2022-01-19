using Microsoft.EntityFrameworkCore;
using Geres4U.Models;

namespace Geres4U.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Reviser> Reviser { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<PointOfInterest> PointOfInterest { get; set; }

        public DbSet<PointOfInterestCategory> PointOfInterestCategory { get; set; }

        public DbSet<ClientHistory> ClientHistory { get; set; }
    }
}