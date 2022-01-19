using Microsoft.EntityFrameworkCore;
using Geres4U.Models;

namespace Geres4U.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<ClientModel> Client { get; set; }
        public DbSet<ReviserModel> Reviser { get; set; }

        public DbSet<CategoryModel> Category { get; set; }

        public DbSet<PointOfInterestModel> PointOfInterest { get; set; }

        public DbSet<PointOfInterestCategoryModel> PointOfInterestCategory { get; set; }

        public DbSet<ClientHistoryModel> ClientHistory { get; set; }
    }
}
