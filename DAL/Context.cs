using Domain.Core.Cars;
using Domain.Core.Cars.CarParts;
using Domain.Core.Cars.CarUnits;
using Domain.Core.Users;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {}

        public DbSet<User> Users { get; set; }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarUnit> CarUnits { get; set; }
        public DbSet<CarPart> CarParts { get; set; }
        public DbSet<Change> Changes { get; set; }
        public DbSet<Maintenance> Maintenances { get; set; }
        public DbSet<Fluids> Fluids { get; set; }
    }
}
