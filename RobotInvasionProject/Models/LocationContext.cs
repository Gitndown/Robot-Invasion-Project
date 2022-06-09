using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace RobotInvasionProjectApi.Models
{
    
    public class LocationContext : DbContext
        {
            public LocationContext(DbContextOptions<LocationContext> options)
                : base(options) 
            {
            }

            public DbSet<Location> Location { get; set; }
        }
    
}
